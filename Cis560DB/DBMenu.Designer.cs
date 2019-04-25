namespace Cis560DB
{
    partial class uxDBMenu
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
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxInsertMoviewButton = new System.Windows.Forms.Button();
            this.uxAddReviewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(12, 12);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(260, 50);
            this.uxSearchButton.TabIndex = 0;
            this.uxSearchButton.Text = "Search Database";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearch_Click);
            // 
            // uxInsertMoviewButton
            // 
            this.uxInsertMoviewButton.Location = new System.Drawing.Point(12, 68);
            this.uxInsertMoviewButton.Name = "uxInsertMoviewButton";
            this.uxInsertMoviewButton.Size = new System.Drawing.Size(260, 50);
            this.uxInsertMoviewButton.TabIndex = 1;
            this.uxInsertMoviewButton.Text = "Insert Movie";
            this.uxInsertMoviewButton.UseVisualStyleBackColor = true;
            this.uxInsertMoviewButton.Click += new System.EventHandler(this.uxInsertMovie_Click);
            // 
            // uxAddReviewButton
            // 
            this.uxAddReviewButton.Location = new System.Drawing.Point(12, 124);
            this.uxAddReviewButton.Name = "uxAddReviewButton";
            this.uxAddReviewButton.Size = new System.Drawing.Size(260, 50);
            this.uxAddReviewButton.TabIndex = 2;
            this.uxAddReviewButton.Text = "Add Movie Review";
            this.uxAddReviewButton.UseVisualStyleBackColor = true;
            this.uxAddReviewButton.Click += new System.EventHandler(this.uxAddReview_Click);
            // 
            // uxDBMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.Controls.Add(this.uxAddReviewButton);
            this.Controls.Add(this.uxInsertMoviewButton);
            this.Controls.Add(this.uxSearchButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 226);
            this.MinimumSize = new System.Drawing.Size(300, 226);
            this.Name = "uxDBMenu";
            this.Text = "DBMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.Button uxInsertMoviewButton;
        private System.Windows.Forms.Button uxAddReviewButton;
    }
}