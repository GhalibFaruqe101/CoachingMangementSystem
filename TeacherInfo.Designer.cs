namespace CoachingMangementSystem
{
    partial class TeacherInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.return_btn = new System.Windows.Forms.Button();
            this.t_data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.schedule_btn = new System.Windows.Forms.Button();
            this.edt_btn = new System.Windows.Forms.Button();
            this.teacher_sub = new System.Windows.Forms.TextBox();
            this.subject_lb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.teacher_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.teacher_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teacher_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teacher_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_course = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.t_sec = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.return_btn);
            this.panel1.Controls.Add(this.t_data);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 356);
            this.panel1.TabIndex = 5;
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.return_btn.FlatAppearance.BorderSize = 0;
            this.return_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.return_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_btn.ForeColor = System.Drawing.Color.White;
            this.return_btn.Location = new System.Drawing.Point(1003, 13);
            this.return_btn.Margin = new System.Windows.Forms.Padding(4);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(104, 36);
            this.return_btn.TabIndex = 25;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // t_data
            // 
            this.t_data.AllowUserToAddRows = false;
            this.t_data.AllowUserToDeleteRows = false;
            this.t_data.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.t_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.t_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_data.EnableHeadersVisualStyles = false;
            this.t_data.Location = new System.Drawing.Point(25, 57);
            this.t_data.Margin = new System.Windows.Forms.Padding(4);
            this.t_data.Name = "t_data";
            this.t_data.ReadOnly = true;
            this.t_data.RowHeadersVisible = false;
            this.t_data.RowHeadersWidth = 51;
            this.t_data.Size = new System.Drawing.Size(1080, 276);
            this.t_data.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information";
            // 
            // schedule_btn
            // 
            this.schedule_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.schedule_btn.FlatAppearance.BorderSize = 0;
            this.schedule_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.schedule_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.schedule_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.schedule_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedule_btn.ForeColor = System.Drawing.Color.White;
            this.schedule_btn.Location = new System.Drawing.Point(13, 553);
            this.schedule_btn.Margin = new System.Windows.Forms.Padding(4);
            this.schedule_btn.Name = "schedule_btn";
            this.schedule_btn.Size = new System.Drawing.Size(287, 58);
            this.schedule_btn.TabIndex = 26;
            this.schedule_btn.Text = "Schedule";
            this.schedule_btn.UseVisualStyleBackColor = false;
            this.schedule_btn.Click += new System.EventHandler(this.schedule_btn_Click);
            // 
            // edt_btn
            // 
            this.edt_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.edt_btn.FlatAppearance.BorderSize = 0;
            this.edt_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.edt_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.edt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edt_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_btn.ForeColor = System.Drawing.Color.White;
            this.edt_btn.Location = new System.Drawing.Point(1015, 577);
            this.edt_btn.Margin = new System.Windows.Forms.Padding(4);
            this.edt_btn.Name = "edt_btn";
            this.edt_btn.Size = new System.Drawing.Size(113, 46);
            this.edt_btn.TabIndex = 29;
            this.edt_btn.Text = "Edit Profile";
            this.edt_btn.UseVisualStyleBackColor = false;
            // 
            // teacher_sub
            // 
            this.teacher_sub.Location = new System.Drawing.Point(632, 354);
            this.teacher_sub.Margin = new System.Windows.Forms.Padding(4);
            this.teacher_sub.Multiline = true;
            this.teacher_sub.Name = "teacher_sub";
            this.teacher_sub.Size = new System.Drawing.Size(191, 30);
            this.teacher_sub.TabIndex = 40;
            // 
            // subject_lb
            // 
            this.subject_lb.AutoSize = true;
            this.subject_lb.Location = new System.Drawing.Point(548, 362);
            this.subject_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subject_lb.Name = "subject_lb";
            this.subject_lb.Size = new System.Drawing.Size(52, 16);
            this.subject_lb.TabIndex = 39;
            this.subject_lb.Text = "Subject";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(860, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Status:";
            // 
            // teacher_address
            // 
            this.teacher_address.Location = new System.Drawing.Point(632, 252);
            this.teacher_address.Margin = new System.Windows.Forms.Padding(4);
            this.teacher_address.Multiline = true;
            this.teacher_address.Name = "teacher_address";
            this.teacher_address.Size = new System.Drawing.Size(191, 80);
            this.teacher_address.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Address:";
            // 
            // teacher_gender
            // 
            this.teacher_gender.FormattingEnabled = true;
            this.teacher_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.teacher_gender.Location = new System.Drawing.Point(324, 354);
            this.teacher_gender.Margin = new System.Windows.Forms.Padding(4);
            this.teacher_gender.Name = "teacher_gender";
            this.teacher_gender.Size = new System.Drawing.Size(191, 24);
            this.teacher_gender.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 358);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Gender:";
            // 
            // teacher_name
            // 
            this.teacher_name.Location = new System.Drawing.Point(323, 302);
            this.teacher_name.Margin = new System.Windows.Forms.Padding(4);
            this.teacher_name.Multiline = true;
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.Size = new System.Drawing.Size(191, 30);
            this.teacher_name.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Full Name:";
            // 
            // teacher_id
            // 
            this.teacher_id.Location = new System.Drawing.Point(323, 252);
            this.teacher_id.Margin = new System.Windows.Forms.Padding(4);
            this.teacher_id.Multiline = true;
            this.teacher_id.Name = "teacher_id";
            this.teacher_id.Size = new System.Drawing.Size(135, 30);
            this.teacher_id.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Teacher ID:";
            // 
            // t_course
            // 
            this.t_course.Location = new System.Drawing.Point(863, 396);
            this.t_course.Margin = new System.Windows.Forms.Padding(4);
            this.t_course.Multiline = true;
            this.t_course.Name = "t_course";
            this.t_course.Size = new System.Drawing.Size(191, 30);
            this.t_course.TabIndex = 31;
            this.t_course.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(783, 404);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Course:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(517, 303);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 30);
            this.textBox2.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 311);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Subject";
            // 
            // t_sec
            // 
            this.t_sec.Location = new System.Drawing.Point(863, 456);
            this.t_sec.Margin = new System.Windows.Forms.Padding(4);
            this.t_sec.Multiline = true;
            this.t_sec.Name = "t_sec";
            this.t_sec.Size = new System.Drawing.Size(191, 30);
            this.t_sec.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(783, 464);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Section";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(803, 577);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(113, 46);
            this.search_btn.TabIndex = 34;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // TeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 636);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.t_sec);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.t_course);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edt_btn);
            this.Controls.Add(this.schedule_btn);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherInfo";
            this.Text = "TeacherInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.DataGridView t_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button schedule_btn;
        private System.Windows.Forms.Button edt_btn;
        private System.Windows.Forms.TextBox teacher_sub;
        private System.Windows.Forms.Label subject_lb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox teacher_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox teacher_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacher_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacher_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_course;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t_sec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button search_btn;
    }
}