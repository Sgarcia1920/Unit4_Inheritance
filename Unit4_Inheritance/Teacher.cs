using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4_Inheritance
{
	internal class Teacher:Institutional_person
	{
		protected string university_degree;

		public string University_degree
		{
			get { return university_degree; }
			set { university_degree = value; }
		}

		public Teacher() : base()
		{
			
			this.university_degree = "Nothing is entered";

		}
		public Teacher(string name, string paternalSurname, string motherSurname, int age, string email, string university_degree) : base(name, paternalSurname, motherSurname, age, email)
		{
			this.university_degree = university_degree;
		}

		public override string ToString()
		{
			return base.ToString() + "\nUniversity degree: " + university_degree;
		}



	}
}
