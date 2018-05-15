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
    public partial class ProcessDescriptions : Form
    {

        private SqlConnection conn;
        private SqlCommand cmd = new SqlCommand();
        private string source;
        private string dbPath = "C:\\Users\\Student\\Documents\\Systems Project.mdf"; //Path to the database

        public ProcessDescriptions()
        {
            InitializeComponent();
        }

        private void ProcessDescriptions_Load(object sender, EventArgs e)
        {
            source = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + dbPath + ";Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(source);
        }

        //CLOSE
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Selection newSelectionScreen = new Selection();
            newSelectionScreen.Show();
            this.Close();
        }

        //SUBMIT
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Check Input Code vs. other codes
            //If there, update what is there
            //If not there, create new

            SqlCommand updatecmd = new SqlCommand();
            updatecmd.Connection = conn;
            updatecmd.CommandType = CommandType.StoredProcedure;
            updatecmd.CommandText = "spUpdateProcess";

            updatecmd.Parameters.AddWithValue("Processes", code_mskedtxtbx.Text).Direction = ParameterDirection.Input;
            updatecmd.Parameters.AddWithValue("ProcessDescription", information_rchtxtbx.Text).Direction = ParameterDirection.Input;

            updatecmd.Parameters.Add("@RowCount", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            try
            {
                conn.Open();
                updatecmd.ExecuteNonQuery();
                if (updatecmd.UpdatedRowSource.Equals(1))
                {
                    MessageBox.Show("Successful");
                }
                else
                {
                   createProcess(); //AAAAAAAAA HI
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand deletecmd = new SqlCommand();
            deletecmd.Connection = conn;
            deletecmd.CommandType = CommandType.StoredProcedure;
            deletecmd.CommandText = "spDeleteProcess";

            deletecmd.Parameters.AddWithValue("Processes", code_mskedtxtbx.Text).Direction = ParameterDirection.Input;

            deletecmd.Parameters.Add("@RowCount", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            try
            {
                conn.Open();
                deletecmd.ExecuteNonQuery();
                if (deletecmd.Parameters.Count > 0)
                {
                    MessageBox.Show("Process has been deleted");
                }
                else
                {
                    MessageBox.Show("Delete unsuccessful");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conn.Close();
                deletecmd.Parameters.Clear();
            }
        }

        private void createProcess()
        {
            SqlCommand createcmd = new SqlCommand();
            createcmd.Connection = conn;
            createcmd.CommandType = CommandType.StoredProcedure;
            createcmd.CommandText = "spCreateProcess";

            createcmd.Parameters.AddWithValue("Processes", code_mskedtxtbx.Text).Direction = ParameterDirection.Input;
            createcmd.Parameters.AddWithValue("ProcessDescription", information_rchtxtbx.Text).Direction = ParameterDirection.Input;

            createcmd.Parameters.Add("@Error", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            try
            {
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
                createcmd.Parameters.Clear();
            }
        }
    }
}

