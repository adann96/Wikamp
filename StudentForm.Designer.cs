namespace Wikamp
{
    partial class StudentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.labelWydzial = new System.Windows.Forms.Label();
            this.labelNazwaWydzialu = new System.Windows.Forms.Label();
            this.labelConnection = new System.Windows.Forms.Label();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nameAndSurname = new System.Windows.Forms.Label();
            this.kierunek = new System.Windows.Forms.Label();
            this.facultyName = new System.Windows.Forms.Label();
            this.indexNo = new System.Windows.Forms.Label();
            this.indexNoName = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.addressName = new System.Windows.Forms.Label();
            this.miejsceZamieszkania = new System.Windows.Forms.Label();
            this.miejsceZamieszkaniaName = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.semestersList = new System.Windows.Forms.ComboBox();
            this.gradesDisplay = new System.Windows.Forms.DataGridView();
            this.feeList = new System.Windows.Forms.ComboBox();
            this.feeDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWydzial
            // 
            this.labelWydzial.AutoSize = true;
            this.labelWydzial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelWydzial.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWydzial.Location = new System.Drawing.Point(14, 10);
            this.labelWydzial.Name = "labelWydzial";
            this.labelWydzial.Size = new System.Drawing.Size(56, 15);
            this.labelWydzial.TabIndex = 0;
            this.labelWydzial.Text = "Wydział:";
            // 
            // labelNazwaWydzialu
            // 
            this.labelNazwaWydzialu.AutoSize = true;
            this.labelNazwaWydzialu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelNazwaWydzialu.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwaWydzialu.Location = new System.Drawing.Point(78, 10);
            this.labelNazwaWydzialu.Name = "labelNazwaWydzialu";
            this.labelNazwaWydzialu.Size = new System.Drawing.Size(354, 15);
            this.labelNazwaWydzialu.TabIndex = 1;
            this.labelNazwaWydzialu.Text = "Wydział Elektrotechniki, Elektroniki, Informatyki i Automatyki";
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelConnection.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelConnection.Location = new System.Drawing.Point(929, 10);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(76, 15);
            this.labelConnection.TabIndex = 2;
            this.labelConnection.Text = "Connection:";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelConnectionStatus.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelConnectionStatus.Location = new System.Drawing.Point(1011, 10);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(57, 15);
            this.labelConnectionStatus.TabIndex = 4;
            this.labelConnectionStatus.Text = "Succeed";
            this.labelConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(252, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // nameAndSurname
            // 
            this.nameAndSurname.AutoSize = true;
            this.nameAndSurname.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nameAndSurname.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameAndSurname.Location = new System.Drawing.Point(61, 412);
            this.nameAndSurname.Name = "nameAndSurname";
            this.nameAndSurname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameAndSurname.Size = new System.Drawing.Size(158, 15);
            this.nameAndSurname.TabIndex = 7;
            this.nameAndSurname.Text = "Patryk Eustachy Badowski";
            this.nameAndSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kierunek
            // 
            this.kierunek.AutoSize = true;
            this.kierunek.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.kierunek.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kierunek.Location = new System.Drawing.Point(17, 440);
            this.kierunek.Name = "kierunek";
            this.kierunek.Size = new System.Drawing.Size(61, 15);
            this.kierunek.TabIndex = 8;
            this.kierunek.Text = "Kierunek:";
            // 
            // facultyName
            // 
            this.facultyName.AutoSize = true;
            this.facultyName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.facultyName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.facultyName.Location = new System.Drawing.Point(82, 440);
            this.facultyName.Name = "facultyName";
            this.facultyName.Size = new System.Drawing.Size(75, 15);
            this.facultyName.TabIndex = 9;
            this.facultyName.Text = "Informatyka";
            // 
            // indexNo
            // 
            this.indexNo.AutoSize = true;
            this.indexNo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.indexNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.indexNo.Location = new System.Drawing.Point(17, 465);
            this.indexNo.Name = "indexNo";
            this.indexNo.Size = new System.Drawing.Size(99, 15);
            this.indexNo.TabIndex = 10;
            this.indexNo.Text = "Numer Indeksu: ";
            // 
            // indexNoName
            // 
            this.indexNoName.AutoSize = true;
            this.indexNoName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.indexNoName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.indexNoName.Location = new System.Drawing.Point(124, 465);
            this.indexNoName.Name = "indexNoName";
            this.indexNoName.Size = new System.Drawing.Size(49, 15);
            this.indexNoName.TabIndex = 11;
            this.indexNoName.Text = "212298";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.address.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.address.Location = new System.Drawing.Point(17, 490);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(44, 15);
            this.address.TabIndex = 12;
            this.address.Text = "Adres:";
            // 
            // addressName
            // 
            this.addressName.AutoSize = true;
            this.addressName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addressName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addressName.Location = new System.Drawing.Point(68, 490);
            this.addressName.Name = "addressName";
            this.addressName.Size = new System.Drawing.Size(92, 15);
            this.addressName.TabIndex = 13;
            this.addressName.Text = "ul. Krzywa 10/1";
            // 
            // miejsceZamieszkania
            // 
            this.miejsceZamieszkania.AutoSize = true;
            this.miejsceZamieszkania.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.miejsceZamieszkania.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miejsceZamieszkania.Location = new System.Drawing.Point(17, 516);
            this.miejsceZamieszkania.Name = "miejsceZamieszkania";
            this.miejsceZamieszkania.Size = new System.Drawing.Size(136, 15);
            this.miejsceZamieszkania.TabIndex = 14;
            this.miejsceZamieszkania.Text = "Miejsce Zamieszkania:";
            // 
            // miejsceZamieszkaniaName
            // 
            this.miejsceZamieszkaniaName.AutoSize = true;
            this.miejsceZamieszkaniaName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.miejsceZamieszkaniaName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miejsceZamieszkaniaName.Location = new System.Drawing.Point(159, 516);
            this.miejsceZamieszkaniaName.Name = "miejsceZamieszkaniaName";
            this.miejsceZamieszkaniaName.Size = new System.Drawing.Size(74, 15);
            this.miejsceZamieszkaniaName.TabIndex = 15;
            this.miejsceZamieszkaniaName.Text = "Las Palmas";
            // 
            // semestersList
            // 
            this.semestersList.FormattingEnabled = true;
            this.semestersList.Items.AddRange(new object[] {
            "Semestr 1",
            "Semestr 2",
            "Semestr 3",
            "Semestr 4",
            "Semestr 5",
            "Semestr 6",
            "Semestr 7",
            "Semestr 8"});
            this.semestersList.Location = new System.Drawing.Point(276, 40);
            this.semestersList.Name = "semestersList";
            this.semestersList.Size = new System.Drawing.Size(140, 23);
            this.semestersList.TabIndex = 16;
            this.semestersList.SelectedIndexChanged += new System.EventHandler(this.semestersList_SelectedIndexChanged);
            // 
            // gradesDisplay
            // 
            this.gradesDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesDisplay.Location = new System.Drawing.Point(276, 72);
            this.gradesDisplay.Name = "gradesDisplay";
            this.gradesDisplay.Size = new System.Drawing.Size(790, 314);
            this.gradesDisplay.TabIndex = 17;
            // 
            // feeList
            // 
            this.feeList.FormattingEnabled = true;
            this.feeList.Items.AddRange(new object[] {
            "Semestr 1",
            "Semestr 2",
            "Semestr 3",
            "Semestr 4",
            "Semestr 5",
            "Semestr 6",
            "Semestr 7",
            "Semestr 8"});
            this.feeList.Location = new System.Drawing.Point(276, 403);
            this.feeList.Name = "feeList";
            this.feeList.Size = new System.Drawing.Size(140, 23);
            this.feeList.TabIndex = 18;
            this.feeList.SelectedIndexChanged += new System.EventHandler(this.feeList_SelectedIndexChanged);
            // 
            // feeDisplay
            // 
            this.feeDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feeDisplay.Location = new System.Drawing.Point(276, 440);
            this.feeDisplay.Name = "feeDisplay";
            this.feeDisplay.Size = new System.Drawing.Size(790, 127);
            this.feeDisplay.TabIndex = 19;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1074, 595);
            this.Controls.Add(this.feeDisplay);
            this.Controls.Add(this.feeList);
            this.Controls.Add(this.gradesDisplay);
            this.Controls.Add(this.semestersList);
            this.Controls.Add(this.miejsceZamieszkaniaName);
            this.Controls.Add(this.miejsceZamieszkania);
            this.Controls.Add(this.addressName);
            this.Controls.Add(this.address);
            this.Controls.Add(this.indexNoName);
            this.Controls.Add(this.indexNo);
            this.Controls.Add(this.facultyName);
            this.Controls.Add(this.kierunek);
            this.Controls.Add(this.nameAndSurname);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelConnectionStatus);
            this.Controls.Add(this.labelConnection);
            this.Controls.Add(this.labelNazwaWydzialu);
            this.Controls.Add(this.labelWydzial);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWydzial;
        private System.Windows.Forms.Label labelNazwaWydzialu;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nameAndSurname;
        private System.Windows.Forms.Label kierunek;
        private System.Windows.Forms.Label facultyName;
        private System.Windows.Forms.Label indexNo;
        private System.Windows.Forms.Label indexNoName;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label addressName;
        private System.Windows.Forms.Label miejsceZamieszkania;
        private System.Windows.Forms.Label miejsceZamieszkaniaName;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox semestersList;
        private System.Windows.Forms.DataGridView gradesDisplay;
        private System.Windows.Forms.ComboBox feeList;
        private System.Windows.Forms.DataGridView feeDisplay;
    }
}