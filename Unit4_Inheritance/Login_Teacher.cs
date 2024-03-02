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
	public partial class Login_Teacher : Form
	{
		Teacher teacher_1 = new Teacher();
		public Login_Teacher()
		{
			InitializeComponent();
		}

		private void txt_emailTeacher_TextChanged(object sender, EventArgs e)
		{
			teacher_1.E_mail = txt_emailTeacher.Text;
		}

		private void txtNamesTeacher_TextChanged(object sender, EventArgs e)
		{
			teacher_1.Names = txtNamesTeacher.Text;

		}

		private void txtpaternal_lastname_T_TextChanged(object sender, EventArgs e)
		{
			teacher_1.First_lastname = txtpaternal_lastname_T.Text;

		}

		private void txtmother_lastname_T_TextChanged(object sender, EventArgs e)
		{
			teacher_1.Second_lastname = txtmother_lastname_T.Text;

		}

		private void txt_ageTeacher_TextChanged(object sender, EventArgs e)
		{
			if (int.TryParse(txt_ageTeacher.Text, out int age))
			{
				teacher_1.Ages = age;
			}
		}

		private void txt_university_degree_TextChanged(object sender, EventArgs e)
		{
			teacher_1.University_degree = txt_university_degree.Text;

		}

		private void btn_saveTeacher_Click(object sender, EventArgs e)
		{
			MessageBox.Show(teacher_1.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
