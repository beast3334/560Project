namespace Cis560DB
{
    partial class uxDBSearchForm
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
            this.components = new System.ComponentModel.Container();
            this.uxSearchBox = new System.Windows.Forms.TextBox();
            this.uxSearchLabel = new System.Windows.Forms.Label();
            this.cis560team24DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cis560_team24DataSet3 = new Cis560DB.cis560_team24DataSet3();
            this.cis560_team24DataSet = new Cis560DB.cis560_team24DataSet();
            this.cis560team24DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cis560_team24DataSet2 = new Cis560DB.cis560_team24DataSet2();
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorTableAdapter = new Cis560DB.cis560_team24DataSet2TableAdapters.DirectorTableAdapter();
            this.movieTableAdapter = new Cis560DB.cis560_team24DataSet3TableAdapters.MovieTableAdapter();
            this.uxMoreInfoButton = new System.Windows.Forms.Button();
            this.uxDeleteButton = new System.Windows.Forms.Button();
            this.uxSearchGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cis560team24DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560_team24DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560_team24DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560team24DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560_team24DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSearchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchBox.Location = new System.Drawing.Point(370, 21);
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(218, 26);
            this.uxSearchBox.TabIndex = 2;
            this.uxSearchBox.TextChanged += new System.EventHandler(this.uxTitleBox_TextChanged);
            // 
            // uxSearchLabel
            // 
            this.uxSearchLabel.AutoSize = true;
            this.uxSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchLabel.Location = new System.Drawing.Point(273, 21);
            this.uxSearchLabel.Name = "uxSearchLabel";
            this.uxSearchLabel.Size = new System.Drawing.Size(64, 20);
            this.uxSearchLabel.TabIndex = 21;
            this.uxSearchLabel.Text = "Search:";
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            // 
            // movieBindingSource1
            // 
            this.movieBindingSource1.DataMember = "Movie";
            this.movieBindingSource1.DataSource = this.cis560_team24DataSet3;
            // 
            // cis560_team24DataSet3
            // 
            this.cis560_team24DataSet3.DataSetName = "cis560_team24DataSet3";
            this.cis560_team24DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cis560_team24DataSet
            // 
            this.cis560_team24DataSet.DataSetName = "cis560_team24DataSet";
            this.cis560_team24DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cis560team24DataSetBindingSource1
            // 
            this.cis560team24DataSetBindingSource1.DataSource = this.cis560_team24DataSet;
            this.cis560team24DataSetBindingSource1.Position = 0;
            // 
            // cis560_team24DataSet2
            // 
            this.cis560_team24DataSet2.DataSetName = "cis560_team24DataSet2";
            this.cis560_team24DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataMember = "Director";
            this.directorBindingSource.DataSource = this.cis560_team24DataSet2;
            // 
            // directorTableAdapter
            // 
            this.directorTableAdapter.ClearBeforeFill = true;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // uxMoreInfoButton
            // 
            this.uxMoreInfoButton.Location = new System.Drawing.Point(328, 352);
            this.uxMoreInfoButton.Name = "uxMoreInfoButton";
            this.uxMoreInfoButton.Size = new System.Drawing.Size(214, 33);
            this.uxMoreInfoButton.TabIndex = 40;
            this.uxMoreInfoButton.Text = "More Info";
            this.uxMoreInfoButton.UseVisualStyleBackColor = true;
            this.uxMoreInfoButton.Click += new System.EventHandler(this.uxMoreInfoButton_Click);
            // 
            // uxDeleteButton
            // 
            this.uxDeleteButton.Location = new System.Drawing.Point(703, 352);
            this.uxDeleteButton.Name = "uxDeleteButton";
            this.uxDeleteButton.Size = new System.Drawing.Size(161, 32);
            this.uxDeleteButton.TabIndex = 41;
            this.uxDeleteButton.Text = "Delete";
            this.uxDeleteButton.UseVisualStyleBackColor = true;
            this.uxDeleteButton.Click += new System.EventHandler(this.uxDeleteButton_Click);
            // 
            // uxSearchGrid
            // 
            this.uxSearchGrid.AllowUserToAddRows = false;
            this.uxSearchGrid.AllowUserToDeleteRows = false;
            this.uxSearchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxSearchGrid.Location = new System.Drawing.Point(12, 63);
            this.uxSearchGrid.MultiSelect = false;
            this.uxSearchGrid.Name = "uxSearchGrid";
            this.uxSearchGrid.ReadOnly = true;
            this.uxSearchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxSearchGrid.Size = new System.Drawing.Size(852, 283);
            this.uxSearchGrid.TabIndex = 42;
            // 
            // uxDBSearchForm
            // 
            this.AccessibleName = "uxRatingForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 397);
            this.Controls.Add(this.uxSearchGrid);
            this.Controls.Add(this.uxDeleteButton);
            this.Controls.Add(this.uxMoreInfoButton);
            this.Controls.Add(this.uxSearchLabel);
            this.Controls.Add(this.uxSearchBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(892, 436);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(892, 436);
            this.Name = "uxDBSearchForm";
            this.Text = "Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosingForm);
            this.Load += new System.EventHandler(this.uxDBSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cis560team24DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560_team24DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560_team24DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560team24DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560_team24DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSearchGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uxSearchBox;
        private System.Windows.Forms.Label uxSearchLabel;
        private System.Windows.Forms.BindingSource cis560team24DataSetBindingSource;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allTimeBoxOfficeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cis560team24DataSetBindingSource1;
        private cis560_team24DataSet cis560_team24DataSet;
        private cis560_team24DataSet2 cis560_team24DataSet2;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private cis560_team24DataSet2TableAdapters.DirectorTableAdapter directorTableAdapter;
        private cis560_team24DataSet3 cis560_team24DataSet3;
        private System.Windows.Forms.BindingSource movieBindingSource1;
        private cis560_team24DataSet3TableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.Button uxMoreInfoButton;
        private System.Windows.Forms.Button uxDeleteButton;
        private System.Windows.Forms.DataGridView uxSearchGrid;
    }
}