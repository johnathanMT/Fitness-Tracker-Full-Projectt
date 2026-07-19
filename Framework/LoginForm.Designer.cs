namespace Framework
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlLeft = new Panel();
            lblBrand = new Label();
            lblTagline = new Label();
            lblFootnote = new Label();
            pnlRight = new Panel();
            lblWelcome = new Label();
            lblSub = new Label();
            lblUser = new Label();
            txtLoginName = new TextBox();
            lblPass = new Label();
            txtLoginPass = new TextBox();
            chkShowPass = new CheckBox();
            lblError = new Label();
            btnLogin = new Button();
            lnkRegister = new LinkLabel();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();
            //
            // pnlLeft  (accent "hero" panel)
            //
            pnlLeft.BackColor = Color.FromArgb(79, 70, 229);
            pnlLeft.Controls.Add(lblBrand);
            pnlLeft.Controls.Add(lblTagline);
            pnlLeft.Controls.Add(lblFootnote);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(360, 560);
            pnlLeft.TabIndex = 0;
            //
            // lblBrand
            //
            lblBrand.AutoSize = true;
            lblBrand.BackColor = Color.Transparent;
            lblBrand.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(40, 70);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(255, 47);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Fitness Tracker";
            //
            // lblTagline
            //
            lblTagline.AutoSize = true;
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Segoe UI", 12F);
            lblTagline.ForeColor = Color.FromArgb(224, 231, 255);
            lblTagline.Location = new Point(42, 128);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(214, 21);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Track. Improve. Achieve.";
            //
            // lblFootnote
            //
            lblFootnote.BackColor = Color.Transparent;
            lblFootnote.Font = new Font("Segoe UI", 9.5F);
            lblFootnote.ForeColor = Color.FromArgb(199, 210, 254);
            lblFootnote.Location = new Point(42, 470);
            lblFootnote.Name = "lblFootnote";
            lblFootnote.Size = new Size(280, 70);
            lblFootnote.TabIndex = 2;
            lblFootnote.Text = "Log your walks, swims and daily goals — and see whether you reached your calorie target.";
            //
            // pnlRight  (white form panel)
            //
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(lblWelcome);
            pnlRight.Controls.Add(lblSub);
            pnlRight.Controls.Add(lblUser);
            pnlRight.Controls.Add(txtLoginName);
            pnlRight.Controls.Add(lblPass);
            pnlRight.Controls.Add(txtLoginPass);
            pnlRight.Controls.Add(chkShowPass);
            pnlRight.Controls.Add(lblError);
            pnlRight.Controls.Add(btnLogin);
            pnlRight.Controls.Add(lnkRegister);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(360, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(0);
            pnlRight.Size = new Size(540, 560);
            pnlRight.TabIndex = 1;
            //
            // lblWelcome
            //
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(30, 41, 59);
            lblWelcome.Location = new Point(60, 70);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(197, 37);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome back";
            //
            // lblSub
            //
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Segoe UI", 10.5F);
            lblSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblSub.Location = new Point(62, 112);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(150, 19);
            lblSub.TabIndex = 1;
            lblSub.Text = "Sign in to continue";
            //
            // lblUser
            //
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblUser.ForeColor = Color.FromArgb(51, 65, 85);
            lblUser.Location = new Point(62, 168);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(72, 17);
            lblUser.TabIndex = 2;
            lblUser.Text = "USERNAME";
            //
            // txtLoginName
            //
            txtLoginName.BorderStyle = BorderStyle.FixedSingle;
            txtLoginName.Font = new Font("Segoe UI", 12F);
            txtLoginName.Location = new Point(62, 190);
            txtLoginName.Name = "txtLoginName";
            txtLoginName.PlaceholderText = "Enter your username";
            txtLoginName.Size = new Size(416, 32);
            txtLoginName.TabIndex = 3;
            //
            // lblPass
            //
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblPass.ForeColor = Color.FromArgb(51, 65, 85);
            lblPass.Location = new Point(62, 244);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(70, 17);
            lblPass.TabIndex = 4;
            lblPass.Text = "PASSWORD";
            //
            // txtLoginPass
            //
            txtLoginPass.BorderStyle = BorderStyle.FixedSingle;
            txtLoginPass.Font = new Font("Segoe UI", 12F);
            txtLoginPass.Location = new Point(62, 266);
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.PlaceholderText = "Enter your password";
            txtLoginPass.Size = new Size(416, 32);
            txtLoginPass.TabIndex = 5;
            txtLoginPass.UseSystemPasswordChar = true;
            //
            // chkShowPass
            //
            chkShowPass.AutoSize = true;
            chkShowPass.Font = new Font("Segoe UI", 9.5F);
            chkShowPass.ForeColor = Color.FromArgb(100, 116, 139);
            chkShowPass.Location = new Point(62, 306);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(122, 21);
            chkShowPass.TabIndex = 6;
            chkShowPass.Text = "Show password";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            //
            // lblError
            //
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9.5F);
            lblError.ForeColor = Color.FromArgb(220, 38, 38);
            lblError.Location = new Point(62, 338);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 17);
            lblError.TabIndex = 7;
            lblError.Text = "";
            //
            // btnLogin
            //
            btnLogin.BackColor = Color.FromArgb(79, 70, 229);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 56, 202);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(62, 370);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(416, 48);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Sign in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Click += btnLogin_Click;
            //
            // lnkRegister
            //
            lnkRegister.ActiveLinkColor = Color.FromArgb(67, 56, 202);
            lnkRegister.AutoSize = true;
            lnkRegister.Font = new Font("Segoe UI", 10F);
            lnkRegister.LinkColor = Color.FromArgb(79, 70, 229);
            lnkRegister.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkRegister.Location = new Point(62, 438);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(258, 19);
            lnkRegister.TabIndex = 9;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Don't have an account?  Create one";
            lnkRegister.LinkArea = new LinkArea(24, 10);
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            //
            // LoginForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 560);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fitness Tracker — Login";
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Label lblBrand;
        private Label lblTagline;
        private Label lblFootnote;
        private Panel pnlRight;
        private Label lblWelcome;
        private Label lblSub;
        private Label lblUser;
        private TextBox txtLoginName;
        private Label lblPass;
        private TextBox txtLoginPass;
        private CheckBox chkShowPass;
        private Label lblError;
        private Button btnLogin;
        private LinkLabel lnkRegister;
    }
}
