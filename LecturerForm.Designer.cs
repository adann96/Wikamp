namespace Wikamp
{
    partial class LecturerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerForm));
            this.nameAndSurname = new System.Windows.Forms.Label();
            this.labelNazwaWydzialu = new System.Windows.Forms.Label();
            this.labelWydzial = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.labelConnection = new System.Windows.Forms.Label();
            this.subjectsList = new System.Windows.Forms.ComboBox();
            this.listaIndeksów = new System.Windows.Forms.ComboBox();
            this.studentGradesFromSubject = new System.Windows.Forms.DataGridView();
            this.dispGrades = new System.Windows.Forms.Button();
            this.gradeUpd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradesFromSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // nameAndSurname
            // 
            this.nameAndSurname.AutoSize = true;
            this.nameAndSurname.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nameAndSurname.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameAndSurname.Location = new System.Drawing.Point(56, 423);
            this.nameAndSurname.Name = "nameAndSurname";
            this.nameAndSurname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameAndSurname.Size = new System.Drawing.Size(158, 15);
            this.nameAndSurname.TabIndex = 20;
            this.nameAndSurname.Text = "Patryk Eustachy Badowski";
            this.nameAndSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNazwaWydzialu
            // 
            this.labelNazwaWydzialu.AutoSize = true;
            this.labelNazwaWydzialu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelNazwaWydzialu.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwaWydzialu.Location = new System.Drawing.Point(76, 9);
            this.labelNazwaWydzialu.Name = "labelNazwaWydzialu";
            this.labelNazwaWydzialu.Size = new System.Drawing.Size(354, 15);
            this.labelNazwaWydzialu.TabIndex = 17;
            this.labelNazwaWydzialu.Text = "Wydział Elektrotechniki, Elektroniki, Informatyki i Automatyki";
            // 
            // labelWydzial
            // 
            this.labelWydzial.AutoSize = true;
            this.labelWydzial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelWydzial.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWydzial.Location = new System.Drawing.Point(12, 9);
            this.labelWydzial.Name = "labelWydzial";
            this.labelWydzial.Size = new System.Drawing.Size(56, 15);
            this.labelWydzial.TabIndex = 16;
            this.labelWydzial.Text = "Wydział:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(252, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelConnectionStatus.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelConnectionStatus.Location = new System.Drawing.Point(914, 9);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(57, 15);
            this.labelConnectionStatus.TabIndex = 30;
            this.labelConnectionStatus.Text = "Succeed";
            this.labelConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelConnection.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelConnection.Location = new System.Drawing.Point(832, 9);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(76, 15);
            this.labelConnection.TabIndex = 29;
            this.labelConnection.Text = "Connection:";
            // 
            // subjectsList
            // 
            this.subjectsList.FormattingEnabled = true;
            this.subjectsList.Location = new System.Drawing.Point(270, 39);
            this.subjectsList.Name = "subjectsList";
            this.subjectsList.Size = new System.Drawing.Size(121, 21);
            this.subjectsList.TabIndex = 31;
            this.subjectsList.SelectedIndexChanged += new System.EventHandler(this.listaPrzedmiotow_SelectedIndexChanged);
            // 
            // listaIndeksów
            // 
            this.listaIndeksów.FormattingEnabled = true;
            this.listaIndeksów.Location = new System.Drawing.Point(270, 67);
            this.listaIndeksów.Name = "listaIndeksów";
            this.listaIndeksów.Size = new System.Drawing.Size(121, 21);
            this.listaIndeksów.TabIndex = 32;
            // 
            // studentGradesFromSubject
            // 
            this.studentGradesFromSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGradesFromSubject.Location = new System.Drawing.Point(270, 94);
            this.studentGradesFromSubject.Name = "studentGradesFromSubject";
            this.studentGradesFromSubject.Size = new System.Drawing.Size(690, 344);
            this.studentGradesFromSubject.TabIndex = 33;
            // 
            // dispGrades
            // 
            this.dispGrades.Location = new System.Drawing.Point(270, 444);
            this.dispGrades.Name = "dispGrades";
            this.dispGrades.Size = new System.Drawing.Size(121, 23);
            this.dispGrades.TabIndex = 34;
            this.dispGrades.Text = "Display Grades";
            this.dispGrades.UseVisualStyleBackColor = true;
            this.dispGrades.Click += new System.EventHandler(this.dispGrades_Click);
            // 
            // gradeUpd
            // 
            this.gradeUpd.Location = new System.Drawing.Point(397, 444);
            this.gradeUpd.Name = "gradeUpd";
            this.gradeUpd.Size = new System.Drawing.Size(121, 23);
            this.gradeUpd.TabIndex = 35;
            this.gradeUpd.Text = "Add or Mod Grade";
            this.gradeUpd.UseVisualStyleBackColor = true;
            this.gradeUpd.Click += new System.EventHandler(this.gradeUpd_Click);
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(969, 474);
            this.Controls.Add(this.gradeUpd);
            this.Controls.Add(this.dispGrades);
            this.Controls.Add(this.studentGradesFromSubject);
            this.Controls.Add(this.listaIndeksów);
            this.Controls.Add(this.subjectsList);
            this.Controls.Add(this.labelConnectionStatus);
            this.Controls.Add(this.labelConnection);
            this.Controls.Add(this.nameAndSurname);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNazwaWydzialu);
            this.Controls.Add(this.labelWydzial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LecturerForm";
            this.Text = "LecturerForm";
            this.Load += new System.EventHandler(this.LecturerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradesFromSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameAndSurname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNazwaWydzialu;
        private System.Windows.Forms.Label labelWydzial;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.ComboBox subjectsList;
        private System.Windows.Forms.ComboBox listaIndeksów;
        private System.Windows.Forms.DataGridView studentGradesFromSubject;
        private System.Windows.Forms.Button dispGrades;
        private System.Windows.Forms.Button gradeUpd;
    }
}