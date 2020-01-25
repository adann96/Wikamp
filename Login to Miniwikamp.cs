using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Wikamp
{
    public partial class loginForm : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand1, sqlCommand2;
        SqlDataReader sqlDataReader1;

        public loginForm()
        {
            InitializeComponent();
            passwordTextBox1.Visible = false;
            logInTextBox1.Visible = false;
            logInButton1.Visible = false;

            passwordTextBox2.Visible = false;
            logInTextBox2.Visible = false;
            logInButton2.Visible = false;
            adminCheckBox.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new SqlConnection(@"Data Source=DESKTOP-N69JGE9\UNIOFTECHN;Initial Catalog=univ_db;Integrated Security=True");
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand1 = new SqlCommand("select studenci.NUMER_INDEKSU, studenci.PASSWORD_ACC, studenci.IMIE, studenci.NAZWISKO, kierunki.NAZWA, studenci.ULICA, studenci.BLOK_NR, studenci.MIESZKANIE_NR, studenci.MIASTO, studenci.KOD, wydzialy.NAZWA from studenci inner join kierunki on kierunki.KIERUNEK_ID = studenci.KIERUNEK_ID inner join wydzialy on wydzialy.WYDZIAL_ID = kierunki.WYDZIAL_ID where studenci.NUMER_INDEKSU = " + logInTextBox1.Text + " and studenci.PASSWORD_ACC = '" + passwordTextBox1.Text + "';", sqlConnection);
                sqlDataReader1 = sqlCommand1.ExecuteReader();
                
                while (sqlDataReader1.Read())
                {
                    if (sqlDataReader1.GetValue(0).ToString().Equals(logInTextBox1.Text.ToString().Trim()) && sqlDataReader1.GetValue(1).ToString().Equals(passwordTextBox1.Text.ToString().Trim()))
                    {
                        Student student = new Student(sqlDataReader1.GetValue(0).ToString(), sqlDataReader1.GetValue(1).ToString(), sqlDataReader1.GetValue(2).ToString(), sqlDataReader1.GetValue(3).ToString(), sqlDataReader1.GetValue(4).ToString(), sqlDataReader1.GetValue(5).ToString(), sqlDataReader1.GetValue(6).ToString(), sqlDataReader1.GetValue(7).ToString(), sqlDataReader1.GetValue(8).ToString(), sqlDataReader1.GetValue(9).ToString(), sqlDataReader1.GetValue(10).ToString());
                        
                        MessageBox.Show("Login Succesfully!");
                        StudentForm studentForm = new StudentForm(student, sqlConnection);

                        studentForm.Show();
                        studentForm.Activate();
                    }
                    else
                    {
                        MessageBox.Show("You've entered wrong credentials!");
                    }
                }
                sqlDataReader1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loginAsStudent_Click(object sender, EventArgs e)
        {
            passwordTextBox1.Visible = true;
            logInTextBox1.Visible = true;
            logInButton1.Visible = true;

            passwordTextBox2.Visible = false;
            logInTextBox2.Visible = false;
            logInButton2.Visible = false;
            adminCheckBox.Visible = false;
        }

        private void loginAsLecturer_Click(object sender, EventArgs e)
        {
            passwordTextBox1.Visible = false;
            logInTextBox1.Visible = false;
            logInButton1.Visible = false;

            passwordTextBox2.Visible = true;
            logInTextBox2.Visible = true;
            logInButton2.Visible = true;
            adminCheckBox.Visible = true;
        }

        private void logInButton2_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand2 = new SqlCommand("select WYKLADOWCA_ID,PASSWORD_ACC,IsAdmin, Imie, Nazwisko, stopien from wykladowcy where WYKLADOWCA_ID = " + logInTextBox2.Text + " and PASSWORD_ACC = '" + 
                    passwordTextBox2.Text + "';", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    if (sqlDataReader.GetValue(0).ToString().Equals(logInTextBox2.Text.ToString()) && sqlDataReader.GetValue(1).ToString().Equals(passwordTextBox2.Text.ToString()))
                    {
                        if (adminCheckBox.Checked == true && sqlDataReader.GetValue(2).ToString().Equals("yes"))
                        {
                            MessageBox.Show("Login Succesfully!");
                        }
                        else if (adminCheckBox.Checked == false && sqlDataReader.GetValue(2).ToString().Equals("no"))
                        {
                            Lecturer lecturer = new Lecturer(sqlDataReader.GetValue(5).ToString(), sqlDataReader.GetValue(3).ToString(), sqlDataReader.GetValue(4).ToString(), sqlDataReader.GetValue(0).ToString(), sqlDataReader.GetValue(1).ToString());
                            MessageBox.Show("Login Succesfully!");

                            LecturerForm lecturerForm = new LecturerForm(lecturer, sqlConnection);
                            sqlDataReader.Close();
                            sqlDataReader.Dispose();

                            lecturerForm.Show();
                            lecturerForm.Activate();
                        }
                        else
                        {
                            MessageBox.Show("You've entered wrong credentials!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You've entered wrong credentials!");
                }
                sqlDataReader.Close();
            }               
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
