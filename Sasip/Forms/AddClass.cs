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
    public partial class AddClass : Form
    {
        private Dashboard parent_dashboard;

        ClassModel classModel;
        String class_time;
        String class_type;
        ClassData classData;
        TeacherData teacher_data;
        public AddClass()
        {
            InitializeComponent();

            teacher_data = new TeacherData();

            fill_teachername_comboBox(teacher_data.load_teacher_list());

            textBox_subject_addclass.Focus();
            textBox_subject_addclass.Select();
        }

        public void setParentForm(Dashboard parent_dashboard)
        {
            this.parent_dashboard = parent_dashboard;
        }//DONE

        private void button_back_addclass_Click(object sender, EventArgs e)
        {
            this.Close();
            parent_dashboard.parentButtonActivation(true);
        }

        private void button_submit_addclass_Click(object sender, EventArgs e)
        {
            if (radioButton_evening_addclass.Checked)
            {
                class_time = "Evening";
            }
            if (radioButton_Time_Morning_addclass.Checked)
            {
                class_time = "Morning";
            }
            if (radioButton_theory_addclass.Checked)
            {
                class_type = "Group";
            }
            if (radioButton_mass_addclass.Checked)
            {
                class_type = "Mass";
            }
            if (radioButton_revision_addclass.Checked)
            {
                class_type = "Revision";
            }
            classModel = new ClassModel();
            classModel.set_subject(textBox_subject_addclass.Text);
            classModel.set_date(comboBox_date_addclass.Text);
            classModel.set_time(class_time);
            classModel.set_class_type(class_type);
            classModel.set_class_year(dateTimePicker_addclass.Text);
            classModel.set_teacher_name(textBox_teachername_addclass.Text);

             classData = new CustomLibrary.Data.ModelData.ClassData();
            classData.saveClass(classModel);
            //this.Close();
            refresh_add_class_page();
            //rent_dashboard.parentButtonActivation(true);

            textBox_subject_addclass.Focus();
            textBox_subject_addclass.Select();
        }

        private void fill_teachername_comboBox(List<TeacherModel> teacherModels)
        {
          
            try
            {
                for (int i =0; i<teacherModels.Count; i++ )
                {
                    textBox_teachername_addclass.Items.Add(teacherModels[i].get_teacher_name());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refresh_add_class_page()
        {
            textBox_subject_addclass.Text = null;
            textBox_teachername_addclass.Text = null;
            radioButton_mass_addclass.Checked = false;
            radioButton_revision_addclass.Checked = false;
            radioButton_theory_addclass.Checked = false;
            radioButton_Time_Morning_addclass.Checked = false;
            radioButton_evening_addclass.Checked = false;
            comboBox_date_addclass.Text = null;
            dateTimePicker_addclass.Value= DateTime.Today;
        }

    }
}
