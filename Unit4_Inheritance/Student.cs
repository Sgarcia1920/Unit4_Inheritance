using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4_Inheritance
{
	internal class Student : Institutional_person
	{

		protected int semester_number;

		public int Semester
		{
			get { return semester_number; }
			set { semester_number = value; }
		}

		protected string specialty;

		public string University_career
		{
			get { return specialty; }
			set { specialty = value; }
		}

		public Student ():base ()
		{
			this.semester_number = 0;
			this.specialty = "Nothing is entered";

        }
		public Student(string name, string paternalSurname, string motherSurname, int age, string email,string specialty, int semester_num):base(name,paternalSurname,motherSurname,age,email)
		{
			this.semester_number = semester_num;
			this.specialty = specialty;
        }

		public override string ToString()
		{
			return base.ToString() + "  Attends the semester: "+ semester_number+ "  Specialy: "+ specialty ;
		}

	}
}
