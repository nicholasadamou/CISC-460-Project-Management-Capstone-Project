/*Nicholas Weidman, Jared Loucks, Farheen Fatima, Nicholas Adamou
 *Last Updated 4/25/18
 *
 *Available contracts form, that allows the user to view and select contracts available for manufacturing 
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class AvailableContracts : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd = new SqlCommand();
        private string source;
        private string dbPath = "C:\\Users\\Student\\Documents\\Systems Project.mdf";

        public AvailableContracts()
        {
            InitializeComponent();
        }

        //EXIT - Closes this form, and opens the selection form
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Selection newSelectionScreen = new Selection();
            newSelectionScreen.Show();
            this.Close();
        }

        //Loads the available contracts on to the form
        private void AvailableContracts_Load(object sender, EventArgs e)
        {
            source = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + dbPath + ";Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(source);

            loadContracts();

        }

        //HELP - Loads a help message box that tells a user what they must do with this form
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a contract to view its details.");
        }

        //Loads the contract information in a new form for the user selected contract
        private void select_btn_Click(object sender, EventArgs e)
        {
            ContractInfo contractInfoScreen = new ContractInfo(selection_mskedtxtbx.Text);
        }

        private void loadContracts()
        {
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spFindContract";
            SqlDataReader reader;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    String contractNumber = (String)reader.GetValue(0);
                    String dueDate = ((DateTime) reader.GetValue(1)).ToLongDateString();
                    String expectedCompletionDate = ((DateTime)reader.GetValue(2)).ToLongDateString();

                    available_rchtxtbx.Text += contractNumber + "\t" + dueDate + "\t" + expectedCompletionDate + "\n";
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

            selection_mskedtxtbx.Select(); //Focus Selection Masked Text Box
        }
    }
}
