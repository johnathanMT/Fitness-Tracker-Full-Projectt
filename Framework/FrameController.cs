using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Framework
{
    public class FrameController
    {
        private DatabaseHelper myDbHelper;
        public FrameController() {
            Console.WriteLine("Controller Loading....");
            this.myDbHelper=new DatabaseHelper();
        }

        public Admin checkAdminLogin(string username, string password)
        {
            return this.myDbHelper.getAdmin(username, password);
        }
        public User getUserByName(string username)
        {
            return this.myDbHelper.getUser(username);
        }
        public void saveNewTrack(string uname,string goal,string date)
        {
            Console.WriteLine($"Goal: BtnSave Controller=>{uname},{goal},{date}");
            Tracker tracker = new Tracker();
            tracker.UserName = uname;
            tracker.GoalBurn = int.Parse(goal);
            tracker.PlayDate = date;
            tracker.TrackStatus = "Progress";
            this.myDbHelper.saveTracker(tracker);
        }

        public void saveNewRecord(string uname,int aid,double total)
        {
            this.myDbHelper.saveTrackerDetail(uname, aid, total);
        }
    
        public List<RecordActivity> getRecordActivies(string uname)
        {  
            List<RecordActivity> act=this.myDbHelper.getDailyActivityByUName(uname);
            foreach (RecordActivity recordActivity in act)
            {
                Console.WriteLine(recordActivity.ActivityName + "::" 
                    + recordActivity.TotalBurn+"::"+
                    recordActivity.GoalBurn);
            }
            return act;
        }
        public void updateRecordStatus(string uname,string status)
        {
            this.myDbHelper.updateTracker(uname, status);
        }
    
    }
}
