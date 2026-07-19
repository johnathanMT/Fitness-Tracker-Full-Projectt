using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class ActivityController
    {
        public List<Activity> activities;
        public ActivityController()
        {
            activities = new List<Activity>();
            activities.Insert(0, walking());
            activities.Insert(1, swimming());
        }
        private Activity walking()
        {
            Activity a = new Activity();
            a.ActivityId = 1;
            a.ActivityName = "Walking";
            a.MetricNames = new string[]
                {"Numbers of Steps","Time Taken","Distance"};
            a.MetricValues = new double[3];
            return a;
        }
        private Activity swimming()
        {
            Activity a = new Activity();
            a.ActivityId = 2;
            a.ActivityName = "Swimming";
            a.MetricNames = new string[]
                {"Numbers of Lap","Time Taken","Average Heart Rate:"};
            a.MetricValues = new double[3];
            return a;
        }
        public double calCaloriesForWalking(double m1,double m2,double m3)
        {
            return m1 + m2 + m3 ;
        }
        public double calCaloriesForSwimming(double m1, double m2, double m3)
        {
            return m1 + m2 + m3 ;
        }
    
        public Activity getWalking()
        {
            return this.activities[0];
        }
        public Activity getSwimming()
        {
            return this.activities[1];
        }

    }
}
