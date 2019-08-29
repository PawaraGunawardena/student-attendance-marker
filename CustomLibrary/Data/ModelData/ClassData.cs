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
    public class ClassData
    {
        public void saveClass(ClassModel classModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Insert into class (subject, date, time, teacher_name, class_type, class_year) values ('"
                    + classModel.get_subject() + "','"
                    + classModel.get_date() + "','"
                    + classModel.get_time() + "','"
                    + classModel.get_teacher_name() + "','"
                    + classModel.get_class_type() + "','"
                    + classModel.get_class_year() 
                    + "');");
                cnn.Close();
            }
        }

        private string LoadConnectionString(String id = "Default")
        {
            //Compare this value with the id value of the ADDED APP.CONFIG value
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public void load_class_list(DataGridView dataGridView)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteDataAdapter data_adapter = new SQLiteDataAdapter("SELECT subject AS ' Subject ', date AS ' Date ', time AS ' Time ', teacher_name AS 'Teacher ', class_type AS ' Class ', class_year AS ' Year ', class_id AS 'Class' FROM class", dbConnection);
                DataSet ds = new System.Data.DataSet();

                data_adapter.Fill(ds, "Info");
                dataGridView.DataSource = ds.Tables[0];
                dbConnection.Close();
            }
           
        }


        public List<ClassModel> load_class_list()
        {
            ClassModel classModel;

            List<ClassModel> classModels = new List<ClassModel>();

            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                String statement = "SELECT DISTINCT class_id, subject, date, time, teacher_name, class_type, class_year FROM class";
                SQLiteCommand sqlite_command = new SQLiteCommand(statement, dbConnection);
                SQLiteDataReader sqlite_reader = sqlite_command.ExecuteReader();

                while (sqlite_reader.Read())
                {
                    classModel = new ClassModel();
                    //teacherModel.set_teacher_id(sqlite_reader.GetInt32(0));
                    classModel.set_class_id(sqlite_reader.GetInt16(0));
                    classModel.set_subject(sqlite_reader.GetString(1));
                    classModel.set_date(sqlite_reader.GetString(2));
                    classModel.set_time(sqlite_reader.GetString(3));
                    classModel.set_teacher_name(sqlite_reader.GetString(4));
                    classModel.set_class_type(sqlite_reader.GetString(5));
                    classModel.set_class_year(sqlite_reader.GetString(6));
                    classModels.Add(classModel);
                }
                dbConnection.Close();
            }
            return classModels;
        }

        public ClassModel selectGetClass(ClassModel classModel)
        {
            
            int classID=-1;

            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                String statement = "SELECT class_id FROM class WHERE"+
                    " subject='"+classModel.get_subject()+
                    "'and date='"+classModel.get_date()+
                    "'and time='" + classModel.get_time()+
                    "'and teacher_name='" + classModel.get_teacher_name()+
                    "'and class_type='" + classModel.get_class_type()+
                    "'and class_year='" + classModel.get_class_year()+
                    "'"
                    
                    ;
                SQLiteCommand sqlite_command = new SQLiteCommand(statement, dbConnection);
                SQLiteDataReader sqlite_reader = sqlite_command.ExecuteReader();
                
                while (sqlite_reader.Read())
                {

                    //teacherModel.set_teacher_id(sqlite_reader.GetInt32(0));
                   
                   classID = sqlite_reader.GetInt32(0);
                    MessageBox.Show(classID.ToString());
                    break;
                }

                dbConnection.Close();
            }
            if(classID > -1)
            {
                classModel.set_class_id(classID);
                
            }
            else
            {
                return null;
            }
            
            
            
            return classModel;
        }

        public int selectGetClassID(ClassModel classModel)
        {

            int classID = -1;

            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                String statement = "SELECT class_id FROM class WHERE" +
                    " subject='" + classModel.get_subject() +
                    "'and date='" + classModel.get_date() +
                    "'and time='" + classModel.get_time() +
                    "'and teacher_name='" + classModel.get_teacher_name() +
                    "'and class_type='" + classModel.get_class_type() +
                    "'and class_year='" + classModel.get_class_year() +
                    "'"

                    ;
                SQLiteCommand sqlite_command = new SQLiteCommand(statement, dbConnection);
                SQLiteDataReader sqlite_reader = sqlite_command.ExecuteReader();

                while (sqlite_reader.Read())
                {

                    //teacherModel.set_teacher_id(sqlite_reader.GetInt32(0));

                    classID = sqlite_reader.GetInt32(0);
                    MessageBox.Show(classID.ToString());
                    break;
                }

                dbConnection.Close();
            }
            if (classID > -1)
            {
                classModel.set_class_id(classID);

            }
            else
            {
                return -1;
            }



            return classID;
        }

        public void removeClass(String class_id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM class WHERE class_id='" + class_id + "'");
                cnn.Close();
            }
        }
    }


}
