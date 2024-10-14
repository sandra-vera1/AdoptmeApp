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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationList));
            lblUpdate = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            btnSearch = new ModelButton();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdate.ForeColor = Color.DarkGreen;
            lblUpdate.Location = new Point(607, 51);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(668, 71);
            lblUpdate.TabIndex = 50;
            lblUpdate.Text = "Adoption Application List";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(87, -82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(291, 325);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 75;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(564, 204);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 76;
            label1.Text = "Search:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(666, 204);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(453, 39);
            textBox1.TabIndex = 77;
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
            btnSearch.Location = new Point(1139, 194);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(175, 53);
            btnSearch.TabIndex = 78;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1752, 817);
            dataGridView1.TabIndex = 79;
            // 
            // ApplicationList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1824, 1166);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(lblUpdate);
            Name = "ApplicationList";
            Text = "ApplicationList";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpdate;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textBox1;
        private ModelButton btnSearch;
        private DataGridView dataGridView1;
    }
}