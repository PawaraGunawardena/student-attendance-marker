namespace Sasip
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.btn_classes = new System.Windows.Forms.Button();
            this.button_attendance_list = new System.Windows.Forms.Button();
            this.button_class_list_dashboard = new System.Windows.Forms.Button();
            this.button_available_teachers = new System.Windows.Forms.Button();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.btn_teachers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox_icon);
            this.splitContainer1.Panel1.Controls.Add(this.btn_classes);
            this.splitContainer1.Panel1.Controls.Add(this.button_attendance_list);
            this.splitContainer1.Panel1.Controls.Add(this.button_class_list_dashboard);
            this.splitContainer1.Panel1.Controls.Add(this.button_available_teachers);
            this.splitContainer1.Panel1.Controls.Add(this.btn_attendance);
            this.splitContainer1.Panel1.Controls.Add(this.btn_teachers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Size = new System.Drawing.Size(1030, 657);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.ErrorImage = null;
            this.pictureBox_icon.InitialImage = null;
            this.pictureBox_icon.Location = new System.Drawing.Point(37, 19);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(160, 160);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_icon.TabIndex = 6;
            this.pictureBox_icon.TabStop = false;
            // 
            // btn_classes
            // 
            this.btn_classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_classes.Location = new System.Drawing.Point(22, 268);
            this.btn_classes.Name = "btn_classes";
            this.btn_classes.Size = new System.Drawing.Size(190, 69);
            this.btn_classes.TabIndex = 0;
            this.btn_classes.Text = "Add Classes";
            this.btn_classes.UseVisualStyleBackColor = true;
            this.btn_classes.Click += new System.EventHandler(this.btn_classes_Click);
            // 
            // button_attendance_list
            // 
            this.button_attendance_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_attendance_list.Location = new System.Drawing.Point(19, 573);
            this.button_attendance_list.Name = "button_attendance_list";
            this.button_attendance_list.Size = new System.Drawing.Size(190, 69);
            this.button_attendance_list.TabIndex = 5;
            this.button_attendance_list.Text = "View Attendance List";
            this.button_attendance_list.UseVisualStyleBackColor = true;
            this.button_attendance_list.Click += new System.EventHandler(this.button_attendance_list_Click);
            // 
            // button_class_list_dashboard
            // 
            this.button_class_list_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_class_list_dashboard.Location = new System.Drawing.Point(20, 497);
            this.button_class_list_dashboard.Name = "button_class_list_dashboard";
            this.button_class_list_dashboard.Size = new System.Drawing.Size(190, 69);
            this.button_class_list_dashboard.TabIndex = 4;
            this.button_class_list_dashboard.Text = "View Classes List | Remove Class";
            this.button_class_list_dashboard.UseVisualStyleBackColor = true;
            this.button_class_list_dashboard.Click += new System.EventHandler(this.button_class_list_dashboard_Click);
            // 
            // button_available_teachers
            // 
            this.button_available_teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_available_teachers.Location = new System.Drawing.Point(22, 421);
            this.button_available_teachers.Name = "button_available_teachers";
            this.button_available_teachers.Size = new System.Drawing.Size(190, 69);
            this.button_available_teachers.TabIndex = 3;
            this.button_available_teachers.Text = "View Teachers List | Remove Teacher";
            this.button_available_teachers.UseVisualStyleBackColor = true;
            this.button_available_teachers.Click += new System.EventHandler(this.button_available_teachers_Click);
            // 
            // btn_attendance
            // 
            this.btn_attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attendance.Location = new System.Drawing.Point(22, 344);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(190, 69);
            this.btn_attendance.TabIndex = 2;
            this.btn_attendance.Text = "Mark Attendance";
            this.btn_attendance.UseVisualStyleBackColor = true;
            this.btn_attendance.Click += new System.EventHandler(this.btn_attendance_Click);
            // 
            // btn_teachers
            // 
            this.btn_teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teachers.Location = new System.Drawing.Point(22, 191);
            this.btn_teachers.Name = "btn_teachers";
            this.btn_teachers.Size = new System.Drawing.Size(190, 69);
            this.btn_teachers.TabIndex = 1;
            this.btn_teachers.Text = "Add Teachers";
            this.btn_teachers.UseVisualStyleBackColor = true;
            this.btn_teachers.Click += new System.EventHandler(this.btn_teachers_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 657);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sasip Attendance Marker v0.5.2";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Button btn_teachers;
        private System.Windows.Forms.Button btn_classes;
        private System.Windows.Forms.Button button_available_teachers;
        private System.Windows.Forms.Button button_class_list_dashboard;
        private System.Windows.Forms.Button button_attendance_list;
        private System.Windows.Forms.PictureBox pictureBox_icon;
    }
}