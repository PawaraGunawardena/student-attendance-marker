using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Configuration;
using Dapper;
using System.Windows.Forms;

namespace CustomLibrary.Data.ModelData
{
    public class StudentAttendanceData
    {
        public void saveStdentAttendance(StudentAttendanceModel student_attendance_model)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //cnn.Execute("Insert into student_attendance (student_id, student_name, entered_date, entered_time, class_id) values (152634789, '','6-10-2018','2:31:11 AM',1)");
                //System.Threading.Thread.Sleep(2000);
                String query = getDBQuery(student_attendance_model);


                try
                {
                    cnn.Execute(query);
                    
                }
                catch (Exception e)
                {
                    while (true)
                    {
                        try
                        {
                            cnn.Execute(query);
                            break;
                        }
                        catch (Exception e1)
                        {

                        }
                    }
                }
                
                
                
                cnn.Close();
            }
           
        }

        private String getDBQuery(StudentAttendanceModel student_attendance_model)
        {
            String query;

            query = "Insert into student_attendance (student_id, student_name, entered_date, entered_time, class_id) values ('"
                    + student_attendance_model.get_student_id() + "','"
                    + student_attendance_model.get_student_name() + "','"
                    + student_attendance_model.get_entered_date() + "','"
                    + student_attendance_model.get_entered_time() + "','"

                    + student_attendance_model.get_class_id()
                    + "')";

            return query;
        }

        private string LoadConnectionString(String id = "Default")
        {
            //Compare this value with the id value of the ADDED APP.CONFIG value
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        public void load_student_list(DataGridView dataGridView)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteDataAdapter data_adapter = new SQLiteDataAdapter
                    ("SELECT student_id AS 'Student ID ', student_name AS 'Student Name', entered_date AS 'Entered-Date ', entered_time AS 'Entered Time ', subject AS 'Subject ', class.date AS 'Date ', class.time AS 'Time ', teacher_name AS 'Teacher ', class_type AS 'Type ', class_year AS 'Year '" +
                    " FROM student_attendance INNER JOIN class on student_attendance.class_id=class.class_id",
                    dbConnection);
                DataSet ds = new System.Data.DataSet();

              //  MessageBox.Show("");
                data_adapter.Fill(ds 
                    );

                dataGridView.DataSource = ds.Tables[0];
                dbConnection.Close();
            }
        }

        public void load_student_list_inday(DataGridView dataGridView, int class_id, String date)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteDataAdapter data_adapter = 
                    new SQLiteDataAdapter
                    ("SELECT student_id AS 'Student ID ', student_name AS 'Student Name', entered_date AS 'Entered Date ', entered_time AS 'Entered Time ' FROM student_attendance WHERE class_id ='"
                        + class_id + "' and entered_date ='"
                        + date + "' ORDER BY entered_time ASC"

                    , dbConnection);
                DataSet ds = new System.Data.DataSet();

                data_adapter.Fill(ds, "Info");
                //dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView.DataSource = ds.Tables[0];
                //dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dbConnection.Close();

             
            }
        }

        public void load_student_list_from_student_id(DataGridView dataGridView, string stuent_id)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteDataAdapter data_adapter =
                    new SQLiteDataAdapter
                    ("SELECT student_id AS 'Student ID ', student_name AS 'Student Name', entered_date AS 'Entered Date ', entered_time AS 'Entered Time ', subject AS 'Subject ', class.date AS 'Date ', class.time AS 'Time ', teacher_name AS 'Teacher ', class_type AS 'Type ', class_year AS 'Year '" +
                    " FROM student_attendance INNER JOIN class on student_attendance.class_id=class.class_id WHERE student_id ='"
                        + stuent_id +"'"

                    , dbConnection);
                DataSet ds = new System.Data.DataSet();

                data_adapter.Fill(ds, "Info");
                //dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView.DataSource = ds.Tables[0];
                //dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dbConnection.Close();
            }
        }

        

            public void load_student_list_from_student_id_and_student_name(DataGridView dataGridView, string stuent_id, string student_name)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteDataAdapter data_adapter =
                    new SQLiteDataAdapter
                    ("SELECT student_id AS 'Student ID ', student_name AS 'Student Name', entered_date AS 'Entered Date ', entered_time AS 'Entered Time ', subject AS 'Subject ', class.date AS 'Date ', class.time AS 'Time ', teacher_name AS 'Teacher ', class_type AS 'Type ', class_year AS 'Year '" +
                    " FROM student_attendance INNER JOIN class on student_attendance.class_id=class.class_id WHERE student_id ='"
                        + stuent_id + "' and student_name ='"
                        + student_name + "'"
                    , dbConnection);
                DataSet ds = new System.Data.DataSet();

                data_adapter.Fill(ds, "Info");
                //dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView.DataSource = ds.Tables[0];
                //dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dbConnection.Close();
            }
        }

        public void load_student_list_from_and_student_name(DataGridView dataGridView,  string student_name)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteDataAdapter data_adapter =
                    new SQLiteDataAdapter
                    ("SELECT student_id AS 'Student ID ', student_name AS 'Student Name', entered_date AS 'Entered Date ', entered_time AS 'Entered Time ', subject AS 'Subject ', class.date AS 'Date ', class.time AS 'Time ', teacher_name AS 'Teacher ', class_type AS 'Type ', class_year AS 'Year '" +
                    " FROM student_attendance INNER JOIN class on student_attendance.class_id=class.class_id WHERE student_name ='"
                        + student_name + "'"
                    , dbConnection);
                DataSet ds = new System.Data.DataSet();

                data_adapter.Fill(ds, "Info");
                //dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView.DataSource = ds.Tables[0];
                //dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dbConnection.Close();
            }
        }

        public void load_student_list_from_class_id_and_date_selected(DataGridView dataGridView, String class_id, String date_selected)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteDataAdapter data_adapter =
                    new SQLiteDataAdapter
                     ("SELECT student_id AS 'Student ID ', student_name AS 'Student Name', entered_date AS 'Entered Date ', entered_time AS 'Entered Time ', subject AS 'Subject ', class.date AS 'Date ', class.time AS 'Time ', teacher_name AS 'Teacher ', class_type AS 'Type ', class_year AS 'Year '" +
                    " FROM student_attendance INNER JOIN class on student_attendance.class_id=class.class_id WHERE class.class_id ='"
                        + class_id + "' and student_attendance.entered_date ='"
                        + date_selected + "'"
                    , dbConnection);

                DataSet ds = new System.Data.DataSet();

                data_adapter.Fill(ds, "Info");
                //dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView.DataSource = ds.Tables[0];
                //dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dbConnection.Close();
            }
        }
        public void load_student_list_from_class_id(DataGridView dataGridView, String class_id)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteDataAdapter data_adapter =
                    new SQLiteDataAdapter
                     ("SELECT student_id AS 'Student ID ', student_name AS 'Student Name', entered_date AS 'Entered Date ', entered_time AS 'Entered Time ', subject AS 'Subject ', class.date AS 'Date ', class.time AS 'Time ', teacher_name AS 'Teacher ', class_type AS 'Type ', class_year AS 'Year '" +
                    " FROM student_attendance INNER JOIN class on student_attendance.class_id=class.class_id WHERE class.class_id ='"
                        + class_id + "'"
                    , dbConnection);

                DataSet ds = new System.Data.DataSet();

                data_adapter.Fill(ds, "Info");
                //dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView.DataSource = ds.Tables[0];
                //dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dbConnection.Close();
            }
        }
        public void load_student_list_from_date_selected(DataGridView dataGridView, String date_selected)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteDataAdapter data_adapter =
                    new SQLiteDataAdapter
                     ("SELECT student_id AS 'Student ID ', student_name AS 'Student Name', entered_date AS 'Entered Date ', entered_time AS 'Entered Time ', subject AS 'Subject ', class.date AS 'Date ', class.time AS 'Time ', teacher_name AS 'Teacher ', class_type AS 'Type ', class_year AS 'Year '" +
                    " FROM student_attendance INNER JOIN class on student_attendance.class_id=class.class_id WHERE student_attendance.entered_date ='"
                        + date_selected + "'"
                    , dbConnection);

                DataSet ds = new System.Data.DataSet();

                data_adapter.Fill(ds, "Info");
                //dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView.DataSource = ds.Tables[0];
                //dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dbConnection.Close();
            }
        }

        public List<String> get_student_list(String class_id, String date)
        {
           // String student_id;

            List<String> student_list = new List<String>();

            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                String statement =
                    "SELECT student_id FROM student_attendance WHERE class_id = '"
                        + class_id + "' and entered_date ='"
                        + date + "'";
                SQLiteCommand sqlite_command = new SQLiteCommand(statement, dbConnection);
                SQLiteDataReader sqlite_reader = sqlite_command.ExecuteReader();

                while (sqlite_reader.Read())
                {
                    //student_id = sqlite_reader.GetString(0);
                    //teacherModel.set_teacher_id(sqlite_reader.GetInt32(0));
                    //MessageBox.Show(sqlite_reader.GetInt32(0).ToString());
                    student_list.Add(sqlite_reader.GetInt32(0).ToString());
                }
                dbConnection.Close();
            }
            return student_list;
        }

        public bool get_student_attendance_by_studentID(int class_id, string student_id, string class_date)
        {
            string query = "SELECT student_id FROM student_attendance WHERE class_id='" + class_id + "' "
                 + "and entered_date='" + class_date + "'"
                 + "and student_id='" + student_id + "'"
            ;

            bool succeeded = false;

            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();

                SQLiteCommand sqlite_command = new SQLiteCommand(query, dbConnection);
                SQLiteDataReader sqlite_reader = sqlite_command.ExecuteReader();

                while (sqlite_reader.Read())
                {
                    //student_id = sqlite_reader.GetString(0);
                    //teacherModel.set_teacher_id(sqlite_reader.GetInt32(0));
                    //MessageBox.Show(sqlite_reader.GetInt32(0).ToString());
                    int id = sqlite_reader.GetInt32(0);
                    succeeded = true;
                    //MessageBox.Show(previous_date);
                }
               
                dbConnection.Close();
            }
          

            return succeeded;
        }

        public string get_previous_class_date(int class_id, string today_date)
        {
            string previous_date = "";

            string query = "SELECT max(entered_date) FROM student_attendance WHERE class_id='"+class_id+"' "
 +"and entered_date < '"+today_date+"'"
                ;
            string query2 = "SELECT entered_date FROM student_attendance ORDER BY entered_date ASC LIMIT 1";
            string query3 = "SELECT entered_date FROM student_attendance";
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
  
                SQLiteCommand sqlite_command = new SQLiteCommand(query, dbConnection);
                SQLiteDataReader sqlite_reader = sqlite_command.ExecuteReader();

                while (sqlite_reader.Read())
                {
                    try
                    {
                        //student_id = sqlite_reader.GetString(0);
                        //teacherModel.set_teacher_id(sqlite_reader.GetInt32(0));
                        //MessageBox.Show(sqlite_reader.GetInt32(0).ToString());
                        previous_date = sqlite_reader.GetString(0);
                        //MessageBox.Show(previous_date);

                    }
                    catch(Exception e)
                    {

                    }


                }
                dbConnection.Close();
            }


            return previous_date;
        }

    }
}
