/*Nicholas Weidman
 *11/15/17
 *
 *Available contracts form, that allows the user to view and select contracts available for manufacturing 
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
    public partial class AvailableContracts : Form
    {
        public AvailableContracts()
        {
            InitializeComponent();
        }

        //Closes this form, and opens the selection form
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Selection newSelectionScreen = new Selection();
            newSelectionScreen.Show();
        }

        //Loads the available contracts on to the form
        private void AvailableContracts_Load(object sender, EventArgs e)
        {
            available_rchtxtbx.Text = Program.LoadContracts();
        }

        //Loads a help message box that tells a user what they must do with this form
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a contract to view its details.");
        }

        //Loads the contract information in a new form for the user selected contract
        private void select_btn_Click(object sender, EventArgs e)
        {
            ContractInfo contractInfoScreen = new ContractInfo();
            contractInfoScreen.setSelectedContractNumber(selection_mskedtxtbx.Text);
            contractInfoScreen.Show();
        }
    }
}
