using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework
{
    public partial class MainForm : Form
    {
        private FrameController myCtr;
        private Admin loginAdmin;
        public MainForm(FrameController myCtr,Admin ladmin)
        {
            InitializeComponent();
            this.myCtr = myCtr;
            this.loginAdmin = ladmin;
            this.lblLoginName.Text = this.loginAdmin.AdminName;
            Console.WriteLine("Connect Main Form with Frame Controller");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void loadForm(Form myForm)
        {
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock=DockStyle.Fill;
            for (int i = 0; i < this.panelMain.Controls.Count; i++)
            {
                this.panelMain.Controls.Remove(this.panelMain.Controls[i]);
            }
            this.panelMain.Controls.Add(myForm);    
            myForm.Show();
        }
        private void btnGoal_Click(object sender, EventArgs e)
        {
            loadForm(new GoalForm(this.myCtr));
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            loadForm(new ActivityForm(this.myCtr));
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            loadForm(new ReportForm(this.myCtr));
        }
    }
}
