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
    public partial class ViewClasses : Form
    {

        Dashboard parent_dashboard;

        ClassData class_data;
        int current_cell_row_index;

        public ViewClasses()
        {
            InitializeComponent();
            class_data = new ClassData();
            //teacher_data.showData();
            class_data.load_class_list(dataGridView_class_lists_viewClasses);
            select_raw_datagridview();
        }

        private void button_back_view_classes_Click(object sender, EventArgs e)
        {
            this.Close();
            parent_dashboard.parentButtonActivation(true);
        }

        public void setParentForm(Dashboard parent_dashboard)
        {
            this.parent_dashboard = parent_dashboard;
        }//DONE

        private void select_raw_datagridview()
        {
            try
            {
                int raw_index = dataGridView_class_lists_viewClasses.Rows.Count - 2;
                dataGridView_class_lists_viewClasses.Focus();
                dataGridView_class_lists_viewClasses.CurrentCell = dataGridView_class_lists_viewClasses[0, raw_index];
                dataGridView_class_lists_viewClasses.Rows[raw_index].Selected = true;
                current_cell_row_index = raw_index;
            }
            catch(Exception e)
            {

            }
    
        }

        private void button_delete_class_ViewClass_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult result = MessageBox.Show("Do you want to Remove Selected Class Details?", "Remove Class", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //yes...
                    DataGridViewRow selectedrow = dataGridView_class_lists_viewClasses.Rows[current_cell_row_index];
                    String class_id = selectedrow.Cells[6].Value.ToString();
                    
                    class_data.removeClass(class_id);
                    class_data.load_class_list(dataGridView_class_lists_viewClasses);
                    select_raw_datagridview();
                }
                else if (result == DialogResult.No)
                {
                    //no...
                    class_data.load_class_list(dataGridView_class_lists_viewClasses);
                    select_raw_datagridview();
                }
            }
            catch(Exception e1)
            {

            }
        }

        private void dataGridView_class_lists_viewClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            current_cell_row_index = e.RowIndex;
        }
    }
}
