namespace Studentinformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            {
                InitializeComponent();
                InitializeData();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            {
                // รับค่าจากฟอร์ม
                string id = txtStudentID.Text;
                string name = txtStudentName.Text;
                string department = txtDepartment.Text;
                double grade;
                if (!double.TryParse(txtGrade.Text, out grade))
                {
                    MessageBox.Show("กรุณากรอกเกรดเป็นตัวเลข");
                    return;
                }

                Advisor selectedAdvisor = cmbAdvisor.SelectedItem as Advisor;
                if (selectedAdvisor == null)
                {
                    MessageBox.Show("กรุณาเลือกอาจารย์ที่ปรึกษา");
                    return;
                }

                // อัปเดต DataGridView
                Student student = new Student(id, name, department, grade, selectedAdvisor);
                students.Add(student);

                // อัปเดต DataGridView
                dgvStudents.DataSource = null;
                dgvStudents.DataSource = students;

                //เคลียร์ช่องป้อนข้อมูล
                txtStudentID.Clear();
                txtStudentName.Clear();
                txtDepartment.Clear();
                txtGrade.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowStudent_Click(object sender, EventArgs e)
        {
            {
                // แสดงนักศึกษาของอาจารย์ที่เลือก

                Advisor selectedAdvisor = cmbAdvisor.SelectedItem as Advisor;
                if (selectedAdvisor != null)
                {
                    dgeAdivsorStudents.DataSource = null;
                    dgeAdivsorStudents.DataSource = selectedAdvisor.Students;
                }
            }

        }

        private void btnFindTopStudent_Click(object sender, EventArgs e)
        {
            {
                // หานักศึกษาที่มีเกรดสูงสุด
                if (students.Count == 0)
                {
                    lblTopStudent.Text = "ยังไม่มีข้อมูลนักศึกษา";
                    return;
                }

                Student topStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();
                lblTopStudent.Text = $"Top Student: {topStudent.Name}, Grade: {topStudent.Grade}";
            }
        }

        private void dgeAdivsorStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

