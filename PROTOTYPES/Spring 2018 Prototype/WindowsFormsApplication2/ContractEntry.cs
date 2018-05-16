/*Nicholas Weidman, Jared Loucks, Nicholas Adamou, Farheen Fatima
 *5/9/18
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
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class ContractEntry : Form
    {
        private string dbPath = "C:\\Users\\Student\\Documents\\Systems Project.mdf"; //Path to the database
        private SqlConnection conn;
        private SqlCommand cmd = new SqlCommand();
        private string source; //Database source to query
        DateTime currentDate = System.DateTime.Today;

        public ContractEntry()
        {
            InitializeComponent();
        }

        //Loads the current date into the appropriate text box
        private void ContractEntry_Load(object sender, EventArgs e)
        {
            source = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + dbPath + ";Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(source);
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
            SqlCommand createcmd = new SqlCommand();
            createcmd.Connection = conn;
            createcmd.CommandType = CommandType.StoredProcedure;
            createcmd.CommandText = "spInsertContract";

            createcmd.Parameters.AddWithValue("ContractNumber", contract_number_mskedtxtbx.Text).Direction = ParameterDirection.Input;
            createcmd.Parameters.AddWithValue("DueDate", due_date.Value).Direction = ParameterDirection.Input;
            createcmd.Parameters.AddWithValue("ExpectedCompletionDate", expected_completion_date.Value).Direction = ParameterDirection.Input;
            createcmd.Parameters.AddWithValue("EntryDate", entry_date.Value).Direction = ParameterDirection.Input;
            createcmd.Parameters.AddWithValue("CurrentLocation", current_location_mskedtxtbx.Text).Direction = ParameterDirection.Input;
            createcmd.Parameters.AddWithValue("StartLocation", start_location_mskedtxtbx.Text).Direction = ParameterDirection.Input;
            createcmd.Parameters.AddWithValue("NecessaryProcesses", necessary_richtxtbx.Text).Direction = ParameterDirection.Input;
            createcmd.Parameters.AddWithValue("Selected", 0).Direction = ParameterDirection.Input;

            createcmd.Parameters.Add("@Error", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            try
            {
                conn.Open();
                createcmd.ExecuteNonQuery();
                if (createcmd.Parameters.Count > 0)
                {
                    MessageBox.Show("Successfully added");
                }
                else
                {
                    MessageBox.Show("Unsuccessful add");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conn.Close();
                createcmd.Parameters.Clear();
            }
        }
    }
}
