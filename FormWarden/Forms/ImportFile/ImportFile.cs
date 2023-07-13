using FormWarden.Constants;
using FormWarden.Domain.Entities;
using FormWarden.Helpers;
using FormWarden.Infrastructure;
using FormWarden.Infrastructure.Repositories;
using FormWarden.Models.Results.Export;
using System.Security;
using System.Text.Json;

namespace FormWarden.Forms;

public partial class ImportFile : Form
{
    private UnitOfWork _unitOfWork;
    private Repository<Identity, Guid> _identityRepository;
    private Repository<Category, Guid> _categoryRepository;

    public event EventHandler? Imported;
    
    private readonly User _user;
    private string _importedFile;
    public ImportFile(User user)
    {
        InitializeComponent();
        _user = user;

        var dbContext = new ApplicationDbContext();

        _unitOfWork = new(dbContext);
        _identityRepository = _unitOfWork.GetRequiredRepository<Identity, Guid>();
        _categoryRepository = _unitOfWork.GetRequiredRepository<Category, Guid>();
    }

    private void btnChooseFile_Click(object sender, EventArgs e)
    {

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                var file = openFileDialog.FileName;
                var sr = new StreamReader(openFileDialog.FileName);
                txtFileName.Text = file;
                var json = sr.ReadToEnd();
                _importedFile = json;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }
    }

    private async void btnImport_Click(object sender, EventArgs e)
    {
        if (_importedFile == null) return;
        var importedVault = JsonSerializer.Deserialize<ExportedVault>(_importedFile);

        if (importedVault != null)
        {
            if (importedVault.Encrypted)
            {
                importedVault.Items.ForEach(item =>
                {
                    item.Username = SecurityHelper.Decrypt(item.Username, Settings.PassPhrase);
                    item.Name = SecurityHelper.Decrypt(item.Name, Settings.PassPhrase);
                    item.Notes = item.Notes is null ? null : SecurityHelper.Decrypt(item.Name, Settings.PassPhrase);
                    item.Uri = item.Uri is null ? null : SecurityHelper.Decrypt(item.Uri, Settings.PassPhrase);
                    item.Password = SecurityHelper.Decrypt(item.Password, Settings.PassPhrase);
                });

                importedVault.Categories.ForEach(item =>
                {
                    item.Name = SecurityHelper.Decrypt(item.Name, Settings.PassPhrase);
                });
            }

            importedVault.Items.ForEach(async item =>
            {
                await _identityRepository.AddAsync(new Identity
                {
                    Name = item.Name,
                    OwnerId = _user.Id,
                    Username = item.Username,
                    CategoryId = item.CategoryId,
                    EncryptedPassword = SecurityHelper.Encrypt(item.Password, Settings.PassPhrase),
                    Note = item.Notes,
                    Uri = item.Uri,
                });
            });

            importedVault.Categories.ForEach(async item =>
            {
                await _categoryRepository.AddAsync(new Category
                {
                    Name = item.Name,
                    OwnerId = _user.Id,
                });
            });

            await _unitOfWork.CommitAsync();

            MessageBox.Show("Import successfully!");

            Close();

            Imported?.Invoke(sender, e);
        }
    }
}
