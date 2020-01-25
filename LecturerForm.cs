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

namespace Wikamp
{
    public partial class LecturerForm : Form
    {
        private Lecturer lecturer;
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapterStudentGrades;
        private DataSet dataSetStudentGrades;

        public LecturerForm(Lecturer lecturer, SqlConnection sqlConnection)
        {
            this.lecturer = lecturer;
            this.sqlConnection = sqlConnection;
            InitializeComponent();
        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {
            labelConnectionStatus.Text = sqlConnection.State.ToString();
            nameAndSurname.Text = lecturer.stopien + " " + lecturer.imie + " " + lecturer.nazwisko;

            SqlCommand sqlCommand = new SqlCommand("select przedmioty.NAZWA_PRZEDMIOTU from wykladowcy inner join przedmioty on przedmioty.WYKLADOWCA_ID = wykladowcy.WYKLADOWCA_ID where wykladowcy.WYKLADOWCA_ID = " + lecturer.login, sqlConnection);
            SqlDataReader subjectList = sqlCommand.ExecuteReader();

            while (subjectList.Read())
            {
                for (byte i = 0; i < subjectList.FieldCount; i++)
                {
                    subjectsList.Items.Add(subjectList.GetString(i));
                }
            }
            subjectList.Close();
            subjectList.Dispose();
        }

        private void listaPrzedmiotow_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaIndeksów.Items.Clear();

            SqlCommand sqlCommand = new SqlCommand("select studenci.NUMER_INDEKSU  from dbo.oceny inner join studenci on studenci.numer_indeksu = oceny.numer_indeksu inner join dbo.przedmioty on przedmioty.przedmiot_id = oceny.przedmiot_id where przedmioty.NAZWA_PRZEDMIOTU = '" + subjectsList.SelectedItem.ToString() + "'", sqlConnection);
            SqlDataReader indexesList = sqlCommand.ExecuteReader();

            while (indexesList.Read())
            {
                for (byte i = 0; i < indexesList.FieldCount; i++)
                {
                    listaIndeksów.Items.Add(Convert.ToString(indexesList.GetInt32(i)));
                }
            }
            indexesList.Close();
            indexesList.Dispose();
        }

        private void dispGrades_Click(object sender, EventArgs e)
        {
            sqlDataAdapterStudentGrades = new SqlDataAdapter("select studenci.IMIE + ' ' + studenci.NAZWISKO, oceny.SEMESTR, oceny.WYKLAD_OCENA, oceny.CWICZ_OCENA, oceny.LAB_OCENA, oceny.OCENA_KONC from oceny inner join przedmioty on przedmioty.PRZEDMIOT_ID = oceny.PRZEDMIOT_ID inner join studenci on oceny.NUMER_INDEKSU = studenci.NUMER_INDEKSU where przedmioty.NAZWA_PRZEDMIOTU = '" + subjectsList.SelectedItem.ToString() + "' and studenci.NUMER_INDEKSU = '" + listaIndeksów.SelectedItem.ToString() + "'", sqlConnection);
            dataSetStudentGrades = new DataSet();
            sqlDataAdapterStudentGrades.Fill(dataSetStudentGrades, "studentGradesFromSubject");
            studentGradesFromSubject.DataSource = dataSetStudentGrades.Tables[0];
        }

        private void gradeUpd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapterStudentGrades);
                sqlDataAdapterStudentGrades.Update(dataSetStudentGrades, "studentGradesFromSubject");
                MessageBox.Show("Grade updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}