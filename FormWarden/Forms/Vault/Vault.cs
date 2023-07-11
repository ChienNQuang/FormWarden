using FormWarden.Domain.Entities;
using FormWarden.Infrastructure;
using FormWarden.Infrastructure.Repositories;
using FormWarden.Models.Results;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class Vault : Form
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Repository<Identity, Guid> _identityRepository;

        private readonly User _user;
        public Vault(User user)
        {
            InitializeComponent();
            _user = user;

            var dbContext = new ApplicationDbContext();

            _unitOfWork = new(dbContext);
            _identityRepository = _unitOfWork.GetRequiredRepository<Identity, Guid>();

            SetDataSource();

            AddButton("Copy username", "Click Me");
            AddButton("Copy password", "Click Me");

            dgvIdentities.Columns[nameof(IdentityResult.Id)].Visible = false;
            dgvIdentities.Columns[nameof(IdentityResult.Password)].Visible = false;
        }

        private void SetDataSource()
        {
            var identities = _identityRepository.GetAll();

            dgvIdentities.DataSource = identities
                .Where(x => x.OwnerId == _user.Id)
                .Select(x => IdentityResult.FromEntity(x))
                .ToList();
        }

        private DataGridViewButtonColumn AddButton(string headerText = "", string text = "")
        {
            var button = new DataGridViewButtonColumn();
            button.HeaderText = headerText;
            button.Text = text;

            dgvIdentities.Columns.Add(button);

            return button;
        }
    

        private void dgvIdentities_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            var identityValidation = Guid.TryParse(dgvIdentities.Rows[e.RowIndex].Cells[2].Value.ToString(), out var identityId);
            if (!identityValidation)
            {
                MessageBox.Show("Invalid Id", "Oops", MessageBoxButtons.OK);
                return;
            }
            var identity = _identityRepository.FindFirst(x => x.Id == identityId);

            if (identity == null)
            {
                MessageBox.Show("Invalid does not exist", "Oops", MessageBoxButtons.OK);
                return;
            }

            var detailForm = new Details(identity);
            detailForm.Show();
        }

        private void btnNewIdentity_Click(object sender, EventArgs e)
        {
            var newItemFrame = new CreateIdentity(_user);
            newItemFrame.SaveIdentity += (e, args) =>
            {
                SetDataSource();
            };
            newItemFrame.ShowDialog();
        }

        private void dgvIdentities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn column &&
                e.RowIndex >= 0)
            {
                var identity = (IdentityResult)senderGrid.CurrentRow.DataBoundItem;
                if (column.HeaderText.Equals("Copy username"))
                {
                    Clipboard.SetText(identity.Username);
                }

                if (column.HeaderText.Equals("Copy password"))
                {
                    Clipboard.SetText(identity.Password);
                }
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Hide();
            var loginForm = new Login();
            loginForm.Show();
        }
    }
}
