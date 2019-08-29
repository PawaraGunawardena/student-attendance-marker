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
   
    public partial class Teachers_List : Form
    {
        Dashboard parent_dashboard;

        TeacherData teacher_data;
        int current_cell_row_index;

        public Teachers_List()
        {
            InitializeComponent();
            teacher_data = new TeacherData();
            //teacher_data.showData();
            teacher_data.load_teacher_list(dataGridView_teacher_list);
            select_raw_datagridview();
        }

        public void setParentForm(Dashboard parent_dashboard)
        {
            this.parent_dashboard = parent_dashboard;
        }//DONE

        private void button_close_teacher_list_Click(object sender, EventArgs e)
        {
            this.Close();
            parent_dashboard.parentButtonActivation(true);
        }

        private void select_raw_datagridview()
        {
            try
            {
                int raw_index = dataGridView_teacher_list.Rows.Count - 1;
                dataGridView_teacher_list.Focus();
                dataGridView_teacher_list.CurrentCell = dataGridView_teacher_list[0, raw_index-1];
                dataGridView_teacher_list.Rows[raw_index-1].Selected = true;
                current_cell_row_index = raw_index - 1;
               // MessageBox.Show(current_cell_row_index.ToString());
            }
            catch(Exception e)
            {

            }
        
        }

        private void button_delete_techer_TeachersList_Click(object sender, EventArgs e)
        {
            //String teacher_name = dataGridView_teacher_list.SelectedRows[0].Value.ToString();

            // int x = dataGridView_teacher_list.SelectedRows[0];
            //MessageBox.Show(teacher_name);
            DialogResult result = MessageBox.Show("Do you want to Remove Selected Teacher Details?", "Remove Teacher", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //yes...
                DataGridViewRow selectedrow = dataGridView_teacher_list.Rows[current_cell_row_index];
                String teacher_name = selectedrow.Cells[0].Value.ToString();
                //MessageBox.Show(selectedrow.Cells[0].Value.ToString());
                teacher_data.removeTeacher(teacher_name);
                teacher_data.load_teacher_list(dataGridView_teacher_list);

                select_raw_datagridview();
            }
            else if (result == DialogResult.No)
            {
                //no...
                teacher_data.load_teacher_list(dataGridView_teacher_list);
                select_raw_datagridview();
            }
         



        }

        private void dataGridView_teacher_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            current_cell_row_index = e.RowIndex;
            //MessageBox.Show(current_cell_row_index.ToString());
        }
    }
}
