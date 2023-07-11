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

        private readonly User _user;

        public event EventHandler? SaveIdentity;
        public CreateIdentity(User user)
        {
            InitializeComponent();
            _user = user;

            var dbContext = new ApplicationDbContext();

            _unitOfWork = new(dbContext);
            _identityRepository = _unitOfWork.GetRequiredRepository<Identity, Guid>();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var identity = new Identity()
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                Note = txtNotes.Text,
                Username = txtUsername.Text,
                EncryptedPassword = SecurityHelper.Encrypt(txtPassword.Text, Settings.PassPhrase),
                Uri = txtUri.Text,
                OwnerId = _user.Id,
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
