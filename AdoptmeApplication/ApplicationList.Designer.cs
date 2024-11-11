namespace AdoptmeApplication
{
    partial class ApplicationList
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationList));
            lblUpdate = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            btnSave = new ModelButton();
            lblResult = new Label();
            rboPending = new RadioButton();
            rboApproved = new RadioButton();
            rboDenied = new RadioButton();
            btnPetPopularity = new ModelButton();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new ModelButton();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdate.ForeColor = Color.DarkGreen;
            lblUpdate.Location = new Point(852, 157);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(668, 71);
            lblUpdate.TabIndex = 50;
            lblUpdate.Text = "Adoption Application List";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(91, -60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(439, 328);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 75;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 394);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(2409, 743);
            dataGridView1.TabIndex = 79;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.BorderRadius = 41;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.GradientAngle = 90F;
            btnSave.GradientBottomColor = Color.MediumPurple;
            btnSave.GradientTopColor = Color.SlateBlue;
            btnSave.Location = new Point(2110, 335);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 53);
            btnSave.TabIndex = 80;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(1578, 345);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(83, 32);
            lblResult.TabIndex = 81;
            lblResult.Text = "Result:";
            // 
            // rboPending
            // 
            rboPending.AutoSize = true;
            rboPending.Location = new Point(1678, 343);
            rboPending.Name = "rboPending";
            rboPending.Size = new Size(132, 36);
            rboPending.TabIndex = 82;
            rboPending.TabStop = true;
            rboPending.Text = "Pending";
            rboPending.UseVisualStyleBackColor = true;
            // 
            // rboApproved
            // 
            rboApproved.AutoSize = true;
            rboApproved.Location = new Point(1816, 343);
            rboApproved.Name = "rboApproved";
            rboApproved.Size = new Size(149, 36);
            rboApproved.TabIndex = 83;
            rboApproved.TabStop = true;
            rboApproved.Text = "Approved";
            rboApproved.UseVisualStyleBackColor = true;
            // 
            // rboDenied
            // 
            rboDenied.AutoSize = true;
            rboDenied.Location = new Point(1971, 343);
            rboDenied.Name = "rboDenied";
            rboDenied.Size = new Size(122, 36);
            rboDenied.TabIndex = 84;
            rboDenied.TabStop = true;
            rboDenied.Text = "Denied";
            rboDenied.UseVisualStyleBackColor = true;
            // 
            // btnPetPopularity
            // 
            btnPetPopularity.BackColor = Color.White;
            btnPetPopularity.BorderRadius = 41;
            btnPetPopularity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPetPopularity.ForeColor = Color.White;
            btnPetPopularity.GradientAngle = 90F;
            btnPetPopularity.GradientBottomColor = Color.MediumPurple;
            btnPetPopularity.GradientTopColor = Color.SlateBlue;
            btnPetPopularity.Location = new Point(2259, 335);
            btnPetPopularity.Name = "btnPetPopularity";
            btnPetPopularity.Size = new Size(175, 53);
            btnPetPopularity.TabIndex = 85;
            btnPetPopularity.Text = "Pet Popularity";
            btnPetPopularity.UseVisualStyleBackColor = false;
            btnPetPopularity.Click += btnPetPopularity_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1635, 48);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 86;
            label1.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1748, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(483, 39);
            txtSearch.TabIndex = 87;
            toolTip1.SetToolTip(txtSearch, "Enter the Application Id Number");
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.BorderRadius = 41;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.GradientAngle = 90F;
            btnSearch.GradientBottomColor = Color.MediumPurple;
            btnSearch.GradientTopColor = Color.SlateBlue;
            btnSearch.Location = new Point(2286, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(132, 53);
            btnSearch.TabIndex = 88;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // ApplicationList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(2485, 1278);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnPetPopularity);
            Controls.Add(rboDenied);
            Controls.Add(rboApproved);
            Controls.Add(rboPending);
            Controls.Add(lblResult);
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(lblUpdate);
            Name = "ApplicationList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApplicationList";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpdate;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private ModelButton btnSave;
        private Label lblResult;
        private RadioButton rboPending;
        private RadioButton rboApproved;
        private RadioButton rboDenied;
        private ModelButton btnPetPopularity;
        private Label label1;
        private TextBox txtSearch;
        private ModelButton btnSearch;
        private ToolTip toolTip1;
    }
}