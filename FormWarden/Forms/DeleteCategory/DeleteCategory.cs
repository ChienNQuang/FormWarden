using FormWarden.Domain.Entities;
using FormWarden.Infrastructure.Repositories;
using FormWarden.Infrastructure;
using Microsoft.IdentityModel.Tokens;
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
    public partial class DeleteCategory : Form
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Repository<Category, Guid> _categoryRepository;
        private readonly Repository<Identity, Guid> _identityRepository;

        private readonly User _user;

        public event EventHandler? SaveIdentity;
        public DeleteCategory(User user)
        {
            InitializeComponent();
            _user = user;

            var dbContext = new ApplicationDbContext();

            _unitOfWork = new(dbContext);
            _categoryRepository = _unitOfWork.GetRequiredRepository<Category, Guid>();
            _identityRepository = _unitOfWork.GetRequiredRepository<Identity, Guid>();

            var categories = _categoryRepository.GetAll();

            CategoryCbx.DataSource = categories
                .Where(x => x.OwnerId == _user.Id)
                .Select(x => x.Name)
                .ToList();
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            var existingCategory = _categoryRepository.FindFirst(x => x.Name.Equals((string)CategoryCbx.SelectedItem)
            && x.OwnerId == _user.Id);

            if (existingCategory is null)
            {
                MessageBox.Show("Category does not exist.", "Warning", MessageBoxButtons.OK);
                return;
            }

            var relatedIdentities = _identityRepository.GetAll()
                .Where(x => x.OwnerId == _user.Id
                && x.CategoryId == existingCategory.Id);

            foreach (var identity in relatedIdentities)
            {
                identity.CategoryId = null;
                _identityRepository.Update(identity);
            }

            _categoryRepository.Remove(existingCategory.Id);

            await _unitOfWork.CommitAsync();

            Close();

            SaveIdentity?.Invoke(sender, e);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
