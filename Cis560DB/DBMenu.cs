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
        public uxDBInsertForm uxInsertForm;
        public uxDBSearchForm uxSearchForm;
        public uxDBReviewForm uxReviewForm;

        public uxDBMenu()
        {
            InitializeComponent();
        }

        private void uxInsertMovie_Click(object sender, EventArgs e)
        {
            if (uxInsertMoviewButton.Enabled == true) {
                uxInsertForm = new uxDBInsertForm();
                uxInsertForm._enableButton  += new enableInsertButton(uxDBInsertForm_ButtonEnabled);
                uxInsertForm.Show();
                uxInsertMoviewButton.Enabled = false;
            }
        }

        private void uxSearch_Click(object sender, EventArgs e)
        {
            if (uxSearchButton.Enabled == true) {
                uxSearchForm = new uxDBSearchForm();
                uxSearchForm._enableButton += new enableSearchButton(uxDBSearchForm_ButtonEnabled);
                uxSearchForm.Show();
                uxSearchButton.Enabled = false;
            }
        }

        private void uxAddReview_Click(object sender, EventArgs e)
        {
            if (uxAddReviewButton.Enabled == true) {
                uxReviewForm = new uxDBReviewForm();
                uxReviewForm.SubmitEvent += new enableReviewButton(uxDBReviewForm_ButtonEnabled);
                uxReviewForm.Show();
                uxAddReviewButton.Enabled = false;
            } 
        }

        //Delegate Functions
        void uxDBReviewForm_ButtonEnabled() {
            uxAddReviewButton.Enabled = true; 
        }

        void uxDBInsertForm_ButtonEnabled() {
            uxInsertMoviewButton.Enabled = true;
        }

        void uxDBSearchForm_ButtonEnabled()
        {
            uxSearchButton.Enabled = true;
        }
    }
}
