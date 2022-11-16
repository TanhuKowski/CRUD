namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_ID = new System.Windows.Forms.TextBox();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.text_Surname = new System.Windows.Forms.TextBox();
            this.text_Father_Name = new System.Windows.Forms.TextBox();
            this.text_Birth_Date = new System.Windows.Forms.TextBox();
            this.text_Email = new System.Windows.Forms.TextBox();
            this.text_Address = new System.Windows.Forms.TextBox();
            this.text_Group_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Student_GRID = new System.Windows.Forms.DataGridView();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Student_GRID)).BeginInit();
            this.SuspendLayout();
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(84, 80);
            this.text_ID.Multiline = true;
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(250, 50);
            this.text_ID.TabIndex = 0;
            // 
            // text_Name
            // 
            this.text_Name.Location = new System.Drawing.Point(84, 136);
            this.text_Name.Multiline = true;
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(250, 50);
            this.text_Name.TabIndex = 1;
            // 
            // text_Surname
            // 
            this.text_Surname.Location = new System.Drawing.Point(84, 192);
            this.text_Surname.Multiline = true;
            this.text_Surname.Name = "text_Surname";
            this.text_Surname.Size = new System.Drawing.Size(250, 50);
            this.text_Surname.TabIndex = 2;
            // 
            // text_Father_Name
            // 
            this.text_Father_Name.Location = new System.Drawing.Point(84, 248);
            this.text_Father_Name.Multiline = true;
            this.text_Father_Name.Name = "text_Father_Name";
            this.text_Father_Name.Size = new System.Drawing.Size(250, 50);
            this.text_Father_Name.TabIndex = 3;
            // 
            // text_Birth_Date
            // 
            this.text_Birth_Date.Location = new System.Drawing.Point(439, 80);
            this.text_Birth_Date.Multiline = true;
            this.text_Birth_Date.Name = "text_Birth_Date";
            this.text_Birth_Date.Size = new System.Drawing.Size(250, 50);
            this.text_Birth_Date.TabIndex = 4;
            // 
            // text_Email
            // 
            this.text_Email.Location = new System.Drawing.Point(439, 136);
            this.text_Email.Multiline = true;
            this.text_Email.Name = "text_Email";
            this.text_Email.Size = new System.Drawing.Size(250, 50);
            this.text_Email.TabIndex = 5;
            // 
            // text_Address
            // 
            this.text_Address.Location = new System.Drawing.Point(439, 248);
            this.text_Address.Multiline = true;
            this.text_Address.Name = "text_Address";
            this.text_Address.Size = new System.Drawing.Size(250, 50);
            this.text_Address.TabIndex = 7;
            // 
            // text_Group_ID
            // 
            this.text_Group_ID.Location = new System.Drawing.Point(439, 192);
            this.text_Group_ID.Multiline = true;
            this.text_Group_ID.Name = "text_Group_ID";
            this.text_Group_ID.Size = new System.Drawing.Size(250, 50);
            this.text_Group_ID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(266, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student Database";
            // 
            // Student_GRID
            // 
            this.Student_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_GRID.Location = new System.Drawing.Point(84, 317);
            this.Student_GRID.Name = "Student_GRID";
            this.Student_GRID.RowHeadersWidth = 51;
            this.Student_GRID.RowTemplate.Height = 29;
            this.Student_GRID.Size = new System.Drawing.Size(605, 124);
            this.Student_GRID.TabIndex = 9;
            this.Student_GRID.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Student_GRID_CellContentClick);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(355, 81);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(66, 47);
            this.btn_Insert.TabIndex = 10;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(355, 137);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(66, 49);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(355, 192);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(66, 50);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Delete";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(355, 248);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(66, 50);
            this.btn_Find.TabIndex = 13;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.Student_GRID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Address);
            this.Controls.Add(this.text_Group_ID);
            this.Controls.Add(this.text_Email);
            this.Controls.Add(this.text_Birth_Date);
            this.Controls.Add(this.text_Father_Name);
            this.Controls.Add(this.text_Surname);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.text_ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Student_GRID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox text_ID;
        private TextBox text_Name;
        private TextBox text_Surname;
        private TextBox text_Father_Name;
        private TextBox text_Birth_Date;
        private TextBox text_Email;
        private TextBox text_Address;
        private TextBox text_Group_ID;
        private Label label1;
        private DataGridView Student_GRID;
        private Button btn_Insert;
        private Button btn_Update;
        private Button btn_Clear;
        private Button btn_Find;
    }
}