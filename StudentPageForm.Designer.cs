namespace Lab_exam_IPT_Cindy
{
    partial class StudentPageForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentIdColumn,
            this.FullNameColumn,
            this.ViewColumn});
            this.dataGridView1.Location = new System.Drawing.Point(50, 50); // Increase margin for better appearance
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 400); // Increase size
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentIdColumn
            // 
            this.StudentIdColumn.HeaderText = "Student ID";
            this.StudentIdColumn.Name = "StudentIdColumn";
            this.StudentIdColumn.ReadOnly = true;
            this.StudentIdColumn.Width = 200; // Increase width for better visibility
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.HeaderText = "Full Name";
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.ReadOnly = true;
            this.FullNameColumn.Width = 400; // Increase width for better visibility
            // 
            // ViewColumn
            // 
            this.ViewColumn.HeaderText = "View";
            this.ViewColumn.Name = "ViewColumn";
            this.ViewColumn.ReadOnly = true;
            this.ViewColumn.Text = "View";
            this.ViewColumn.UseColumnTextForButtonValue = true;
            this.ViewColumn.Width = 150; // Increase width for better visibility
            // 
            // StudentPageForm
            // 
            this.ClientSize = new System.Drawing.Size(1100, 600); // Increase form size
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentPageForm";
            this.Text = "Student Records";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ViewColumn;
    }
}
