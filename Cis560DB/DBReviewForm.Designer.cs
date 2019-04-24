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
            this.uxRatingBox = new System.Windows.Forms.ComboBox();
            this.uxRatingLabel = new System.Windows.Forms.Label();
            this.uxMovieLabel = new System.Windows.Forms.Label();
            this.uxReviewTextBox = new System.Windows.Forms.TextBox();
            this.uxReviewLabel = new System.Windows.Forms.Label();
            this.uxSubmitButton = new System.Windows.Forms.Button();
            this.uxMovietTitleBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uxRatingBox
            // 
            this.uxRatingBox.FormattingEnabled = true;
            this.uxRatingBox.Items.AddRange(new object[] {
            "5 Stars",
            "4 Stars",
            "3 Stars",
            "2 Stars ",
            "1 Star"});
            this.uxRatingBox.Location = new System.Drawing.Point(121, 40);
            this.uxRatingBox.Name = "uxRatingBox";
            this.uxRatingBox.Size = new System.Drawing.Size(93, 21);
            this.uxRatingBox.TabIndex = 20;
            this.uxRatingBox.Text = "--Select Rating--";
            this.uxRatingBox.SelectedIndexChanged += new System.EventHandler(this.uxRatingChanged);
            // 
            // uxRatingLabel
            // 
            this.uxRatingLabel.AutoSize = true;
            this.uxRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRatingLabel.Location = new System.Drawing.Point(14, 41);
            this.uxRatingLabel.Name = "uxRatingLabel";
            this.uxRatingLabel.Size = new System.Drawing.Size(101, 20);
            this.uxRatingLabel.TabIndex = 19;
            this.uxRatingLabel.Text = "Movie Rating";
            // 
            // uxMovieLabel
            // 
            this.uxMovieLabel.AutoSize = true;
            this.uxMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMovieLabel.Location = new System.Drawing.Point(14, 15);
            this.uxMovieLabel.Name = "uxMovieLabel";
            this.uxMovieLabel.Size = new System.Drawing.Size(87, 20);
            this.uxMovieLabel.TabIndex = 18;
            this.uxMovieLabel.Text = "Movie Title:";
            // 
            // uxReviewTextBox
            // 
            this.uxReviewTextBox.Location = new System.Drawing.Point(18, 88);
            this.uxReviewTextBox.Multiline = true;
            this.uxReviewTextBox.Name = "uxReviewTextBox";
            this.uxReviewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxReviewTextBox.Size = new System.Drawing.Size(439, 77);
            this.uxReviewTextBox.TabIndex = 27;
            this.uxReviewTextBox.TextChanged += new System.EventHandler(this.uxReviewTextBox_TextChanged);
            // 
            // uxReviewLabel
            // 
            this.uxReviewLabel.AutoSize = true;
            this.uxReviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReviewLabel.Location = new System.Drawing.Point(14, 65);
            this.uxReviewLabel.Name = "uxReviewLabel";
            this.uxReviewLabel.Size = new System.Drawing.Size(60, 20);
            this.uxReviewLabel.TabIndex = 26;
            this.uxReviewLabel.Text = "Review";
            // 
            // uxSubmitButton
            // 
            this.uxSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSubmitButton.Location = new System.Drawing.Point(18, 171);
            this.uxSubmitButton.Name = "uxSubmitButton";
            this.uxSubmitButton.Size = new System.Drawing.Size(439, 36);
            this.uxSubmitButton.TabIndex = 28;
            this.uxSubmitButton.Text = "Submit Review";
            this.uxSubmitButton.UseVisualStyleBackColor = true;
            this.uxSubmitButton.Click += new System.EventHandler(this.uxSubmit_Click);
            // 
            // uxMovietTitleBox
            // 
            this.uxMovietTitleBox.FormattingEnabled = true;
            this.uxMovietTitleBox.Items.AddRange(new object[] {
            "Test Case"});
            this.uxMovietTitleBox.Location = new System.Drawing.Point(121, 14);
            this.uxMovietTitleBox.Name = "uxMovietTitleBox";
            this.uxMovietTitleBox.Size = new System.Drawing.Size(334, 21);
            this.uxMovietTitleBox.TabIndex = 29;
            this.uxMovietTitleBox.Text = "--Select Movie--";
            this.uxMovietTitleBox.SelectedIndexChanged += new System.EventHandler(this.uxMovieChanged);
            // 
            // uxDBReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 219);
            this.ControlBox = false;
            this.Controls.Add(this.uxMovietTitleBox);
            this.Controls.Add(this.uxSubmitButton);
            this.Controls.Add(this.uxReviewTextBox);
            this.Controls.Add(this.uxReviewLabel);
            this.Controls.Add(this.uxRatingBox);
            this.Controls.Add(this.uxRatingLabel);
            this.Controls.Add(this.uxMovieLabel);
            this.Name = "uxDBReviewForm";
            this.Text = "DBReviewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxRatingBox;
        private System.Windows.Forms.Label uxRatingLabel;
        private System.Windows.Forms.Label uxMovieLabel;
        private System.Windows.Forms.TextBox uxReviewTextBox;
        private System.Windows.Forms.Label uxReviewLabel;
        private System.Windows.Forms.Button uxSubmitButton;
        private System.Windows.Forms.ComboBox uxMovietTitleBox;
    }
}