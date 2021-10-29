
namespace ExamPlate
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.GBOX_Button = new System.Windows.Forms.GroupBox();
            this.BTN_GradeList = new System.Windows.Forms.Button();
            this.BTN_ClassList = new System.Windows.Forms.Button();
            this.BTN_Find = new System.Windows.Forms.Button();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_GetStudent = new System.Windows.Forms.Button();
            this.GBOX_Student = new System.Windows.Forms.GroupBox();
            this.BTN_SaveStudent = new System.Windows.Forms.Button();
            this.TXTBOX_StudentPhoto = new System.Windows.Forms.TextBox();
            this.TXTBOX_StudentName = new System.Windows.Forms.TextBox();
            this.TXTBOX_StudentID = new System.Windows.Forms.TextBox();
            this.LBL_StudentPhoto = new System.Windows.Forms.Label();
            this.LBL_StudentName = new System.Windows.Forms.Label();
            this.LBL_StudentID = new System.Windows.Forms.Label();
            this.GBOX_Class = new System.Windows.Forms.GroupBox();
            this.BTN_SaveClass = new System.Windows.Forms.Button();
            this.TXTBOX_ClassName = new System.Windows.Forms.TextBox();
            this.TXTBOX_ClassID = new System.Windows.Forms.TextBox();
            this.LBL_ClassName = new System.Windows.Forms.Label();
            this.LBL_ClassID = new System.Windows.Forms.Label();
            this.GBOX_Gradess = new System.Windows.Forms.GroupBox();
            this.TXTBOX_PassingStatus = new System.Windows.Forms.TextBox();
            this.LBL_PassingStatus = new System.Windows.Forms.Label();
            this.TXTBOX_GPA = new System.Windows.Forms.TextBox();
            this.TXTBOX_Final = new System.Windows.Forms.TextBox();
            this.TXTBOX_Midterm = new System.Windows.Forms.TextBox();
            this.LBL_GPA = new System.Windows.Forms.Label();
            this.LBL_Final = new System.Windows.Forms.Label();
            this.LBL_Midterm = new System.Windows.Forms.Label();
            this.GBOX_SelectTable = new System.Windows.Forms.GroupBox();
            this.RBTN_Grades = new System.Windows.Forms.RadioButton();
            this.RBTN_Classes = new System.Windows.Forms.RadioButton();
            this.RBTN_Students = new System.Windows.Forms.RadioButton();
            this.GBOX_SelectOrder = new System.Windows.Forms.GroupBox();
            this.RBTN_Ascending = new System.Windows.Forms.RadioButton();
            this.RBTN_Descending = new System.Windows.Forms.RadioButton();
            this.GBOX_OrderType = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RBTN_Name = new System.Windows.Forms.RadioButton();
            this.RBTN_ID = new System.Windows.Forms.RadioButton();
            this.BTN_GetList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.GBOX_Button.SuspendLayout();
            this.GBOX_Student.SuspendLayout();
            this.GBOX_Class.SuspendLayout();
            this.GBOX_Gradess.SuspendLayout();
            this.GBOX_SelectTable.SuspendLayout();
            this.GBOX_SelectOrder.SuspendLayout();
            this.GBOX_OrderType.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat ExtraBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat ExtraBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1084, 269);
            this.dataGridView2.TabIndex = 0;
            // 
            // GBOX_Button
            // 
            this.GBOX_Button.AutoSize = true;
            this.GBOX_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GBOX_Button.Controls.Add(this.BTN_GradeList);
            this.GBOX_Button.Controls.Add(this.BTN_ClassList);
            this.GBOX_Button.Controls.Add(this.BTN_Find);
            this.GBOX_Button.Controls.Add(this.BTN_Update);
            this.GBOX_Button.Controls.Add(this.BTN_Delete);
            this.GBOX_Button.Controls.Add(this.BTN_Save);
            this.GBOX_Button.Controls.Add(this.BTN_GetStudent);
            this.GBOX_Button.Location = new System.Drawing.Point(20, 350);
            this.GBOX_Button.Name = "GBOX_Button";
            this.GBOX_Button.Size = new System.Drawing.Size(263, 436);
            this.GBOX_Button.TabIndex = 1;
            this.GBOX_Button.TabStop = false;
            // 
            // BTN_GradeList
            // 
            this.BTN_GradeList.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_GradeList.Location = new System.Drawing.Point(6, 361);
            this.BTN_GradeList.Name = "BTN_GradeList";
            this.BTN_GradeList.Size = new System.Drawing.Size(250, 50);
            this.BTN_GradeList.TabIndex = 6;
            this.BTN_GradeList.Text = "GRADE LIST";
            this.BTN_GradeList.UseVisualStyleBackColor = true;
            this.BTN_GradeList.Click += new System.EventHandler(this.BTN_GradeList_Click);
            // 
            // BTN_ClassList
            // 
            this.BTN_ClassList.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ClassList.Location = new System.Drawing.Point(7, 305);
            this.BTN_ClassList.Name = "BTN_ClassList";
            this.BTN_ClassList.Size = new System.Drawing.Size(250, 50);
            this.BTN_ClassList.TabIndex = 5;
            this.BTN_ClassList.Text = "CLASS LIST";
            this.BTN_ClassList.UseVisualStyleBackColor = true;
            this.BTN_ClassList.Click += new System.EventHandler(this.BTN_ClassList_Click);
            // 
            // BTN_Find
            // 
            this.BTN_Find.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Find.Location = new System.Drawing.Point(6, 249);
            this.BTN_Find.Name = "BTN_Find";
            this.BTN_Find.Size = new System.Drawing.Size(250, 50);
            this.BTN_Find.TabIndex = 4;
            this.BTN_Find.Text = "FIND";
            this.BTN_Find.UseVisualStyleBackColor = true;
            this.BTN_Find.Click += new System.EventHandler(this.BTN_Find_Click);
            // 
            // BTN_Update
            // 
            this.BTN_Update.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Update.Location = new System.Drawing.Point(7, 193);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(250, 50);
            this.BTN_Update.TabIndex = 3;
            this.BTN_Update.Text = "UPDATE";
            this.BTN_Update.UseVisualStyleBackColor = true;
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Delete.Location = new System.Drawing.Point(7, 137);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(250, 50);
            this.BTN_Delete.TabIndex = 2;
            this.BTN_Delete.Text = "DELETE";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            // 
            // BTN_Save
            // 
            this.BTN_Save.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save.Location = new System.Drawing.Point(6, 81);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(250, 50);
            this.BTN_Save.TabIndex = 1;
            this.BTN_Save.Text = "SAVE";
            this.BTN_Save.UseVisualStyleBackColor = true;
            // 
            // BTN_GetStudent
            // 
            this.BTN_GetStudent.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_GetStudent.Location = new System.Drawing.Point(7, 25);
            this.BTN_GetStudent.Name = "BTN_GetStudent";
            this.BTN_GetStudent.Size = new System.Drawing.Size(250, 50);
            this.BTN_GetStudent.TabIndex = 0;
            this.BTN_GetStudent.Text = "GET STUDENT";
            this.BTN_GetStudent.UseVisualStyleBackColor = true;
            this.BTN_GetStudent.Click += new System.EventHandler(this.BTN_GetStudent_Click);
            // 
            // GBOX_Student
            // 
            this.GBOX_Student.Controls.Add(this.BTN_SaveStudent);
            this.GBOX_Student.Controls.Add(this.TXTBOX_StudentPhoto);
            this.GBOX_Student.Controls.Add(this.TXTBOX_StudentName);
            this.GBOX_Student.Controls.Add(this.TXTBOX_StudentID);
            this.GBOX_Student.Controls.Add(this.LBL_StudentPhoto);
            this.GBOX_Student.Controls.Add(this.LBL_StudentName);
            this.GBOX_Student.Controls.Add(this.LBL_StudentID);
            this.GBOX_Student.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOX_Student.Location = new System.Drawing.Point(315, 350);
            this.GBOX_Student.Name = "GBOX_Student";
            this.GBOX_Student.Size = new System.Drawing.Size(331, 274);
            this.GBOX_Student.TabIndex = 2;
            this.GBOX_Student.TabStop = false;
            this.GBOX_Student.Text = "Student";
            // 
            // BTN_SaveStudent
            // 
            this.BTN_SaveStudent.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SaveStudent.Location = new System.Drawing.Point(45, 200);
            this.BTN_SaveStudent.Name = "BTN_SaveStudent";
            this.BTN_SaveStudent.Size = new System.Drawing.Size(250, 50);
            this.BTN_SaveStudent.TabIndex = 7;
            this.BTN_SaveStudent.Text = "SAVE";
            this.BTN_SaveStudent.UseVisualStyleBackColor = true;
            this.BTN_SaveStudent.Click += new System.EventHandler(this.BTN_SaveStudent_Click);
            // 
            // TXTBOX_StudentPhoto
            // 
            this.TXTBOX_StudentPhoto.Location = new System.Drawing.Point(95, 145);
            this.TXTBOX_StudentPhoto.Name = "TXTBOX_StudentPhoto";
            this.TXTBOX_StudentPhoto.Size = new System.Drawing.Size(200, 37);
            this.TXTBOX_StudentPhoto.TabIndex = 5;
            // 
            // TXTBOX_StudentName
            // 
            this.TXTBOX_StudentName.Location = new System.Drawing.Point(95, 95);
            this.TXTBOX_StudentName.Name = "TXTBOX_StudentName";
            this.TXTBOX_StudentName.Size = new System.Drawing.Size(200, 37);
            this.TXTBOX_StudentName.TabIndex = 4;
            // 
            // TXTBOX_StudentID
            // 
            this.TXTBOX_StudentID.Location = new System.Drawing.Point(95, 45);
            this.TXTBOX_StudentID.Name = "TXTBOX_StudentID";
            this.TXTBOX_StudentID.Size = new System.Drawing.Size(200, 37);
            this.TXTBOX_StudentID.TabIndex = 3;
            // 
            // LBL_StudentPhoto
            // 
            this.LBL_StudentPhoto.AutoSize = true;
            this.LBL_StudentPhoto.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_StudentPhoto.Location = new System.Drawing.Point(5, 150);
            this.LBL_StudentPhoto.Name = "LBL_StudentPhoto";
            this.LBL_StudentPhoto.Size = new System.Drawing.Size(85, 27);
            this.LBL_StudentPhoto.TabIndex = 2;
            this.LBL_StudentPhoto.Text = "Photo:";
            // 
            // LBL_StudentName
            // 
            this.LBL_StudentName.AutoSize = true;
            this.LBL_StudentName.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_StudentName.Location = new System.Drawing.Point(7, 100);
            this.LBL_StudentName.Name = "LBL_StudentName";
            this.LBL_StudentName.Size = new System.Drawing.Size(83, 27);
            this.LBL_StudentName.TabIndex = 1;
            this.LBL_StudentName.Text = "Name:";
            // 
            // LBL_StudentID
            // 
            this.LBL_StudentID.AutoSize = true;
            this.LBL_StudentID.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_StudentID.Location = new System.Drawing.Point(47, 50);
            this.LBL_StudentID.Name = "LBL_StudentID";
            this.LBL_StudentID.Size = new System.Drawing.Size(43, 27);
            this.LBL_StudentID.TabIndex = 0;
            this.LBL_StudentID.Text = "ID:";
            // 
            // GBOX_Class
            // 
            this.GBOX_Class.Controls.Add(this.BTN_SaveClass);
            this.GBOX_Class.Controls.Add(this.TXTBOX_ClassName);
            this.GBOX_Class.Controls.Add(this.TXTBOX_ClassID);
            this.GBOX_Class.Controls.Add(this.LBL_ClassName);
            this.GBOX_Class.Controls.Add(this.LBL_ClassID);
            this.GBOX_Class.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOX_Class.Location = new System.Drawing.Point(315, 650);
            this.GBOX_Class.Name = "GBOX_Class";
            this.GBOX_Class.Size = new System.Drawing.Size(331, 216);
            this.GBOX_Class.TabIndex = 3;
            this.GBOX_Class.TabStop = false;
            this.GBOX_Class.Text = "Class";
            // 
            // BTN_SaveClass
            // 
            this.BTN_SaveClass.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SaveClass.Location = new System.Drawing.Point(45, 150);
            this.BTN_SaveClass.Name = "BTN_SaveClass";
            this.BTN_SaveClass.Size = new System.Drawing.Size(250, 50);
            this.BTN_SaveClass.TabIndex = 8;
            this.BTN_SaveClass.Text = "SAVE";
            this.BTN_SaveClass.UseVisualStyleBackColor = true;
            this.BTN_SaveClass.Click += new System.EventHandler(this.BTN_SaveClass_Click);
            // 
            // TXTBOX_ClassName
            // 
            this.TXTBOX_ClassName.Location = new System.Drawing.Point(95, 95);
            this.TXTBOX_ClassName.Name = "TXTBOX_ClassName";
            this.TXTBOX_ClassName.Size = new System.Drawing.Size(200, 37);
            this.TXTBOX_ClassName.TabIndex = 7;
            // 
            // TXTBOX_ClassID
            // 
            this.TXTBOX_ClassID.Location = new System.Drawing.Point(95, 45);
            this.TXTBOX_ClassID.Name = "TXTBOX_ClassID";
            this.TXTBOX_ClassID.Size = new System.Drawing.Size(200, 37);
            this.TXTBOX_ClassID.TabIndex = 6;
            // 
            // LBL_ClassName
            // 
            this.LBL_ClassName.AutoSize = true;
            this.LBL_ClassName.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ClassName.Location = new System.Drawing.Point(5, 100);
            this.LBL_ClassName.Name = "LBL_ClassName";
            this.LBL_ClassName.Size = new System.Drawing.Size(83, 27);
            this.LBL_ClassName.TabIndex = 1;
            this.LBL_ClassName.Text = "Name:";
            // 
            // LBL_ClassID
            // 
            this.LBL_ClassID.AutoSize = true;
            this.LBL_ClassID.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ClassID.Location = new System.Drawing.Point(47, 50);
            this.LBL_ClassID.Name = "LBL_ClassID";
            this.LBL_ClassID.Size = new System.Drawing.Size(43, 27);
            this.LBL_ClassID.TabIndex = 0;
            this.LBL_ClassID.Text = "ID:";
            // 
            // GBOX_Gradess
            // 
            this.GBOX_Gradess.Controls.Add(this.TXTBOX_PassingStatus);
            this.GBOX_Gradess.Controls.Add(this.LBL_PassingStatus);
            this.GBOX_Gradess.Controls.Add(this.TXTBOX_GPA);
            this.GBOX_Gradess.Controls.Add(this.TXTBOX_Final);
            this.GBOX_Gradess.Controls.Add(this.TXTBOX_Midterm);
            this.GBOX_Gradess.Controls.Add(this.LBL_GPA);
            this.GBOX_Gradess.Controls.Add(this.LBL_Final);
            this.GBOX_Gradess.Controls.Add(this.LBL_Midterm);
            this.GBOX_Gradess.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOX_Gradess.Location = new System.Drawing.Point(676, 350);
            this.GBOX_Gradess.Name = "GBOX_Gradess";
            this.GBOX_Gradess.Size = new System.Drawing.Size(420, 487);
            this.GBOX_Gradess.TabIndex = 6;
            this.GBOX_Gradess.TabStop = false;
            this.GBOX_Gradess.Text = "Grades";
            // 
            // TXTBOX_PassingStatus
            // 
            this.TXTBOX_PassingStatus.Location = new System.Drawing.Point(190, 195);
            this.TXTBOX_PassingStatus.Name = "TXTBOX_PassingStatus";
            this.TXTBOX_PassingStatus.Size = new System.Drawing.Size(200, 37);
            this.TXTBOX_PassingStatus.TabIndex = 7;
            // 
            // LBL_PassingStatus
            // 
            this.LBL_PassingStatus.AutoSize = true;
            this.LBL_PassingStatus.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PassingStatus.Location = new System.Drawing.Point(5, 200);
            this.LBL_PassingStatus.Name = "LBL_PassingStatus";
            this.LBL_PassingStatus.Size = new System.Drawing.Size(181, 27);
            this.LBL_PassingStatus.TabIndex = 6;
            this.LBL_PassingStatus.Text = "Passing Status:";
            // 
            // TXTBOX_GPA
            // 
            this.TXTBOX_GPA.Location = new System.Drawing.Point(190, 145);
            this.TXTBOX_GPA.Name = "TXTBOX_GPA";
            this.TXTBOX_GPA.Size = new System.Drawing.Size(200, 37);
            this.TXTBOX_GPA.TabIndex = 5;
            // 
            // TXTBOX_Final
            // 
            this.TXTBOX_Final.Location = new System.Drawing.Point(190, 95);
            this.TXTBOX_Final.Name = "TXTBOX_Final";
            this.TXTBOX_Final.Size = new System.Drawing.Size(200, 37);
            this.TXTBOX_Final.TabIndex = 4;
            // 
            // TXTBOX_Midterm
            // 
            this.TXTBOX_Midterm.Location = new System.Drawing.Point(190, 45);
            this.TXTBOX_Midterm.Name = "TXTBOX_Midterm";
            this.TXTBOX_Midterm.Size = new System.Drawing.Size(200, 37);
            this.TXTBOX_Midterm.TabIndex = 3;
            // 
            // LBL_GPA
            // 
            this.LBL_GPA.AutoSize = true;
            this.LBL_GPA.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_GPA.Location = new System.Drawing.Point(122, 150);
            this.LBL_GPA.Name = "LBL_GPA";
            this.LBL_GPA.Size = new System.Drawing.Size(64, 27);
            this.LBL_GPA.TabIndex = 2;
            this.LBL_GPA.Text = "GPA:";
            // 
            // LBL_Final
            // 
            this.LBL_Final.AutoSize = true;
            this.LBL_Final.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Final.Location = new System.Drawing.Point(112, 100);
            this.LBL_Final.Name = "LBL_Final";
            this.LBL_Final.Size = new System.Drawing.Size(74, 27);
            this.LBL_Final.TabIndex = 1;
            this.LBL_Final.Text = "Final:";
            // 
            // LBL_Midterm
            // 
            this.LBL_Midterm.AutoSize = true;
            this.LBL_Midterm.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Midterm.Location = new System.Drawing.Point(73, 50);
            this.LBL_Midterm.Name = "LBL_Midterm";
            this.LBL_Midterm.Size = new System.Drawing.Size(113, 27);
            this.LBL_Midterm.TabIndex = 0;
            this.LBL_Midterm.Text = "Midterm:";
            // 
            // GBOX_SelectTable
            // 
            this.GBOX_SelectTable.Controls.Add(this.RBTN_Grades);
            this.GBOX_SelectTable.Controls.Add(this.RBTN_Classes);
            this.GBOX_SelectTable.Controls.Add(this.RBTN_Students);
            this.GBOX_SelectTable.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOX_SelectTable.Location = new System.Drawing.Point(1132, 12);
            this.GBOX_SelectTable.Name = "GBOX_SelectTable";
            this.GBOX_SelectTable.Size = new System.Drawing.Size(293, 187);
            this.GBOX_SelectTable.TabIndex = 9;
            this.GBOX_SelectTable.TabStop = false;
            this.GBOX_SelectTable.Text = "Table";
            // 
            // RBTN_Grades
            // 
            this.RBTN_Grades.AutoSize = true;
            this.RBTN_Grades.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_Grades.Location = new System.Drawing.Point(55, 139);
            this.RBTN_Grades.Name = "RBTN_Grades";
            this.RBTN_Grades.Size = new System.Drawing.Size(127, 37);
            this.RBTN_Grades.TabIndex = 2;
            this.RBTN_Grades.TabStop = true;
            this.RBTN_Grades.Text = "Grades";
            this.RBTN_Grades.UseVisualStyleBackColor = true;
            // 
            // RBTN_Classes
            // 
            this.RBTN_Classes.AutoSize = true;
            this.RBTN_Classes.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_Classes.Location = new System.Drawing.Point(55, 96);
            this.RBTN_Classes.Name = "RBTN_Classes";
            this.RBTN_Classes.Size = new System.Drawing.Size(130, 37);
            this.RBTN_Classes.TabIndex = 1;
            this.RBTN_Classes.TabStop = true;
            this.RBTN_Classes.Text = "Classes";
            this.RBTN_Classes.UseVisualStyleBackColor = true;
            // 
            // RBTN_Students
            // 
            this.RBTN_Students.AutoSize = true;
            this.RBTN_Students.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_Students.Location = new System.Drawing.Point(55, 53);
            this.RBTN_Students.Name = "RBTN_Students";
            this.RBTN_Students.Size = new System.Drawing.Size(150, 37);
            this.RBTN_Students.TabIndex = 0;
            this.RBTN_Students.TabStop = true;
            this.RBTN_Students.Text = "Students";
            this.RBTN_Students.UseVisualStyleBackColor = true;
            // 
            // GBOX_SelectOrder
            // 
            this.GBOX_SelectOrder.Controls.Add(this.RBTN_Ascending);
            this.GBOX_SelectOrder.Controls.Add(this.RBTN_Descending);
            this.GBOX_SelectOrder.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOX_SelectOrder.Location = new System.Drawing.Point(1132, 429);
            this.GBOX_SelectOrder.Name = "GBOX_SelectOrder";
            this.GBOX_SelectOrder.Size = new System.Drawing.Size(293, 148);
            this.GBOX_SelectOrder.TabIndex = 10;
            this.GBOX_SelectOrder.TabStop = false;
            this.GBOX_SelectOrder.Text = "Order";
            // 
            // RBTN_Ascending
            // 
            this.RBTN_Ascending.AutoSize = true;
            this.RBTN_Ascending.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_Ascending.Location = new System.Drawing.Point(55, 48);
            this.RBTN_Ascending.Name = "RBTN_Ascending";
            this.RBTN_Ascending.Size = new System.Drawing.Size(171, 37);
            this.RBTN_Ascending.TabIndex = 1;
            this.RBTN_Ascending.TabStop = true;
            this.RBTN_Ascending.Text = "Ascending";
            this.RBTN_Ascending.UseVisualStyleBackColor = true;
            // 
            // RBTN_Descending
            // 
            this.RBTN_Descending.AutoSize = true;
            this.RBTN_Descending.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_Descending.Location = new System.Drawing.Point(55, 91);
            this.RBTN_Descending.Name = "RBTN_Descending";
            this.RBTN_Descending.Size = new System.Drawing.Size(188, 37);
            this.RBTN_Descending.TabIndex = 0;
            this.RBTN_Descending.TabStop = true;
            this.RBTN_Descending.Text = "Descending";
            this.RBTN_Descending.UseVisualStyleBackColor = true;
            // 
            // GBOX_OrderType
            // 
            this.GBOX_OrderType.Controls.Add(this.radioButton1);
            this.GBOX_OrderType.Controls.Add(this.RBTN_Name);
            this.GBOX_OrderType.Controls.Add(this.RBTN_ID);
            this.GBOX_OrderType.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOX_OrderType.Location = new System.Drawing.Point(1132, 222);
            this.GBOX_OrderType.Name = "GBOX_OrderType";
            this.GBOX_OrderType.Size = new System.Drawing.Size(293, 187);
            this.GBOX_OrderType.TabIndex = 10;
            this.GBOX_OrderType.TabStop = false;
            this.GBOX_OrderType.Text = "Order Type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(55, 139);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(127, 37);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Grades";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RBTN_Name
            // 
            this.RBTN_Name.AutoSize = true;
            this.RBTN_Name.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_Name.Location = new System.Drawing.Point(55, 96);
            this.RBTN_Name.Name = "RBTN_Name";
            this.RBTN_Name.Size = new System.Drawing.Size(114, 37);
            this.RBTN_Name.TabIndex = 1;
            this.RBTN_Name.TabStop = true;
            this.RBTN_Name.Text = "Name";
            this.RBTN_Name.UseVisualStyleBackColor = true;
            // 
            // RBTN_ID
            // 
            this.RBTN_ID.AutoSize = true;
            this.RBTN_ID.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_ID.Location = new System.Drawing.Point(55, 53);
            this.RBTN_ID.Name = "RBTN_ID";
            this.RBTN_ID.Size = new System.Drawing.Size(68, 37);
            this.RBTN_ID.TabIndex = 0;
            this.RBTN_ID.TabStop = true;
            this.RBTN_ID.Text = "ID";
            this.RBTN_ID.UseVisualStyleBackColor = true;
            // 
            // BTN_GetList
            // 
            this.BTN_GetList.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_GetList.Location = new System.Drawing.Point(1132, 736);
            this.BTN_GetList.Name = "BTN_GetList";
            this.BTN_GetList.Size = new System.Drawing.Size(293, 50);
            this.BTN_GetList.TabIndex = 8;
            this.BTN_GetList.Text = "GET LIST";
            this.BTN_GetList.UseVisualStyleBackColor = true;
            this.BTN_GetList.Click += new System.EventHandler(this.BTN_GetList_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1465, 898);
            this.Controls.Add(this.BTN_GetList);
            this.Controls.Add(this.GBOX_OrderType);
            this.Controls.Add(this.GBOX_SelectOrder);
            this.Controls.Add(this.GBOX_SelectTable);
            this.Controls.Add(this.GBOX_Gradess);
            this.Controls.Add(this.GBOX_Class);
            this.Controls.Add(this.GBOX_Student);
            this.Controls.Add(this.GBOX_Button);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.GBOX_Button.ResumeLayout(false);
            this.GBOX_Student.ResumeLayout(false);
            this.GBOX_Student.PerformLayout();
            this.GBOX_Class.ResumeLayout(false);
            this.GBOX_Class.PerformLayout();
            this.GBOX_Gradess.ResumeLayout(false);
            this.GBOX_Gradess.PerformLayout();
            this.GBOX_SelectTable.ResumeLayout(false);
            this.GBOX_SelectTable.PerformLayout();
            this.GBOX_SelectOrder.ResumeLayout(false);
            this.GBOX_SelectOrder.PerformLayout();
            this.GBOX_OrderType.ResumeLayout(false);
            this.GBOX_OrderType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox GBOX_Button;
        private System.Windows.Forms.Button BTN_GradeList;
        private System.Windows.Forms.Button BTN_ClassList;
        private System.Windows.Forms.Button BTN_Find;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_GetStudent;
        private System.Windows.Forms.GroupBox GBOX_Student;
        private System.Windows.Forms.Label LBL_StudentPhoto;
        private System.Windows.Forms.Label LBL_StudentName;
        private System.Windows.Forms.Label LBL_StudentID;
        private System.Windows.Forms.GroupBox GBOX_Class;
        private System.Windows.Forms.Label LBL_ClassName;
        private System.Windows.Forms.Label LBL_ClassID;
        private System.Windows.Forms.TextBox TXTBOX_StudentPhoto;
        private System.Windows.Forms.TextBox TXTBOX_StudentName;
        private System.Windows.Forms.TextBox TXTBOX_StudentID;
        private System.Windows.Forms.TextBox TXTBOX_ClassName;
        private System.Windows.Forms.TextBox TXTBOX_ClassID;
        private System.Windows.Forms.GroupBox GBOX_Gradess;
        private System.Windows.Forms.TextBox TXTBOX_GPA;
        private System.Windows.Forms.TextBox TXTBOX_Final;
        private System.Windows.Forms.TextBox TXTBOX_Midterm;
        private System.Windows.Forms.Label LBL_GPA;
        private System.Windows.Forms.Label LBL_Final;
        private System.Windows.Forms.Label LBL_Midterm;
        private System.Windows.Forms.TextBox TXTBOX_PassingStatus;
        private System.Windows.Forms.Label LBL_PassingStatus;
        private System.Windows.Forms.Button BTN_SaveStudent;
        private System.Windows.Forms.Button BTN_SaveClass;
        private System.Windows.Forms.GroupBox GBOX_SelectTable;
        private System.Windows.Forms.RadioButton RBTN_Grades;
        private System.Windows.Forms.RadioButton RBTN_Classes;
        private System.Windows.Forms.RadioButton RBTN_Students;
        private System.Windows.Forms.GroupBox GBOX_SelectOrder;
        private System.Windows.Forms.RadioButton RBTN_Ascending;
        private System.Windows.Forms.RadioButton RBTN_Descending;
        private System.Windows.Forms.GroupBox GBOX_OrderType;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton RBTN_Name;
        private System.Windows.Forms.RadioButton RBTN_ID;
        private System.Windows.Forms.Button BTN_GetList;
    }
}

