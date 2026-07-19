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
    public partial class GoalForm : Form
    {
        private FrameController myCtrl;
        public GoalForm(FrameController ctrl)
        {
            InitializeComponent();
            this.myCtrl = ctrl;

            //not show the error label
            this.lblErrGoal.Visible = false;
            this.lblErrUserName.Visible = false;

            //get today date and format and show in label
            DateTime today = DateTime.Now;
            string todayDate = today.ToString("dd-MMM-yyyy");
            this.lblToday.Text = todayDate;
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string strUname = txtUserName.Text;
                Console.WriteLine("Goal username ==>" + strUname);

                User user = this.myCtrl.getUserByName(strUname);
                if (user == null)
                {
                    this.lblErrUserName.Text = "user does not exist";
                    this.lblErrUserName.Visible = true;
                }
                else
                {
                    this.lblErrUserName.Text = "";
                    this.lblErrUserName.Visible = false;
                }
            }
        }

        private void txtGoal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string strGoal = txtGoal.Text;
                Console.WriteLine("Goal cal ==>" + strGoal);
                if (!int.TryParse(strGoal, out int result))
                {
                    //It is not numeric
                    this.lblErrGoal.Text = "goal calorie must be numeric";
                    this.lblErrGoal.Visible = true;
                }
                else
                {
                    this.lblErrGoal.Text = "";
                    this.lblErrGoal.Visible = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Goal: BtnSave=> Start");
            string strName = this.txtUserName.Text;
            string strGoal = this.txtGoal.Text;
            string today = this.lblToday.Text;
            Console.WriteLine($"Goal: BtnSave 1=>{strName},{strGoal},{today}");
            this.myCtrl.saveNewTrack(strName, strGoal, today);
            MessageBox.Show("Tracker Save", "Success");
        }
    }
}
