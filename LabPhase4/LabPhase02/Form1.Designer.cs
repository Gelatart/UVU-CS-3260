namespace LabPhase3
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelError = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletedEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.labelCredits = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add New Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(25, 79);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(100, 225);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee Type";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hourly",
            "Salary",
            "Sales",
            "Contract"});
            this.comboBox1.Location = new System.Drawing.Point(15, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Employee ID:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 249);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(133, 22);
            this.textBox3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Monthly Salary";
            this.label6.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(194, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 22);
            this.textBox4.TabIndex = 12;
            this.textBox4.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Commission";
            this.label7.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(194, 109);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(133, 22);
            this.textBox5.TabIndex = 14;
            this.textBox5.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Gross Sales";
            this.label8.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(194, 178);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(133, 22);
            this.textBox6.TabIndex = 16;
            this.textBox6.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 48);
            this.button2.TabIndex = 17;
            this.button2.Text = "Save Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(191, 229);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(98, 17);
            this.labelError.TabIndex = 18;
            this.labelError.Text = "Error Indicator";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(18, 368);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(133, 22);
            this.textBox7.TabIndex = 19;
            //this.textBox7.AutoPostBack = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ID",
            "First Name",
            "Last Name",
            "Full Name"});
            this.comboBox2.Location = new System.Drawing.Point(18, 336);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 24);
            this.comboBox2.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(22, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "No Employees Found";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Select Search Type";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileDialogToolStripMenuItem,
            this.saveFileDialogToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileDialogToolStripMenuItem
            // 
            this.openFileDialogToolStripMenuItem.Name = "openFileDialogToolStripMenuItem";
            this.openFileDialogToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openFileDialogToolStripMenuItem.Text = "Open File Dialog";
            this.openFileDialogToolStripMenuItem.Click += new System.EventHandler(this.openFileDialogToolStripMenuItem_Click);
            // 
            // saveFileDialogToolStripMenuItem
            // 
            this.saveFileDialogToolStripMenuItem.Name = "saveFileDialogToolStripMenuItem";
            this.saveFileDialogToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveFileDialogToolStripMenuItem.Text = "Save File Dialog";
            this.saveFileDialogToolStripMenuItem.Click += new System.EventHandler(this.saveFileDialogToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeEmployeesToolStripMenuItem,
            this.deletedEmployeesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // activeEmployeesToolStripMenuItem
            // 
            this.activeEmployeesToolStripMenuItem.Checked = true;
            this.activeEmployeesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeEmployeesToolStripMenuItem.Name = "activeEmployeesToolStripMenuItem";
            this.activeEmployeesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.activeEmployeesToolStripMenuItem.Text = "Active Employees";
            this.activeEmployeesToolStripMenuItem.Click += new System.EventHandler(this.activeEmployeesToolStripMenuItem_Click);
            // 
            // deletedEmployeesToolStripMenuItem
            // 
            this.deletedEmployeesToolStripMenuItem.Name = "deletedEmployeesToolStripMenuItem";
            this.deletedEmployeesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deletedEmployeesToolStripMenuItem.Text = "Deleted Employees";
            this.deletedEmployeesToolStripMenuItem.Click += new System.EventHandler(this.deletedEmployeesToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(94, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 48);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete Data";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(168, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 407);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelError);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(537, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.comboBoxGrade);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.labelCredits);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.labelName);
            this.tabPage2.Controls.Add(this.textBoxID);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(537, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Education Benefits";
            this.tabPage2.UseVisualStyleBackColor = true;
            //this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(19, 61);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(161, 303);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 28);
            this.button4.TabIndex = 22;
            this.button4.Text = "Available";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(104, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 28);
            this.button5.TabIndex = 23;
            this.button5.Text = "Enrolled";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Course ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(230, 82);
            this.textBoxID.Name = "textBox7";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(232, 22);
            this.textBoxID.TabIndex = 25;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(227, 107);
            this.labelName.Name = "label9";
            this.labelName.Size = new System.Drawing.Size(94, 17);
            this.labelName.TabIndex = 26;
            this.labelName.Text = "Course Name";
            //this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(230, 127);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(232, 22);
            this.textBox8.TabIndex = 27;
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Location = new System.Drawing.Point(227, 152);
            this.labelCredits.Name = "label10";
            this.labelCredits.Size = new System.Drawing.Size(101, 17);
            this.labelCredits.TabIndex = 28;
            this.labelCredits.Text = "Course Credits";
            //this.labelCredits.Click += new System.EventHandler(this.labelCredits_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Grade";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(230, 172);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(98, 22);
            this.textBox9.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(227, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Course Description";
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Location = new System.Drawing.Point(364, 173);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(98, 24);
            this.comboBoxGrade.TabIndex = 33;
            this.comboBoxGrade.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrade_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(230, 218);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(232, 97);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(227, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "This Employee qualifies for Education Benefits";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(227, 318);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "Approved Date: ";
            this.label14.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(270, 336);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 28);
            this.button6.TabIndex = 37;
            this.button6.Text = "Enroll in course";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.tabControl1);            
            //this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox7);
            /*
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            */
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Employee Directory";
            //this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelError;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletedEmployeesToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button6;
    }
}

