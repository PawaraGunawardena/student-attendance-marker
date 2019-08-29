namespace Sasip
{
    partial class ViewClasses
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
            this.dataGridView_class_lists_viewClasses = new System.Windows.Forms.DataGridView();
            this.groupBox_classslists_ViewClasses = new System.Windows.Forms.GroupBox();
            this.button_back_view_classes = new System.Windows.Forms.Button();
            this.label_ClassList_Heading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_delete_class_ViewClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_class_lists_viewClasses)).BeginInit();
            this.groupBox_classslists_ViewClasses.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_class_lists_viewClasses
            // 
            this.dataGridView_class_lists_viewClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_class_lists_viewClasses.Location = new System.Drawing.Point(19, 25);
            this.dataGridView_class_lists_viewClasses.Name = "dataGridView_class_lists_viewClasses";
            this.dataGridView_class_lists_viewClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_class_lists_viewClasses.Size = new System.Drawing.Size(677, 366);
            this.dataGridView_class_lists_viewClasses.TabIndex = 0;
            this.dataGridView_class_lists_viewClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_class_lists_viewClasses_CellClick);
            // 
            // groupBox_classslists_ViewClasses
            // 
            this.groupBox_classslists_ViewClasses.Controls.Add(this.dataGridView_class_lists_viewClasses);
            this.groupBox_classslists_ViewClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_classslists_ViewClasses.Location = new System.Drawing.Point(19, 51);
            this.groupBox_classslists_ViewClasses.Name = "groupBox_classslists_ViewClasses";
            this.groupBox_classslists_ViewClasses.Size = new System.Drawing.Size(716, 408);
            this.groupBox_classslists_ViewClasses.TabIndex = 1;
            this.groupBox_classslists_ViewClasses.TabStop = false;
            this.groupBox_classslists_ViewClasses.Text = "Classes";
            // 
            // button_back_view_classes
            // 
            this.button_back_view_classes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back_view_classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back_view_classes.Location = new System.Drawing.Point(7, 4);
            this.button_back_view_classes.Name = "button_back_view_classes";
            this.button_back_view_classes.Size = new System.Drawing.Size(75, 28);
            this.button_back_view_classes.TabIndex = 2;
            this.button_back_view_classes.Text = "Back";
            this.button_back_view_classes.UseVisualStyleBackColor = true;
            this.button_back_view_classes.Click += new System.EventHandler(this.button_back_view_classes_Click);
            // 
            // label_ClassList_Heading
            // 
            this.label_ClassList_Heading.AutoSize = true;
            this.label_ClassList_Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClassList_Heading.Location = new System.Drawing.Point(305, 8);
            this.label_ClassList_Heading.Name = "label_ClassList_Heading";
            this.label_ClassList_Heading.Size = new System.Drawing.Size(113, 24);
            this.label_ClassList_Heading.TabIndex = 5;
            this.label_ClassList_Heading.Text = "CLASS LIST";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button_back_view_classes);
            this.panel1.Controls.Add(this.label_ClassList_Heading);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 34);
            this.panel1.TabIndex = 6;
            // 
            // button_delete_class_ViewClass
            // 
            this.button_delete_class_ViewClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete_class_ViewClass.Location = new System.Drawing.Point(519, 481);
            this.button_delete_class_ViewClass.Name = "button_delete_class_ViewClass";
            this.button_delete_class_ViewClass.Size = new System.Drawing.Size(196, 28);
            this.button_delete_class_ViewClass.TabIndex = 7;
            this.button_delete_class_ViewClass.Text = "Remove Selected Class";
            this.button_delete_class_ViewClass.UseVisualStyleBackColor = true;
            this.button_delete_class_ViewClass.Click += new System.EventHandler(this.button_delete_class_ViewClass_Click);
            // 
            // ViewClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 536);
            this.Controls.Add(this.button_delete_class_ViewClass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_classslists_ViewClasses);
            this.Name = "ViewClasses";
            this.Text = "Classes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_class_lists_viewClasses)).EndInit();
            this.groupBox_classslists_ViewClasses.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_class_lists_viewClasses;
        private System.Windows.Forms.GroupBox groupBox_classslists_ViewClasses;
        private System.Windows.Forms.Button button_back_view_classes;
        private System.Windows.Forms.Label label_ClassList_Heading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_delete_class_ViewClass;
    }
}