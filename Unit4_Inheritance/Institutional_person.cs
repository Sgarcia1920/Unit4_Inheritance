using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4_Inheritance
{
	internal class Institutional_person
	{
		protected string name;

		public string Names
		{
			get { return name; }
			set { name = value; }
		}
		protected string paternal_lastname;

		public string First_lastname
		{
			get { return paternal_lastname; }
			set { paternal_lastname = value; }
		}
		protected string mother_lastname;

		public string Second_lastname
		{
			get { return mother_lastname; }
			set { mother_lastname = value; }
		}

		protected int age;

		public int Ages
		{
			get { return age; }
			set { age = value; }
		}
		protected string e_mail;
		public string E_mail
			{
			get { return e_mail; }
			set { e_mail = value; }
		}
		
		public Institutional_person()
		{
			this.name = "Nothing is entered";
			this.paternal_lastname = "Nothing is entered";
			this.mother_lastname = "Nothing is entered";
			this.age = 0;
			this.e_mail = "Nothing is entered";

		}
		public Institutional_person(string name,string paternal_surname,string mother_surname,int age, string email)
		{
			this.name = name;
			this.paternal_lastname = paternal_surname;
			this.mother_lastname =mother_surname;
			this.age = age;
			this.e_mail = email;
		}

		public override string ToString()
		{
			return "" + "Registered at "+ name + " " +paternal_lastname+ "" + mother_lastname + ";"+ age+ " years";
		}



	}
}
