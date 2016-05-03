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


namespace StudentManager2
{
    
    public partial class Main : Form
    {
        List<cStudent> StudentsList = StudentStorage.getAllStudents();

        public Main()
        {
            InitializeComponent();           
        }


        private void Main_Load(object sender, EventArgs e)
        {                      
            Order();                       
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(firstNameBox.Text))
                MessageBox.Show("Wpisz imię studenta.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);            
            else if (string.IsNullOrWhiteSpace(lastNameBox.Text))
                MessageBox.Show("Wpisz nazwisko studenta.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {               
                cStudent student = new cStudent();
                int maxId = StudentsList.Select(x => x.Id).DefaultIfEmpty(0).Max();
                student.Id = maxId + 1;
                student.FirstName = firstNameBox.Text;
                student.LastName = lastNameBox.Text;

                StudentStorage.addStudent(student);
                StudentsList = StudentStorage.getAllStudents();
                Order();
                lastNameBox.Text = "";
                firstNameBox.Text = "";

            }
        }     

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                DialogResult dr = MessageBox.Show("Czy na pewno chcesz usunąć studenta wraz z jego ocenami z bazy danych?", "", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    StudentStorage.deleteStudent(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[3].Value));
                    StudentsList = StudentStorage.getAllStudents();
                    Order();
                }
                               
            }
            else
                MessageBox.Show("Proszę wybrać studenta.",
                            "Błąd", MessageBoxButtons.OK);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameBox.Text))
                MessageBox.Show("Wpisz imię studenta.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(lastNameBox.Text))
                MessageBox.Show("Wpisz nazwisko studenta.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                StudentStorage.updateStudent(Convert.ToInt32(idBox.Text), firstNameBox.Text, lastNameBox.Text);
                StudentsList = StudentStorage.getAllStudents();
                Order();

                addButton.Enabled = true;
                deleteButton.Enabled = true;
                searchButton.Enabled = true;
                saveButton.Enabled = false;

                idBox.Text = "";
                lastNameBox.Text = "";
                firstNameBox.Text = "";
            }

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {            
            Application.Exit();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                idBox.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                lastNameBox.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                firstNameBox.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                addButton.Enabled = false;
                deleteButton.Enabled = false;
                searchButton.Enabled = false;
                saveButton.Enabled = true;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        public void Order()
        {
            dataGridView.Rows.Clear();
            int i = 1;
            foreach (cStudent s in StudentsList)
            {
                int n = dataGridView.Rows.Add();
                dataGridView.Rows[n].Cells[0].Value = i.ToString();
                dataGridView.Rows[n].Cells[1].Value = s.LastName;
                dataGridView.Rows[n].Cells[2].Value = s.FirstName;
                dataGridView.Rows[n].Cells[3].Value = s.Id.ToString();
                i++;
            }
            
        }

        private void firstNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addButton.PerformClick();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lastNameBox.Text))
                MessageBox.Show("Wpisz nazwisko studenta.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dataGridView.ClearSelection();
                string searchValue = lastNameBox.Text;
                int rowIndex = -1;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        dataGridView.Rows[rowIndex].Selected = true;
                        break;
                    }
                }
                if (dataGridView.SelectedRows.Count == 0)
                    MessageBox.Show("Nie znaleziono studenta o podanym nazwisku.", "Błąd",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            StudentDetails sd = new StudentDetails();
            sd.idBox.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            sd.lastNameBox.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            sd.firstNameBox.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            sd.Show();
        }
    }
}
