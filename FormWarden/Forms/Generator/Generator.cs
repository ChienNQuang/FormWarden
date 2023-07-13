using FormWarden.Helpers;
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
    public partial class Generator : Form
    {
        private static readonly Random random = new Random();
        public Generator()
        {
            InitializeComponent();
        }

        private void rbUsername_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsername.Checked)
            {
                foreach (var control in gbPasswordType.Controls)
                {
                    if (control is RadioButton)
                    {
                        var radioButton = control as RadioButton;
                        radioButton.Checked = false;
                        radioButton.AutoCheck = false;
                    }
                }
                txtLength.ReadOnly = true;
                cbLowerCase.Enabled = false;
                cbSpecialCharacters.Enabled = false;
            }
        }

        private void rbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPassword.Checked)
            {
                foreach (var control in gbPasswordType.Controls)
                {
                    if (control is RadioButton)
                    {
                        var radioButton = control as RadioButton;
                        radioButton.AutoCheck = true;
                    }
                }
                txtLength.ReadOnly = false;
                cbLowerCase.Enabled = true;
                cbSpecialCharacters.Enabled = true;
            }
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            

            var result = new StringBuilder();

            if (rbUsername.Checked)
            {
                result.Append(GenerateUsername(cbUpperCase.Checked));
            }

            else if (rbPassword.Checked)
            {
                var lenghtValidation = int.TryParse(txtLength.Text, out var length);
                if (!lenghtValidation)
                {
                    MessageBox.Show("Invalid input", "Oops", MessageBoxButtons.OK);
                    return;
                }

                if (length <= 0)
                {
                    MessageBox.Show("Invalid input", "Oops", MessageBoxButtons.OK);
                    return;
                }

                if (rbTypePassword.Checked)
                {
                    result.Append(GeneratePassword(length, cbLowerCase.Checked, cbUpperCase.Checked, cbSpecialCharacters.Checked));
                }
                else if (rbPassphrase.Checked)
                {
                    result.Append(GeneratePassphrase(length));
                }
            }

            txtResult.Text = result.ToString();
            txtResult.ReadOnly = true;
        }

        private string GenerateUsername(bool upper)
        {
            var usernameGenerator = new UsernameGenerator();
            return usernameGenerator.GenerateName(upper);
        }

        private string GeneratePassword(int length, bool useLower, bool useUpper, bool useSpecial)
        {
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string specialChars = "!@#$%^&*";

            StringBuilder password = new StringBuilder();
            var charSet = "";

            if (useLower)
                charSet += lowerChars;

            if (useUpper)
                charSet += upperChars;

            if (useSpecial)
                charSet += specialChars;

            if (charSet.Length == 0)
            {
                MessageBox.Show("Please select at least one character set.", "Oops", MessageBoxButtons.OK);
                return string.Empty;
            }

            for (int i = 0; i < length; i++)
            {
                char randomChar = charSet[random.Next(charSet.Length)];
                password.Append(randomChar);
            }

            return password.ToString();
        }

        private string GeneratePassphrase(int length)
        {
            const string words = "apple banana cherry dog elephant frog guitar horse icecream";

            string[] wordArray = words.Split(' ');

            StringBuilder passphrase = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                string randomWord = wordArray[random.Next(wordArray.Length)];
                passphrase.Append(randomWord);
                passphrase.Append(' ');
            }

            return passphrase.ToString().Trim();
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }
    }
}
