using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationUIApp
{
    public partial class StudentInformationUI : Form
    {
        StudentInfo[] students = new StudentInfo[3];
        int studentsArrayIndex;

        public StudentInformationUI()
        {
            InitializeComponent();
            InitializeStudentIndex();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (studentsArrayIndex < 3)
            {
                StudentInfo studentObj = new StudentInfo();
                studentObj.regNumber = regTextBox.Text;
                studentObj.firstName = firstNameTextBox.Text;
                studentObj.lastName = lastNameTextBox.Text;
                students[studentsArrayIndex] = studentObj;
                studentsArrayIndex++;
                MessageBox.Show("Reg no: " + studentObj.regNumber + " has been saved.");
            }
            else
            {
                MessageBox.Show("Already 3 students exists");
            }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            if (studentsArrayIndex < 3)
            {
                int presentNumberOfStudents = studentsArrayIndex;
                MessageBox.Show("Only " + presentNumberOfStudents + " student(s) has been saved." +
                                (3 - presentNumberOfStudents) + " student(s) is still remaining.");
            }
            else
            {
                string columns = "Registration Number\t" + "Full Name";
                string studentsInformation = "";

                foreach (StudentInfo studentObj in students)
                {
                    studentsInformation += studentObj.regNumber + "\t";
                    studentsInformation += studentObj.GetFullName();
                    studentsInformation += "\n";
                }
                MessageBox.Show(columns + "\n" + studentsInformation);
            }
        }
    }
}
