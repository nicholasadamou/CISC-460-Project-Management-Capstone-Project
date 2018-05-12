/*Nicholas Weidman
 *11/15/16
 *
 *A form to display the details of a user selected contract.
 *Selecting a contract from this form will allow the user to begin manufacturing it
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
    public partial class ContractInfo : Form
    {
        private Contract selectedContract; //The contract being loaded
        private String selectedContractNumber; //The contract number of the contract being loaded

        public ContractInfo()
        {
            InitializeComponent();
        }

        //Sets a new contract number
        public void setSelectedContractNumber(String newContractNumber) { selectedContractNumber = newContractNumber; }

        //Closes the contract info form
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Loads the contract information into the proper locations
        private void ContractInfo_Load(object sender, EventArgs e)
        {
            //Finds the selected contract in the list of available contracts
            if (Program.findContract(selectedContractNumber) != null)
            {
                selectedContract = Program.findContract(selectedContractNumber);

                //Places contract information in the correct text boxes
                contract_num_textbx.Text = selectedContract.getContractNumber();
                due_date_mskdtxtbx.Text = selectedContract.getDueDate();
                entry_date_mskdtxtbx.Text = selectedContract.getEntryDate();
                expected_mskdtxtbx.Text = selectedContract.getExpectedCompletion();
                start_location_textbx.Text = selectedContract.getStartLocation();
                processes_rchtxtbx.Text = selectedContract.getNecessaryProcesses();
            }
            else
            {
                MessageBox.Show("Specified contract not found, please try again");
                this.Close();
            }
        }

        //Displays a help message box for the user
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecting the contract will select it for manufacturing.\nUpdating the contract will allow for the" +
                " expected completion date and due date to be changed.\nSubmit will submit any changes made to the contract.)");
        }

        //Changes the read only property of the due date and expected completion date text boxes
        //Allows the user to update contract information
        private void update_btn_Click(object sender, EventArgs e)
        {
            due_date_mskdtxtbx.ReadOnly = expected_mskdtxtbx.ReadOnly = false;
        }
        
        //Submits any changes to the contract information
        private void submit_btn_Click(object sender, EventArgs e)
        {
            Program.updateContract(contract_num_textbx.Text, due_date_mskdtxtbx.Text, expected_mskdtxtbx.Text);
            MessageBox.Show("The contract was successfully updated");
        }

        //Informs the user that the contract has been selected for manufacturing
        private void select_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The contract has been selected for manufacturing");
        }
    }
}
