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
    public partial class AddTeacher : Form
    {

        String teacher_name;
        String teacher_sex;

        TeacherModel teacherModel;
        TeacherData teacherData;

        private Dashboard parent_dashboard;

        public AddTeacher()
        {
            InitializeComponent();

            textBox_add_teacher_name.Focus();
            textBox_add_teacher_name.Select();
        }

        private void button_add_teacher_clear_Click(object sender, EventArgs e)
        {
            textBox_add_teacher_name.Text = "";
            comboBoxadd_teacher_sex = null;

            textBox_add_teacher_name.Focus();
            textBox_add_teacher_name.Select();
        }

        private void button_add_teacher_submit_Click(object sender, EventArgs e)
        {
            

            if(textBox_add_teacher_name.Text == null || comboBoxadd_teacher_sex.Text == null)
            {
                
            }
            else
            {
                teacher_name = textBox_add_teacher_name.Text;
                teacher_sex = comboBoxadd_teacher_sex.Text;

                teacherModel = new TeacherModel();
                teacherData = new TeacherData();


                teacherModel.set_teacher_name(teacher_name);
                teacherModel.set_teacher_sex(teacher_sex);
                teacherData.saveTeacher(teacherModel);
                refresh_add_teacher_page();
                //this.Close();
                //rent_dashboard.parentButtonActivation(true);

                textBox_add_teacher_name.Focus();
                textBox_add_teacher_name.Select();
            }
        }

        public void setParentForm(Dashboard parent_dashboard)
        {
            this.parent_dashboard = parent_dashboard;
        }//DONE

        private void button_cancel_add_teacher_Click(object sender, EventArgs e)
        {
            this.Close();
            parent_dashboard.parentButtonActivation(true);
        }

        private void refresh_add_teacher_page()
        {
            textBox_add_teacher_name.Text = null;
            comboBoxadd_teacher_sex.Text = null;
        }
    }
}
