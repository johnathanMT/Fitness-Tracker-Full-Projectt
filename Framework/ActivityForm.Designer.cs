namespace Framework
{
    partial class ActivityForm
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
            label2 = new Label();
            comboActivity = new ComboBox();
            lblM1 = new Label();
            lblM2 = new Label();
            lblM3 = new Label();
            txtM1 = new TextBox();
            txtM2 = new TextBox();
            txtM3 = new TextBox();
            btnRecord = new Button();
            lblBurn = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 18);
            label1.Name = "label1";
            label1.Size = new Size(387, 50);
            label1.TabIndex = 0;
            label1.Text = "Daily Activity Record";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 93);
            label2.Name = "label2";
            label2.Size = new Size(324, 45);
            label2.TabIndex = 1;
            label2.Text = "Select Activity Name:";
            // 
            // comboActivity
            // 
            comboActivity.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboActivity.FormattingEnabled = true;
            comboActivity.Location = new Point(478, 90);
            comboActivity.Name = "comboActivity";
            comboActivity.Size = new Size(373, 53);
            comboActivity.TabIndex = 2;
            comboActivity.SelectedIndexChanged += comboActivity_SelectedIndexChanged;
            // 
            // lblM1
            // 
            lblM1.AutoSize = true;
            lblM1.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblM1.Location = new Point(128, 166);
            lblM1.Name = "lblM1";
            lblM1.Size = new Size(324, 45);
            lblM1.TabIndex = 3;
            lblM1.Text = "Select Activity Name:";
            // 
            // lblM2
            // 
            lblM2.AutoSize = true;
            lblM2.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblM2.Location = new Point(128, 229);
            lblM2.Name = "lblM2";
            lblM2.Size = new Size(324, 45);
            lblM2.TabIndex = 4;
            lblM2.Text = "Select Activity Name:";
            // 
            // lblM3
            // 
            lblM3.AutoSize = true;
            lblM3.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblM3.Location = new Point(128, 293);
            lblM3.Name = "lblM3";
            lblM3.Size = new Size(324, 45);
            lblM3.TabIndex = 5;
            lblM3.Text = "Select Activity Name:";
            // 
            // txtM1
            // 
            txtM1.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtM1.Location = new Point(572, 160);
            txtM1.Name = "txtM1";
            txtM1.Size = new Size(274, 51);
            txtM1.TabIndex = 6;
            // 
            // txtM2
            // 
            txtM2.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtM2.Location = new Point(572, 226);
            txtM2.Name = "txtM2";
            txtM2.Size = new Size(274, 51);
            txtM2.TabIndex = 7;
            // 
            // txtM3
            // 
            txtM3.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtM3.Location = new Point(572, 290);
            txtM3.Name = "txtM3";
            txtM3.Size = new Size(274, 51);
            txtM3.TabIndex = 8;
            // 
            // btnRecord
            // 
            btnRecord.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecord.Location = new Point(400, 368);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(189, 61);
            btnRecord.TabIndex = 9;
            btnRecord.Text = "RECORD";
            btnRecord.UseVisualStyleBackColor = true;
            btnRecord.Click += btnRecord_Click;
            // 
            // lblBurn
            // 
            lblBurn.AutoSize = true;
            lblBurn.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBurn.ForeColor = Color.Blue;
            lblBurn.Location = new Point(602, 463);
            lblBurn.Name = "lblBurn";
            lblBurn.Size = new Size(292, 45);
            lblBurn.TabIndex = 10;
            lblBurn.Text = "Total Burn=xxxxx";
            // 
            // ActivityForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(976, 536);
            Controls.Add(lblBurn);
            Controls.Add(btnRecord);
            Controls.Add(txtM3);
            Controls.Add(txtM2);
            Controls.Add(txtM1);
            Controls.Add(lblM3);
            Controls.Add(lblM2);
            Controls.Add(lblM1);
            Controls.Add(comboActivity);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ActivityForm";
            Text = "ActivityForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboActivity;
        private Label lblM1;
        private Label lblM2;
        private Label lblM3;
        private TextBox txtM1;
        private TextBox txtM2;
        private TextBox txtM3;
        private Button btnRecord;
        private Label lblBurn;
    }
}