using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sasip.Forms
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            create_new();
            create_new_2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            create_new();
        }

        public void create_new()
        {

            AddClass testForm = new AddClass();


            TabPage tabPage = new TabPage { Text = testForm.Text };


            tabPage.BorderStyle = BorderStyle.Fixed3D;
            //tabPage2.BorderStyle = BorderStyle.Fixed3D;
            // IntPtr h = this.tabFormPage.Handle;
            tabControl.TabPages.Add(tabPage);


            testForm.TopLevel = false;
            testForm.Parent = tabPage;
            testForm.Show();

        }

        public void create_new_2()
        {
            AddTeacher addTeacher = new AddTeacher();

            TabPage tabPage2 = new TabPage { Text = addTeacher.Text };
            tabControl.TabPages.Add(tabPage2);

            addTeacher.TopLevel = false;
            addTeacher.Parent = tabPage2;
            addTeacher.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
