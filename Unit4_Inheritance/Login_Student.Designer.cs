namespace Unit4_Inheritance
{
	partial class Login_Student
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
			label1 = new Label();
			txtNames = new TextBox();
			label2 = new Label();
			txtpaternal_lastname = new TextBox();
			label = new Label();
			xd = new Label();
			txtmother_lastname = new TextBox();
			label3 = new Label();
			txt_age = new TextBox();
			label4 = new Label();
			txt_semester = new TextBox();
			txt_speciality = new TextBox();
			label5 = new Label();
			btn_save = new Button();
			txt_email = new TextBox();
			label6 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Navy;
			label1.Location = new Point(70, 128);
			label1.Name = "label1";
			label1.Size = new Size(144, 21);
			label1.TabIndex = 0;
			label1.Text = "Enter first names";
			// 
			// txtNames
			// 
			txtNames.ForeColor = Color.Black;
			txtNames.Location = new Point(70, 152);
			txtNames.Name = "txtNames";
			txtNames.Size = new Size(191, 23);
			txtNames.TabIndex = 1;
			txtNames.TextChanged += txtNames_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.DarkTurquoise;
			label2.Location = new Point(228, 23);
			label2.Name = "label2";
			label2.Size = new Size(273, 29);
			label2.TabIndex = 2;
			label2.Text = "Student Information";
			// 
			// txtpaternal_lastname
			// 
			txtpaternal_lastname.Location = new Point(70, 216);
			txtpaternal_lastname.Name = "txtpaternal_lastname";
			txtpaternal_lastname.Size = new Size(191, 23);
			txtpaternal_lastname.TabIndex = 3;
			txtpaternal_lastname.TextChanged += txtpaternal_lastname_TextChanged;
			// 
			// label
			// 
			label.AutoSize = true;
			label.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label.ForeColor = Color.Navy;
			label.Location = new Point(70, 192);
			label.Name = "label";
			label.Size = new Size(239, 21);
			label.TabIndex = 4;
			label.Text = "Enter the Paternal Last Name";
			// 
			// xd
			// 
			xd.AutoSize = true;
			xd.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			xd.ForeColor = Color.Navy;
			xd.Location = new Point(65, 258);
			xd.Name = "xd";
			xd.Size = new Size(244, 21);
			xd.TabIndex = 5;
			xd.Text = "Enter the Mother's Last Name";
			// 
			// txtmother_lastname
			// 
			txtmother_lastname.Location = new Point(70, 282);
			txtmother_lastname.Name = "txtmother_lastname";
			txtmother_lastname.Size = new Size(191, 23);
			txtmother_lastname.TabIndex = 6;
			txtmother_lastname.TextChanged += textBox1_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Navy;
			label3.Location = new Point(477, 128);
			label3.Name = "label3";
			label3.Size = new Size(40, 21);
			label3.TabIndex = 7;
			label3.Text = "Age";
			// 
			// txt_age
			// 
			txt_age.ForeColor = Color.Black;
			txt_age.Location = new Point(477, 152);
			txt_age.Name = "txt_age";
			txt_age.Size = new Size(191, 23);
			txt_age.TabIndex = 8;
			txt_age.TextChanged += txt_age_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.Navy;
			label4.Location = new Point(477, 192);
			label4.Name = "label4";
			label4.Size = new Size(159, 21);
			label4.TabIndex = 9;
			label4.Text = "Semester(Number)";
			// 
			// txt_semester
			// 
			txt_semester.ForeColor = Color.Black;
			txt_semester.Location = new Point(477, 216);
			txt_semester.Name = "txt_semester";
			txt_semester.Size = new Size(191, 23);
			txt_semester.TabIndex = 10;
			txt_semester.TextChanged += txt_semester_TextChanged;
			// 
			// txt_speciality
			// 
			txt_speciality.ForeColor = Color.Black;
			txt_speciality.Location = new Point(477, 282);
			txt_speciality.Name = "txt_speciality";
			txt_speciality.Size = new Size(191, 23);
			txt_speciality.TabIndex = 12;
			txt_speciality.TextChanged += txt_speciality_TextChanged_1;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.Navy;
			label5.Location = new Point(477, 258);
			label5.Name = "label5";
			label5.Size = new Size(62, 21);
			label5.TabIndex = 11;
			label5.Text = "Career";
			// 
			// btn_save
			// 
			btn_save.BackColor = Color.OliveDrab;
			btn_save.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_save.ForeColor = SystemColors.ButtonFace;
			btn_save.Location = new Point(312, 329);
			btn_save.Name = "btn_save";
			btn_save.Size = new Size(120, 56);
			btn_save.TabIndex = 13;
			btn_save.Text = "Save";
			btn_save.UseVisualStyleBackColor = false;
			btn_save.Click += btn_save_Click;
			// 
			// txt_email
			// 
			txt_email.ForeColor = Color.Black;
			txt_email.Location = new Point(228, 85);
			txt_email.Name = "txt_email";
			txt_email.Size = new Size(276, 23);
			txt_email.TabIndex = 15;
			txt_email.TextChanged += txt_email_TextChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.Navy;
			label6.Location = new Point(334, 61);
			label6.Name = "label6";
			label6.Size = new Size(53, 21);
			label6.TabIndex = 14;
			label6.Text = "Email";
			// 
			// Login_Student
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(748, 453);
			Controls.Add(txt_email);
			Controls.Add(label6);
			Controls.Add(btn_save);
			Controls.Add(txt_speciality);
			Controls.Add(label5);
			Controls.Add(txt_semester);
			Controls.Add(label4);
			Controls.Add(txt_age);
			Controls.Add(label3);
			Controls.Add(txtmother_lastname);
			Controls.Add(xd);
			Controls.Add(label);
			Controls.Add(txtpaternal_lastname);
			Controls.Add(label2);
			Controls.Add(txtNames);
			Controls.Add(label1);
			Name = "Login_Student";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login_Student";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtNames;
		private Label label2;
		private TextBox txtpaternal_lastname;
		private Label label;
		private Label xd;
		private TextBox txtmother_lastname;
		private Label label3;
		private TextBox txt_age;
		private Label label4;
		private TextBox txt_semester;
		private TextBox txt_speciality;
		private Label label5;
		private Button btn_save;
		private TextBox txt_email;
		private Label label6;
	}
}