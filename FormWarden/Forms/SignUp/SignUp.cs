using FormWarden.Domain.Entities;
using FormWarden.Helpers;
using FormWarden.Infrastructure;
using FormWarden.Infrastructure.Repositories;

namespace FormWarden.Forms
{
    public partial class SignUp : Form
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Repository<User, Guid> _userRepository;
        public SignUp()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            _unitOfWork = new(context);
            _userRepository = _unitOfWork.GetRequiredRepository<User, Guid>();
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;

            if (string.IsNullOrEmpty(username.Trim()))
            {
                MessageBox.Show("Username cannot be empty", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(password.Trim()))
            {
                MessageBox.Show("Password cannot be empty", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(firstName.Trim()))
            {
                MessageBox.Show("First name cannot be empty", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(lastName.Trim()))
            {
                MessageBox.Show("Last name cannot be empty", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            var user = new User
            {
                Username = username,
                HashedPassword = SecurityHelper.Hash(password),
                FirstName = firstName,
                LastName = lastName,
            };

            var userEntity = await _userRepository.AddAsync(user);
            await _unitOfWork.CommitAsync();

            MessageBox.Show("User created successfully", "Thong bao", MessageBoxButtons.OK);

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
