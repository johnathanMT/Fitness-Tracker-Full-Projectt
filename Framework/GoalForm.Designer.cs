namespace Framework
{
    partial class GoalForm
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
            label1 = new Label();
            lblToday = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            txtGoal = new TextBox();
            lblErrUserName = new Label();
            lblErrGoal = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(631, 45);
            label1.TabIndex = 0;
            label1.Text = "TODAY GOAL CALORIE BURN REGISTER";
            // 
            // lblToday
            // 
            lblToday.AutoSize = true;
            lblToday.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblToday.Location = new Point(719, 93);
            lblToday.Name = "lblToday";
            lblToday.Size = new Size(245, 45);
            lblToday.TabIndex = 1;
            lblToday.Text = "dd-MMM-yyyy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(116, 179);
            label2.Name = "label2";
            label2.Size = new Size(272, 45);
            label2.TabIndex = 2;
            label2.Text = "Enter User Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(116, 303);
            label3.Name = "label3";
            label3.Size = new Size(364, 45);
            label3.TabIndex = 3;
            label3.Text = "Enter Goal Calorie Burn:";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(506, 179);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(306, 51);
            txtUserName.TabIndex = 4;
            txtUserName.KeyDown += txtUserName_KeyDown;
            // 
            // txtGoal
            // 
            txtGoal.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGoal.Location = new Point(506, 303);
            txtGoal.Name = "txtGoal";
            txtGoal.Size = new Size(306, 51);
            txtGoal.TabIndex = 5;
            txtGoal.KeyDown += txtGoal_KeyDown;
            // 
            // lblErrUserName
            // 
            lblErrUserName.AutoSize = true;
            lblErrUserName.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblErrUserName.ForeColor = Color.Red;
            lblErrUserName.Location = new Point(506, 233);
            lblErrUserName.Name = "lblErrUserName";
            lblErrUserName.Size = new Size(66, 30);
            lblErrUserName.TabIndex = 6;
            lblErrUserName.Text = "label4";
            // 
            // lblErrGoal
            // 
            lblErrGoal.AutoSize = true;
            lblErrGoal.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblErrGoal.ForeColor = Color.Red;
            lblErrGoal.Location = new Point(506, 357);
            lblErrGoal.Name = "lblErrGoal";
            lblErrGoal.Size = new Size(66, 30);
            lblErrGoal.TabIndex = 7;
            lblErrGoal.Text = "label5";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 128, 0);
            btnSave.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(378, 421);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(267, 67);
            btnSave.TabIndex = 8;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // GoalForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(976, 536);
            Controls.Add(btnSave);
            Controls.Add(lblErrGoal);
            Controls.Add(lblErrUserName);
            Controls.Add(txtGoal);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblToday);
            Controls.Add(label1);
            Name = "GoalForm";
            Text = "GoalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblToday;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private TextBox txtGoal;
        private Label lblErrUserName;
        private Label lblErrGoal;
        private Button btnSave;
    }
}