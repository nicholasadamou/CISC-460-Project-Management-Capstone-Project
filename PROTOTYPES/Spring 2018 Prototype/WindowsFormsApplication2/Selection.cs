/*Nicholas Weidman
 *4/18/18
 * 
 * Allows the user to select a form to view and use
 * Closing this form will return the user to the sign in screen
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
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        //Set permissions according to access level
        private void Selection_Load(object sender, EventArgs e)
        {
            if (Verification.verification.Equals("Hourly"))
            {
                reports_btn.Enabled = false;
            }
        }

        //Closes the selection form and returns the user to the sign in screen
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.showSignInForm();
            this.Close();
        }

        //Loads the available contracts form and closes the selection form
        private void available_contracts_btn_Click(object sender, EventArgs e)
        {
            AvailableContracts newAvailableContractsForm = new AvailableContracts();
            newAvailableContractsForm.Show();
            this.Close();
        }

        //Loads the contract entry form and closes the selection form
        private void contract_entry_btn_Click(object sender, EventArgs e)
        {
            ContractEntry newContractEntryForm = new ContractEntry();
            newContractEntryForm.Show();
            this.Close();
        }


        //Loads the forecasting report form and closes the selection form
        private void reports_btn_Click(object sender, EventArgs e)
        {
            ForecastingReport newForecastingReportForm = new ForecastingReport();
            newForecastingReportForm.Show();
            this.Close();
        }

        //Loads the process description form and closes the selection form
        private void processes_btn_Click(object sender, EventArgs e)
        {
            ProcessDescriptions newProcessesDescriptions = new ProcessDescriptions();
            newProcessesDescriptions.Show();
            this.Close();
        }

        //Shows a help message box to the user that explains the form
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select what form you would like to view.  Exiting this screen will return you to the sign in screen.");
        }

        private void btn_ProcessDefinitions_Click(object sender, EventArgs e)
        {
            ProcessDefinitions newProcessDefinitionsForm = new ProcessDefinitions();
            newProcessDefinitionsForm.Show();
            this.Close();
        }
    }
}
