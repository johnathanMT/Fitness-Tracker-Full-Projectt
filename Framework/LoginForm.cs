using System;
using System.Windows.Forms;

namespace Framework
{
    public partial class LoginForm : Form
    {
        private FrameController myCtr;

        // --- Failed-login handling (required by the brief) ---
        private int failedAttempts = 0;
        private const int MAX_ATTEMPTS = 3;

        public LoginForm()
        {
            InitializeComponent();
            this.myCtr = new FrameController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strName = this.txtLoginName.Text.Trim();
            string strPass = this.txtLoginPass.Text;

            // 1) basic presence check with a inline message
            if (string.IsNullOrWhiteSpace(strName) || string.IsNullOrWhiteSpace(strPass))
            {
                ShowError("Please enter both username and password.");
                return;
            }

            // 2) authenticate (returns null when the credentials do not match)
            Admin loginAdmin = this.myCtr.checkAdminLogin(strName, strPass);

            if (loginAdmin != null)
            {
                lblError.Text = "";
                MainForm mf = new MainForm(this.myCtr, loginAdmin);
                mf.Show();
                this.Hide();
                return;
            }

            // 3) failed: count the attempt and lock after the limit
            failedAttempts++;
            int left = MAX_ATTEMPTS - failedAttempts;

            if (left <= 0)
            {
                ShowError("Account locked after 3 failed attempts.");
                btnLogin.Enabled = false;
                txtLoginName.Enabled = false;
                txtLoginPass.Enabled = false;
            }
            else
            {
                ShowError($"Incorrect username or password. Attempts left: {left}");
                txtLoginPass.Clear();
                txtLoginPass.Focus();
            }
        }

        // Show / hide the password characters
        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtLoginPass.UseSystemPasswordChar = !chkShowPass.Checked;
        }

        // Open the registration screen
        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // When RegisterForm is built, open it here, e.g.:
            // var rf = new RegisterForm(this.myCtr);
            // rf.ShowDialog();
            MessageBox.Show("Registration screen goes here.", "Create account",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
        }
    }
}
