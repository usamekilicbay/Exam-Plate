using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum Table
{
    STUDENTS,
    CLASSES,
    GRADES
}

namespace ExamPlate
{
    public partial class Form1 : Form
    {
        Table selectedTable;
        ExamPlateEntities database = new ExamPlateEntities();

        public Form1()
        {
            InitializeComponent();
        }

        #region READ

        private void BTN_GetStudent_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = (from table in database.TBL_Students
                                        select new { table.StudentID, table.StudentName, table.StudentPhotoURL }).ToList();
        }

        private void BTN_ClassList_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = (from table in database.TBL_Classes
                                        select new { table.ClassID, table.ClassName }).ToList();
        }

        private void BTN_GradeList_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = database.GRADE_LIST();
        }

        #endregion

        private void BTN_SaveStudent_Click(object sender, EventArgs e)
        {
            TBL_Students tbl_Students = new TBL_Students
            {
                StudentName = TXTBOX_StudentName.Text,
                StudentPhotoURL = TXTBOX_StudentPhoto.Text
            };

            database.TBL_Students.Add(tbl_Students);
            database.SaveChanges();
            MessageBox.Show("Student saved");
        }

        private void BTN_SaveClass_Click(object sender, EventArgs e)
        {
            TBL_Classes tbl_Classes = new TBL_Classes
            {
                ClassName = TXTBOX_ClassName.Text
            };

            database.TBL_Classes.Add(tbl_Classes);
            database.SaveChanges();
            MessageBox.Show("Class saved");
        }

        private void BTN_Find_Click(object sender, EventArgs e)
        {
            short midterm = Convert.ToInt16(TXTBOX_Midterm.Text);
            dataGridView2.DataSource = database.TBL_Grades.Where(x => x.MidtermGrade >= midterm).ToList();
        }

        private void BTN_GetList_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = database.TBL_Students.OrderBy(s => s.StudentName).ToList();
        }
    }
}
