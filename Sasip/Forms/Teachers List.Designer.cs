namespace Sasip
{
    partial class Teachers_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_teachersList = new System.Windows.Forms.GroupBox();
            this.dataGridView_teacher_list = new System.Windows.Forms.DataGridView();
            this.button_close_teacher_list = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_ViewTeachersList_Heading = new System.Windows.Forms.Label();
            this.button_delete_techer_TeachersList = new System.Windows.Forms.Button();
            this.groupBox_teachersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teacher_list)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_teachersList
            // 
            this.groupBox_teachersList.Controls.Add(this.dataGridView_teacher_list);
            this.groupBox_teachersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_teachersList.Location = new System.Drawing.Point(15, 54);
            this.groupBox_teachersList.Name = "groupBox_teachersList";
            this.groupBox_teachersList.Size = new System.Drawing.Size(724, 394);
            this.groupBox_teachersList.TabIndex = 0;
            this.groupBox_teachersList.TabStop = false;
            this.groupBox_teachersList.Text = "Teachers List";
            // 
            // dataGridView_teacher_list
            // 
            this.dataGridView_teacher_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_teacher_list.Location = new System.Drawing.Point(15, 26);
            this.dataGridView_teacher_list.Name = "dataGridView_teacher_list";
            this.dataGridView_teacher_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_teacher_list.Size = new System.Drawing.Size(693, 353);
            this.dataGridView_teacher_list.TabIndex = 0;
            this.dataGridView_teacher_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_teacher_list_CellClick);
            // 
            // button_close_teacher_list
            // 
            this.button_close_teacher_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close_teacher_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close_teacher_list.Location = new System.Drawing.Point(7, 3);
            this.button_close_teacher_list.Name = "button_close_teacher_list";
            this.button_close_teacher_list.Size = new System.Drawing.Size(75, 28);
            this.button_close_teacher_list.TabIndex = 1;
            this.button_close_teacher_list.Text = "Back";
            this.button_close_teacher_list.UseVisualStyleBackColor = true;
            this.button_close_teacher_list.Click += new System.EventHandler(this.button_close_teacher_list_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button_close_teacher_list);
            this.panel1.Controls.Add(this.label_ViewTeachersList_Heading);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 34);
            this.panel1.TabIndex = 6;
            // 
            // label_ViewTeachersList_Heading
            // 
            this.label_ViewTeachersList_Heading.AutoSize = true;
            this.label_ViewTeachersList_Heading.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_ViewTeachersList_Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ViewTeachersList_Heading.Location = new System.Drawing.Point(305, 8);
            this.label_ViewTeachersList_Heading.Name = "label_ViewTeachersList_Heading";
            this.label_ViewTeachersList_Heading.Size = new System.Drawing.Size(156, 24);
            this.label_ViewTeachersList_Heading.TabIndex = 5;
            this.label_ViewTeachersList_Heading.Text = "TEACHERS LIST";
            // 
            // button_delete_techer_TeachersList
            // 
            this.button_delete_techer_TeachersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete_techer_TeachersList.Location = new System.Drawing.Point(570, 475);
            this.button_delete_techer_TeachersList.Name = "button_delete_techer_TeachersList";
            this.button_delete_techer_TeachersList.Size = new System.Drawing.Size(153, 28);
            this.button_delete_techer_TeachersList.TabIndex = 7;
            this.button_delete_techer_TeachersList.Text = "Remove Selected Teacher";
            this.button_delete_techer_TeachersList.UseVisualStyleBackColor = true;
            this.button_delete_techer_TeachersList.Click += new System.EventHandler(this.button_delete_techer_TeachersList_Click);
            // 
            // Teachers_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 536);
            this.Controls.Add(this.button_delete_techer_TeachersList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_teachersList);
            this.Name = "Teachers_List";
            this.Text = "Teachers_List";
            this.groupBox_teachersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teacher_list)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_teachersList;
        private System.Windows.Forms.DataGridView dataGridView_teacher_list;
        private System.Windows.Forms.Button button_close_teacher_list;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_ViewTeachersList_Heading;
        private System.Windows.Forms.Button button_delete_techer_TeachersList;
    }
}