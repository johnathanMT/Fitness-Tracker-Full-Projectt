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
    public partial class ReportForm : Form
    {
        private FrameController myCtrl;
        public ReportForm(FrameController ctrl)
        {
            InitializeComponent();
            this.myCtrl = ctrl;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string uname=this.txtUserName.Text;
            List<RecordActivity> act=this.myCtrl.getRecordActivies(uname);
            DataTable dt = new DataTable();
            dt.Columns.Add("Activity Name", typeof(string));
            dt.Columns.Add("Burn Cal", typeof(double));
            double dailyTotal = 0;
            foreach (RecordActivity recordActivity in act)
            {
                dt.Rows.Add(recordActivity.ActivityName, recordActivity.TotalBurn);
                dailyTotal+= recordActivity.TotalBurn;
            }
            dt.Rows.Add("Daily Toal Burn",dailyTotal);
            double goalBurn = act[0].GoalBurn;
            dt.Rows.Add("Goal Burn",goalBurn);

            this.dgvActivity.DataSource = dt;

            if (goalBurn<= dailyTotal)
                this.lblResult.Text = "SUCCESS";
            else
                this.lblResult.Text = "FAILURE";

            this.myCtrl.updateRecordStatus(uname, this.lblResult.Text);
        }
    }
}
