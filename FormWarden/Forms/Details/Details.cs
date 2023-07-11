using FormWarden.Constants;
using FormWarden.Domain.Entities;
using FormWarden.Helpers;
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
        public Details(Identity identity)
        {

            _identity = identity;
            InitializeComponent();
            SetUp();
        }

        private void SetUp()
        {
            txtName.Text = _identity.Name;
            txtNotes.Text = _identity.Note;
            txtPassword.Text = SecurityHelper.Decrypt(_identity.EncryptedPassword, Settings.PassPhrase);
            txtUri.Text = _identity.Uri;
            txtUsername.Text = _identity.Username;
        }
    }
}
