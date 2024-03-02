namespace Unit4_Inheritance
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_teacher_Click(object sender, EventArgs e)
		{
			Login_Teacher loginTeacherForm = new Login_Teacher();
			loginTeacherForm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Login_Student loginStudentForm = new Login_Student();
			loginStudentForm.Show();
		}
	}
}
