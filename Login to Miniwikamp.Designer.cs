namespace Wikamp
{
    partial class loginForm
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
            this.logInTextBox1 = new System.Windows.Forms.TextBox();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.logInButton1 = new System.Windows.Forms.Button();
            this.loginAsStudent = new System.Windows.Forms.Button();
            this.loginAsLecturer = new System.Windows.Forms.Button();
            this.logInTextBox2 = new System.Windows.Forms.TextBox();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.logInButton2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logInTextBox1
            // 
            this.logInTextBox1.Location = new System.Drawing.Point(12, 382);
            this.logInTextBox1.Name = "logInTextBox1";
            this.logInTextBox1.Size = new System.Drawing.Size(152, 20);
            this.logInTextBox1.TabIndex = 0;
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.Location = new System.Drawing.Point(12, 408);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.PasswordChar = '*';
            this.passwordTextBox1.Size = new System.Drawing.Size(152, 20);
            this.passwordTextBox1.TabIndex = 1;
            // 
            // logInButton1
            // 
            this.logInButton1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logInButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logInButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton1.Location = new System.Drawing.Point(12, 434);
            this.logInButton1.Name = "logInButton1";
            this.logInButton1.Size = new System.Drawing.Size(152, 42);
            this.logInButton1.TabIndex = 2;
            this.logInButton1.Text = "LogIn";
            this.logInButton1.UseVisualStyleBackColor = false;
            this.logInButton1.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // loginAsStudent
            // 
            this.loginAsStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginAsStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginAsStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAsStudent.Location = new System.Drawing.Point(12, 334);
            this.loginAsStudent.Name = "loginAsStudent";
            this.loginAsStudent.Size = new System.Drawing.Size(152, 42);
            this.loginAsStudent.TabIndex = 3;
            this.loginAsStudent.Text = "Login as a student";
            this.loginAsStudent.UseVisualStyleBackColor = false;
            this.loginAsStudent.Click += new System.EventHandler(this.loginAsStudent_Click);
            // 
            // loginAsLecturer
            // 
            this.loginAsLecturer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginAsLecturer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginAsLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAsLecturer.Location = new System.Drawing.Point(200, 334);
            this.loginAsLecturer.Name = "loginAsLecturer";
            this.loginAsLecturer.Size = new System.Drawing.Size(152, 42);
            this.loginAsLecturer.TabIndex = 4;
            this.loginAsLecturer.Text = "Login as a lecturer";
            this.loginAsLecturer.UseVisualStyleBackColor = false;
            this.loginAsLecturer.Click += new System.EventHandler(this.loginAsLecturer_Click);
            // 
            // logInTextBox2
            // 
            this.logInTextBox2.Location = new System.Drawing.Point(200, 382);
            this.logInTextBox2.Name = "logInTextBox2";
            this.logInTextBox2.Size = new System.Drawing.Size(152, 20);
            this.logInTextBox2.TabIndex = 7;
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Location = new System.Drawing.Point(200, 408);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '*';
            this.passwordTextBox2.Size = new System.Drawing.Size(152, 20);
            this.passwordTextBox2.TabIndex = 8;
            // 
            // logInButton2
            // 
            this.logInButton2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logInButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logInButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton2.Location = new System.Drawing.Point(200, 457);
            this.logInButton2.Name = "logInButton2";
            this.logInButton2.Size = new System.Drawing.Size(152, 42);
            this.logInButton2.TabIndex = 9;
            this.logInButton2.Text = "LogIn";
            this.logInButton2.UseVisualStyleBackColor = false;
            this.logInButton2.Click += new System.EventHandler(this.logInButton2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Wikamp.Properties.Resources.pł;
            this.pictureBox3.InitialImage = global::Wikamp.Properties.Resources.pł;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(340, 155);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Wikamp.Properties.Resources.teacher_school_student_professor_produce_organic_male_512;
            this.pictureBox2.InitialImage = global::Wikamp.Properties.Resources.teacher_school_student_professor_produce_organic_male_512;
            this.pictureBox2.Location = new System.Drawing.Point(200, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Wikamp.Properties.Resources.student__graduation__degree__hat__education_512;
            this.pictureBox1.Location = new System.Drawing.Point(12, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(217, 434);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(123, 17);
            this.adminCheckBox.TabIndex = 12;
            this.adminCheckBox.Text = "I am an administrator";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 513);
            this.Controls.Add(this.adminCheckBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.logInButton2);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.logInTextBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginAsLecturer);
            this.Controls.Add(this.loginAsStudent);
            this.Controls.Add(this.logInButton1);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(this.logInTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "loginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logInTextBox1;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.Button logInButton1;
        private System.Windows.Forms.Button loginAsStudent;
        private System.Windows.Forms.Button loginAsLecturer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox logInTextBox2;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.Button logInButton2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox adminCheckBox;
    }
}

