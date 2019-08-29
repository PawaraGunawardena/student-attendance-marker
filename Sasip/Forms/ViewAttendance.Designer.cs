namespace Sasip
{
    partial class ViewAttendance
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
            this.groupBox_view_attendance = new System.Windows.Forms.GroupBox();
            this.DataGridView_StudentAttendanceData = new System.Windows.Forms.DataGridView();
            this.groupBox_filter_by = new System.Windows.Forms.GroupBox();
            this.button_search_viewAttendance = new System.Windows.Forms.Button();
            this.textBox_student_id_ViewAttendance = new System.Windows.Forms.TextBox();
            this.label_student_id = new System.Windows.Forms.Label();
            this.textBox_student_name_viewAteendance = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_AttendanceList_Heading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_back_view_attendance = new System.Windows.Forms.Button();
            this.groupBox_class_viewAttendance = new System.Windows.Forms.GroupBox();
            this.comboBox_class_view_attendance = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_date_viewAttendance = new System.Windows.Forms.DateTimePicker();
            this.button_filterClass_viewAttedance = new System.Windows.Forms.Button();
            this.label_class_view_attendance = new System.Windows.Forms.Label();
            this.label_date_view_attendance = new System.Windows.Forms.Label();
            this.label_count_header_AttendanceList = new System.Windows.Forms.Label();
            this.label_count_value_ViewAttendance = new System.Windows.Forms.Label();
            this.groupBox_view_attendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_StudentAttendanceData)).BeginInit();
            this.groupBox_filter_by.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_class_viewAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_view_attendance
            // 
            this.groupBox_view_attendance.Controls.Add(this.DataGridView_StudentAttendanceData);
            this.groupBox_view_attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_view_attendance.Location = new System.Drawing.Point(12, 240);
            this.groupBox_view_attendance.Name = "groupBox_view_attendance";
            this.groupBox_view_attendance.Size = new System.Drawing.Size(730, 284);
            this.groupBox_view_attendance.TabIndex = 0;
            this.groupBox_view_attendance.TabStop = false;
            this.groupBox_view_attendance.Text = "Attendance";
            // 
            // DataGridView_StudentAttendanceData
            // 
            this.DataGridView_StudentAttendanceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_StudentAttendanceData.Location = new System.Drawing.Point(16, 30);
            this.DataGridView_StudentAttendanceData.Name = "DataGridView_StudentAttendanceData";
            this.DataGridView_StudentAttendanceData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_StudentAttendanceData.Size = new System.Drawing.Size(697, 241);
            this.DataGridView_StudentAttendanceData.TabIndex = 0;
            // 
            // groupBox_filter_by
            // 
            this.groupBox_filter_by.Controls.Add(this.button_search_viewAttendance);
            this.groupBox_filter_by.Controls.Add(this.textBox_student_id_ViewAttendance);
            this.groupBox_filter_by.Controls.Add(this.label_student_id);
            this.groupBox_filter_by.Controls.Add(this.textBox_student_name_viewAteendance);
            this.groupBox_filter_by.Controls.Add(this.label_name);
            this.groupBox_filter_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_filter_by.Location = new System.Drawing.Point(11, 42);
            this.groupBox_filter_by.Name = "groupBox_filter_by";
            this.groupBox_filter_by.Size = new System.Drawing.Size(731, 69);
            this.groupBox_filter_by.TabIndex = 2;
            this.groupBox_filter_by.TabStop = false;
            this.groupBox_filter_by.Text = "Filter By Student";
            // 
            // button_search_viewAttendance
            // 
            this.button_search_viewAttendance.Location = new System.Drawing.Point(646, 25);
            this.button_search_viewAttendance.Name = "button_search_viewAttendance";
            this.button_search_viewAttendance.Size = new System.Drawing.Size(75, 28);
            this.button_search_viewAttendance.TabIndex = 3;
            this.button_search_viewAttendance.Text = "Search";
            this.button_search_viewAttendance.UseVisualStyleBackColor = true;
            this.button_search_viewAttendance.Click += new System.EventHandler(this.button_search_viewAttendance_Click);
            // 
            // textBox_student_id_ViewAttendance
            // 
            this.textBox_student_id_ViewAttendance.Location = new System.Drawing.Point(103, 26);
            this.textBox_student_id_ViewAttendance.Name = "textBox_student_id_ViewAttendance";
            this.textBox_student_id_ViewAttendance.Size = new System.Drawing.Size(202, 26);
            this.textBox_student_id_ViewAttendance.TabIndex = 7;
            // 
            // label_student_id
            // 
            this.label_student_id.AutoSize = true;
            this.label_student_id.Location = new System.Drawing.Point(7, 29);
            this.label_student_id.Name = "label_student_id";
            this.label_student_id.Size = new System.Drawing.Size(95, 20);
            this.label_student_id.TabIndex = 6;
            this.label_student_id.Text = "Student ID :";
            // 
            // textBox_student_name_viewAteendance
            // 
            this.textBox_student_name_viewAteendance.Location = new System.Drawing.Point(431, 26);
            this.textBox_student_name_viewAteendance.Name = "textBox_student_name_viewAteendance";
            this.textBox_student_name_viewAteendance.Size = new System.Drawing.Size(203, 26);
            this.textBox_student_name_viewAteendance.TabIndex = 5;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(311, 29);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(120, 20);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Student Name :";
            // 
            // label_AttendanceList_Heading
            // 
            this.label_AttendanceList_Heading.AutoSize = true;
            this.label_AttendanceList_Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AttendanceList_Heading.Location = new System.Drawing.Point(289, 6);
            this.label_AttendanceList_Heading.Name = "label_AttendanceList_Heading";
            this.label_AttendanceList_Heading.Size = new System.Drawing.Size(183, 24);
            this.label_AttendanceList_Heading.TabIndex = 5;
            this.label_AttendanceList_Heading.Text = "ATTENDANCE LIST";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label_AttendanceList_Heading);
            this.panel1.Controls.Add(this.button_back_view_attendance);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 34);
            this.panel1.TabIndex = 6;
            // 
            // button_back_view_attendance
            // 
            this.button_back_view_attendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back_view_attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back_view_attendance.Location = new System.Drawing.Point(7, 4);
            this.button_back_view_attendance.Name = "button_back_view_attendance";
            this.button_back_view_attendance.Size = new System.Drawing.Size(75, 28);
            this.button_back_view_attendance.TabIndex = 1;
            this.button_back_view_attendance.Text = "Back";
            this.button_back_view_attendance.UseVisualStyleBackColor = true;
            this.button_back_view_attendance.Click += new System.EventHandler(this.button_back_view_attendance_Click);
            // 
            // groupBox_class_viewAttendance
            // 
            this.groupBox_class_viewAttendance.Controls.Add(this.comboBox_class_view_attendance);
            this.groupBox_class_viewAttendance.Controls.Add(this.dateTimePicker_date_viewAttendance);
            this.groupBox_class_viewAttendance.Controls.Add(this.button_filterClass_viewAttedance);
            this.groupBox_class_viewAttendance.Controls.Add(this.label_class_view_attendance);
            this.groupBox_class_viewAttendance.Controls.Add(this.label_date_view_attendance);
            this.groupBox_class_viewAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_class_viewAttendance.Location = new System.Drawing.Point(12, 114);
            this.groupBox_class_viewAttendance.Name = "groupBox_class_viewAttendance";
            this.groupBox_class_viewAttendance.Size = new System.Drawing.Size(731, 108);
            this.groupBox_class_viewAttendance.TabIndex = 12;
            this.groupBox_class_viewAttendance.TabStop = false;
            this.groupBox_class_viewAttendance.Text = "Filter By Class";
            // 
            // comboBox_class_view_attendance
            // 
            this.comboBox_class_view_attendance.FormattingEnabled = true;
            this.comboBox_class_view_attendance.Location = new System.Drawing.Point(63, 27);
            this.comboBox_class_view_attendance.Name = "comboBox_class_view_attendance";
            this.comboBox_class_view_attendance.Size = new System.Drawing.Size(455, 28);
            this.comboBox_class_view_attendance.TabIndex = 9;
            this.comboBox_class_view_attendance.SelectedIndexChanged += new System.EventHandler(this.comboBox_class_view_attendance_SelectedIndexChanged);
            // 
            // dateTimePicker_date_viewAttendance
            // 
            this.dateTimePicker_date_viewAttendance.Location = new System.Drawing.Point(63, 69);
            this.dateTimePicker_date_viewAttendance.Name = "dateTimePicker_date_viewAttendance";
            this.dateTimePicker_date_viewAttendance.Size = new System.Drawing.Size(277, 26);
            this.dateTimePicker_date_viewAttendance.TabIndex = 8;
            this.dateTimePicker_date_viewAttendance.ValueChanged += new System.EventHandler(this.dateTimePicker_date_viewAttendance_ValueChanged);
            // 
            // button_filterClass_viewAttedance
            // 
            this.button_filterClass_viewAttedance.Location = new System.Drawing.Point(645, 28);
            this.button_filterClass_viewAttedance.Name = "button_filterClass_viewAttedance";
            this.button_filterClass_viewAttedance.Size = new System.Drawing.Size(75, 28);
            this.button_filterClass_viewAttedance.TabIndex = 3;
            this.button_filterClass_viewAttedance.Text = "Search";
            this.button_filterClass_viewAttedance.UseVisualStyleBackColor = true;
            this.button_filterClass_viewAttedance.Click += new System.EventHandler(this.button_filterClass_viewAttedance_Click);
            // 
            // label_class_view_attendance
            // 
            this.label_class_view_attendance.AutoSize = true;
            this.label_class_view_attendance.Location = new System.Drawing.Point(5, 31);
            this.label_class_view_attendance.Name = "label_class_view_attendance";
            this.label_class_view_attendance.Size = new System.Drawing.Size(56, 20);
            this.label_class_view_attendance.TabIndex = 6;
            this.label_class_view_attendance.Text = "Class :";
            // 
            // label_date_view_attendance
            // 
            this.label_date_view_attendance.AutoSize = true;
            this.label_date_view_attendance.Location = new System.Drawing.Point(9, 72);
            this.label_date_view_attendance.Name = "label_date_view_attendance";
            this.label_date_view_attendance.Size = new System.Drawing.Size(52, 20);
            this.label_date_view_attendance.TabIndex = 4;
            this.label_date_view_attendance.Text = "Date :";
            // 
            // label_count_header_AttendanceList
            // 
            this.label_count_header_AttendanceList.AutoSize = true;
            this.label_count_header_AttendanceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count_header_AttendanceList.Location = new System.Drawing.Point(649, 225);
            this.label_count_header_AttendanceList.Name = "label_count_header_AttendanceList";
            this.label_count_header_AttendanceList.Size = new System.Drawing.Size(56, 20);
            this.label_count_header_AttendanceList.TabIndex = 13;
            this.label_count_header_AttendanceList.Text = "Count:";
            // 
            // label_count_value_ViewAttendance
            // 
            this.label_count_value_ViewAttendance.AutoSize = true;
            this.label_count_value_ViewAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count_value_ViewAttendance.Location = new System.Drawing.Point(711, 225);
            this.label_count_value_ViewAttendance.Name = "label_count_value_ViewAttendance";
            this.label_count_value_ViewAttendance.Size = new System.Drawing.Size(14, 20);
            this.label_count_value_ViewAttendance.TabIndex = 14;
            this.label_count_value_ViewAttendance.Text = "-";
            // 
            // ViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 536);
            this.Controls.Add(this.label_count_value_ViewAttendance);
            this.Controls.Add(this.label_count_header_AttendanceList);
            this.Controls.Add(this.groupBox_class_viewAttendance);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_filter_by);
            this.Controls.Add(this.groupBox_view_attendance);
            this.Name = "ViewAttendance";
            this.Text = "ViewAttendance";
            this.groupBox_view_attendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_StudentAttendanceData)).EndInit();
            this.groupBox_filter_by.ResumeLayout(false);
            this.groupBox_filter_by.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_class_viewAttendance.ResumeLayout(false);
            this.groupBox_class_viewAttendance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_view_attendance;
        private System.Windows.Forms.DataGridView DataGridView_StudentAttendanceData;
        private System.Windows.Forms.GroupBox groupBox_filter_by;
        private System.Windows.Forms.Button button_search_viewAttendance;
        private System.Windows.Forms.TextBox textBox_student_id_ViewAttendance;
        private System.Windows.Forms.Label label_student_id;
        private System.Windows.Forms.TextBox textBox_student_name_viewAteendance;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_AttendanceList_Heading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_back_view_attendance;
        private System.Windows.Forms.GroupBox groupBox_class_viewAttendance;
        private System.Windows.Forms.Button button_filterClass_viewAttedance;
        private System.Windows.Forms.Label label_class_view_attendance;
        private System.Windows.Forms.Label label_date_view_attendance;
        private System.Windows.Forms.ComboBox comboBox_class_view_attendance;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date_viewAttendance;
        private System.Windows.Forms.Label label_count_header_AttendanceList;
        private System.Windows.Forms.Label label_count_value_ViewAttendance;
    }
}