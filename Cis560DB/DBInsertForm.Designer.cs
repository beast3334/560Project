namespace Cis560DB
{
    partial class uxDBInsertForm
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
            this.uxTitleBox = new System.Windows.Forms.TextBox();
            this.uxMovieLabel = new System.Windows.Forms.Label();
            this.uxDirectorLabel = new System.Windows.Forms.Label();
            this.uxDirectorBox = new System.Windows.Forms.TextBox();
            this.uxProfitLabel = new System.Windows.Forms.Label();
            this.uxCostLabel = new System.Windows.Forms.Label();
            this.uxProfitBox = new System.Windows.Forms.TextBox();
            this.uxLanguageBox = new System.Windows.Forms.TextBox();
            this.uxAddMovieButton = new System.Windows.Forms.Button();
            this.uxGenreLabel = new System.Windows.Forms.Label();
            this.uxGenreBox = new System.Windows.Forms.ComboBox();
            this.uxDateLabel = new System.Windows.Forms.Label();
            this.uxDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.uxCastList = new System.Windows.Forms.ListBox();
            this.uxRole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uxAddActor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxGender = new System.Windows.Forms.TextBox();
            this.uxLastName = new System.Windows.Forms.TextBox();
            this.uxFirstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxTitleBox
            // 
            this.uxTitleBox.Location = new System.Drawing.Point(119, 9);
            this.uxTitleBox.Name = "uxTitleBox";
            this.uxTitleBox.Size = new System.Drawing.Size(246, 20);
            this.uxTitleBox.TabIndex = 1;
            this.uxTitleBox.TextChanged += new System.EventHandler(this.uxTitleBox_TextChanged);
            // 
            // uxMovieLabel
            // 
            this.uxMovieLabel.AutoSize = true;
            this.uxMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMovieLabel.Location = new System.Drawing.Point(12, 9);
            this.uxMovieLabel.Name = "uxMovieLabel";
            this.uxMovieLabel.Size = new System.Drawing.Size(101, 20);
            this.uxMovieLabel.TabIndex = 7;
            this.uxMovieLabel.Text = "Movie Title * :";
            // 
            // uxDirectorLabel
            // 
            this.uxDirectorLabel.AutoSize = true;
            this.uxDirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDirectorLabel.Location = new System.Drawing.Point(12, 35);
            this.uxDirectorLabel.Name = "uxDirectorLabel";
            this.uxDirectorLabel.Size = new System.Drawing.Size(163, 20);
            this.uxDirectorLabel.TabIndex = 8;
            this.uxDirectorLabel.Text = "Director (First Last) * :";
            // 
            // uxDirectorBox
            // 
            this.uxDirectorBox.Location = new System.Drawing.Point(195, 35);
            this.uxDirectorBox.Name = "uxDirectorBox";
            this.uxDirectorBox.Size = new System.Drawing.Size(170, 20);
            this.uxDirectorBox.TabIndex = 9;
            this.uxDirectorBox.TextChanged += new System.EventHandler(this.uxDirectorBox_TextChanged);
            // 
            // uxProfitLabel
            // 
            this.uxProfitLabel.AutoSize = true;
            this.uxProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxProfitLabel.Location = new System.Drawing.Point(12, 61);
            this.uxProfitLabel.Name = "uxProfitLabel";
            this.uxProfitLabel.Size = new System.Drawing.Size(168, 20);
            this.uxProfitLabel.TabIndex = 18;
            this.uxProfitLabel.Text = "Box Office Revenue * :";
            // 
            // uxCostLabel
            // 
            this.uxCostLabel.AutoSize = true;
            this.uxCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCostLabel.Location = new System.Drawing.Point(12, 91);
            this.uxCostLabel.Name = "uxCostLabel";
            this.uxCostLabel.Size = new System.Drawing.Size(273, 20);
            this.uxCostLabel.TabIndex = 19;
            this.uxCostLabel.Text = "Language (two character identifier) * :";
            // 
            // uxProfitBox
            // 
            this.uxProfitBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Action",
            "Adventure",
            "Comedy",
            "Drama",
            "Documentary",
            "Horror",
            "Sci-Fi",
            "Space-Opera",
            "Thriller"});
            this.uxProfitBox.Location = new System.Drawing.Point(195, 61);
            this.uxProfitBox.Name = "uxProfitBox";
            this.uxProfitBox.Size = new System.Drawing.Size(170, 20);
            this.uxProfitBox.TabIndex = 21;
            this.uxProfitBox.TextChanged += new System.EventHandler(this.uxProfitBox_TextChanged);
            // 
            // uxLanguageBox
            // 
            this.uxLanguageBox.Location = new System.Drawing.Point(291, 93);
            this.uxLanguageBox.Name = "uxLanguageBox";
            this.uxLanguageBox.Size = new System.Drawing.Size(74, 20);
            this.uxLanguageBox.TabIndex = 22;
            // 
            // uxAddMovieButton
            // 
            this.uxAddMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddMovieButton.Location = new System.Drawing.Point(58, 290);
            this.uxAddMovieButton.Name = "uxAddMovieButton";
            this.uxAddMovieButton.Size = new System.Drawing.Size(670, 35);
            this.uxAddMovieButton.TabIndex = 17;
            this.uxAddMovieButton.Text = "Add Movie";
            this.uxAddMovieButton.UseVisualStyleBackColor = true;
            this.uxAddMovieButton.Click += new System.EventHandler(this.uxAddMovieButton_Click);
            // 
            // uxGenreLabel
            // 
            this.uxGenreLabel.AutoSize = true;
            this.uxGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGenreLabel.Location = new System.Drawing.Point(385, 9);
            this.uxGenreLabel.Name = "uxGenreLabel";
            this.uxGenreLabel.Size = new System.Drawing.Size(72, 20);
            this.uxGenreLabel.TabIndex = 25;
            this.uxGenreLabel.Text = "Genre * :";
            // 
            // uxGenreBox
            // 
            this.uxGenreBox.FormattingEnabled = true;
            this.uxGenreBox.Items.AddRange(new object[] {
            "Action ",
            "Adventure",
            "Animation",
            "Comedy",
            "Crime",
            "Drama",
            "Fantasy",
            "Historical",
            "Historical Fiction",
            "Horror",
            "Magical Realism",
            "Mystery",
            "Paranoid Fiction",
            "Philosophical",
            "Political",
            "Romance",
            "Saga",
            "Satire",
            "Science Ficition",
            "Thriller",
            "Western"});
            this.uxGenreBox.Location = new System.Drawing.Point(504, 7);
            this.uxGenreBox.Name = "uxGenreBox";
            this.uxGenreBox.Size = new System.Drawing.Size(110, 21);
            this.uxGenreBox.TabIndex = 26;
            this.uxGenreBox.Text = "--Select Genre--";
            this.uxGenreBox.SelectedIndexChanged += new System.EventHandler(this.uxGenreBox_SelectedIndexChanged);
            // 
            // uxDateLabel
            // 
            this.uxDateLabel.AutoSize = true;
            this.uxDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDateLabel.Location = new System.Drawing.Point(12, 121);
            this.uxDateLabel.Name = "uxDateLabel";
            this.uxDateLabel.Size = new System.Drawing.Size(125, 20);
            this.uxDateLabel.TabIndex = 27;
            this.uxDateLabel.Text = "Release Date * :";
            // 
            // uxDatePicker
            // 
            this.uxDatePicker.Location = new System.Drawing.Point(148, 121);
            this.uxDatePicker.Name = "uxDatePicker";
            this.uxDatePicker.Size = new System.Drawing.Size(217, 20);
            this.uxDatePicker.TabIndex = 30;
            this.uxDatePicker.ValueChanged += new System.EventHandler(this.uxDatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cast:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // actorBindingSource
            // 
            this.actorBindingSource.DataMember = "Actor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uxCastList);
            this.panel1.Controls.Add(this.uxRole);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.uxAddActor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.uxGender);
            this.panel1.Controls.Add(this.uxLastName);
            this.panel1.Controls.Add(this.uxFirstName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(389, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 213);
            this.panel1.TabIndex = 32;
            // 
            // uxCastList
            // 
            this.uxCastList.FormattingEnabled = true;
            this.uxCastList.Location = new System.Drawing.Point(47, 130);
            this.uxCastList.Name = "uxCastList";
            this.uxCastList.Size = new System.Drawing.Size(320, 69);
            this.uxCastList.TabIndex = 33;
            // 
            // uxRole
            // 
            this.uxRole.Location = new System.Drawing.Point(287, 50);
            this.uxRole.Name = "uxRole";
            this.uxRole.Size = new System.Drawing.Size(93, 20);
            this.uxRole.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Role:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // uxAddActor
            // 
            this.uxAddActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddActor.Location = new System.Drawing.Point(102, 81);
            this.uxAddActor.Name = "uxAddActor";
            this.uxAddActor.Size = new System.Drawing.Size(203, 24);
            this.uxAddActor.TabIndex = 33;
            this.uxAddActor.Text = "Add Actor";
            this.uxAddActor.UseVisualStyleBackColor = true;
            this.uxAddActor.Click += new System.EventHandler(this.uxAddActor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "First Name:";
            // 
            // uxGender
            // 
            this.uxGender.Location = new System.Drawing.Point(215, 50);
            this.uxGender.Name = "uxGender";
            this.uxGender.Size = new System.Drawing.Size(66, 20);
            this.uxGender.TabIndex = 35;
            // 
            // uxLastName
            // 
            this.uxLastName.Location = new System.Drawing.Point(131, 50);
            this.uxLastName.Name = "uxLastName";
            this.uxLastName.Size = new System.Drawing.Size(78, 20);
            this.uxLastName.TabIndex = 34;
            // 
            // uxFirstName
            // 
            this.uxFirstName.Location = new System.Drawing.Point(47, 50);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(78, 20);
            this.uxFirstName.TabIndex = 33;
            this.uxFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // uxDBInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(787, 337);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uxDatePicker);
            this.Controls.Add(this.uxDateLabel);
            this.Controls.Add(this.uxGenreBox);
            this.Controls.Add(this.uxGenreLabel);
            this.Controls.Add(this.uxLanguageBox);
            this.Controls.Add(this.uxProfitBox);
            this.Controls.Add(this.uxCostLabel);
            this.Controls.Add(this.uxProfitLabel);
            this.Controls.Add(this.uxAddMovieButton);
            this.Controls.Add(this.uxDirectorBox);
            this.Controls.Add(this.uxDirectorLabel);
            this.Controls.Add(this.uxMovieLabel);
            this.Controls.Add(this.uxTitleBox);
            this.Name = "uxDBInsertForm";
            this.Text = "DBInsertForm";
            this.Load += new System.EventHandler(this.uxDBInsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uxTitleBox;
        private System.Windows.Forms.Label uxMovieLabel;
        private System.Windows.Forms.Label uxDirectorLabel;
        private System.Windows.Forms.TextBox uxDirectorBox;
        private System.Windows.Forms.Label uxProfitLabel;
        private System.Windows.Forms.Label uxCostLabel;
        private System.Windows.Forms.TextBox uxProfitBox;
        private System.Windows.Forms.TextBox uxLanguageBox;
        private System.Windows.Forms.Button uxAddMovieButton;
        private System.Windows.Forms.Label uxGenreLabel;
        private System.Windows.Forms.ComboBox uxGenreBox;
        private System.Windows.Forms.Label uxDateLabel;
        private System.Windows.Forms.DateTimePicker uxDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource actorBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox uxGender;
        private System.Windows.Forms.TextBox uxLastName;
        private System.Windows.Forms.TextBox uxFirstName;
        private System.Windows.Forms.TextBox uxRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button uxAddActor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox uxCastList;
    }
}

