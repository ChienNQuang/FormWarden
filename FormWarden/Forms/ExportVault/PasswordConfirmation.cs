using FormWarden.Domain.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FormWarden.Forms;

public partial class PasswordConfirmation : Form
{
    private readonly User _user;
    public event EventHandler? Confirmed;
    public PasswordConfirmation(User user)
    {
        InitializeComponent();
        _user = user;
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
        {
            MessageBox.Show("Password cannot be empty", "Thong bao", MessageBoxButtons.OK);
            return;
        }

        if (SecurityHelper.Hash(txtPassword.Text).Equals(_user.HashedPassword))
        {
            Close();

            Confirmed?.Invoke(sender, e);
        }
    }
}
