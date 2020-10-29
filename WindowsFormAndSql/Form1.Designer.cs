namespace WindowsFormAndSql
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblMiddleInitial = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblEnterStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtEnterStudentId = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewStudentRecords = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentId
            // 
            this.lblStudentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStudentId.Location = new System.Drawing.Point(79, 36);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(85, 18);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student ID:";
            // 
            // lblFirstname
            // 
            this.lblFirstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFirstname.Location = new System.Drawing.Point(85, 71);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(81, 18);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "Firstname:";
            // 
            // lblLastname
            // 
            this.lblLastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLastname.Location = new System.Drawing.Point(83, 105);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(82, 18);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Lastname:";
            // 
            // lblMiddleInitial
            // 
            this.lblMiddleInitial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMiddleInitial.AutoSize = true;
            this.lblMiddleInitial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleInitial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMiddleInitial.Location = new System.Drawing.Point(140, 144);
            this.lblMiddleInitial.Name = "lblMiddleInitial";
            this.lblMiddleInitial.Size = new System.Drawing.Size(30, 18);
            this.lblMiddleInitial.TabIndex = 3;
            this.lblMiddleInitial.Text = "MI:";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGender.Location = new System.Drawing.Point(287, 143);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 18);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddress.Location = new System.Drawing.Point(99, 183);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 18);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBirthday.Location = new System.Drawing.Point(97, 220);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(72, 18);
            this.lblBirthday.TabIndex = 6;
            this.lblBirthday.Text = "Birthday:";
            // 
            // lblEnterStudentId
            // 
            this.lblEnterStudentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnterStudentId.AutoSize = true;
            this.lblEnterStudentId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterStudentId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEnterStudentId.Location = new System.Drawing.Point(419, 36);
            this.lblEnterStudentId.Name = "lblEnterStudentId";
            this.lblEnterStudentId.Size = new System.Drawing.Size(125, 18);
            this.lblEnterStudentId.TabIndex = 7;
            this.lblEnterStudentId.Text = "Enter Student ID:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.ForeColor = System.Drawing.Color.White;
            this.txtStudentId.Location = new System.Drawing.Point(189, 35);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStudentId.Size = new System.Drawing.Size(179, 21);
            this.txtStudentId.TabIndex = 8;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.ForeColor = System.Drawing.Color.White;
            this.txtFirstname.Location = new System.Drawing.Point(189, 69);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFirstname.Size = new System.Drawing.Size(278, 21);
            this.txtFirstname.TabIndex = 9;
            // 
            // txtLastname
            // 
            this.txtLastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.ForeColor = System.Drawing.Color.White;
            this.txtLastname.Location = new System.Drawing.Point(189, 105);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLastname.Size = new System.Drawing.Size(278, 21);
            this.txtLastname.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(189, 184);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddress.Size = new System.Drawing.Size(278, 21);
            this.txtAddress.TabIndex = 11;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthday.ForeColor = System.Drawing.Color.White;
            this.txtBirthday.Location = new System.Drawing.Point(189, 220);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBirthday.Size = new System.Drawing.Size(278, 21);
            this.txtBirthday.TabIndex = 12;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMiddleInitial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtMiddleInitial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiddleInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleInitial.ForeColor = System.Drawing.Color.White;
            this.txtMiddleInitial.Location = new System.Drawing.Point(189, 144);
            this.txtMiddleInitial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMiddleInitial.Size = new System.Drawing.Size(75, 21);
            this.txtMiddleInitial.TabIndex = 13;
            // 
            // txtGender
            // 
            this.txtGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.Color.White;
            this.txtGender.Location = new System.Drawing.Point(376, 143);
            this.txtGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGender.Name = "txtGender";
            this.txtGender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGender.Size = new System.Drawing.Size(92, 21);
            this.txtGender.TabIndex = 14;
            // 
            // txtEnterStudentId
            // 
            this.txtEnterStudentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnterStudentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtEnterStudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnterStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterStudentId.ForeColor = System.Drawing.Color.White;
            this.txtEnterStudentId.Location = new System.Drawing.Point(572, 36);
            this.txtEnterStudentId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEnterStudentId.Name = "txtEnterStudentId";
            this.txtEnterStudentId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnterStudentId.Size = new System.Drawing.Size(113, 21);
            this.txtEnterStudentId.TabIndex = 15;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(35, 271);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnCreate.Size = new System.Drawing.Size(119, 45);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRead
            // 
            this.btnRead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.White;
            this.btnRead.Image = ((System.Drawing.Image)(resources.GetObject("btnRead.Image")));
            this.btnRead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRead.Location = new System.Drawing.Point(178, 271);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnRead.Size = new System.Drawing.Size(119, 45);
            this.btnRead.TabIndex = 17;
            this.btnRead.Text = "Read";
            this.btnRead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(325, 271);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnUpdate.Size = new System.Drawing.Size(119, 45);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(471, 271);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnDelete.Size = new System.Drawing.Size(119, 45);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(616, 271);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnSearch.Size = new System.Drawing.Size(119, 45);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewStudentRecords
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewStudentRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewStudentRecords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dataGridViewStudentRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewStudentRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentRecords.Location = new System.Drawing.Point(35, 324);
            this.dataGridViewStudentRecords.Name = "dataGridViewStudentRecords";
            this.dataGridViewStudentRecords.Size = new System.Drawing.Size(700, 280);
            this.dataGridViewStudentRecords.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(775, 616);
            this.Controls.Add(this.dataGridViewStudentRecords);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtEnterStudentId);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblEnterStudentId);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblMiddleInitial);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblStudentId);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(791, 655);
            this.MinimumSize = new System.Drawing.Size(791, 655);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My SQL Application";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblMiddleInitial;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblEnterStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtEnterStudentId;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewStudentRecords;
    }
}

