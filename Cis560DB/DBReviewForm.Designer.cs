namespace Cis560DB
{
    partial class uxDBReviewForm
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
            this.uxMovieGrid = new System.Windows.Forms.DataGridView();
            this.uxFirstName = new System.Windows.Forms.TextBox();
            this.uxOneStar = new System.Windows.Forms.RadioButton();
            this.uxTwoStar = new System.Windows.Forms.RadioButton();
            this.uxThreeStar = new System.Windows.Forms.RadioButton();
            this.uxFourStar = new System.Windows.Forms.RadioButton();
            this.uxFiveStar = new System.Windows.Forms.RadioButton();
            this.uxSubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uxSearchByLabel = new System.Windows.Forms.Label();
            this.uxSearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMovieGrid
            // 
            this.uxMovieGrid.AllowUserToAddRows = false;
            this.uxMovieGrid.AllowUserToDeleteRows = false;
            this.uxMovieGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxMovieGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxMovieGrid.Location = new System.Drawing.Point(34, 40);
            this.uxMovieGrid.MultiSelect = false;
            this.uxMovieGrid.Name = "uxMovieGrid";
            this.uxMovieGrid.ReadOnly = true;
            this.uxMovieGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxMovieGrid.Size = new System.Drawing.Size(602, 302);
            this.uxMovieGrid.TabIndex = 0;
            // 
            // uxFirstName
            // 
            this.uxFirstName.Location = new System.Drawing.Point(218, 375);
            this.uxFirstName.Multiline = true;
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(200, 27);
            this.uxFirstName.TabIndex = 1;
            // 
            // uxOneStar
            // 
            this.uxOneStar.AutoSize = true;
            this.uxOneStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOneStar.Location = new System.Drawing.Point(60, 10);
            this.uxOneStar.Name = "uxOneStar";
            this.uxOneStar.Size = new System.Drawing.Size(57, 19);
            this.uxOneStar.TabIndex = 3;
            this.uxOneStar.TabStop = true;
            this.uxOneStar.Text = "1 Star";
            this.uxOneStar.UseVisualStyleBackColor = true;
            // 
            // uxTwoStar
            // 
            this.uxTwoStar.AutoSize = true;
            this.uxTwoStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTwoStar.Location = new System.Drawing.Point(60, 35);
            this.uxTwoStar.Name = "uxTwoStar";
            this.uxTwoStar.Size = new System.Drawing.Size(57, 19);
            this.uxTwoStar.TabIndex = 4;
            this.uxTwoStar.TabStop = true;
            this.uxTwoStar.Text = "2 Star";
            this.uxTwoStar.UseVisualStyleBackColor = true;
            // 
            // uxThreeStar
            // 
            this.uxThreeStar.AutoSize = true;
            this.uxThreeStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxThreeStar.Location = new System.Drawing.Point(60, 60);
            this.uxThreeStar.Name = "uxThreeStar";
            this.uxThreeStar.Size = new System.Drawing.Size(57, 19);
            this.uxThreeStar.TabIndex = 5;
            this.uxThreeStar.TabStop = true;
            this.uxThreeStar.Text = "3 Star";
            this.uxThreeStar.UseVisualStyleBackColor = true;
            // 
            // uxFourStar
            // 
            this.uxFourStar.AutoSize = true;
            this.uxFourStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFourStar.Location = new System.Drawing.Point(60, 85);
            this.uxFourStar.Name = "uxFourStar";
            this.uxFourStar.Size = new System.Drawing.Size(57, 19);
            this.uxFourStar.TabIndex = 6;
            this.uxFourStar.TabStop = true;
            this.uxFourStar.Text = "4 Star";
            this.uxFourStar.UseVisualStyleBackColor = true;
            // 
            // uxFiveStar
            // 
            this.uxFiveStar.AutoSize = true;
            this.uxFiveStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFiveStar.Location = new System.Drawing.Point(60, 110);
            this.uxFiveStar.Name = "uxFiveStar";
            this.uxFiveStar.Size = new System.Drawing.Size(57, 19);
            this.uxFiveStar.TabIndex = 7;
            this.uxFiveStar.TabStop = true;
            this.uxFiveStar.Text = "5 Star";
            this.uxFiveStar.UseVisualStyleBackColor = true;
            // 
            // uxSubmitButton
            // 
            this.uxSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSubmitButton.Location = new System.Drawing.Point(436, 440);
            this.uxSubmitButton.Name = "uxSubmitButton";
            this.uxSubmitButton.Size = new System.Drawing.Size(132, 47);
            this.uxSubmitButton.TabIndex = 8;
            this.uxSubmitButton.Text = "Submit";
            this.uxSubmitButton.UseVisualStyleBackColor = true;
            this.uxSubmitButton.Click += new System.EventHandler(this.uxSubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uxOneStar);
            this.groupBox1.Controls.Add(this.uxTwoStar);
            this.groupBox1.Controls.Add(this.uxThreeStar);
            this.groupBox1.Controls.Add(this.uxFiveStar);
            this.groupBox1.Controls.Add(this.uxFourStar);
            this.groupBox1.Location = new System.Drawing.Point(218, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 134);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // uxSearchByLabel
            // 
            this.uxSearchByLabel.AutoSize = true;
            this.uxSearchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchByLabel.Location = new System.Drawing.Point(181, 8);
            this.uxSearchByLabel.Name = "uxSearchByLabel";
            this.uxSearchByLabel.Size = new System.Drawing.Size(64, 20);
            this.uxSearchByLabel.TabIndex = 23;
            this.uxSearchByLabel.Text = "Search:";
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchBox.Location = new System.Drawing.Point(278, 8);
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(218, 26);
            this.uxSearchBox.TabIndex = 22;
            this.uxSearchBox.TextChanged += new System.EventHandler(this.uxSearchBox_TextChanged);
            // 
            // uxDBReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 545);
            this.Controls.Add(this.uxSearchByLabel);
            this.Controls.Add(this.uxSearchBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxSubmitButton);
            this.Controls.Add(this.uxFirstName);
            this.Controls.Add(this.uxMovieGrid);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(708, 584);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(708, 584);
            this.Name = "uxDBReviewForm";
            this.Text = "DBReviewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosingForm);
            this.Load += new System.EventHandler(this.uxDBReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxMovieGrid;
        private System.Windows.Forms.TextBox uxFirstName;
        private System.Windows.Forms.RadioButton uxOneStar;
        private System.Windows.Forms.RadioButton uxTwoStar;
        private System.Windows.Forms.RadioButton uxThreeStar;
        private System.Windows.Forms.RadioButton uxFourStar;
        private System.Windows.Forms.RadioButton uxFiveStar;
        private System.Windows.Forms.Button uxSubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label uxSearchByLabel;
        private System.Windows.Forms.TextBox uxSearchBox;
    }
}