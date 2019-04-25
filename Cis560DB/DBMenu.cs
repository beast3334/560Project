using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cis560DB
{
    public partial class uxDBMenu : Form
    {
        // uxDBInsertForm object, represents the insert form to the database. 
        public uxDBInsertForm uxInsertForm;
        // uxDBSearchForm object, represents the search form to the database. 
        public uxDBSearchForm uxSearchForm;
        // uxDBReviewForm object, represents the review form of the database. 
        public uxDBReviewForm uxReviewForm;


        /// <Summary>
        /// Initializes the DBMenu Form
        /// </Summary>
        public uxDBMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates an instance of the DBInsertForm. The form allows the user to add a movie to the Movie Database.
        /// </summary>
        private void uxInsertMovie_Click(object sender, EventArgs e)
        {
            if (uxInsertMoviewButton.Enabled == true) {
                uxInsertForm = new uxDBInsertForm();
                uxInsertForm._enableButtons  += new enableButtonsInsert(uxDBMenu_ButtonsEnabled);
                uxInsertForm.Show();
                uxInsertMoviewButton.Enabled = false;
                uxAddReviewButton.Enabled = false;
                uxSearchButton.Enabled = false;
            }
        }

        /// <summary>
        ///  Creates an instance of the DBSearchForm. The form allows the user to search for a movie within the database.
        /// </summary>
        private void uxSearch_Click(object sender, EventArgs e)
        {
            if (uxSearchButton.Enabled == true) {
                uxSearchForm = new uxDBSearchForm();
                uxSearchForm._enableButtons += new enableButtonsSearch(uxDBMenu_ButtonsEnabled);
                uxSearchForm.Show();
                uxSearchButton.Enabled = false;
                uxInsertMoviewButton.Enabled = false;
                uxAddReviewButton.Enabled = false;
            }
        }

        /// <summary>
        /// Creates an instance of the DBReviewForm. The form allows the user to rate and add a review of 
        /// the movie to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddReview_Click(object sender, EventArgs e)
        {
            if (uxAddReviewButton.Enabled == true) {
                uxReviewForm = new uxDBReviewForm();
                uxReviewForm._enableButtons += new enableButtonsReview(uxDBMenu_ButtonsEnabled);
                uxReviewForm.Show();
                uxAddReviewButton.Enabled = false;
                uxInsertMoviewButton.Enabled = false;
                uxSearchButton.Enabled = false;
            }
        }

        /// <summary>
        /// Called by delagates in the DBSearchForm, DBInsertForm, and DBReviewFrom Classes. Allows the buttons 
        /// in the DBMenu to be unlocked after the one of the forms is closed.
        /// </summary>
        void uxDBMenu_ButtonsEnabled()
        {
            uxInsertMoviewButton.Enabled = true;
            uxAddReviewButton.Enabled = true;
            uxSearchButton.Enabled = true;
        }
    }
}
