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
    public partial class ArchivedContracts : Form
    {
        public ArchivedContracts()
        {
            InitializeComponent();
        }

        //Select Button
        private void select_btn_Click(object sender, EventArgs e)
        {

        }

        //Exit Button; close the form
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Selection newSelectionScreen = new Selection();
            newSelectionScreen.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a contract to view its details.");
        }
    }
}
