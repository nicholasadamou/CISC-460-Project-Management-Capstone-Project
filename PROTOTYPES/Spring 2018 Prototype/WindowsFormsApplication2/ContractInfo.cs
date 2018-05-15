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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ContractInfo : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd = new SqlCommand();
        private string source;

        //Attributes of the contracted selected on the Available Contracts form
        private String selectedContractNumber; //The contract number of the contract being loaded
        private DateTime selectedDueDate;
        private DateTime selectedEntryDate;
        private DateTime selectedExpectedCompletionDate;
        private String selectedStartLocation;
        private String selectedCurrentLocation;
        private String selectedProcesses;

        private string dbPath = "C:\\Users\\Student\\Documents\\Systems Project.mdf"; //Path to the database


        public ContractInfo(String contractNumber)
        {

            InitializeComponent();

            selectedContractNumber = contractNumber;

            source = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + dbPath + ";Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(source);

            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLoadContractDetails";
            SqlDataReader reader;
            cmd.Parameters.AddWithValue("@ContractNumber", selectedContractNumber).Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@DueDate", SqlDbType.Date).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@EntryDate", SqlDbType.Date).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@ExpectedCompletionDate", SqlDbType.Date).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@CurrentLocation", SqlDbType.VarChar, 3).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@StartLocation", SqlDbType.VarChar, 3).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@NecessaryProcesses", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

            {
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows) //<-----
                {
                    reader.Read();
                    
                    selectedDueDate = (System.DateTime)reader.GetValue(0);
                    selectedEntryDate = (System.DateTime)reader.GetValue(1);
                    selectedExpectedCompletionDate = (System.DateTime)reader.GetValue(2);
                    selectedCurrentLocation = (String)reader.GetValue(3);
                    selectedStartLocation = (String)reader.GetValue(4);
                    selectedProcesses = (String)reader.GetValue(5);

                    conn.Close();
                    cmd.Parameters.Clear();
                    reader.Close();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("Contract Not Found");
                    conn.Close();
                    cmd.Parameters.Clear();
                }
            }
        }

        public ContractInfo()
        {
            InitializeComponent();
        }

        //Loads the contract information into the proper locations
        private void ContractInfo_Load(object sender, EventArgs e)
        {
            contract_num_textbx.Text = selectedContractNumber;
            dueDate_dtetimepckr.Value = selectedDueDate;
            entryDate_dtetimepckr.Value = selectedEntryDate;
            expComplDate_dtetimepckr.Value = selectedExpectedCompletionDate;
            startLocation_textbx.Text = selectedStartLocation;
            currentLocationMsked.Text = selectedCurrentLocation;
            processes_rchtxtbx.Text = selectedProcesses;
        }

        //Displays a help message box for the user
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecting the contract will select it for manufacturing.\nUpdating the contract will allow for the" +
                " expected completion date and due date to be changed.\nSubmit will submit any changes made to the contract.)");
        }

        //Informs the user that the contract has been selected for manufacturing
        private void select_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The contract has been selected for manufacturing");
        }

        private void exit_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //UPDATE
        private void update_btn_Click_1(object sender, EventArgs e)
        {
            dueDate_dtetimepckr.Enabled = expComplDate_dtetimepckr.Enabled = currentLocationMsked.Enabled = submit_btn.Enabled = update_btn.Enabled;
        }

        private void submit_btn_Click_1(object sender, EventArgs e)
        {
            dueDate_dtetimepckr.Enabled = expComplDate_dtetimepckr.Enabled = currentLocationMsked.Enabled = submit_btn.Enabled = !update_btn.Enabled;

            SqlCommand updatecmd = new SqlCommand();
            updatecmd.Connection = conn;
            updatecmd.CommandType = CommandType.StoredProcedure;
            updatecmd.CommandText = "spUpdateContract";

            updatecmd.Parameters.AddWithValue("DueDate", dueDate_dtetimepckr.Value).Direction = ParameterDirection.Input;
            updatecmd.Parameters.AddWithValue("ExpectedCompletionDate", expComplDate_dtetimepckr.Value).Direction = ParameterDirection.Input;
            updatecmd.Parameters.AddWithValue("CurrentLocation", currentLocationMsked.Text).Direction = ParameterDirection.Input;
            updatecmd.Parameters.AddWithValue("ContractNumber", contract_num_textbx.Text).Direction = ParameterDirection.Input;

            updatecmd.Parameters.Add("@RowCount", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            try
            {
                conn.Open();
                updatecmd.ExecuteNonQuery();
                if (updatecmd.UpdatedRowSource > 0)
                {
                    MessageBox.Show("Successful");
                }
                else
                {
                    MessageBox.Show("Unsuccessful");
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

        //select contract
        private void select_btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}