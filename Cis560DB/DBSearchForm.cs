﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cis560DB
{
    public delegate void enableSearchButton();

    public partial class uxDBSearchForm : Form
    {
        public event enableSearchButton SubmitEvent;

        public uxDBSearchForm()
        {
            InitializeComponent();

        }
        SqlConnection sqlconnection;
        SqlCommand sqlcommand;
        string ConnectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team24;Integrated Security=True";

        string Query;
        DataSet dataset;
        DataTable datatable;
        SqlDataAdapter sqladapter;

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            SubmitEvent();
            Close();
        }

        private void uxDBSearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cis560_team24DataSet3.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.cis560_team24DataSet3.Movie);
            // TODO: This line of code loads data into the 'cis560_team24DataSet2.Director' table. You can move, or remove it, as needed.
            this.directorTableAdapter.Fill(this.cis560_team24DataSet2.Director);
            // TODO: This line of code loads data into the 'cis560_team24DataSet1.Movie' table. You can move, or remove it, as needed.
            sqlconnection = new SqlConnection(ConnectionString);
            Query = "Select MovieTitle, ReleaseDate, [Language], AllTimeBoxOffice FROM MovieInfo.Movie";
            sqlcommand = new SqlCommand(Query, sqlconnection);
            sqladapter = new SqlDataAdapter();
            datatable = new DataTable();
            sqladapter.SelectCommand = sqlcommand;
            sqladapter.Fill(datatable);
            uxSearchGrid.DataSource = datatable;

        }

        private void movieIdToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
              
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void uxTitleBox_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(datatable);
            DV.RowFilter = string.Format("MovieTitle LIKE '%{0}%'", uxSearchBox.Text);
            uxSearchGrid.DataSource = DV;
        }
    }
}
