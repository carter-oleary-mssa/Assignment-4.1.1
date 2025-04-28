namespace Assignment_4._1._1
{
    partial class PersonInfoForm
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
            lblInfoFName = new Label();
            lblInfoLName = new Label();
            lblInfoMobile = new Label();
            lblInfoWork = new Label();
            lblInfoAddress = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblInfoFName
            // 
            lblInfoFName.AutoSize = true;
            lblInfoFName.Location = new Point(236, 106);
            lblInfoFName.Name = "lblInfoFName";
            lblInfoFName.Size = new Size(80, 20);
            lblInfoFName.TabIndex = 0;
            lblInfoFName.Text = "First Name";
            // 
            // lblInfoLName
            // 
            lblInfoLName.AutoSize = true;
            lblInfoLName.Location = new Point(236, 126);
            lblInfoLName.Name = "lblInfoLName";
            lblInfoLName.Size = new Size(79, 20);
            lblInfoLName.TabIndex = 1;
            lblInfoLName.Text = "Last Name";
            // 
            // lblInfoMobile
            // 
            lblInfoMobile.AutoSize = true;
            lblInfoMobile.Location = new Point(236, 146);
            lblInfoMobile.Name = "lblInfoMobile";
            lblInfoMobile.RightToLeft = RightToLeft.Yes;
            lblInfoMobile.Size = new Size(56, 20);
            lblInfoMobile.TabIndex = 2;
            lblInfoMobile.Text = "Mobile";
            // 
            // lblInfoWork
            // 
            lblInfoWork.AutoSize = true;
            lblInfoWork.Location = new Point(236, 166);
            lblInfoWork.Name = "lblInfoWork";
            lblInfoWork.Size = new Size(43, 20);
            lblInfoWork.TabIndex = 3;
            lblInfoWork.Text = "Work";
            // 
            // lblInfoAddress
            // 
            lblInfoAddress.AutoSize = true;
            lblInfoAddress.Location = new Point(236, 186);
            lblInfoAddress.Name = "lblInfoAddress";
            lblInfoAddress.Size = new Size(62, 20);
            lblInfoAddress.TabIndex = 4;
            lblInfoAddress.Text = "Address";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(236, 232);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PersonInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(lblInfoAddress);
            Controls.Add(lblInfoWork);
            Controls.Add(lblInfoMobile);
            Controls.Add(lblInfoLName);
            Controls.Add(lblInfoFName);
            Name = "PersonInfoForm";
            Text = "PersonInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoFName;
        private Label lblInfoLName;
        private Label lblInfoMobile;
        private Label lblInfoWork;
        private Label lblInfoAddress;
        private Button btnBack;
    }
}