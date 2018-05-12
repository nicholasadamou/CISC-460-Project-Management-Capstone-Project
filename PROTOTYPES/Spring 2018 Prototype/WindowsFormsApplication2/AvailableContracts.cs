/*Nicholas Weidman, Jared Loucks, Farheen Fatima, Nicholas Adamou
 *5/9/18
 *
 *Available contracts form, that allows the user to view and select contracts available for manufacturing 
 *Users can also migrate completed contracts to the Archived database
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

        //Closes this form, and opens the selection form
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

        //Loads a help message box that tells a user what they must do with this form
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a contract to view its details.");
        }

        //Loads the contract information in a new form for the user selected contract
        private void select_btn_Click(object sender, EventArgs e)
        {
            if (selection_mskedtxtbx.Text.Length != 9)
            {
                MessageBox.Show("Please enter a contract number");
            }
            else
            {
                ContractInfo contractInfoScreen = new ContractInfo(selection_mskedtxtbx.Text);
                this.Close();
            }
           
        }

        //Loads the contract number, due date, and expected completion date of each available contract in the Contract database table
        private void loadContracts()
        {
            available_rchtxtbx.Text = "Contract Number\tDue Date\t\t\tExpected Completion Date\n" +
                "-----------------------------------------------------------------------------------------------------------------------------------\n";

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

        //Toggles whether all available contracts or only delinquent contracts are diaplayed
        private void delinquent_chkbx_CheckedChanged(object sender, EventArgs e)
        {
            //Display only delinquent contracts
            if (delinquent_chkbx.Checked == true)
            {
                //Prepare the textbox and format it
                available_rchtxtbx.Clear();

                available_rchtxtbx.Text = "Contract Number\tDue Date\t\t\tExpected Completion Date\n" +
                "-----------------------------------------------------------------------------------------------------------------------------------\n";

                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spLoadDelinquent";
                SqlDataReader reader;

                cmd.Parameters.AddWithValue("CurrentDate", System.DateTime.Today).Direction = ParameterDirection.Input;
                try
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //Load the contract number, due date, and expected completion date on to the form
                        String contractNumber = (String)reader.GetValue(0);
                        String dueDate = ((DateTime)reader.GetValue(1)).ToLongDateString();
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
            }
            //Load all available contracts
            else if (delinquent_chkbx.Checked == false)
            {
                available_rchtxtbx.Clear();

                available_rchtxtbx.Text = "Contract Number\tDue Date\t\t\tExpected Completion Date\n" +
                "-----------------------------------------------------------------------------------------------------------------------------------\n";

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
                        //Load the contract number, due date, and expected completion date on to the form
                        String contractNumber = (String)reader.GetValue(0);
                        String dueDate = ((DateTime)reader.GetValue(1)).ToLongDateString();
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
            }
        }

        //Removes completed contracts from the Contract table and sends them to the Archived table
        private void btn_UpdateArchive_Click(object sender, EventArgs e)
        {
            SqlCommand updatecmd = new SqlCommand();
            updatecmd.Connection = conn;
            updatecmd.CommandType = CommandType.StoredProcedure;
            updatecmd.CommandText = "spArchiveMigration";

            updatecmd.Parameters.Add("@RowCount", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            try
            {
                conn.Open();
                updatecmd.ExecuteNonQuery();
                if (updatecmd.UpdatedRowSource > 0)
                {
                    MessageBox.Show("Archive Successful");
                }
                else
                {
                    MessageBox.Show("Archive Unsuccessful");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conn.Close();
                updatecmd.Parameters.Clear();
            }
        }
    }
}
