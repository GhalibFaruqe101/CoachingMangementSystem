namespace CoachingMangementSystem
{
    partial class TeacherDashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.T_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.AddStudent_btn = new System.Windows.Forms.Button();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.wel_teacher = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addStudentForm1 = new CoachingMangementSystem.AddStudentForm();
            this.addTeachersForm1 = new CoachingMangementSystem.AddTeachersForm();
            this.panel1.SuspendLayout();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 30);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1440, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(618, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teacher DashBoard";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Teal;
            this.Panel.Controls.Add(this.T_name);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.logout_btn);
            this.Panel.Controls.Add(this.AddStudent_btn);
            this.Panel.Controls.Add(this.Dashboard_btn);
            this.Panel.Controls.Add(this.wel_teacher);
            this.Panel.Controls.Add(this.pictureBox1);
            this.Panel.Location = new System.Drawing.Point(4, 29);
            this.Panel.Margin = new System.Windows.Forms.Padding(4);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1350, 741);
            this.Panel.TabIndex = 4;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // T_name
            // 
            this.T_name.AutoSize = true;
            this.T_name.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.T_name.Location = new System.Drawing.Point(612, 301);
            this.T_name.Name = "T_name";
            this.T_name.Size = new System.Drawing.Size(96, 38);
            this.T_name.TabIndex = 7;
            this.T_name.Text = "label4";
            this.T_name.Click += new System.EventHandler(this.T_name_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(643, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 27);
            this.label1.TabIndex = 6;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.White;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.Black;
            this.logout_btn.Location = new System.Drawing.Point(570, 494);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(223, 52);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // AddStudent_btn
            // 
            this.AddStudent_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudent_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddStudent_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddStudent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudent_btn.ForeColor = System.Drawing.Color.White;
            this.AddStudent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddStudent_btn.Location = new System.Drawing.Point(546, 417);
            this.AddStudent_btn.Margin = new System.Windows.Forms.Padding(4);
            this.AddStudent_btn.Name = "AddStudent_btn";
            this.AddStudent_btn.Size = new System.Drawing.Size(267, 52);
            this.AddStudent_btn.TabIndex = 3;
            this.AddStudent_btn.Text = "Profile";
            this.AddStudent_btn.UseVisualStyleBackColor = true;
            this.AddStudent_btn.Click += new System.EventHandler(this.AddStudent_btn_Click);
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.Dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard_btn.Location = new System.Drawing.Point(546, 351);
            this.Dashboard_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(267, 52);
            this.Dashboard_btn.TabIndex = 2;
            this.Dashboard_btn.Text = "Student Information";
            this.Dashboard_btn.UseVisualStyleBackColor = true;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // wel_teacher
            // 
            this.wel_teacher.AutoSize = true;
            this.wel_teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wel_teacher.ForeColor = System.Drawing.Color.White;
            this.wel_teacher.Location = new System.Drawing.Point(597, 278);
            this.wel_teacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wel_teacher.Name = "wel_teacher";
            this.wel_teacher.Size = new System.Drawing.Size(0, 25);
            this.wel_teacher.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(627, 175);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Panel);
            this.panel3.Controls.Add(this.addStudentForm1);
            this.panel3.Controls.Add(this.addTeachersForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1354, 774);
            this.panel3.TabIndex = 5;
            // 
            // addStudentForm1
            // 
            this.addStudentForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStudentForm1.Location = new System.Drawing.Point(0, 0);
            this.addStudentForm1.Margin = new System.Windows.Forms.Padding(5);
            this.addStudentForm1.Name = "addStudentForm1";
            this.addStudentForm1.Size = new System.Drawing.Size(1354, 774);
            this.addStudentForm1.TabIndex = 1;
            // 
            // addTeachersForm1
            // 
            this.addTeachersForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTeachersForm1.Location = new System.Drawing.Point(0, 0);
            this.addTeachersForm1.Margin = new System.Windows.Forms.Padding(5);
            this.addTeachersForm1.Name = "addTeachersForm1";
            this.addTeachersForm1.Size = new System.Drawing.Size(1354, 774);
            this.addTeachersForm1.TabIndex = 0;
            // 
            // TeacherDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 774);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "TeacherDashBoard";
            this.Text = "TeacherDashBoard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button AddStudent_btn;
        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.Label wel_teacher;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private CoachingMangementSystem.AddStudentForm addStudentForm1;
        private CoachingMangementSystem.AddTeachersForm addTeachersForm1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label T_name;
    }
}