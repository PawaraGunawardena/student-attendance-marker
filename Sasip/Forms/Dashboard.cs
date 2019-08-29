using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sasip
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
           // this.WindowState = FormWindowState.Maximized;

            this.IsMdiContainer = true;
            Image img = Image.FromFile("sasip_icon.jpg");
            pictureBox_icon.Image = img;
            // this.TransparencyKey = BackColor;
            // panel_color();

            this.ActiveControl = btn_teachers;
            btn_teachers.Focus();
            btn_teachers.Select();
        }

      

        private void btn_classes_Click(object sender, EventArgs e)
        {
            parentButtonActivation(false);
            AddClass addClass = new AddClass();
            addClass.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(addClass);
            addClass.Location = new Point((splitContainer1.Panel2.Width - addClass.Width) / 2, (splitContainer1.Panel2.Height - addClass.Height) / 2);
            addClass.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            addClass.Show();
            // markAttendance.buttonDeactivate();
            addClass.setParentForm(this);
        }

        public void parentButtonActivation(bool activation)
        {
            Button btn_attendance = this.btn_attendance;
            Button btn_classes = this.btn_classes;
            Button btn_teachers = this.btn_teachers;
            Button btn_all_teachers = this.button_available_teachers;

            //  PictureBox pictureBox = this.pictureBoxName;

            btn_attendance.Enabled = activation;
            btn_classes.Enabled = activation;
            btn_teachers.Enabled = activation;
            btn_all_teachers.Enabled = activation;
            //pictureBoxName.Visible = activation;
            button_attendance_list.Enabled = activation;
            button_class_list_dashboard.Enabled = activation;
        }

        public void buttonDeactivate()
        {
            //Button availabilityButton = this.btnShowAvailability;
            //Button refreshButton = this.btnRefresh;

           // refreshButton.Enabled = false;
           // availabilityButton.Enabled = false;
           // moreDetailActivation(false);
        }

        private void btn_teachers_Click(object sender, EventArgs e)
        {
            parentButtonActivation(false);
            AddTeacher addTeacher = new AddTeacher();
            addTeacher.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(addTeacher);
            addTeacher.Location = new Point((splitContainer1.Panel2.Width - addTeacher.Width) / 2, (splitContainer1.Panel2.Height - addTeacher.Height) / 2);
            addTeacher.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            addTeacher.Show();
            // markAttendance.buttonDeactivate();
            addTeacher.setParentForm(this);
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            parentButtonActivation(false);
            MarkAttendance markAttendance = new MarkAttendance();
            markAttendance.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(markAttendance);
            markAttendance.Location = new Point((splitContainer1.Panel2.Width - markAttendance.Width) / 2, (splitContainer1.Panel2.Height - markAttendance.Height) / 2);
            markAttendance.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            markAttendance.Show();
            // markAttendance.buttonDeactivate();
            markAttendance.setParentForm(this);
        }

        private void button_available_teachers_Click(object sender, EventArgs e)
        {
            parentButtonActivation(false);
            Teachers_List teachers_list = new Teachers_List();
            teachers_list.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(teachers_list);
            teachers_list.Location = new Point((splitContainer1.Panel2.Width - teachers_list.Width) / 2, (splitContainer1.Panel2.Height - teachers_list.Height) / 2);
            teachers_list.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            teachers_list.Show();
            // markAttendance.buttonDeactivate();
            teachers_list.setParentForm(this);
        }

        private void button_class_list_dashboard_Click(object sender, EventArgs e)
        {
            parentButtonActivation(false);
            ViewClasses classes_list = new ViewClasses();
            classes_list.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(classes_list);
            classes_list.Location = new Point((splitContainer1.Panel2.Width - classes_list.Width) / 2, (splitContainer1.Panel2.Height - classes_list.Height) / 2);
            classes_list.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            classes_list.Show();
            // markAttendance.buttonDeactivate();
            classes_list.setParentForm(this);
        }

        private void button_attendance_list_Click(object sender, EventArgs e)
        {
            parentButtonActivation(false);
            ViewAttendance view_attendance_list = new ViewAttendance();
            view_attendance_list.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(view_attendance_list);
            view_attendance_list.Location = new Point((splitContainer1.Panel2.Width - view_attendance_list.Width) / 2, (splitContainer1.Panel2.Height - view_attendance_list.Height) / 2);
            view_attendance_list.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            view_attendance_list.Show();
            // markAttendance.buttonDeactivate();
            view_attendance_list.setParentForm(this);
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            parentButtonActivation(false);
            Forms.TestForm view_attendance_list = new Forms.TestForm();
            view_attendance_list.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(view_attendance_list);
            view_attendance_list.Location = new Point((splitContainer1.Panel2.Width - view_attendance_list.Width) / 2, (splitContainer1.Panel2.Height - view_attendance_list.Height) / 2);
            view_attendance_list.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            view_attendance_list.Show();
            // markAttendance.buttonDeactivate();
            //view_attendance_list.setParentForm(this);
        }

        private void dashboard_load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
        }

        private void panel_color()
        {
            splitContainer1.Panel2.BackColor = Color.FromArgb(20, 0, 0, 0);
            // int x   = 230;
            //splitContainer1.Panel2.BackColor = Color.FromArgb(0, Color.Blue);
        }
    }
}
