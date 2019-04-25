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
            this.uxSearchByLabel = new System.Windows.Forms.Label();
            this.cis560team24DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uxSearchGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.cis560team24DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSearchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560_team24DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560_team24DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560team24DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560_team24DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchBox.Location = new System.Drawing.Point(370, 21);
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(218, 30);
            this.uxSearchBox.TabIndex = 2;
            this.uxSearchBox.TextChanged += new System.EventHandler(this.uxTitleBox_TextChanged);
            // 
            // uxSearchByLabel
            // 
            this.uxSearchByLabel.AutoSize = true;
            this.uxSearchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchByLabel.Location = new System.Drawing.Point(255, 21);
            this.uxSearchByLabel.Name = "uxSearchByLabel";
            this.uxSearchByLabel.Size = new System.Drawing.Size(109, 25);
            this.uxSearchByLabel.TabIndex = 21;
            this.uxSearchByLabel.Text = "Search By:";
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            // 
            // uxSearchGrid
            // 
            this.uxSearchGrid.AllowUserToAddRows = false;
            this.uxSearchGrid.AllowUserToDeleteRows = false;
            this.uxSearchGrid.AutoGenerateColumns = false;
            this.uxSearchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxSearchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.uxSearchGrid.DataSource = this.movieBindingSource1;
            this.uxSearchGrid.Location = new System.Drawing.Point(12, 62);
            this.uxSearchGrid.Name = "uxSearchGrid";
            this.uxSearchGrid.ReadOnly = true;
            this.uxSearchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxSearchGrid.Size = new System.Drawing.Size(852, 284);
            this.uxSearchGrid.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MovieId";
            this.Column1.HeaderText = "MovieId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MovieTitle";
            this.dataGridViewTextBoxColumn2.HeaderText = "MovieTitle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ReleaseDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "ReleaseDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Language";
            this.dataGridViewTextBoxColumn4.HeaderText = "Language";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AllTimeBoxOffice";
            this.dataGridViewTextBoxColumn5.HeaderText = "AllTimeBoxOffice";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
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
            // uxDBSearchForm
            // 
            this.AccessibleName = "uxRatingForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 397);
            this.ControlBox = false;
            this.Controls.Add(this.uxDeleteButton);
            this.Controls.Add(this.uxMoreInfoButton);
            this.Controls.Add(this.uxSearchGrid);
            this.Controls.Add(this.uxSearchByLabel);
            this.Controls.Add(this.uxSearchBox);
            this.Name = "uxDBSearchForm";
            this.Text = "Rating";
            this.Load += new System.EventHandler(this.uxDBSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cis560team24DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSearchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560_team24DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560_team24DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560team24DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560_team24DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uxSearchBox;
        private System.Windows.Forms.Label uxSearchByLabel;
        private System.Windows.Forms.BindingSource cis560team24DataSetBindingSource;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allTimeBoxOfficeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView uxSearchGrid;
        private System.Windows.Forms.BindingSource cis560team24DataSetBindingSource1;
        private cis560_team24DataSet cis560_team24DataSet;
        private cis560_team24DataSet2 cis560_team24DataSet2;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private cis560_team24DataSet2TableAdapters.DirectorTableAdapter directorTableAdapter;
        private cis560_team24DataSet3 cis560_team24DataSet3;
        private System.Windows.Forms.BindingSource movieBindingSource1;
        private cis560_team24DataSet3TableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.Button uxMoreInfoButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button uxDeleteButton;
    }
}