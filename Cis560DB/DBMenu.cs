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

        /*
         * Initializes the DBMenu Form
         */
        public uxDBMenu()
        {
            InitializeComponent();
        }

        /*
         * Creates an instance of the DBInsertForm. The form allows the user to add a movie 
         * to the Movie Database.
         */
        private void uxInsertMovie_Click(object sender, EventArgs e)
        {
            if (uxInsertMoviewButton.Enabled == true) {
                uxInsertForm = new uxDBInsertForm();
                uxInsertForm.SubmitEvent  += new enableInsertButton(uxDBInsertForm_ButtonEnabled);
                uxInsertForm.Show();
                uxInsertMoviewButton.Enabled = false;
            }
        }

        /*
        * Creates an instance of the DBSearchForm. The form allows the user to search for 
        * a movie within the database.
        */
        private void uxSearch_Click(object sender, EventArgs e)
        {
            if (uxSearchButton.Enabled == true) {
                uxSearchForm = new uxDBSearchForm();
                uxSearchForm.SubmitEvent += new enableSearchButton(uxDBSearchForm_ButtonEnabled);
                uxSearchForm.Show();
                uxSearchButton.Enabled = false;
            }
        }

        /*
         * Creates an instance of the DBReviewForm. The form allows the user to rate and add 
         * a review of the movie to the database.
         */
        private void uxAddReview_Click(object sender, EventArgs e)
        {
            if (uxAddReviewButton.Enabled == true) {
                uxReviewForm = new uxDBReviewForm();
                uxReviewForm.SubmitEvent += new enableReviewButton(uxDBReviewForm_ButtonEnabled);
                uxReviewForm.Show();
                uxAddReviewButton.Enabled = false;
            } 
        }

        /*
         * Called by the delagate in the DBReviewForm Class. Allows the uxAddReviewButton 
         * to unlock after the DBReviewForm is closed.
         */
        void uxDBReviewForm_ButtonEnabled() {
            uxAddReviewButton.Enabled = true; 
        }

        /*
         * Called by the delagate in the DBInsertForm Class. Allows the uxInsertMovieButton
         * to unlock after the DBInsertForm is closed.
         */
        void uxDBInsertForm_ButtonEnabled() {
            uxInsertMoviewButton.Enabled = true;
        }

        /*
         * Called by the delagate in the DBSearchForm Class. Allows the uxSearchButton
         * to unlock after the DBSearchForm is closed.
         */
        void uxDBSearchForm_ButtonEnabled()
        {
            uxSearchButton.Enabled = true;
        }
    }
}
