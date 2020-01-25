using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Timers;

namespace Wikamp
{
    public partial class StudentForm : Form
    {
        private Student student;
        private SqlConnection sqlConnection;

        public StudentForm(Student student, SqlConnection sqlConnection)
        {
            this.student = student;
            this.sqlConnection = sqlConnection;
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            labelConnectionStatus.Text = sqlConnection.State.ToString();
            gradesDisplay.ReadOnly = true;
            feeDisplay.ReadOnly = true;
            nameAndSurname.Text = student.studentName + " " + student.studentSurname;
            facultyName.Text = student.faculty;
            indexNoName.Text = student.studentLogin;

            if ((student.accNo.Equals("")) || (student.accNo.Equals(null)))
            {
                addressName.Text = "ul. " + student.street + " " + student.accNo;
            }
            else
            {
                addressName.Text = "ul. " + student.street + " " + student.accNo + " m." + student.flatNo;
            }

            miejsceZamieszkaniaName.Text = student.city + ", " + student.postalCode;
            labelNazwaWydzialu.Text = student.wydzial;

        }

        private void semestersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (semestersList.SelectedItem.Equals("Semestr 1"))
                {
                    SqlDataAdapter sqlDataAdapterStudentGrades = new SqlDataAdapter("select przedmioty.NAZWA_PRZEDMIOTU, oceny.Semestr, oceny.WYKLAD_OCENA, oceny.cwicz_ocena, oceny.lab_ocena, oceny.ocena_konc from dbo.oceny inner join studenci on studenci.numer_indeksu = oceny.numer_indeksu inner join dbo.przedmioty on przedmioty.przedmiot_id = oceny.przedmiot_id where studenci.NUMER_INDEKSU = " + student.studentLogin + " and  oceny.Semestr = 1", sqlConnection);
                    DataTable dataTableStudentGrades = new DataTable();
                    sqlDataAdapterStudentGrades.Fill(dataTableStudentGrades);
                    gradesDisplay.DataSource = dataTableStudentGrades;
                }

                else if (semestersList.SelectedItem.Equals("Semestr 2"))
                {
                    SqlDataAdapter sqlDataAdapterStudentGrades = new SqlDataAdapter("select przedmioty.NAZWA_PRZEDMIOTU, oceny.Semestr, oceny.WYKLAD_OCENA, oceny.cwicz_ocena, oceny.lab_ocena, oceny.ocena_konc from dbo.oceny inner join studenci on studenci.numer_indeksu = oceny.numer_indeksu inner join dbo.przedmioty on przedmioty.przedmiot_id = oceny.przedmiot_id where studenci.NUMER_INDEKSU = " + student.studentLogin + " and  oceny.Semestr = 2", sqlConnection);
                    DataTable dataTableStudentGrades = new DataTable();
                    sqlDataAdapterStudentGrades.Fill(dataTableStudentGrades);
                    gradesDisplay.DataSource = dataTableStudentGrades;
                }
                else if (semestersList.SelectedItem.Equals("Semestr 3"))
                {
                    SqlDataAdapter sqlDataAdapterStudentGrades = new SqlDataAdapter("select przedmioty.NAZWA_PRZEDMIOTU, oceny.Semestr, oceny.WYKLAD_OCENA, oceny.cwicz_ocena, oceny.lab_ocena, oceny.ocena_konc from dbo.oceny inner join studenci on studenci.numer_indeksu = oceny.numer_indeksu inner join dbo.przedmioty on przedmioty.przedmiot_id = oceny.przedmiot_id where studenci.NUMER_INDEKSU = " + student.studentLogin + " and  oceny.Semestr = 3", sqlConnection);
                    DataTable dataTableStudentGrades = new DataTable();
                    sqlDataAdapterStudentGrades.Fill(dataTableStudentGrades);
                    gradesDisplay.DataSource = dataTableStudentGrades;
                }
                else if (semestersList.SelectedItem.Equals("Semestr 4"))
                {
                    SqlDataAdapter sqlDataAdapterStudentGrades = new SqlDataAdapter("select przedmioty.NAZWA_PRZEDMIOTU, oceny.Semestr, oceny.WYKLAD_OCENA, oceny.cwicz_ocena, oceny.lab_ocena, oceny.ocena_konc from dbo.oceny inner join studenci on studenci.numer_indeksu = oceny.numer_indeksu inner join dbo.przedmioty on przedmioty.przedmiot_id = oceny.przedmiot_id where studenci.NUMER_INDEKSU = " + student.studentLogin + " and  oceny.Semestr = 4", sqlConnection);
                    DataTable dataTableStudentGrades = new DataTable();
                    sqlDataAdapterStudentGrades.Fill(dataTableStudentGrades);
                    gradesDisplay.DataSource = dataTableStudentGrades;
                }
                else if (semestersList.SelectedItem.Equals("Semestr 5"))
                {
                    SqlDataAdapter sqlDataAdapterStudentGrades = new SqlDataAdapter("select przedmioty.NAZWA_PRZEDMIOTU, oceny.Semestr, oceny.WYKLAD_OCENA, oceny.cwicz_ocena, oceny.lab_ocena, oceny.ocena_konc from dbo.oceny inner join studenci on studenci.numer_indeksu = oceny.numer_indeksu inner join dbo.przedmioty on przedmioty.przedmiot_id = oceny.przedmiot_id where studenci.NUMER_INDEKSU = " + student.studentLogin + " and  oceny.Semestr = 5", sqlConnection);
                    DataTable dataTableStudentGrades = new DataTable();
                    sqlDataAdapterStudentGrades.Fill(dataTableStudentGrades);
                    gradesDisplay.DataSource = dataTableStudentGrades;
                }
                else if (semestersList.SelectedItem.Equals("Semestr 6"))
                {
                    SqlDataAdapter sqlDataAdapterStudentGrades = new SqlDataAdapter("select przedmioty.NAZWA_PRZEDMIOTU, oceny.Semestr, oceny.WYKLAD_OCENA, oceny.cwicz_ocena, oceny.lab_ocena, oceny.ocena_konc from dbo.oceny inner join studenci on studenci.numer_indeksu = oceny.numer_indeksu inner join dbo.przedmioty on przedmioty.przedmiot_id = oceny.przedmiot_id where studenci.NUMER_INDEKSU = " + student.studentLogin + " and  oceny.Semestr = 6", sqlConnection);
                    DataTable dataTableStudentGrades = new DataTable();
                    sqlDataAdapterStudentGrades.Fill(dataTableStudentGrades);
                    gradesDisplay.DataSource = dataTableStudentGrades;
                }
                else if (semestersList.SelectedItem.Equals("Semestr 7"))
                {
                    SqlDataAdapter sqlDataAdapterStudentGrades = new SqlDataAdapter("select przedmioty.NAZWA_PRZEDMIOTU, oceny.Semestr, oceny.WYKLAD_OCENA, oceny.cwicz_ocena, oceny.lab_ocena, oceny.ocena_konc from dbo.oceny inner join studenci on studenci.numer_indeksu = oceny.numer_indeksu inner join dbo.przedmioty on przedmioty.przedmiot_id = oceny.przedmiot_id where studenci.NUMER_INDEKSU = " + student.studentLogin + " and  oceny.Semestr = 7", sqlConnection);
                    DataTable dataTableStudentGrades = new DataTable();
                    sqlDataAdapterStudentGrades.Fill(dataTableStudentGrades);
                    gradesDisplay.DataSource = dataTableStudentGrades;
                }
                else if (semestersList.SelectedItem.Equals("Semestr 8"))
                {
                    SqlDataAdapter sqlDataAdapterStudentGrades = new SqlDataAdapter("select przedmioty.NAZWA_PRZEDMIOTU, oceny.Semestr, oceny.WYKLAD_OCENA, oceny.cwicz_ocena, oceny.lab_ocena, oceny.ocena_konc from dbo.oceny inner join studenci on studenci.numer_indeksu = oceny.numer_indeksu inner join dbo.przedmioty on przedmioty.przedmiot_id = oceny.przedmiot_id where studenci.NUMER_INDEKSU = " + student.studentLogin + " and  oceny.Semestr = 8", sqlConnection);
                    DataTable dataTableStudentGrades = new DataTable();
                    sqlDataAdapterStudentGrades.Fill(dataTableStudentGrades);
                    gradesDisplay.DataSource = dataTableStudentGrades;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void feeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (feeList.SelectedItem.Equals("Semestr 1"))
                {
                    SqlDataAdapter sqlDataAdapterStudentFees = new SqlDataAdapter("select oplaty.RATA_PIERWSZA,oplaty.RATA_DRUGA,oplaty.RATA_TRZECIA,oplaty.RATA_CZWARTA,oplaty.POWT_PRZEDM,oplaty.NADPLATA,oplaty.ODSETKI from studenci inner join oplaty on oplaty.NUMER_INDEKSU = studenci.NUMER_INDEKSU where studenci.NUMER_INDEKSU = " + student.studentLogin + " and oplaty.Semestr = 1", sqlConnection);
                    DataTable dataTableStudentFees = new DataTable();
                    sqlDataAdapterStudentFees.Fill(dataTableStudentFees);
                    feeDisplay.DataSource = dataTableStudentFees;
                }

                else if (feeList.SelectedItem.Equals("Semestr 2"))
                {
                    SqlDataAdapter sqlDataAdapterStudentFees = new SqlDataAdapter("select oplaty.RATA_PIERWSZA,oplaty.RATA_DRUGA,oplaty.RATA_TRZECIA,oplaty.RATA_CZWARTA,oplaty.POWT_PRZEDM,oplaty.NADPLATA,oplaty.ODSETKI from studenci inner join oplaty on oplaty.NUMER_INDEKSU = studenci.NUMER_INDEKSU where studenci.NUMER_INDEKSU = " + student.studentLogin + " and oplaty.Semestr = 2", sqlConnection);
                    DataTable dataTableStudentFees = new DataTable();
                    sqlDataAdapterStudentFees.Fill(dataTableStudentFees);
                    feeDisplay.DataSource = dataTableStudentFees;
                }
                else if (feeList.SelectedItem.Equals("Semestr 3"))
                {
                    SqlDataAdapter sqlDataAdapterStudentFees = new SqlDataAdapter("select oplaty.RATA_PIERWSZA,oplaty.RATA_DRUGA,oplaty.RATA_TRZECIA,oplaty.RATA_CZWARTA,oplaty.POWT_PRZEDM,oplaty.NADPLATA,oplaty.ODSETKI from studenci inner join oplaty on oplaty.NUMER_INDEKSU = studenci.NUMER_INDEKSU where studenci.NUMER_INDEKSU = " + student.studentLogin + " and oplaty.Semestr = 3", sqlConnection);
                    DataTable dataTableStudentFees = new DataTable();
                    sqlDataAdapterStudentFees.Fill(dataTableStudentFees);
                    feeDisplay.DataSource = dataTableStudentFees;
                }
                else if (feeList.SelectedItem.Equals("Semestr 4"))
                {
                    SqlDataAdapter sqlDataAdapterStudentFees = new SqlDataAdapter("select oplaty.RATA_PIERWSZA,oplaty.RATA_DRUGA,oplaty.RATA_TRZECIA,oplaty.RATA_CZWARTA,oplaty.POWT_PRZEDM,oplaty.NADPLATA,oplaty.ODSETKI from studenci inner join oplaty on oplaty.NUMER_INDEKSU = studenci.NUMER_INDEKSU where studenci.NUMER_INDEKSU = " + student.studentLogin + " and oplaty.Semestr = 4", sqlConnection);
                    DataTable dataTableStudentFees = new DataTable();
                    sqlDataAdapterStudentFees.Fill(dataTableStudentFees);
                    feeDisplay.DataSource = dataTableStudentFees;
                }
                else if (feeList.SelectedItem.Equals("Semestr 5"))
                {
                    SqlDataAdapter sqlDataAdapterStudentFees = new SqlDataAdapter("select oplaty.RATA_PIERWSZA,oplaty.RATA_DRUGA,oplaty.RATA_TRZECIA,oplaty.RATA_CZWARTA,oplaty.POWT_PRZEDM,oplaty.NADPLATA,oplaty.ODSETKI from studenci inner join oplaty on oplaty.NUMER_INDEKSU = studenci.NUMER_INDEKSU where studenci.NUMER_INDEKSU = " + student.studentLogin + " and oplaty.Semestr = 5", sqlConnection);
                    DataTable dataTableStudentFees = new DataTable();
                    sqlDataAdapterStudentFees.Fill(dataTableStudentFees);
                    feeDisplay.DataSource = dataTableStudentFees;
                }
                else if (feeList.SelectedItem.Equals("Semestr 6"))
                {
                    SqlDataAdapter sqlDataAdapterStudentFees = new SqlDataAdapter("select oplaty.RATA_PIERWSZA,oplaty.RATA_DRUGA,oplaty.RATA_TRZECIA,oplaty.RATA_CZWARTA,oplaty.POWT_PRZEDM,oplaty.NADPLATA,oplaty.ODSETKI from studenci inner join oplaty on oplaty.NUMER_INDEKSU = studenci.NUMER_INDEKSU where studenci.NUMER_INDEKSU = " + student.studentLogin + " and oplaty.Semestr = 6", sqlConnection);
                    DataTable dataTableStudentFees = new DataTable();
                    sqlDataAdapterStudentFees.Fill(dataTableStudentFees);
                    feeDisplay.DataSource = dataTableStudentFees;
                }
                else if (feeList.SelectedItem.Equals("Semestr 7"))
                {
                    SqlDataAdapter sqlDataAdapterStudentFees = new SqlDataAdapter("select oplaty.RATA_PIERWSZA,oplaty.RATA_DRUGA,oplaty.RATA_TRZECIA,oplaty.RATA_CZWARTA,oplaty.POWT_PRZEDM,oplaty.NADPLATA,oplaty.ODSETKI from studenci inner join oplaty on oplaty.NUMER_INDEKSU = studenci.NUMER_INDEKSU where studenci.NUMER_INDEKSU = " + student.studentLogin + " and oplaty.Semestr = 7", sqlConnection);
                    DataTable dataTableStudentFees = new DataTable();
                    sqlDataAdapterStudentFees.Fill(dataTableStudentFees);
                    feeDisplay.DataSource = dataTableStudentFees;
                }
                else if (feeList.SelectedItem.Equals("Semestr 8"))
                {
                    SqlDataAdapter sqlDataAdapterStudentFees = new SqlDataAdapter("select oplaty.RATA_PIERWSZA,oplaty.RATA_DRUGA,oplaty.RATA_TRZECIA,oplaty.RATA_CZWARTA,oplaty.POWT_PRZEDM,oplaty.NADPLATA,oplaty.ODSETKI from studenci inner join oplaty on oplaty.NUMER_INDEKSU = studenci.NUMER_INDEKSU where studenci.NUMER_INDEKSU = " + student.studentLogin + " and oplaty.Semestr = 8", sqlConnection);
                    DataTable dataTableStudentFees = new DataTable();
                    sqlDataAdapterStudentFees.Fill(dataTableStudentFees);
                    feeDisplay.DataSource = dataTableStudentFees;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
