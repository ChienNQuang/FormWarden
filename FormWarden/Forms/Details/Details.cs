using FormWarden.Constants;
using FormWarden.Domain.Entities;
using FormWarden.Helpers;
using FormWarden.Infrastructure;
using FormWarden.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormWarden.Forms
{
    public partial class Details : Form
    {
        private readonly Identity _identity;
        private readonly UnitOfWork _unitOfWork;
        private readonly Repository<Identity, Guid> _identityRepository;
        private Repository<Category, Guid> _categoryRepository;
        private readonly ApplicationDbContext _dbContext;
        public event EventHandler? SaveIdentity;
        private List<string> _categoriesList = new List<string>();
        private readonly User _user;
        public Details(Identity identity, User user)
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
            _identity = identity;
            _user = user;
            _unitOfWork = new(_dbContext);
            _identityRepository = _unitOfWork.GetRequiredRepository<Identity, Guid>();
            _categoryRepository = _unitOfWork.GetRequiredRepository<Category, Guid>();
            SetUp();
        }

        private void SetUp()
        {
            txtName.Text = _identity.Name;
            txtNotes.Text = _identity.Note;
            txtPassword.Text = SecurityHelper.Decrypt(_identity.EncryptedPassword, Settings.PassPhrase);
            txtUri.Text = _identity.Uri;
            txtUsername.Text = _identity.Username;

            cbCategories.DataSource = null;
            _categoriesList.Clear();
            _categoriesList.Add("Choose a category");

            var categories = _categoryRepository.GetAll();
            _categoriesList.AddRange(categories
                .Where(x => x.OwnerId == _user.Id)
                .Select(x => x.Name)
                .ToList());

            cbCategories.DataSource = _categoriesList;
        }

        private async void btUpdate_Click(object sender, EventArgs e)
        {
           var identity = _identityRepository.FindFirst(x => x.Id == _identity.Id);
            
            if (identity is null)
            {
                MessageBox.Show("Identity does not exist.", "Oops", MessageBoxButtons.OK);
                return;
            }

            var categoryName = cbCategories.Text;
            var category = _categoryRepository.FindFirst(x => x.Name.Equals(categoryName));

            if (category is null)
            {
                MessageBox.Show("Category does not exist.", "Oops", MessageBoxButtons.OK);
                return;
            }
            
            identity.Note = txtNotes.Text;
            identity.Uri = txtUri.Text;
            identity.Username= txtUsername.Text;
            identity.Name = txtName.Text;
            identity.EncryptedPassword = SecurityHelper.Encrypt(txtPassword.Text, Settings.PassPhrase);
            identity.Category = category;
            
            _identityRepository.Update(identity);
            await _unitOfWork.CommitAsync();
            Close();
            SaveIdentity?.Invoke(sender, e);
        }

        private async void btDelete_Click(object sender, EventArgs e)
        {
            var identity = _identityRepository.FindFirst(x => x.Id == _identity.Id);

            if (identity is null)
            {
                MessageBox.Show("Identity does not exist.", "Oops", MessageBoxButtons.OK);
                return;
            }

            _identityRepository.Remove(_identity.Id);
            await _unitOfWork.CommitAsync();
            Close();
            SaveIdentity?.Invoke(sender, e);
        }
    }
}
