namespace ReadingFile
{
    partial class FrmRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbStudentNo = new TextBox();
            tbLastName = new TextBox();
            tbAge = new TextBox();
            tbFirstName = new TextBox();
            tbMiddle = new TextBox();
            dtpBirthday = new DateTimePicker();
            cbProgram = new ComboBox();
            label10 = new Label();
            cbGender = new ComboBox();
            tbContactNo = new TextBox();
            btnRegister = new Button();
            btnRecords = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(190, 45);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(27, 103);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(27, 150);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(82, 196);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(45, 250);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(362, 100);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 5;
            label6.Text = "Program";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(348, 150);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 6;
            label7.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(409, 201);
            label8.Name = "label8";
            label8.Size = new Size(38, 25);
            label8.TabIndex = 7;
            label8.Text = "M.I";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(336, 308);
            label9.Name = "label9";
            label9.Size = new Size(111, 25);
            label9.TabIndex = 8;
            label9.Text = "Contact No.";
            // 
            // tbStudentNo
            // 
            tbStudentNo.Location = new Point(137, 105);
            tbStudentNo.Name = "tbStudentNo";
            tbStudentNo.Size = new Size(100, 23);
            tbStudentNo.TabIndex = 9;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(137, 157);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(100, 23);
            tbLastName.TabIndex = 10;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(137, 201);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(100, 23);
            tbAge.TabIndex = 11;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(456, 150);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(121, 23);
            tbFirstName.TabIndex = 12;
            // 
            // tbMiddle
            // 
            tbMiddle.Location = new Point(456, 203);
            tbMiddle.Name = "tbMiddle";
            tbMiddle.Size = new Size(121, 23);
            tbMiddle.TabIndex = 14;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(137, 250);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 15;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(456, 103);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(121, 23);
            cbProgram.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(373, 250);
            label10.Name = "label10";
            label10.Size = new Size(74, 25);
            label10.TabIndex = 17;
            label10.Text = "Gender";
            label10.Click += label10_Click;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(456, 255);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 23);
            cbGender.TabIndex = 18;
            // 
            // tbContactNo
            // 
            tbContactNo.Location = new Point(456, 308);
            tbContactNo.Name = "tbContactNo";
            tbContactNo.Size = new Size(121, 23);
            tbContactNo.TabIndex = 19;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Black;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = SystemColors.ButtonFace;
            btnRegister.Location = new Point(241, 369);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(85, 39);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnRecords
            // 
            btnRecords.BackColor = Color.Black;
            btnRecords.FlatStyle = FlatStyle.Flat;
            btnRecords.ForeColor = SystemColors.ButtonFace;
            btnRecords.Location = new Point(348, 369);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(85, 39);
            btnRecords.TabIndex = 21;
            btnRecords.Text = "Records";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(659, 420);
            Controls.Add(btnRecords);
            Controls.Add(btnRegister);
            Controls.Add(tbContactNo);
            Controls.Add(cbGender);
            Controls.Add(label10);
            Controls.Add(cbProgram);
            Controls.Add(dtpBirthday);
            Controls.Add(tbMiddle);
            Controls.Add(tbFirstName);
            Controls.Add(tbAge);
            Controls.Add(tbLastName);
            Controls.Add(tbStudentNo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            Load += FrmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tbStudentNo;
        private TextBox tbLastName;
        private TextBox tbAge;
        private TextBox tbFirstName;
        private TextBox tbMiddle;
        private DateTimePicker dtpBirthday;
        private ComboBox cbProgram;
        private Label label10;
        private ComboBox cbGender;
        private TextBox tbContactNo;
        private Button btnRegister;
        private Button btnRecords;
    }
}