namespace CoachingMangementSystem
{
    partial class StudentProfile
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
            this.searchbtn = new System.Windows.Forms.Button();
            this.student_status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.student_deleteBtn = new System.Windows.Forms.Button();
            this.student_clearBtn = new System.Windows.Forms.Button();
            this.student_updateBtn = new System.Windows.Forms.Button();
            this.student_addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.student_section = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.student_grade = new System.Windows.Forms.ComboBox();
            this.student_studentData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.student_studentData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.searchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.Location = new System.Drawing.Point(754, 220);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(87, 31);
            this.searchbtn.TabIndex = 21;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // student_status
            // 
            this.student_status.FormattingEnabled = true;
            this.student_status.Items.AddRange(new object[] {
            "Enrolled",
            "Pending",
            "Graduated"});
            this.student_status.Location = new System.Drawing.Point(703, 74);
            this.student_status.Margin = new System.Windows.Forms.Padding(4);
            this.student_status.Name = "student_status";
            this.student_status.Size = new System.Drawing.Size(191, 24);
            this.student_status.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Status:";
            // 
            // student_deleteBtn
            // 
            this.student_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.student_deleteBtn.FlatAppearance.BorderSize = 0;
            this.student_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_deleteBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.student_deleteBtn.Location = new System.Drawing.Point(547, 214);
            this.student_deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.student_deleteBtn.Name = "student_deleteBtn";
            this.student_deleteBtn.Size = new System.Drawing.Size(136, 43);
            this.student_deleteBtn.TabIndex = 17;
            this.student_deleteBtn.Text = "Delete";
            this.student_deleteBtn.UseVisualStyleBackColor = false;
            // 
            // student_clearBtn
            // 
            this.student_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.student_clearBtn.FlatAppearance.BorderSize = 0;
            this.student_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_clearBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_clearBtn.ForeColor = System.Drawing.Color.White;
            this.student_clearBtn.Location = new System.Drawing.Point(379, 214);
            this.student_clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.student_clearBtn.Name = "student_clearBtn";
            this.student_clearBtn.Size = new System.Drawing.Size(136, 43);
            this.student_clearBtn.TabIndex = 16;
            this.student_clearBtn.Text = "Clear";
            this.student_clearBtn.UseVisualStyleBackColor = false;
            // 
            // student_updateBtn
            // 
            this.student_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.student_updateBtn.FlatAppearance.BorderSize = 0;
            this.student_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_updateBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_updateBtn.ForeColor = System.Drawing.Color.White;
            this.student_updateBtn.Location = new System.Drawing.Point(196, 214);
            this.student_updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.student_updateBtn.Name = "student_updateBtn";
            this.student_updateBtn.Size = new System.Drawing.Size(136, 43);
            this.student_updateBtn.TabIndex = 15;
            this.student_updateBtn.Text = "Update";
            this.student_updateBtn.UseVisualStyleBackColor = false;
            // 
            // student_addBtn
            // 
            this.student_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.student_addBtn.FlatAppearance.BorderSize = 0;
            this.student_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_addBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_addBtn.ForeColor = System.Drawing.Color.White;
            this.student_addBtn.Location = new System.Drawing.Point(28, 214);
            this.student_addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.student_addBtn.Name = "student_addBtn";
            this.student_addBtn.Size = new System.Drawing.Size(136, 43);
            this.student_addBtn.TabIndex = 14;
            this.student_addBtn.Text = "Add";
            this.student_addBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Profile";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(849, 221);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(4);
            this.searchtxt.Multiline = true;
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(191, 30);
            this.searchtxt.TabIndex = 20;
            // 
            // student_section
            // 
            this.student_section.FormattingEnabled = true;
            this.student_section.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.student_section.Location = new System.Drawing.Point(703, 26);
            this.student_section.Margin = new System.Windows.Forms.Padding(4);
            this.student_section.Name = "student_section";
            this.student_section.Size = new System.Drawing.Size(191, 24);
            this.student_section.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Section:";
            // 
            // student_grade
            // 
            this.student_grade.FormattingEnabled = true;
            this.student_grade.Items.AddRange(new object[] {
            "Grade 1",
            "Grade 2",
            "Grade 3",
            "Grade 4",
            "Grade 5",
            "Grade 6"});
            this.student_grade.Location = new System.Drawing.Point(379, 33);
            this.student_grade.Margin = new System.Windows.Forms.Padding(4);
            this.student_grade.Name = "student_grade";
            this.student_grade.Size = new System.Drawing.Size(191, 24);
            this.student_grade.TabIndex = 9;
            // 
            // student_studentData
            // 
            this.student_studentData.AllowUserToAddRows = false;
            this.student_studentData.AllowUserToDeleteRows = false;
            this.student_studentData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.student_studentData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.student_studentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_studentData.EnableHeadersVisualStyles = false;
            this.student_studentData.Location = new System.Drawing.Point(25, 58);
            this.student_studentData.Margin = new System.Windows.Forms.Padding(4);
            this.student_studentData.Name = "student_studentData";
            this.student_studentData.ReadOnly = true;
            this.student_studentData.RowHeadersVisible = false;
            this.student_studentData.RowHeadersWidth = 51;
            this.student_studentData.Size = new System.Drawing.Size(1080, 276);
            this.student_studentData.TabIndex = 1;
            this.student_studentData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_studentData_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.student_studentData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 356);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Grade:";
            // 
            // student_name
            // 
            this.student_name.Location = new System.Drawing.Point(105, 76);
            this.student_name.Margin = new System.Windows.Forms.Padding(4);
            this.student_name.Multiline = true;
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(191, 30);
            this.student_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // student_id
            // 
            this.student_id.Location = new System.Drawing.Point(105, 26);
            this.student_id.Margin = new System.Windows.Forms.Padding(4);
            this.student_id.Multiline = true;
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(135, 30);
            this.student_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.searchbtn);
            this.panel2.Controls.Add(this.searchtxt);
            this.panel2.Controls.Add(this.student_status);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.student_deleteBtn);
            this.panel2.Controls.Add(this.student_clearBtn);
            this.panel2.Controls.Add(this.student_updateBtn);
            this.panel2.Controls.Add(this.student_addBtn);
            this.panel2.Controls.Add(this.student_section);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.student_grade);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.student_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.student_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 379);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 281);
            this.panel2.TabIndex = 5;
            // 
            // StudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "StudentProfile";
            this.Text = "StudentProfile";
            ((System.ComponentModel.ISupportInitialize)(this.student_studentData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.ComboBox student_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button student_deleteBtn;
        private System.Windows.Forms.Button student_clearBtn;
        private System.Windows.Forms.Button student_updateBtn;
        private System.Windows.Forms.Button student_addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.ComboBox student_section;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox student_grade;
        private System.Windows.Forms.DataGridView student_studentData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox student_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}
