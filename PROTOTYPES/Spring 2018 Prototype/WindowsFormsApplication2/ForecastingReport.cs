/*Nicholas Weidman, Jared Loucks, Farheen Fatima, Nicholas Adamou
 *5/9/18
 *
 *A form that allows the user to submit and print forecasting reports for the company
 *
 * STILL IN PROGRESS
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ForecastingReport : Form
    {
        public ForecastingReport()
        {
            InitializeComponent();
        }

        //Closes the forecasting report form, and opens the form selection screen
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Selection newSelectionScreen = new Selection();
            newSelectionScreen.Show();
            this.Close();
        }

        //Clears the entry fields and informs the user that the report was successfully submitted
        //All fields must be completed for the form to be submitted
        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (forecast_period_textbx.Text.Length == 0 || ytd_revenue_mskdtxtbx.Text.Length == 0 || ytd_textbx.Text.Length == 0||
                revenue_mskdtxtbx.Text.Length == 0 || projected_contracts_textbx.Text.Length == 0)
            {
                MessageBox.Show("Please complete all fields");
            }
            else
            {
                forecast_period_textbx.Text = ytd_revenue_mskdtxtbx.Text = ytd_textbx.Text = revenue_mskdtxtbx.Text = projected_contracts_textbx.Text = null;
                MessageBox.Show("Forecast was successfully submitted");
            }
        }

        //Displays a help message box for the user
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please complete all fields before submitting the forecast report.");
        }
    }
}