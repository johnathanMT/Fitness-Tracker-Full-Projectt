namespace Framework
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            label1 = new Label();
            panelFooter = new Panel();
            panelMenu = new Panel();
            button4 = new Button();
            btnReport = new Button();
            btnActivity = new Button();
            btnGoal = new Button();
            panelMain = new Panel();
            lblLoginName = new Label();
            panelHeader.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.ActiveCaption;
            panelHeader.Controls.Add(lblLoginName);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1379, 103);
            panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(432, 9);
            label1.Name = "label1";
            label1.Size = new Size(509, 74);
            label1.TabIndex = 0;
            label1.Text = "FITNESS TRACKER";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = SystemColors.ActiveCaption;
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 732);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1379, 89);
            panelFooter.TabIndex = 1;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ActiveCaption;
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(btnReport);
            panelMenu.Controls.Add(btnActivity);
            panelMenu.Controls.Add(btnGoal);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 103);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(284, 629);
            panelMenu.TabIndex = 2;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(27, 551);
            button4.Name = "button4";
            button4.Size = new Size(194, 59);
            button4.TabIndex = 3;
            button4.Text = "LOGOUT";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.Location = new Point(22, 236);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(208, 64);
            btnReport.TabIndex = 2;
            btnReport.Text = "REPORT";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnActivity
            // 
            btnActivity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActivity.Location = new Point(21, 140);
            btnActivity.Name = "btnActivity";
            btnActivity.Size = new Size(210, 62);
            btnActivity.TabIndex = 1;
            btnActivity.Text = "ACTVITY";
            btnActivity.UseVisualStyleBackColor = true;
            btnActivity.Click += btnActivity_Click;
            // 
            // btnGoal
            // 
            btnGoal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoal.Location = new Point(21, 41);
            btnGoal.Name = "btnGoal";
            btnGoal.Size = new Size(213, 65);
            btnGoal.TabIndex = 0;
            btnGoal.Text = "SET GOAL";
            btnGoal.UseVisualStyleBackColor = true;
            btnGoal.Click += btnGoal_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.GradientInactiveCaption;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(284, 103);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1095, 629);
            panelMain.TabIndex = 3;
            // 
            // lblLoginName
            // 
            lblLoginName.AutoSize = true;
            lblLoginName.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLoginName.ForeColor = Color.Blue;
            lblLoginName.Location = new Point(1205, 55);
            lblLoginName.Name = "lblLoginName";
            lblLoginName.Size = new Size(116, 45);
            lblLoginName.TabIndex = 1;
            lblLoginName.Text = "label2";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 821);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Name = "MainForm";
            Text = "MainForm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Panel panelFooter;
        private Panel panelMenu;
        private Panel panelMain;
        private Button button4;
        private Button btnReport;
        private Button btnActivity;
        private Button btnGoal;
        private Label lblLoginName;
    }
}