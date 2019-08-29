namespace Sasip
{
    partial class AddClass
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
            this.groupBox_addclass = new System.Windows.Forms.GroupBox();
            this.textBox_teachername_addclass = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_addclass = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_theory_addclass = new System.Windows.Forms.RadioButton();
            this.radioButton_revision_addclass = new System.Windows.Forms.RadioButton();
            this.radioButton_mass_addclass = new System.Windows.Forms.RadioButton();
            this.groupBox_calsstime_addclass = new System.Windows.Forms.GroupBox();
            this.comboBox_date_addclass = new System.Windows.Forms.ComboBox();
            this.radioButton_evening_addclass = new System.Windows.Forms.RadioButton();
            this.radioButton_Time_Morning_addclass = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_cassname_addclass = new System.Windows.Forms.Label();
            this.textBox_subject_addclass = new System.Windows.Forms.TextBox();
            this.button_submit_addclass = new System.Windows.Forms.Button();
            this.button_back_addclass = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_AddClass_Heading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_addclass.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_calsstime_addclass.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_addclass
            // 
            this.groupBox_addclass.Controls.Add(this.textBox_teachername_addclass);
            this.groupBox_addclass.Controls.Add(this.groupBox1);
            this.groupBox_addclass.Controls.Add(this.groupBox_calsstime_addclass);
            this.groupBox_addclass.Controls.Add(this.label3);
            this.groupBox_addclass.Controls.Add(this.label_cassname_addclass);
            this.groupBox_addclass.Controls.Add(this.textBox_subject_addclass);
            this.groupBox_addclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_addclass.Location = new System.Drawing.Point(12, 126);
            this.groupBox_addclass.Name = "groupBox_addclass";
            this.groupBox_addclass.Size = new System.Drawing.Size(730, 300);
            this.groupBox_addclass.TabIndex = 1;
            this.groupBox_addclass.TabStop = false;
            // 
            // textBox_teachername_addclass
            // 
            this.textBox_teachername_addclass.FormattingEnabled = true;
            this.textBox_teachername_addclass.Location = new System.Drawing.Point(110, 92);
            this.textBox_teachername_addclass.Name = "textBox_teachername_addclass";
            this.textBox_teachername_addclass.Size = new System.Drawing.Size(254, 28);
            this.textBox_teachername_addclass.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_addclass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioButton_theory_addclass);
            this.groupBox1.Controls.Add(this.radioButton_revision_addclass);
            this.groupBox1.Controls.Add(this.radioButton_mass_addclass);
            this.groupBox1.Location = new System.Drawing.Point(35, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 126);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Details";
            // 
            // dateTimePicker_addclass
            // 
            this.dateTimePicker_addclass.CustomFormat = "yyyy";
            this.dateTimePicker_addclass.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_addclass.Location = new System.Drawing.Point(110, 80);
            this.dateTimePicker_addclass.Name = "dateTimePicker_addclass";
            this.dateTimePicker_addclass.ShowUpDown = true;
            this.dateTimePicker_addclass.Size = new System.Drawing.Size(68, 26);
            this.dateTimePicker_addclass.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Class Type:";
            // 
            // radioButton_theory_addclass
            // 
            this.radioButton_theory_addclass.AutoSize = true;
            this.radioButton_theory_addclass.Location = new System.Drawing.Point(272, 32);
            this.radioButton_theory_addclass.Name = "radioButton_theory_addclass";
            this.radioButton_theory_addclass.Size = new System.Drawing.Size(75, 24);
            this.radioButton_theory_addclass.TabIndex = 15;
            this.radioButton_theory_addclass.TabStop = true;
            this.radioButton_theory_addclass.Text = "Theory";
            this.radioButton_theory_addclass.UseVisualStyleBackColor = true;
            // 
            // radioButton_revision_addclass
            // 
            this.radioButton_revision_addclass.AutoSize = true;
            this.radioButton_revision_addclass.Location = new System.Drawing.Point(110, 32);
            this.radioButton_revision_addclass.Name = "radioButton_revision_addclass";
            this.radioButton_revision_addclass.Size = new System.Drawing.Size(87, 24);
            this.radioButton_revision_addclass.TabIndex = 13;
            this.radioButton_revision_addclass.TabStop = true;
            this.radioButton_revision_addclass.Text = "Revision";
            this.radioButton_revision_addclass.UseVisualStyleBackColor = true;
            // 
            // radioButton_mass_addclass
            // 
            this.radioButton_mass_addclass.AutoSize = true;
            this.radioButton_mass_addclass.Location = new System.Drawing.Point(202, 32);
            this.radioButton_mass_addclass.Name = "radioButton_mass_addclass";
            this.radioButton_mass_addclass.Size = new System.Drawing.Size(65, 24);
            this.radioButton_mass_addclass.TabIndex = 14;
            this.radioButton_mass_addclass.TabStop = true;
            this.radioButton_mass_addclass.Text = "Mass";
            this.radioButton_mass_addclass.UseVisualStyleBackColor = true;
            // 
            // groupBox_calsstime_addclass
            // 
            this.groupBox_calsstime_addclass.Controls.Add(this.comboBox_date_addclass);
            this.groupBox_calsstime_addclass.Controls.Add(this.radioButton_evening_addclass);
            this.groupBox_calsstime_addclass.Controls.Add(this.radioButton_Time_Morning_addclass);
            this.groupBox_calsstime_addclass.Controls.Add(this.label1);
            this.groupBox_calsstime_addclass.Controls.Add(this.label2);
            this.groupBox_calsstime_addclass.Location = new System.Drawing.Point(430, 156);
            this.groupBox_calsstime_addclass.Name = "groupBox_calsstime_addclass";
            this.groupBox_calsstime_addclass.Size = new System.Drawing.Size(282, 126);
            this.groupBox_calsstime_addclass.TabIndex = 11;
            this.groupBox_calsstime_addclass.TabStop = false;
            this.groupBox_calsstime_addclass.Text = "Class Time";
            // 
            // comboBox_date_addclass
            // 
            this.comboBox_date_addclass.FormattingEnabled = true;
            this.comboBox_date_addclass.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.comboBox_date_addclass.Location = new System.Drawing.Point(78, 31);
            this.comboBox_date_addclass.Name = "comboBox_date_addclass";
            this.comboBox_date_addclass.Size = new System.Drawing.Size(142, 28);
            this.comboBox_date_addclass.TabIndex = 8;
            // 
            // radioButton_evening_addclass
            // 
            this.radioButton_evening_addclass.AutoSize = true;
            this.radioButton_evening_addclass.Location = new System.Drawing.Point(165, 80);
            this.radioButton_evening_addclass.Name = "radioButton_evening_addclass";
            this.radioButton_evening_addclass.Size = new System.Drawing.Size(84, 24);
            this.radioButton_evening_addclass.TabIndex = 9;
            this.radioButton_evening_addclass.TabStop = true;
            this.radioButton_evening_addclass.Text = "Evening";
            this.radioButton_evening_addclass.UseVisualStyleBackColor = true;
            // 
            // radioButton_Time_Morning_addclass
            // 
            this.radioButton_Time_Morning_addclass.AutoSize = true;
            this.radioButton_Time_Morning_addclass.Location = new System.Drawing.Point(76, 80);
            this.radioButton_Time_Morning_addclass.Name = "radioButton_Time_Morning_addclass";
            this.radioButton_Time_Morning_addclass.Size = new System.Drawing.Size(84, 24);
            this.radioButton_Time_Morning_addclass.TabIndex = 10;
            this.radioButton_Time_Morning_addclass.TabStop = true;
            this.radioButton_Time_Morning_addclass.Text = "Morning";
            this.radioButton_Time_Morning_addclass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teacher:";
            // 
            // label_cassname_addclass
            // 
            this.label_cassname_addclass.AutoSize = true;
            this.label_cassname_addclass.Location = new System.Drawing.Point(42, 45);
            this.label_cassname_addclass.Name = "label_cassname_addclass";
            this.label_cassname_addclass.Size = new System.Drawing.Size(67, 20);
            this.label_cassname_addclass.TabIndex = 1;
            this.label_cassname_addclass.Text = "Subject:";
            // 
            // textBox_subject_addclass
            // 
            this.textBox_subject_addclass.Location = new System.Drawing.Point(110, 42);
            this.textBox_subject_addclass.Name = "textBox_subject_addclass";
            this.textBox_subject_addclass.Size = new System.Drawing.Size(254, 26);
            this.textBox_subject_addclass.TabIndex = 0;
            // 
            // button_submit_addclass
            // 
            this.button_submit_addclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit_addclass.Location = new System.Drawing.Point(661, 450);
            this.button_submit_addclass.Name = "button_submit_addclass";
            this.button_submit_addclass.Size = new System.Drawing.Size(75, 28);
            this.button_submit_addclass.TabIndex = 2;
            this.button_submit_addclass.Text = "Submit";
            this.button_submit_addclass.UseVisualStyleBackColor = true;
            this.button_submit_addclass.Click += new System.EventHandler(this.button_submit_addclass_Click);
            // 
            // button_back_addclass
            // 
            this.button_back_addclass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back_addclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back_addclass.Location = new System.Drawing.Point(7, 3);
            this.button_back_addclass.Name = "button_back_addclass";
            this.button_back_addclass.Size = new System.Drawing.Size(75, 30);
            this.button_back_addclass.TabIndex = 3;
            this.button_back_addclass.Text = "Back";
            this.button_back_addclass.UseVisualStyleBackColor = true;
            this.button_back_addclass.Click += new System.EventHandler(this.button_back_addclass_Click);
            // 
            // label_AddClass_Heading
            // 
            this.label_AddClass_Heading.AutoSize = true;
            this.label_AddClass_Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddClass_Heading.Location = new System.Drawing.Point(303, 6);
            this.label_AddClass_Heading.Name = "label_AddClass_Heading";
            this.label_AddClass_Heading.Size = new System.Drawing.Size(182, 24);
            this.label_AddClass_Heading.TabIndex = 4;
            this.label_AddClass_Heading.Text = "ADD A NEW CLASS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button_back_addclass);
            this.panel1.Controls.Add(this.label_AddClass_Heading);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 34);
            this.panel1.TabIndex = 5;
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(754, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_submit_addclass);
            this.Controls.Add(this.groupBox_addclass);
            this.Name = "AddClass";
            this.Text = "AddClass";
            this.groupBox_addclass.ResumeLayout(false);
            this.groupBox_addclass.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_calsstime_addclass.ResumeLayout(false);
            this.groupBox_calsstime_addclass.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_addclass;
        private System.Windows.Forms.Button button_submit_addclass;
        private System.Windows.Forms.Button button_back_addclass;
        private System.Windows.Forms.RadioButton radioButton_Time_Morning_addclass;
        private System.Windows.Forms.RadioButton radioButton_evening_addclass;
        private System.Windows.Forms.ComboBox comboBox_date_addclass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_cassname_addclass;
        private System.Windows.Forms.TextBox textBox_subject_addclass;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_addclass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_theory_addclass;
        private System.Windows.Forms.RadioButton radioButton_revision_addclass;
        private System.Windows.Forms.RadioButton radioButton_mass_addclass;
        private System.Windows.Forms.GroupBox groupBox_calsstime_addclass;
        private System.Windows.Forms.ComboBox textBox_teachername_addclass;
        private System.Windows.Forms.Label label_AddClass_Heading;
        private System.Windows.Forms.Panel panel1;
    }
}