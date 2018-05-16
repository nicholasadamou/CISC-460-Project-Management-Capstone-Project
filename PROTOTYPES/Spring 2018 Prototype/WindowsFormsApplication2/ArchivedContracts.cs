/*Nicholas Weidman, Jared Loucks, Farheen Fatima, Nicholas Adamou
 *5/9/18
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
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class ArchivedContracts : Form
    {

        private SqlConnection conn;
        private SqlCommand cmd = new SqlCommand();
        private string source;
        private string dbPath = "C:\\Users\\Student\\Documents\\Systems Project.mdf";

        public ArchivedContracts()
        {
            InitializeComponent();
        }

        //Load a contract information screen for the specified contract
        private void select_btn_Click(object sender, EventArgs e)
        {
            ContractInfo contractInfoScreen = new ContractInfo(maskedtxtbx_Selection.Text, 0);
        }

        //Close this form and return the user to the Selection form
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Selection newSelectionScreen = new Selection();
            newSelectionScreen.Show();
        }

        //Show a help message for the form
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a contract to view its details.");
        }

        //Load archived contract details on to the form
        private void ArchivedContracts_Load(object sender, EventArgs e)
        {
            source = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + dbPath + ";Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(source);

            loadContracts();
            maskedtxtbx_Selection.Select();
        }

        //Load the contract number, expected completion date, and due date for all contracts in the Archived table
        private void loadContracts()
        {
            //+++++++
            maskedtxtbx_Selection.Text = "Contract Number"; //Select Contract by Number

            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spFindArchived";
            SqlDataReader reader;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    String contractNumber = (String)reader.GetValue(0);
                    String dueDate = ((DateTime)reader.GetValue(1)).ToLongDateString();
                    String expectedCompletionDate = ((DateTime)reader.GetValue(2)).ToLongDateString();

                    //+++++++
                    archived_rchtxtxbx.Text += contractNumber + "\t" + dueDate + "\t" + expectedCompletionDate + "\n";
                }

                reader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conn.Close();
                cmd.Parameters.Clear();
            }
        }
    }
}
