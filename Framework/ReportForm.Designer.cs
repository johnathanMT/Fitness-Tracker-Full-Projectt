namespace Framework
{
    partial class ReportForm
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
            lblHead = new Label();
            label1 = new Label();
            txtUserName = new TextBox();
            dgvActivity = new DataGridView();
            lblResult = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvActivity).BeginInit();
            SuspendLayout();
            // 
            // lblHead
            // 
            lblHead.AutoSize = true;
            lblHead.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHead.Location = new Point(339, 29);
            lblHead.Name = "lblHead";
            lblHead.Size = new Size(274, 50);
            lblHead.TabIndex = 0;
            lblHead.Text = "DAILY REPORT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 101);
            label1.Name = "label1";
            label1.Size = new Size(262, 45);
            label1.TabIndex = 1;
            label1.Text = "Enter user name:";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(480, 99);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(206, 51);
            txtUserName.TabIndex = 2;
            // 
            // dgvActivity
            // 
            dgvActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivity.Location = new Point(183, 166);
            dgvActivity.Name = "dgvActivity";
            dgvActivity.RowHeadersWidth = 72;
            dgvActivity.Size = new Size(635, 232);
            dgvActivity.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Blue;
            lblResult.Location = new Point(339, 412);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(128, 50);
            lblResult.TabIndex = 4;
            lblResult.Text = "label2";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(710, 96);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(161, 50);
            btnSave.TabIndex = 5;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(976, 536);
            Controls.Add(btnSave);
            Controls.Add(lblResult);
            Controls.Add(dgvActivity);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Controls.Add(lblHead);
            Name = "ReportForm";
            Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)dgvActivity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHead;
        private Label label1;
        private TextBox txtUserName;
        private DataGridView dgvActivity;
        private Label lblResult;
        private Button btnSave;
    }
}