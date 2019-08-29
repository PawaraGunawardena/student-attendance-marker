using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomLibrary;
using CustomLibrary.Data.ModelData;


namespace Sasip
{
    public partial class MarkAttendance : Form
    {
        Dashboard parent_dashboard;
        ClassData classData;
        ClassModel classModel ;
        int class_id;
        StudentAttendanceData student_attendance_data;
        List<String> student_id_list_inday = new List<string>();
        List<String> student_name_list_inday = new List<string>();
        string previous_class_date;

        String date_format = "yyyy-MM-dd";
        String time_format = "HH:mm:ss.ffff";

        int id_value_length_standard = 8;
        public MarkAttendance()
        {
            InitializeComponent();
            classData = new ClassData();
            classModel = new ClassModel();
            fill_year_comboBox_select_class_MarkAttendance_SelectedIndexChanged(classData.load_class_list());
            this.ActiveControl = textBox_indexNo_markAttendance;
            textBox_indexNo_markAttendance.Focus();
            textBox_indexNo_markAttendance.Select();
            validatingMarkingComponents(true);
            student_attendance_data = new StudentAttendanceData();
           // student_id_list_inday = student_attendance_data.get_student_list(class_id.ToString(), DateTime.Today.ToString("dd-MM-yyyy"));
        }

        private void button_back_mark_attendance_Click(object sender, EventArgs e)
        {
            this.Close();
            parent_dashboard.parentButtonActivation(true);
        }

        public void setParentForm(Dashboard parent_dashboard)
        {
            this.parent_dashboard = parent_dashboard;
        }//DONE

        private void MarkAttendance_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox_indexNo_markAttendance;
            textBox_indexNo_markAttendance.Focus();
            textBox_indexNo_markAttendance.Select();
        }
 
        private void textValueChanged(object sender, EventArgs e)
        {
            String id_value = textBox_indexNo_markAttendance.Text;
            if (id_value.Length != id_value_length_standard)
            {

            }
            else
            {
                if(!student_id_list_inday.Contains(id_value.ToString()))
                {
                    StudentAttendanceData student_attendance_data = new StudentAttendanceData();
                    StudentAttendanceModel student_attendance_model = new StudentAttendanceModel();
                    student_attendance_model.set_student_id(id_value);
                    student_attendance_model.set_student_name(null);
                    student_attendance_model.set_entered_date(DateTime.Today.ToString(date_format));
                    student_attendance_model.set_entered_time(DateTime.Now.ToString(time_format));
                    student_attendance_model.set_class_id(class_id.ToString());

                    student_attendance_data.saveStdentAttendance(student_attendance_model);
                    textBox_indexNo_markAttendance.Text = "";
                    student_attendance_data.load_student_list_inday(dataGridView_attendence_MarkAttendance, class_id, DateTime.Today.ToString(date_format));

                    label_student_count_value_markAttendance.Text = (this.dataGridView_attendence_MarkAttendance.Rows.Count - 1).ToString();
                    select_raw_datagridview();
                    student_id_list_inday.Add(id_value);
                    textBox_indexNo_markAttendance.Focus();
                    textBox_indexNo_markAttendance.Select();
                    check_last_week_attendance(id_value);
                }
                else{
                    MessageBox.Show("ID Value "+ textBox_indexNo_markAttendance.Text+" has already entered");
                    textBox_indexNo_markAttendance.Text = "";


                }
            }

        }

        public void validatingMarkingComponents(bool activation)
        {
            textBox_indexNo_markAttendance.Enabled = activation;
            dataGridView_attendence_MarkAttendance.Enabled = activation;
        }

        private void button_forgetID_Submit_Click(object sender, EventArgs e)
        {
            string id_value = textBox_student_index_forgetID_MarkAttendance.Text.ToString();
            string student_name = textBox_student_name_forgetID_MarkAttendance.Text;

            if (id_value.Length > 0 && id_value.Length < id_value_length_standard)
            {
                MessageBox.Show("ID value " + id_value + " has " + id_value.Length + " characters. Invalid ID number.");
            }
            else if (id_value.Length == id_value_length_standard && student_name.Length != 0)
            {
                if (!student_id_list_inday.Contains(id_value.ToString()) && !student_name_list_inday.Contains(student_name.ToString()))
                {
                    //StudentAttendanceData student_attendance_data = new StudentAttendanceData();
                    StudentAttendanceModel student_attendance_model = new StudentAttendanceModel();

                    student_attendance_model.set_student_id(id_value);
                    student_attendance_model.set_student_name(student_name);
                    student_attendance_model.set_entered_date(DateTime.Today.ToString(date_format));
                    student_attendance_model.set_entered_time(DateTime.Now.ToString(time_format));
                    student_attendance_model.set_class_id(class_id.ToString());

                    student_attendance_data.saveStdentAttendance(student_attendance_model);

                    textBox_student_index_forgetID_MarkAttendance.Text = "";
                    textBox_student_name_forgetID_MarkAttendance.Text = "";

                    student_attendance_data.load_student_list_inday(dataGridView_attendence_MarkAttendance, class_id, DateTime.Today.ToString(date_format));
                    label_student_count_value_markAttendance.Text = (this.dataGridView_attendence_MarkAttendance.Rows.Count - 1).ToString();
                    select_raw_datagridview();
                    student_id_list_inday.Add(id_value);
                    student_name_list_inday.Add(student_name);
                    textBox_indexNo_markAttendance.Focus();
                    textBox_indexNo_markAttendance.Select();
                }
                else
                {
                    MessageBox.Show("ID Value " + id_value + " or Name " + student_name + " or both have already entered");
                    textBox_indexNo_markAttendance.Text = "";
                    textBox_student_index_forgetID_MarkAttendance.Text ="";
                    textBox_student_name_forgetID_MarkAttendance.Text ="";
                    textBox_indexNo_markAttendance.Focus();
                    textBox_indexNo_markAttendance.Select();
                }
            }
            else if (id_value.Length == 0 && student_name.Length != 0)
            {
                if (!student_name_list_inday.Contains(student_name.ToString()))
                {
                    //StudentAttendanceData student_attendance_data = new StudentAttendanceData();
                    StudentAttendanceModel student_attendance_model = new StudentAttendanceModel();

                    student_attendance_model.set_student_id(id_value);
                    student_attendance_model.set_student_name(student_name);
                    student_attendance_model.set_entered_date(DateTime.Today.ToString(date_format));
                    student_attendance_model.set_entered_time(DateTime.Now.ToString(time_format));
                    student_attendance_model.set_class_id(class_id.ToString());

                    student_attendance_data.saveStdentAttendance(student_attendance_model);

                    textBox_student_index_forgetID_MarkAttendance.Text = "";
                    textBox_student_name_forgetID_MarkAttendance.Text = "";

                    student_attendance_data.load_student_list_inday(dataGridView_attendence_MarkAttendance, class_id, DateTime.Today.ToString(time_format));
                    label_student_count_value_markAttendance.Text = (this.dataGridView_attendence_MarkAttendance.Rows.Count - 1).ToString();
                    select_raw_datagridview();
                    //student_id_list_inday.Add(id_value);
                    student_name_list_inday.Add(student_name);
                    textBox_indexNo_markAttendance.Focus();
                    textBox_indexNo_markAttendance.Select();
                }
                else
                {
                    MessageBox.Show("Name " + student_name + " has already entered");
                    textBox_indexNo_markAttendance.Text = "";
                    textBox_student_index_forgetID_MarkAttendance.Text = "";
                    textBox_student_name_forgetID_MarkAttendance.Text = "";
                    textBox_indexNo_markAttendance.Focus();
                    textBox_indexNo_markAttendance.Select();
                }
            }
            else if (id_value.Length == id_value_length_standard && student_name.Length == 0)
            {
                if (!student_id_list_inday.Contains(id_value.ToString()) && !student_name_list_inday.Contains(student_name.ToString()))
                {
                    //StudentAttendanceData student_attendance_data = new StudentAttendanceData();
                    StudentAttendanceModel student_attendance_model = new StudentAttendanceModel();

                    student_attendance_model.set_student_id(id_value);
                    student_attendance_model.set_student_name(student_name);
                    student_attendance_model.set_entered_date(DateTime.Today.ToString(date_format));
                    student_attendance_model.set_entered_time(DateTime.Now.ToString(time_format));
                    student_attendance_model.set_class_id(class_id.ToString());

                    student_attendance_data.saveStdentAttendance(student_attendance_model);

                    textBox_student_index_forgetID_MarkAttendance.Text = "";
                    textBox_student_name_forgetID_MarkAttendance.Text = "";

                    student_attendance_data.load_student_list_inday(dataGridView_attendence_MarkAttendance, class_id, DateTime.Today.ToString(date_format));
                    label_student_count_value_markAttendance.Text = (this.dataGridView_attendence_MarkAttendance.Rows.Count - 1).ToString();
                    select_raw_datagridview();
                    student_id_list_inday.Add(id_value);
                    //student_name_list_inday.Add(student_name);
                    textBox_indexNo_markAttendance.Focus();
                    textBox_indexNo_markAttendance.Select();
                }
                else
                {
                    MessageBox.Show("ID Value " + id_value + " has already entered");
                    textBox_indexNo_markAttendance.Text = "";
                    textBox_student_index_forgetID_MarkAttendance.Text = "";
                    textBox_student_name_forgetID_MarkAttendance.Text = "";
                    textBox_indexNo_markAttendance.Focus();
                    textBox_indexNo_markAttendance.Select();

                }
            }


        }

        private void comboBox_select_class_MarkAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {
           try
            {
                String[] class_data = comboBox_select_class_MarkAttendance.Text.Trim().Split(null);

                class_id = Int16.Parse(class_data[0]);

                classModel.set_class_id(class_id);
                classModel.set_subject(class_data[1]);
                classModel.set_date(class_data[2]);
                classModel.set_time(class_data[3]);
                classModel.set_teacher_name(class_data[4]);
                classModel.set_class_type(class_data[5]);
                classModel.set_class_year(class_data[6]);
                validatingMarkingComponents(true);
                student_attendance_data.load_student_list_inday(dataGridView_attendence_MarkAttendance, class_id, DateTime.Today.ToString(date_format));
                label_student_count_value_markAttendance.Text= (this.dataGridView_attendence_MarkAttendance.Rows.Count -1 ).ToString() ;
                select_raw_datagridview();

                textBox_indexNo_markAttendance.Focus();
                textBox_indexNo_markAttendance.Select();
                student_id_list_inday = student_attendance_data.get_student_list(class_id.ToString(), DateTime.Today.ToString(date_format));

                /* for(int i=0; i<student_id_list_inday.Count;i++)
                 {
                     MessageBox.Show(student_id_list_inday[i]);
                 }*/
                previous_class_date = student_attendance_data.get_previous_class_date(class_id, DateTime.Today.ToString(date_format));
                label_lastweekdate_MarkAttendance.Text = previous_class_date;
            }
            catch(Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void fill_year_comboBox_select_class_MarkAttendance_SelectedIndexChanged(List<ClassModel> classModels)
        {
            string class_selecting_string = "";

            try
            {
                for (int i = 0; i < classModels.Count; i++)
                {
                    class_selecting_string = class_selecting_string + " " 
                                            + classModels[i].get_class_id() + " "
                                            + classModels[i].get_subject() + " "
                                            + classModels[i].get_date() + " "
                                            + classModels[i].get_time() + " "
                                            + classModels[i].get_teacher_name() + " "
                                            + classModels[i].get_class_type() + " "
                                            + classModels[i].get_class_year() + " "
                        ;

                    
                    comboBox_select_class_MarkAttendance.Items.Add(class_selecting_string);

                    class_selecting_string = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void select_raw_datagridview()
        {
            try
            {
                int raw_index = dataGridView_attendence_MarkAttendance.Rows.Count - 1;
                dataGridView_attendence_MarkAttendance.Focus();
                dataGridView_attendence_MarkAttendance.CurrentCell = dataGridView_attendence_MarkAttendance[0, raw_index - 1];
                dataGridView_attendence_MarkAttendance.Rows[raw_index - 1].Selected = true;

            }
            catch (Exception e)
            {

            }
        }

        private void check_last_week_attendance(String student_id)
        {
            if(student_attendance_data.get_student_attendance_by_studentID(class_id, student_id, previous_class_date ))
            {
                label_student_lastweekAttendance_value_markAttendance.Text = "ATTENDED";
                label_student_lastweekAttendance_value_markAttendance.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label_student_lastweekAttendance_value_markAttendance.Text = "NOT ATTENDED";
                label_student_lastweekAttendance_value_markAttendance.ForeColor = System.Drawing.Color.Red;
            }
         
        }
    }
}
