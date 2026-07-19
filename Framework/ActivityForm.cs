using Microsoft.VisualBasic;
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
    public partial class ActivityForm : Form
    {
        private ActivityController myActCtrl;
        private FrameController myCtrl;
        public ActivityForm(FrameController ctr)
        {
            InitializeComponent();
            this.myActCtrl = new ActivityController();
            this.myCtrl = ctr;
            prepareCombo();
            controlMetric(false);
            this.btnRecord.Visible = false;
            this.lblBurn.Visible = false;
        }
        private void prepareCombo()
        {
            this.comboActivity.Items.Add("SELECT");//combo index=0
            this.comboActivity.Items.Add("Walking");
            this.comboActivity.Items.Add("Swimming");

            this.comboActivity.SelectedIndex = 0;
        }
        private void controlMetric(bool status)
        {
            this.lblM1.Visible = status;
            this.lblM2.Visible = status;
            this.lblM3.Visible = status;

            this.txtM1.Visible = status;
            this.txtM2.Visible = status;
            this.txtM3.Visible = status;
        }

        private void settingMetric(Activity a)
        {
            this.lblM1.Text = "Enter " + a.MetricNames[0] + ":";
            this.lblM2.Text = "Enter " + a.MetricNames[1] + ":";
            this.lblM3.Text = "Enter " + a.MetricNames[2] + ":";
            controlMetric(true);
            this.btnRecord.Visible = true;
        }
        private void comboActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.comboActivity.SelectedIndex;
            switch (index)
            {
                case 0:
                    controlMetric(false);
                    this.lblBurn.Visible = false;
                    this.btnRecord.Visible = false;
                    break;
                case 1: settingMetric(this.myActCtrl.getWalking()); break;
                case 2: settingMetric(this.myActCtrl.getSwimming()); break;
            }
        }

        private double[] setMetricValues()
        {
            double[] met = new double[3];
            met[0]=double.Parse(txtM1.Text);
            met[1] = double.Parse(txtM2.Text);
            met[2] = double.Parse(txtM3.Text);
            return met;
        }
        private void btnRecord_Click(object sender, EventArgs e)
        {
            string uname=Interaction.InputBox("Enter User name:",
                "Daily Burn Record");
            if (uname != null) {
                int index = this.comboActivity.SelectedIndex;
                double[] metValues = setMetricValues();
                double totalCal = 0.0;
                switch (index)
                {
                    case 1: totalCal = this.myActCtrl.calCaloriesForWalking(
                            metValues[0], metValues[1], metValues[2]); break;
                    case 2: totalCal = this.myActCtrl.calCaloriesForSwimming(
                            metValues[0], metValues[1], metValues[2]); break;
                }
                this.lblBurn.Text = "Total Calories =" + totalCal;
                this.lblBurn.Visible = true;

                this.myCtrl.saveNewRecord(uname, index, totalCal);
            }
            
        }
    }
}
