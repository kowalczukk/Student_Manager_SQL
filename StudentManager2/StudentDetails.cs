using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Data.SqlClient;

namespace StudentManager2
{
    public partial class StudentDetails : Form
    {
        cStudent student = new cStudent();
        List<cSubject> subjectList = MarksStorage.getSubjects();

        public StudentDetails()
        {
            InitializeComponent();

        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            
            foreach (cSubject s in subjectList)
            {
                subjectComboBox.Items.Add(s.SubjectName);
            }

            if (Security.Who == "teacher")
                student = StudentStorage.getStudent(Convert.ToInt32(idBox.Text));
            else
            {
                student = StudentStorage.getStudent(Security.StudentId);
                idBox.Text = student.Id.ToString();
                firstNameBox.Text = student.FirstName;
                lastNameBox.Text = student.LastName;
                addMarkButton.Enabled = false;
                deleteMarkButton.Enabled = false;
            }
        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order();
        }

        private void addMarkButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                cMark m = CreateMarkFromForm();
                MarksStorage.addMark(m);
                ReloadData();
                ResetForm();
                Order();
            }
            
        }

        private void deleteMarkButton_Click(object sender, EventArgs e)
        {
            if (markGridView.SelectedRows.Count == 1)
            {
                MarksStorage.deleteMark(Convert.ToInt32(markGridView.SelectedRows[0].Cells[2].Value));
                student = StudentStorage.getStudent(Convert.ToInt32(idBox.Text));
                Order();
            }
        }

        private void StudentDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Security.Who == "student")
                Application.Exit();
        }

        private void numberBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addMarkButton.PerformClick();
            }
        }

        public void Order()
        {
            markGridView.Rows.Clear();
            foreach (cSubject s in subjectList)
            {
                if (subjectComboBox.Text == s.SubjectName)
                {
                    foreach (cMark m in student.Marks)
                        if (m.SubjectID == s.Id)
                        {
                            int n = markGridView.Rows.Add();
                            markGridView.Rows[n].Cells[0].Value = m.Number.ToString();
                            markGridView.Rows[n].Cells[1].Value = m.Type.ToString();
                            markGridView.Rows[n].Cells[2].Value = m.Id.ToString();
                        }
                    break;
                }

            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(numberBox.Text))
            {
                MessageBox.Show("Wpisz ocenę.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(typeBox.Text))
            {
                MessageBox.Show("Wpisz za co jest ocena.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(subjectComboBox.Text))
            {
                MessageBox.Show("Wybierz przedmiot.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numberBox.Text != "1" && numberBox.Text != "2" && numberBox.Text != "3" &&
                numberBox.Text != "4" && numberBox.Text != "5")
            {
                MessageBox.Show("Niepoprawna ocena", "Błąd",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private cMark CreateMarkFromForm()
        {
            int maxId = MarksStorage.getMaxMarkId();
            
            cMark m = new cMark();
            m.Id = maxId + 1;
            m.StudentID = student.Id;
            m.SubjectID = GetSelectedSubject().Id;
            m.TeacherID = Login.TeacherId;
            m.Number = Convert.ToInt32(numberBox.Text);
            m.Type = typeBox.Text;
            return m;
        }

        private cSubject GetSelectedSubject()
        {
            foreach (cSubject s in subjectList)
            {
                if (subjectComboBox.Text == s.SubjectName)
                    return s;
            }
            return null;
        }

        private void ReloadData()
        {
            student = StudentStorage.getStudent(Convert.ToInt32(idBox.Text));

            //int n = markGridView.Rows.Add();
            //markGridView.Rows[n].Cells[0].Value = numberBox.Text;
            //markGridView.Rows[n].Cells[1].Value = typeBox.Text;
            //markGridView.Rows[n].Cells[2].Value = student.Id.ToString();
            
        }

        private void ResetForm()
        {
            numberBox.Text = "";
            typeBox.Text = "";
        }
    }
}
    //public class cStudent : cOsoba
    //{
    //    Dictionary<int, Mark> oceny = new Dictionary<int, Mark>();

    //    public cStudent() {
            
    //    }
    //    public List<Mark> Oceny {
    //        get {
    //            return new List<Mark>(oceny.Values);
    //        }
    //    }
    //}
    //public class cNauczyciel : cOsoba
    //{
    //    Dictionary<int, Mark> przedmioty = new Dictionary<int, Mark>();

    //    public cStudent()
    //    {

    //    }
    //    public List<Mark> Przedmioty
    //    {
    //        get
    //        {
    //            return new List<Mark>(oceny.Values);
    //        }
    //    }
    //}
    //public class cOsoba { //: IEnumerable<cOsoba> {
    //    #region deklaracje zmiennych
    //    int _id = 0;
    //    string _imie = "", _nazwisko = "";
    //    #endregion

    //    public cOsoba() { }
    //    public cOsoba(string imie, string nazwisko, int id)
    //    {
    //        _id = id;
    //        _imie = imie;
    //        _nazwisko = nazwisko;
    //    }
    //    public int Id { get { return _id; } }
    //    public string Imie {
    //        get { return _imie; }
    //        //set { _imie = value; }
    //    }
    //    public string Nazwisko {
    //        get { return _nazwisko; }
    //        //set { _nazwisko = value; }
    //    }
    //    public string Nazwa 
    //    {
    //        get { return _imie + " " + _nazwisko; }
    //    }
    //}


