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
    public class TeacherData
    {
        public List<TeacherModel> LoadTeacher()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TeacherModel>("select * from teacher", new DynamicParameters());
                cnn.Close();
                return output.ToList();

            }
        }

        public void saveTeacher(TeacherModel teacherModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Insert into teacher (teacher_name, sex) values ('" + teacherModel.get_teacher_name()+"','"+teacherModel.get_teacher_sex()+"');");
                cnn.Close();
            }
        }

        private string LoadConnectionString(String id = "Default")
        {
            //Compare this value with the id value of the ADDED APP.CONFIG value
                return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public void showData()
        {
            using (IDbConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                using (IDbCommand dbCmd = dbConnection.CreateCommand())
                {
                    string sqlQuery = "SELECT * FROM teacher";
                    dbCmd.CommandText = sqlQuery;
                    using (IDataReader reader = dbCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show(reader["name"] + " " + reader["sex"]);
                        }
                        dbConnection.Close();
                    }
                }
                dbConnection.Close();
            }
        }

        public void load_teacher_list( DataGridView dataGridView)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteDataAdapter data_adapter = new SQLiteDataAdapter("SELECT teacher_name AS ' Teacher ' FROM teacher", dbConnection);
                DataSet ds = new System.Data.DataSet();

                data_adapter.Fill(ds, "Info");
                dataGridView.DataSource = ds.Tables[0];
                dbConnection.Close();
            }
        }

        public List<TeacherModel> load_teacher_list()
        {
            TeacherModel teacherModel ;

            List<TeacherModel> teacherModels = new List<TeacherModel>();

            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                String statement = "SELECT teacher_name AS 'Teacher-Name', sex AS 'Sex' FROM teacher";
                SQLiteCommand sqlite_command = new SQLiteCommand(statement, dbConnection);
                SQLiteDataReader sqlite_reader = sqlite_command.ExecuteReader();
              
                while(sqlite_reader.Read())
                {
                    teacherModel = new TeacherModel();
                    //teacherModel.set_teacher_id(sqlite_reader.GetInt32(0));
                    teacherModel.set_teacher_name(sqlite_reader.GetString(0));
                    teacherModel.set_teacher_sex(sqlite_reader.GetString(1));
                    teacherModels.Add(teacherModel);
                }
                dbConnection.Close();
            }
            return teacherModels;
        }

        public void removeTeacher(String teacher_name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM teacher WHERE teacher_name='"+teacher_name+"'");
                cnn.Close();
            }
        }

    }
}
