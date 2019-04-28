namespace Cis560DB
{
    partial class ExpandedInfo
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
            this.uxCastGrid = new System.Windows.Forms.DataGridView();
            this.uxReviewGrid = new System.Windows.Forms.DataGridView();
            this.uxCastLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxDirectorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxCastGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxReviewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxCastGrid
            // 
            this.uxCastGrid.AllowUserToAddRows = false;
            this.uxCastGrid.AllowUserToDeleteRows = false;
            this.uxCastGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxCastGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxCastGrid.Location = new System.Drawing.Point(12, 32);
            this.uxCastGrid.Name = "uxCastGrid";
            this.uxCastGrid.ReadOnly = true;
            this.uxCastGrid.Size = new System.Drawing.Size(395, 346);
            this.uxCastGrid.TabIndex = 1;
            // 
            // uxReviewGrid
            // 
            this.uxReviewGrid.AllowUserToAddRows = false;
            this.uxReviewGrid.AllowUserToDeleteRows = false;
            this.uxReviewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxReviewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxReviewGrid.Location = new System.Drawing.Point(413, 32);
            this.uxReviewGrid.Name = "uxReviewGrid";
            this.uxReviewGrid.ReadOnly = true;
            this.uxReviewGrid.Size = new System.Drawing.Size(396, 346);
            this.uxReviewGrid.TabIndex = 1;
            // 
            // uxCastLabel
            // 
            this.uxCastLabel.AutoSize = true;
            this.uxCastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCastLabel.Location = new System.Drawing.Point(12, 4);
            this.uxCastLabel.Name = "uxCastLabel";
            this.uxCastLabel.Size = new System.Drawing.Size(42, 20);
            this.uxCastLabel.TabIndex = 2;
            this.uxCastLabel.Text = "Cast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ratings";
            // 
            // uxDirectorLabel
            // 
            this.uxDirectorLabel.AutoSize = true;
            this.uxDirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDirectorLabel.Location = new System.Drawing.Point(12, 382);
            this.uxDirectorLabel.Name = "uxDirectorLabel";
            this.uxDirectorLabel.Size = new System.Drawing.Size(69, 20);
            this.uxDirectorLabel.TabIndex = 4;
            this.uxDirectorLabel.Text = "Director:";
            // 
            // ExpandedInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 411);
            this.Controls.Add(this.uxDirectorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxCastLabel);
            this.Controls.Add(this.uxReviewGrid);
            this.Controls.Add(this.uxCastGrid);
            this.Name = "ExpandedInfo";
            this.Text = "ExpandedInfo";
            this.Load += new System.EventHandler(this.ExpandedInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxCastGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxReviewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxCastGrid;
        private System.Windows.Forms.DataGridView uxReviewGrid;
        private System.Windows.Forms.Label uxCastLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxDirectorLabel;
    }
}