using FormWarden.Domain.Entities;
using FormWarden.Infrastructure;
using FormWarden.Infrastructure.Repositories;
using FormWarden.Models.Results.Export;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace FormWarden.Forms;

public partial class ExportVault : Form
{
    private UnitOfWork _unitOfWork;
    private Repository<Identity, Guid> _identityRepository;
    private Repository<Category, Guid> _categoryRepository;

    private readonly User _user;
    public ExportVault(User user)
    {
        InitializeComponent();
        _user = user;

        var dbContext = new ApplicationDbContext();

        _unitOfWork = new(dbContext);
        _identityRepository = _unitOfWork.GetRequiredRepository<Identity, Guid>();
        _categoryRepository = _unitOfWork.GetRequiredRepository<Category, Guid>();

        var list = new List<string>()
        {
            ".json"
        };

        cbFileFormat.DataSource = list;
        cbFileFormat.SelectedIndex = 0;
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        var passwordConfirmationForm = new PasswordConfirmation(_user);
        passwordConfirmationForm.Confirmed += Export;
        passwordConfirmationForm.ShowDialog();
    }

    private void Export(object sender, EventArgs e)
    {
        var categories = _categoryRepository.FindByCondition(x => x.OwnerId == _user.Id);
        var identities = _identityRepository.FindByCondition(x => x.OwnerId == _user.Id);

        ExportedVault exportedVault;
        if (chkEncrypted.Checked)
        {
            exportedVault = new ExportedVault
            {
                Encrypted = true,
                Categories = categories.Select(x => ExportedCategory.FromEntityEncrypted(x)).ToList(),
                Items = identities.Select(x => ExportedIdentity.FromEntityEncrypted(x)).ToList(),
            };
        }
        else
        {
            exportedVault = new ExportedVault
            {
                Encrypted = false,
                Categories = categories.Select(x => ExportedCategory.FromEntity(x)).ToList(),
                Items = identities.Select(x => ExportedIdentity.FromEntity(x)).ToList(),
            };
        }
        var options = new JsonSerializerOptions()
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true,
        };
        string json = JsonSerializer.Serialize(exportedVault, options);
        var assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        var assemblyParentPath = Path.GetDirectoryName(assemblyPath);

        var name = $"formwarden{(chkEncrypted.Checked ? "_encrypted" : "")}_export_{DateTime.Now.ToString("yyyymmddHHmmss")}{cbFileFormat.Text}";

        var f = new SaveFileDialog
        {
            InitialDirectory = assemblyParentPath,
            FileName = name,
            DefaultExt = cbFileFormat.Text[1..]
        };
        if (f.ShowDialog() == DialogResult.OK)
        {
            File.WriteAllText(f.FileName, json);
        }

        Close();
    }
}
