using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit4_Inheritance
{
	public partial class Login_Student : Form
	{
		Student student_1 = new Student();
		public Login_Student()
		{
			InitializeComponent();
		}

		private void txtNames_TextChanged(object sender, EventArgs e)
		{
			
			student_1.Names = txtNames.Text;

		}

		private void txtpaternal_lastname_TextChanged(object sender, EventArgs e)
		{
			
			student_1.First_lastname = txtpaternal_lastname.Text;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			student_1.Second_lastname = txtmother_lastname.Text;
		}

		private void txt_age_TextChanged(object sender, EventArgs e)
		{
			
			if (int.TryParse(txt_age.Text, out int age))
			{
				student_1.Ages = age;
			}
		}

		private void txt_semester_TextChanged(object sender, EventArgs e)
		{
			
			if (int.TryParse(txt_semester.Text, out int semester))
			{
				student_1.Semester = semester;
			}
		}

		private void txt_speciality_TextChanged_1(object sender, EventArgs e)
		{
			
			student_1.University_career = txt_speciality.Text;
		}



		private void txt_email_TextChanged(object sender, EventArgs e)
		{
			
			student_1.E_mail = txt_email.Text;
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			MessageBox.Show(student_1.ToString(),"",MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
