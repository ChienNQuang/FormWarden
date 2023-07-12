using FormWarden.Constants;
using FormWarden.Domain.Entities;
using FormWarden.Helpers;
using FormWarden.Infrastructure;
using FormWarden.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormWarden.Forms
{
    public partial class CreateIdentity : Form
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Repository<Identity, Guid> _identityRepository;
        private readonly Repository<Category, Guid> _categoryRepository;
        private List<string> _categoriesList = new List<string>();

        private readonly User _user;

        public event EventHandler? SaveIdentity;
        public CreateIdentity(User user)
        {
            InitializeComponent();
            _user = user;

            var dbContext = new ApplicationDbContext();

            _unitOfWork = new(dbContext);
            _identityRepository = _unitOfWork.GetRequiredRepository<Identity, Guid>();
            _categoryRepository = _unitOfWork.GetRequiredRepository<Category, Guid>();

            _categoriesList.Add("None");

            var categories = _categoryRepository.GetAll();

            _categoriesList.AddRange(categories
                .Where(x => x.OwnerId == _user.Id)
                .Select(x => x.Name)
                .ToList());

            CategoryCbx.DataSource = _categoriesList;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var category = _categoryRepository.FindFirst(x => x.Name.Equals((string)CategoryCbx.SelectedItem)
            && x.OwnerId == _user.Id);
            var identity = new Identity()
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                Note = txtNotes.Text,
                Username = txtUsername.Text,
                EncryptedPassword = SecurityHelper.Encrypt(txtPassword.Text, Settings.PassPhrase),
                Uri = txtUri.Text,
                OwnerId = _user.Id,
                CategoryId = category is null ? null : category.Id,
            };

            await _identityRepository.AddAsync(identity);

            await _unitOfWork.CommitAsync();

            Close();

            SaveIdentity?.Invoke(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
