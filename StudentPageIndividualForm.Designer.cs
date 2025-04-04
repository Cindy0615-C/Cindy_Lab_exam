namespace Lab_exam_IPT_Cindy
{
    partial class StudentPageIndividualForm
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
            this.labelStudentId = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGuardian = new System.Windows.Forms.Label();
            this.labelHobbies = new System.Windows.Forms.Label();
            this.labelNickname = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelYearLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStudentId
            // 
            this.labelStudentId.Location = new System.Drawing.Point(12, 20);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(500, 30);
            this.labelStudentId.TabIndex = 0;
            // 
            // labelFullName
            // 
            this.labelFullName.Location = new System.Drawing.Point(12, 60);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(500, 30);
            this.labelFullName.TabIndex = 1;
            // 
            // labelAddress
            // 
            this.labelAddress.Location = new System.Drawing.Point(12, 100);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(500, 30);
            this.labelAddress.TabIndex = 2;
            // 
            // labelContact
            // 
            this.labelContact.Location = new System.Drawing.Point(12, 140);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(500, 30);
            this.labelContact.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(12, 180);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(500, 30);
            this.labelEmail.TabIndex = 4;
            // 
            // labelGuardian
            // 
            this.labelGuardian.Location = new System.Drawing.Point(12, 220);
            this.labelGuardian.Name = "labelGuardian";
            this.labelGuardian.Size = new System.Drawing.Size(500, 30);
            this.labelGuardian.TabIndex = 5;
            // 
            // labelHobbies
            // 
            this.labelHobbies.Location = new System.Drawing.Point(12, 260);
            this.labelHobbies.Name = "labelHobbies";
            this.labelHobbies.Size = new System.Drawing.Size(500, 30);
            this.labelHobbies.TabIndex = 6;
            // 
            // labelNickname
            // 
            this.labelNickname.Location = new System.Drawing.Point(12, 300);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(500, 30);
            this.labelNickname.TabIndex = 7;
            // 
            // labelCourse
            // 
            this.labelCourse.Location = new System.Drawing.Point(12, 340);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(500, 30);
            this.labelCourse.TabIndex = 8;
            // 
            // labelYearLevel
            // 
            this.labelYearLevel.Location = new System.Drawing.Point(12, 380);
            this.labelYearLevel.Name = "labelYearLevel";
            this.labelYearLevel.Size = new System.Drawing.Size(500, 30);
            this.labelYearLevel.TabIndex = 9;
            // 
            // StudentPageIndividualForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 450); // Increased size
            this.Controls.Add(this.labelYearLevel);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.labelHobbies);
            this.Controls.Add(this.labelGuardian);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.labelStudentId);
            this.Name = "StudentPageIndividualForm";
            this.Text = "Student Details";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGuardian;
        private System.Windows.Forms.Label labelHobbies;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelYearLevel;
    }
}
