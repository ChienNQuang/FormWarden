using FormWarden.Domain.Entities;
using FormWarden.Infrastructure;
using FormWarden.Infrastructure.Repositories;
using FormWarden.Models.Results;
using Microsoft.EntityFrameworkCore;
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
        private UnitOfWork _unitOfWork;
        private Repository<Identity, Guid> _identityRepository;
        private Repository<Category, Guid> _categoryRepository;
        private List<string> _categoriesList = new List<string>();

        private readonly User _user;
        public Vault(User user)
        {
            InitializeComponent();
            _user = user;

            var dbContext = new ApplicationDbContext();

            _unitOfWork = new(dbContext);
            _identityRepository = _unitOfWork.GetRequiredRepository<Identity, Guid>();
            _categoryRepository = _unitOfWork.GetRequiredRepository<Category, Guid>();

            SetDataSource();

            AddButton("Copy username", "Click Me");
            AddButton("Copy password", "Click Me");

            dgvIdentities.Columns[nameof(IdentityResult.Id)].Visible = false;
            dgvIdentities.Columns[nameof(IdentityResult.Password)].Visible = false;
        }

        private void SetDataSource()
        {
            var dbContext = new ApplicationDbContext();
            _unitOfWork = new(dbContext);
            _identityRepository = _unitOfWork.GetRequiredRepository<Identity, Guid>();
            _categoryRepository = _unitOfWork.GetRequiredRepository<Category, Guid>();
            var identities = _identityRepository.GetAll();

            dgvIdentities.DataSource = identities
                .Include(x => x.Category)
                .Where(x => x.OwnerId == _user.Id)
                .Select(x => IdentityResult.FromEntity(x))
                .ToList();


            CategoryCbx.DataSource = null;
            _categoriesList.Clear();
            _categoriesList.Add("Choose a category.");

            var categories = _categoryRepository.GetAll();

            _categoriesList.AddRange(categories
                .Where(x => x.OwnerId == _user.Id)
                .Select(x => x.Name)
                .ToList());

            CategoryCbx.DataSource = _categoriesList;

        }

        private DataGridViewButtonColumn AddButton(string headerText = "", string text = "")
        {
            var button = new DataGridViewButtonColumn();
            button.HeaderText = headerText;
            button.Text = text;

            dgvIdentities.Columns.Add(button);

            return button;
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


        private void CategoryCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var identities = _identityRepository.GetAll();

            if (CategoryCbx.SelectedIndex < 1)
            {
                dgvIdentities.DataSource = identities
                    .Where(x => x.OwnerId == _user.Id)
                    .Select(x => IdentityResult.FromEntity(x))
                    .ToList();
            }
            else
            {
                dgvIdentities.DataSource = identities
                    .Include(x => x.Category)
                    .Where(x => x.OwnerId == _user.Id && x.Category!.Name.Equals((string)CategoryCbx.SelectedItem))
                    .Select(x => IdentityResult.FromEntity(x))
                    .ToList();
            }
        }

        private void newCategoryBtn_Click(object sender, EventArgs e)
        {
            var newCategoryFrame = new CreateCategory(_user);
            newCategoryFrame.SaveIdentity += (e, args) =>
            {
                SetDataSource();
            };
            newCategoryFrame.ShowDialog();
        }

        private void deleteCategoryBtn_Click(object sender, EventArgs e)
        {
            var deleteCategoryFrame = new DeleteCategory(_user);
            deleteCategoryFrame.SaveIdentity += (e, args) =>
            {
                SetDataSource();
            };
            deleteCategoryFrame.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var exportVaultForm = new ExportVault(_user);
            exportVaultForm.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var importVaultForm = new ImportFile(_user);
            importVaultForm.Imported += (e, args) =>
            {
                SetDataSource();
            };
            importVaultForm.ShowDialog();
        }

        private void Vault_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btGenerator_Click(object sender, EventArgs e)
        {
            var generatorForm = new Generator();
            generatorForm.Show();
        }

        private void dgvIdentities_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

            var detailForm = new Details(identity, _user);
            detailForm.SaveIdentity += (s, args) =>
            {
                SetDataSource();
            };
            detailForm.ShowDialog();
        }
    }
}
