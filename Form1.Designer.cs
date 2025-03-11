using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Studentinformation
{
    public partial class Form1 : Form
    {
        // คลาสอาจารย์ที่ปรึกษา
        public class Advisor
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public List<Student> Students { get; set; } = new List<Student>();
            public Advisor(string name, string department)
            {
                Name = name;
                Department = department;
            }

            public void AddStudent(Student student)
            {
                Students.Add(student);
            }
        }

        // คลาสนักศึกษา
        public class Student
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public double Grade { get; set; }
            public Advisor Advisor { get; set; }

            public Student(string id, string name, string department, double grade, Advisor advisor)
            {
                ID = id;
                Name = name;
                Department = department;
                Grade = grade;
                Advisor = advisor;
                advisor.AddStudent(this);
            }
        }

        // รายการอาจารย์และนักศึกษา
        private List<Advisor> advisors = new List<Advisor>();
        private List<Student> students = new List<Student>();
        private void InitializeData()
        {
            // เพิ่มอาจารย์ที่ปรึกษาเริ่มต้น
            advisors.Add(new Advisor("อาจารย์ปโยฑร", "Computer Science"));
            advisors.Add(new Advisor("อาจารย์นพคุณ", "Computer Science"));

            // โหลดอาจารย์ลง ComboBox
            cmbAdvisor.DataSource = advisors;
            cmbAdvisor.DisplayMember = "Name";
        }


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvStudents = new DataGridView();
            dgeAdivsorStudents = new DataGridView();
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            txtGrade = new TextBox();
            txtDepartment = new TextBox();
            cmbAdvisor = new ComboBox();
            btnAddStudent = new Button();
            btnShowStudent = new Button();
            btnFindTopStudent = new Button();
            lblTopStudent = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgeAdivsorStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(23, 219);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(240, 150);
            dgvStudents.TabIndex = 0;
            dgvStudents.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dgeAdivsorStudents
            // 
            dgeAdivsorStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgeAdivsorStudents.Location = new Point(303, 219);
            dgeAdivsorStudents.Name = "dgeAdivsorStudents";
            dgeAdivsorStudents.Size = new Size(240, 150);
            dgeAdivsorStudents.TabIndex = 1;
            dgeAdivsorStudents.CellContentClick += dgeAdivsorStudents_CellContentClick;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(109, 40);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(100, 23);
            txtStudentID.TabIndex = 2;
            txtStudentID.Tag = "";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(109, 69);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(100, 23);
            txtStudentName.TabIndex = 3;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(109, 127);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(107, 23);
            txtGrade.TabIndex = 4;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(109, 98);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(100, 23);
            txtDepartment.TabIndex = 5;
            // 
            // cmbAdvisor
            // 
            cmbAdvisor.FormattingEnabled = true;
            cmbAdvisor.Location = new Point(109, 154);
            cmbAdvisor.Name = "cmbAdvisor";
            cmbAdvisor.Size = new Size(121, 23);
            cmbAdvisor.TabIndex = 6;
            cmbAdvisor.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(286, 43);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(96, 34);
            btnAddStudent.TabIndex = 7;
            btnAddStudent.Text = "AddStudent";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnShowStudent
            // 
            btnShowStudent.Location = new Point(286, 83);
            btnShowStudent.Name = "btnShowStudent";
            btnShowStudent.Size = new Size(96, 33);
            btnShowStudent.TabIndex = 8;
            btnShowStudent.Text = "ShowStudents";
            btnShowStudent.UseVisualStyleBackColor = true;
            btnShowStudent.Click += btnShowStudent_Click;
            // 
            // btnFindTopStudent
            // 
            btnFindTopStudent.Location = new Point(286, 127);
            btnFindTopStudent.Name = "btnFindTopStudent";
            btnFindTopStudent.Size = new Size(96, 36);
            btnFindTopStudent.TabIndex = 9;
            btnFindTopStudent.Text = "FindTop";
            btnFindTopStudent.UseVisualStyleBackColor = true;
            btnFindTopStudent.Click += btnFindTopStudent_Click;
            // 
            // lblTopStudent
            // 
            lblTopStudent.AutoSize = true;
            lblTopStudent.Location = new Point(41, 395);
            lblTopStudent.Name = "lblTopStudent";
            lblTopStudent.Size = new Size(71, 15);
            lblTopStudent.TabIndex = 10;
            lblTopStudent.Text = "Top Student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 43);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 11;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 72);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 12;
            label2.Text = "Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 101);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 13;
            label3.Text = "Department:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 130);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 14;
            label4.Text = "Grade :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 157);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 15;
            label5.Text = "Advisor :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 201);
            label6.Name = "label6";
            label6.Size = new Size(182, 15);
            label6.TabIndex = 16;
            label6.Text = "Students under selected Advisor :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTopStudent);
            Controls.Add(btnFindTopStudent);
            Controls.Add(btnShowStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(cmbAdvisor);
            Controls.Add(txtDepartment);
            Controls.Add(txtGrade);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentID);
            Controls.Add(dgeAdivsorStudents);
            Controls.Add(dgvStudents);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgeAdivsorStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private DataGridView dgeAdivsorStudents;
        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private TextBox txtGrade;
        private TextBox txtDepartment;
        private ComboBox cmbAdvisor;
        private Button btnAddStudent;
        private Button btnShowStudent;
        private Button btnFindTopStudent;
        private Label lblTopStudent;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
