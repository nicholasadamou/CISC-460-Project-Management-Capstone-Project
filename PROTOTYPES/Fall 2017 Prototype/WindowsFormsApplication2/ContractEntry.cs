/*Nicholas Weidman
 *11/15/17
 *
 *A contract entry form that allows the user to enter the details of a new contract
 *and submit it to the system.
 *
 *All fields must be completed before the conract is allowed to be submitted.
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
using System.Collections;

namespace WindowsFormsApplication2
{
    public partial class ContractEntry : Form
    {
        DateTime currentDate = System.DateTime.Today;

        public ContractEntry()
        {
            InitializeComponent();
        }

        //Loads the current date into the appropriate text box
        private void ContractEntry_Load(object sender, EventArgs e)
        {
            entry_date_msked.Text = currentDate.ToString("MM/dd/yyyy");
        }

        //Displays the selection form screen, and closes this screen
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Selection newSelectionScreen = new Selection();
            newSelectionScreen.Show();
            this.Close();
        }

        //Submits the details of the contract to the system
        //The user must complete all fields for the contract to be submitted
        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (contract_number_mskedtxtbx.Text.Length == 0 || start_location_mskedtxtbx.Text.Length == 0 || necessary_richtxtbx.Text.Length == 0 ||
                due_date_msked.Text.Length == 0 || entry_date_msked.Text.Length == 0 || expected_completion_msked.Text.Length == 0)
            {
                MessageBox.Show("Please complete all fields");
            }
            else //Creates a new contract, enters its details, and adds it to the system list
            {
                Contract newContract = new Contract(contract_number_mskedtxtbx.Text, start_location_mskedtxtbx.Text, necessary_richtxtbx.Text,
                due_date_msked.Text, entry_date_msked.Text, expected_completion_msked.Text);

                Program.AddContract(newContract);

                contract_number_mskedtxtbx.Text = start_location_mskedtxtbx.Text = necessary_richtxtbx.Text = due_date_msked.Text =
                    expected_completion_msked.Text = null;

                MessageBox.Show("Contract successfully submitted.");
            }
        }

        //Displays a help message box for the user
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All fields must be completed before the contract can be sumbitted.  The contract will be added to the"
                + " available contract list");
        }
    }
}
