using FormWarden.Constants;
using FormWarden.Domain.Entities;
using FormWarden.Helpers;
using FormWarden.Infrastructure.Repositories;
using FormWarden.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.IdentityModel.Tokens;

namespace FormWarden.Forms
{
    public partial class CreateCategory : Form
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Repository<Category, Guid> _categoryRepository;

        private readonly User _user;

        public event EventHandler? SaveIdentity;
        public CreateCategory(User user)
        {
            InitializeComponent();
            _user = user;

            var dbContext = new ApplicationDbContext();

            _unitOfWork = new(dbContext);
            _categoryRepository = _unitOfWork.GetRequiredRepository<Category, Guid>();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            if (categoryNameTxt.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Field must not be empty.", "Warning", MessageBoxButtons.OK);
                return;
            }

            if (categoryNameTxt.Text.Equals("None") || categoryNameTxt.Text.Equals("Choose a category."))
            {
                MessageBox.Show("This name cannot be used.", "Warning", MessageBoxButtons.OK);
                return;
            }

            var existingCategory = _categoryRepository.FindFirst(x => x.Name.Equals(categoryNameTxt.Text)
            && x.OwnerId == _user.Id);

            if (existingCategory is not null)
            {
                MessageBox.Show("Category already exists.", "Warning", MessageBoxButtons.OK);
                return;
            }

            var category = new Category()
            {
                Id = Guid.NewGuid(),
                Name = categoryNameTxt.Text,
                OwnerId = _user.Id,
            };

            await _categoryRepository.AddAsync(category);

            await _unitOfWork.CommitAsync();

            Close();

            SaveIdentity?.Invoke(sender, e);
        }
    }
}
