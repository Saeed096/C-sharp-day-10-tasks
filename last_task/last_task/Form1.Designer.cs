namespace last_task
{
    partial class Form1
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
            this.departmentsComboBox = new System.Windows.Forms.ComboBox();
            this.emp_list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name_txt_box = new System.Windows.Forms.TextBox();
            this.address_txt_box = new System.Windows.Forms.TextBox();
            this.birth_date_box = new System.Windows.Forms.DateTimePicker();
            this.departments_combo2 = new System.Windows.Forms.ComboBox();
            this.salary_box = new System.Windows.Forms.NumericUpDown();
            this.update_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ssn_box = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.salary_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssn_box)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentsComboBox
            // 
            this.departmentsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentsComboBox.FormattingEnabled = true;
            this.departmentsComboBox.Location = new System.Drawing.Point(41, 40);
            this.departmentsComboBox.Name = "departmentsComboBox";
            this.departmentsComboBox.Size = new System.Drawing.Size(121, 24);
            this.departmentsComboBox.TabIndex = 0;
            this.departmentsComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentsComboBox_SelectedIndexChanged);
            // 
            // emp_list
            // 
            this.emp_list.FormattingEnabled = true;
            this.emp_list.ItemHeight = 16;
            this.emp_list.Location = new System.Drawing.Point(22, 158);
            this.emp_list.Name = "emp_list";
            this.emp_list.Size = new System.Drawing.Size(166, 228);
            this.emp_list.TabIndex = 1;
            this.emp_list.SelectedIndexChanged += new System.EventHandler(this.emp_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "birth date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "department";
            // 
            // name_txt_box
            // 
            this.name_txt_box.Location = new System.Drawing.Point(561, 34);
            this.name_txt_box.Name = "name_txt_box";
            this.name_txt_box.Size = new System.Drawing.Size(172, 22);
            this.name_txt_box.TabIndex = 8;
            // 
            // address_txt_box
            // 
            this.address_txt_box.Location = new System.Drawing.Point(560, 184);
            this.address_txt_box.Name = "address_txt_box";
            this.address_txt_box.Size = new System.Drawing.Size(172, 22);
            this.address_txt_box.TabIndex = 9;
            // 
            // birth_date_box
            // 
            this.birth_date_box.Location = new System.Drawing.Point(560, 120);
            this.birth_date_box.Name = "birth_date_box";
            this.birth_date_box.Size = new System.Drawing.Size(172, 22);
            this.birth_date_box.TabIndex = 10;
            // 
            // departments_combo2
            // 
            this.departments_combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departments_combo2.FormattingEnabled = true;
            this.departments_combo2.Location = new System.Drawing.Point(560, 323);
            this.departments_combo2.Name = "departments_combo2";
            this.departments_combo2.Size = new System.Drawing.Size(121, 24);
            this.departments_combo2.TabIndex = 12;
            // 
            // salary_box
            // 
            this.salary_box.Location = new System.Drawing.Point(561, 252);
            this.salary_box.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.salary_box.Name = "salary_box";
            this.salary_box.Size = new System.Drawing.Size(171, 22);
            this.salary_box.TabIndex = 13;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(571, 389);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(98, 38);
            this.update_btn.TabIndex = 14;
            this.update_btn.Text = "update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Enabled = false;
            this.add_btn.Location = new System.Drawing.Point(447, 389);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(98, 38);
            this.add_btn.TabIndex = 15;
            this.add_btn.Text = "add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(690, 389);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(98, 38);
            this.delete_btn.TabIndex = 16;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "SSN";
            // 
            // ssn_box
            // 
            this.ssn_box.Location = new System.Drawing.Point(562, 76);
            this.ssn_box.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.ssn_box.Name = "ssn_box";
            this.ssn_box.Size = new System.Drawing.Size(171, 22);
            this.ssn_box.TabIndex = 18;
            this.ssn_box.ValueChanged += new System.EventHandler(this.ssn_box_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ssn_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.salary_box);
            this.Controls.Add(this.departments_combo2);
            this.Controls.Add(this.birth_date_box);
            this.Controls.Add(this.address_txt_box);
            this.Controls.Add(this.name_txt_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emp_list);
            this.Controls.Add(this.departmentsComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.salary_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssn_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox departmentsComboBox;
        private System.Windows.Forms.ListBox emp_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_txt_box;
        private System.Windows.Forms.TextBox address_txt_box;
        private System.Windows.Forms.DateTimePicker birth_date_box;
        private System.Windows.Forms.ComboBox departments_combo2;
        private System.Windows.Forms.NumericUpDown salary_box;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ssn_box;
    }
}

