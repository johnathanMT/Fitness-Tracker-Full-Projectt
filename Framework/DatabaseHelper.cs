using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Framework
{
    public class DatabaseHelper
    {
        private string dbName = "FworkDB.db"; //uer defined database name
        private string conn = "Data Source="; // prepare for sqlite data source connection
        public DatabaseHelper()
        {
            this.conn = this.conn + this.dbName;
            //connect the SQLite database
            using (var myDbCon = new SqliteConnection(this.conn))
            {
                Console.WriteLine("Database Connection is OK");

                myDbCon.Open();
                //SQL 
                var myDbCmd =myDbCon.CreateCommand();//to execute the SQL 

                //prepare the SQL (create)
                myDbCmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS tbl_admin(
                            admin_id INTEGER PRIMARY KEY AUTOINCREMENT,
                            admin_name TEXT,
                            admin_pass TEXT
                        );
                            INSERT INTO tbl_admin values
                            (1,'Admin','AdminPass123'),
                            (2,'Root','RootPass1234')
                            ON CONFLICT(admin_id) DO NOTHING;


                       CREATE TABLE IF NOT EXISTS tbl_user(
                            user_name TEXT PRIMARY KEY,
                            user_pass TEXT,
                            user_weight REAL,
                            user_height REAL
                       );

                       INSERT INTO tbl_user values
                        ('James','JamesPass123',150,60),
                        ('Smith','SmithPass123',200,80)
                        ON CONFLICT(user_name) DO NOTHING;


                        CREATE TABLE IF NOT EXISTS tbl_activity(
                            activity_id INTEGER PRIMARY KEY,
                            activity_name TEXT
                        );
                        insert into tbl_activity values
                        (1,'walking'),(2,'swimming')
                        ON CONFLICT(activity_id) DO NOTHING;
  
                        CREATE TABLE IF NOT EXISTS tbl_tracker(
                            tracker_id INTEGER PRIMARY KEY AUTOINCREMENT,
                            user_name TEXT,
                            goal_burn  INTEGER,
                            play_date  TEXT,
                            track_status TEXT,
                            FOREIGN KEY(user_name) REFERENCES tbl_user(user_name)
                        );
                        CREATE TABLE IF NOT EXISTS tbl_tracker_detail(
                            detail_id INTEGER PRIMARY KEY AUTOINCREMENT,
                            tracker_id INTEGER,
                            activity_id INTEGER,
                            activity_burn  INTEGER,
                            FOREIGN KEY(tracker_id) REFERENCES tbl_tracker(tracker_id),
                            FOREIGN KEY(activity_id) REFERENCES tbl_activity(activity_id)
                        );
                        insert into tbl_tracker values
                        (1,'james',1800,'20-06-2026','NOT REACH')
                        ON CONFLICT(tracker_id) DO NOTHING;

                        insert into tbl_tracker_detail values
                        (1,1,1,300),(2,1,2,800)
                        ON CONFLICT(detail_id) DO NOTHING;
                        
                ";
                Console.WriteLine("Create SUCCESS");
                //execute the SQL:create command
                myDbCmd.ExecuteNonQuery();

                myDbCon.Close();
            }
        }
    
    
        public Admin getAdmin(string name,string pass)
        {
            Admin admin = null;
            using (var myDbCon = new SqliteConnection(this.conn))
            {
                Console.WriteLine("Database Connection is OK");

                myDbCon.Open();
                //SQL 
                var myDbCmd = myDbCon.CreateCommand();//to execute the SQL 

                //prepare the SQL (create)
                myDbCmd.CommandText = @"
                    SELECT * FROM tbl_admin
                    WHERE admin_name=@pname
                    AND admin_pass=@ppass
                ";
                myDbCmd.Parameters.AddWithValue("@pname", name);
                myDbCmd.Parameters.AddWithValue("@ppass", pass);

                using (var myReader = myDbCmd.ExecuteReader())
                {
                    if (myReader.Read())
                    {   //record exist in the TABLE
                        //Console.WriteLine("Record EXIST");
                        admin = new Admin();
                        int aid=myReader.GetInt32(0);
                        string aname=myReader.GetString(1);
                        string apass=myReader.GetString(2);
                        Console.WriteLine($"Select Result {aid}:{aname}:{apass}");

                        admin.AdminId = aid;
                        admin.AdminName= aname;
                        admin.AdminPassword= apass;
                    }
                }
                myDbCon.Close();
            }
            return admin;
        }
        public User getUser(string name)
        {
            User user= null;
            using (var myDbCon = new SqliteConnection(this.conn))
            {
                myDbCon.Open();
                var myDbCmd = myDbCon.CreateCommand();//to execute the SQL 
                myDbCmd.CommandText = @"
                    SELECT * FROM tbl_user
                    WHERE user_name=@pname
                ";
                myDbCmd.Parameters.AddWithValue("@pname", name);
                using (var myReader = myDbCmd.ExecuteReader())
                {
                    if (myReader.Read())
                    {   
                        string uname = myReader.GetString(0);
                        string apass = myReader.GetString(1);
                        double weight=myReader.GetDouble(2);
                        double height = myReader.GetDouble(3);
                        user = new User(uname,apass,weight,height);
                    }
                }
                myDbCon.Close();
            }
            return user;
        }
        public void saveTracker(Tracker tracker)
        {
            Console.WriteLine($"Goal: BtnSave Helpler=>" +
                $"{tracker.UserName},{tracker.GoalBurn},{tracker.PlayDate}," +
                $"{tracker.TrackStatus}");
            using (var myDbCon = new SqliteConnection(this.conn))
            {
                myDbCon.Open();
                var myDbCmd = myDbCon.CreateCommand();//to execute the SQL 
                myDbCmd.CommandText = @"
                    INSERT INTO tbl_tracker 
                    VALUES(null,@uname,@goal,@date,@status);
                ";
                myDbCmd.Parameters.AddWithValue("@uname", tracker.UserName);
                myDbCmd.Parameters.AddWithValue("@goal", tracker.GoalBurn);
                myDbCmd.Parameters.AddWithValue("@date", tracker.PlayDate);
                myDbCmd.Parameters.AddWithValue("@status", tracker.TrackStatus);
                myDbCmd.ExecuteNonQuery();
                myDbCon.Close();
                Console.WriteLine($"Goal: BtnSave Helpler FINISH=>");
            }    
        }
        public void saveTrackerDetail(string uname, int aid, double burn)
        {
            using (var myDbCon = new SqliteConnection(this.conn))
            {
                myDbCon.Open();
                var myDbCmd = myDbCon.CreateCommand();

                myDbCmd.CommandText = @"
                    SELECT tracker_id FROM tbl_tracker
                    WHERE user_name=@uname
                    AND track_status=@status
                ";
                myDbCmd.Parameters.AddWithValue("@uname", uname);
                myDbCmd.Parameters.AddWithValue("@status", "Progress");
                int trackerId = 0;
                using (var myReader = myDbCmd.ExecuteReader())
                {
                    if (myReader.Read()) trackerId = myReader.GetInt32(0);
                }

                //inSERT
                myDbCmd.CommandText = @"
                   INSERT INTO tbl_tracker_detail values
                    (null,@tid,@aid,@burn)
                ";
                myDbCmd.Parameters.AddWithValue("@tid", trackerId);
                myDbCmd.Parameters.AddWithValue("@aid", aid);
                myDbCmd.Parameters.AddWithValue("@burn",burn);
                myDbCmd.ExecuteNonQuery();

                myDbCon.Close();
            }
        }
        public List<RecordActivity> getDailyActivityByUName(string uname)
        {
            List<RecordActivity> recList = new List<RecordActivity>();
            using (var myDbCon = new SqliteConnection(this.conn))
            {
                myDbCon.Open();
                var myDbCmd = myDbCon.CreateCommand();

                myDbCmd.CommandText = @"
                    SELECT ta.activity_name,td.activity_burn,tt.goal_burn
                    FROM tbl_tracker tt,tbl_activity ta,tbl_tracker_detail td
                    WHERE tt.user_name=@uname
                    AND tt.track_status=@status 
                    AND td.activity_id=ta.activity_id
                    AND tt.tracker_id=td.tracker_id
                ";
                myDbCmd.Parameters.AddWithValue("@uname", uname);
                myDbCmd.Parameters.AddWithValue("@status", "Progress");
                
                using (var myReader = myDbCmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        string aname = myReader.GetString(0);
                        int burn=myReader.GetInt32(1);
                        double goal=myReader.GetDouble(2);
                        recList.Add(new RecordActivity(aname, burn,goal));
                    }
                }
                myDbCon.Close();
            }
            return recList;
        }
        public void updateTracker(string uname, string status)
        {
            using (var myDbCon = new SqliteConnection(this.conn))
            {
                myDbCon.Open();
                var myDbCmd = myDbCon.CreateCommand();

                myDbCmd.CommandText = @"
                    UPDATE tbl_tracker
                    SET track_status=@update_status
                    WHERE user_name=@uname
                    AND track_status=@status 
                ";
                myDbCmd.Parameters.AddWithValue("@uname", uname);
                myDbCmd.Parameters.AddWithValue("@update_status", status);
                myDbCmd.Parameters.AddWithValue("@status", "Progress");
                myDbCmd.ExecuteNonQuery();
                myDbCon.Close();
            }
        }
    }
}
