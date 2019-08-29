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
    public partial class ViewAttendance : Form
    {

        Dashboard parent_dashboard;
        ClassData classData;
        StudentAttendanceData student_attendance_data;
        String class_id ="";
        String date_selected ="";
        public ViewAttendance()
        {
            InitializeComponent();
            classData = new ClassData();
            student_attendance_data = new StudentAttendanceData();
            //student_attendance_data.load_student_list(DataGridView_StudentAttendanceData);
            //select_raw_datagridview();
            fill_year_comboBox_select_class_ViewAttendance_SelectedIndexChanged(classData.load_class_list());

            setEmptyDateTime();
         
        }

        private void button_back_view_attendance_Click(object sender, EventArgs e)
        {
            this.Close();
            parent_dashboard.parentButtonActivation(true);


        }
        public void setParentForm(Dashboard parent_dashboard)
        {
            this.parent_dashboard = parent_dashboard;
        }//DONE

        private void button_search_viewAttendance_Click(object sender, EventArgs e)
        {
            string student_id = textBox_student_id_ViewAttendance.Text;
            string student_name = textBox_student_name_viewAteendance.Text;
            string class_date = "";
            string class_type = "";

            if(student_id.Length !=0 && student_name.Length==0 && class_date.Length == 0 && class_type.Length == 0)
            {
                student_attendance_data.load_student_list_from_student_id(DataGridView_StudentAttendanceData, student_id);
            }
            else if (student_id.Length != 0 && student_name.Length != 0 && class_date.Length == 0 && class_type.Length == 0)
            {
                student_attendance_data.load_student_list_from_student_id_and_student_name(DataGridView_StudentAttendanceData, student_id, student_name);
            }

            else if (student_id.Length == 0 && student_name.Length != 0 && class_date.Length == 0 && class_type.Length == 0)
            {
                student_attendance_data.load_student_list_from_and_student_name(DataGridView_StudentAttendanceData, student_name);
            }

            textBox_student_id_ViewAttendance.Text = null;
            textBox_student_name_viewAteendance.Text = null;
            label_count_value_ViewAttendance.Text = (this.DataGridView_StudentAttendanceData.Rows.Count - 1).ToString();
            select_raw_datagridview();
        }

        private void select_raw_datagridview()
        {
            int raw_index = DataGridView_StudentAttendanceData.Rows.Count - 2;
            DataGridView_StudentAttendanceData.Focus();
            DataGridView_StudentAttendanceData.CurrentCell = DataGridView_StudentAttendanceData[0, raw_index];
            DataGridView_StudentAttendanceData.Rows[raw_index].Selected = true;
        }

        private void button_filterClass_viewAttedance_Click(object sender, EventArgs e)
        {
            try
            {
                if (class_id != "" && date_selected != "")
                {
                    student_attendance_data.load_student_list_from_class_id_and_date_selected(DataGridView_StudentAttendanceData, class_id, date_selected);
                }
                else if (class_id == "" && date_selected != "")
                {
                    student_attendance_data.load_student_list_from_date_selected(DataGridView_StudentAttendanceData, date_selected);
                }
                else if (class_id != "" && date_selected == "")
                {
                    student_attendance_data.load_student_list_from_class_id(DataGridView_StudentAttendanceData, class_id);

                }

                class_id = "";
                date_selected = "";
                setEmptyDateTime();
                comboBox_class_view_attendance.Text = null;
                label_count_value_ViewAttendance.Text = (this.DataGridView_StudentAttendanceData.Rows.Count - 1).ToString();
                select_raw_datagridview();
            }
            catch(Exception e1)
            {

            }
           
        }

        private void fill_year_comboBox_select_class_ViewAttendance_SelectedIndexChanged(List<ClassModel> classModels)
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

                    comboBox_class_view_attendance.Items.Add(class_selecting_string);
                    class_selecting_string = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox_class_view_attendance_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] class_data = comboBox_class_view_attendance.Text.Trim().Split(null);

            class_id = class_data[0];
        }

        private void dateTimePicker_date_viewAttendance_ValueChanged(object sender, EventArgs e)
        {
           // dateTimePicker_date_viewAttendance.CustomFormat. = "dd-MM-yyyy";
            dateTimePicker_date_viewAttendance.Format = DateTimePickerFormat.Long;
            date_selected = dateTimePicker_date_viewAttendance.Value.ToString("yyyy-MM-dd");
        }

        private void setEmptyDateTime()
        {
            dateTimePicker_date_viewAttendance.CustomFormat = " ";
            dateTimePicker_date_viewAttendance.Format = DateTimePickerFormat.Custom;
            //dateTimePicker_date_viewAttendance.Text = "";
        }
    }
}
