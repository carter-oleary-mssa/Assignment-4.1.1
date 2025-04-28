namespace Assignment_4._1._1
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mobilePhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personBindingSource = new BindingSource(components);
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnSearch = new Button();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtMobile = new TextBox();
            txtWork = new TextBox();
            txtAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            label5 = new Label();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, mobilePhoneDataGridViewTextBoxColumn, workPhoneDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn });
            dataGridView1.DataSource = personBindingSource;
            dataGridView1.Location = new Point(12, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(683, 348);
            dataGridView1.TabIndex = 0;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // mobilePhoneDataGridViewTextBoxColumn
            // 
            mobilePhoneDataGridViewTextBoxColumn.DataPropertyName = "MobilePhone";
            mobilePhoneDataGridViewTextBoxColumn.HeaderText = "MobilePhone";
            mobilePhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            mobilePhoneDataGridViewTextBoxColumn.Name = "mobilePhoneDataGridViewTextBoxColumn";
            mobilePhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // workPhoneDataGridViewTextBoxColumn
            // 
            workPhoneDataGridViewTextBoxColumn.DataPropertyName = "WorkPhone";
            workPhoneDataGridViewTextBoxColumn.HeaderText = "WorkPhone";
            workPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            workPhoneDataGridViewTextBoxColumn.Name = "workPhoneDataGridViewTextBoxColumn";
            workPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Person);
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 493);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(583, 27);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 470);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(601, 491);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(916, 119);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(203, 27);
            txtFName.TabIndex = 4;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(916, 152);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(203, 27);
            txtLName.TabIndex = 5;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(916, 185);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(203, 27);
            txtMobile.TabIndex = 6;
            // 
            // txtWork
            // 
            txtWork.Location = new Point(916, 218);
            txtWork.Name = "txtWork";
            txtWork.Size = new Size(203, 27);
            txtWork.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(916, 251);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(203, 27);
            txtAddress.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(831, 122);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 10;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(831, 155);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 11;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(809, 221);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 12;
            label3.Text = "Work Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(848, 254);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 13;
            label4.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(796, 188);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 15;
            label6.Text = "Mobile Number";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(916, 284);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1025, 284);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(545, 32);
            label5.Name = "label5";
            label5.Size = new Size(195, 38);
            label5.TabIndex = 18;
            label5.Text = "Address Book";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(15, 523);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 706);
            Controls.Add(lblError);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAddress);
            Controls.Add(txtWork);
            Controls.Add(txtMobile);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(btnSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobilePhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private BindingSource personBindingSource;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnSearch;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtMobile;
        private TextBox txtWork;
        private TextBox txtAddress;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button btnAdd;
        private Button btnDelete;
        private Label label5;
        private Label lblError;
    }
}
