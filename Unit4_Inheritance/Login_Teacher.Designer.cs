namespace Unit4_Inheritance
{
	partial class Login_Teacher
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
			txt_emailTeacher = new TextBox();
			label6 = new Label();
			btn_saveTeacher = new Button();
			txt_university_degree = new TextBox();
			label4 = new Label();
			txt_ageTeacher = new TextBox();
			label3 = new Label();
			txtmother_lastname_T = new TextBox();
			xd = new Label();
			label = new Label();
			txtpaternal_lastname_T = new TextBox();
			label2 = new Label();
			txtNamesTeacher = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// txt_emailTeacher
			// 
			txt_emailTeacher.ForeColor = Color.Black;
			txt_emailTeacher.Location = new Point(262, 106);
			txt_emailTeacher.Name = "txt_emailTeacher";
			txt_emailTeacher.Size = new Size(276, 23);
			txt_emailTeacher.TabIndex = 31;
			txt_emailTeacher.TextChanged += txt_emailTeacher_TextChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.Navy;
			label6.Location = new Point(368, 82);
			label6.Name = "label6";
			label6.Size = new Size(53, 21);
			label6.TabIndex = 30;
			label6.Text = "Email";
			// 
			// btn_saveTeacher
			// 
			btn_saveTeacher.BackColor = Color.OliveDrab;
			btn_saveTeacher.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_saveTeacher.ForeColor = SystemColors.ButtonFace;
			btn_saveTeacher.Location = new Point(346, 350);
			btn_saveTeacher.Name = "btn_saveTeacher";
			btn_saveTeacher.Size = new Size(120, 56);
			btn_saveTeacher.TabIndex = 29;
			btn_saveTeacher.Text = "Save";
			btn_saveTeacher.UseVisualStyleBackColor = false;
			btn_saveTeacher.Click += btn_saveTeacher_Click;
			// 
			// txt_university_degree
			// 
			txt_university_degree.ForeColor = Color.Black;
			txt_university_degree.Location = new Point(511, 257);
			txt_university_degree.Name = "txt_university_degree";
			txt_university_degree.Size = new Size(191, 23);
			txt_university_degree.TabIndex = 26;
			txt_university_degree.TextChanged += txt_university_degree_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.Navy;
			label4.Location = new Point(511, 233);
			label4.Name = "label4";
			label4.Size = new Size(151, 21);
			label4.TabIndex = 25;
			label4.Text = "University Degree";
			// 
			// txt_ageTeacher
			// 
			txt_ageTeacher.ForeColor = Color.Black;
			txt_ageTeacher.Location = new Point(511, 173);
			txt_ageTeacher.Name = "txt_ageTeacher";
			txt_ageTeacher.Size = new Size(191, 23);
			txt_ageTeacher.TabIndex = 24;
			txt_ageTeacher.TextChanged += txt_ageTeacher_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Navy;
			label3.Location = new Point(511, 149);
			label3.Name = "label3";
			label3.Size = new Size(40, 21);
			label3.TabIndex = 23;
			label3.Text = "Age";
			// 
			// txtmother_lastname_T
			// 
			txtmother_lastname_T.Location = new Point(104, 303);
			txtmother_lastname_T.Name = "txtmother_lastname_T";
			txtmother_lastname_T.Size = new Size(191, 23);
			txtmother_lastname_T.TabIndex = 22;
			txtmother_lastname_T.TextChanged += txtmother_lastname_T_TextChanged;
			// 
			// xd
			// 
			xd.AutoSize = true;
			xd.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			xd.ForeColor = Color.Navy;
			xd.Location = new Point(99, 279);
			xd.Name = "xd";
			xd.Size = new Size(244, 21);
			xd.TabIndex = 21;
			xd.Text = "Enter the Mother's Last Name";
			// 
			// label
			// 
			label.AutoSize = true;
			label.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label.ForeColor = Color.Navy;
			label.Location = new Point(104, 213);
			label.Name = "label";
			label.Size = new Size(239, 21);
			label.TabIndex = 20;
			label.Text = "Enter the Paternal Last Name";
			// 
			// txtpaternal_lastname_T
			// 
			txtpaternal_lastname_T.Location = new Point(104, 237);
			txtpaternal_lastname_T.Name = "txtpaternal_lastname_T";
			txtpaternal_lastname_T.Size = new Size(191, 23);
			txtpaternal_lastname_T.TabIndex = 19;
			txtpaternal_lastname_T.TextChanged += txtpaternal_lastname_T_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.DarkTurquoise;
			label2.Location = new Point(262, 44);
			label2.Name = "label2";
			label2.Size = new Size(275, 29);
			label2.TabIndex = 18;
			label2.Text = "Teacher Information";
			// 
			// txtNamesTeacher
			// 
			txtNamesTeacher.ForeColor = Color.Black;
			txtNamesTeacher.Location = new Point(104, 173);
			txtNamesTeacher.Name = "txtNamesTeacher";
			txtNamesTeacher.Size = new Size(191, 23);
			txtNamesTeacher.TabIndex = 17;
			txtNamesTeacher.TextChanged += txtNamesTeacher_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Navy;
			label1.Location = new Point(104, 149);
			label1.Name = "label1";
			label1.Size = new Size(144, 21);
			label1.TabIndex = 16;
			label1.Text = "Enter first names";
			// 
			// Login_Teacher
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(txt_emailTeacher);
			Controls.Add(label6);
			Controls.Add(btn_saveTeacher);
			Controls.Add(txt_university_degree);
			Controls.Add(label4);
			Controls.Add(txt_ageTeacher);
			Controls.Add(label3);
			Controls.Add(txtmother_lastname_T);
			Controls.Add(xd);
			Controls.Add(label);
			Controls.Add(txtpaternal_lastname_T);
			Controls.Add(label2);
			Controls.Add(txtNamesTeacher);
			Controls.Add(label1);
			Name = "Login_Teacher";
			Text = "Login_Teacher";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txt_emailTeacher;
		private Label label6;
		private Button btn_saveTeacher;
		private TextBox txt_university_degree;
		private Label label4;
		private TextBox txt_ageTeacher;
		private Label label3;
		private TextBox txtmother_lastname_T;
		private Label xd;
		private Label label;
		private TextBox txtpaternal_lastname_T;
		private Label label2;
		private TextBox txtNamesTeacher;
		private Label label1;
	}
}