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
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxMovieGrid
            // 
            this.uxMovieGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxMovieGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxMovieGrid.Location = new System.Drawing.Point(39, 12);
            this.uxMovieGrid.Name = "uxMovieGrid";
            this.uxMovieGrid.Size = new System.Drawing.Size(602, 302);
            this.uxMovieGrid.TabIndex = 0;
            // 
            // uxDBReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 494);
            this.ControlBox = false;
            this.Controls.Add(this.uxMovieGrid);
            this.Name = "uxDBReviewForm";
            this.Text = "DBReviewForm";
            this.Load += new System.EventHandler(this.uxDBReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uxMovieGrid;
    }
}