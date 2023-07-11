using FormWarden.Domain.Entities;
using FormWarden.Helpers;
using FormWarden.Infrastructure;
using FormWarden.Infrastructure.Repositories;

namespace FormWarden.Forms
{
    public partial class Login : Form
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Repository<User, Guid> _userRepository;
        public Login()
        {
            var context = new ApplicationDbContext();
            context.Database.EnsureCreated();
            _unitOfWork = new(context);
            _userRepository = _unitOfWork.GetRequiredRepository<User, Guid>();


            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _userRepository.FindFirst(x => x.Username == txtUsername.Text);

            if (user is null)
            {
                MessageBox.Show("User does not exist", "Warning", MessageBoxButtons.OK);
                return;
            }

            if (!user.HashedPassword.Equals(SecurityHelper.Hash(txtPassword.Text)))
            {
                MessageBox.Show("Password is wrong", "Warning", MessageBoxButtons.OK);
            }

            Hide();

            var vaultForm = new Vault(user);
            vaultForm.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var signUpForm = new SignUp();
            signUpForm.ShowDialog();
        }
    }
}
