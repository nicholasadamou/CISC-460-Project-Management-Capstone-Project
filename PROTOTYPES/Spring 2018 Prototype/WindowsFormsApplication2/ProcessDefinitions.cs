/*Nicholas Weidman, Jared Loucks, Farheen Fatima, Nicholas Adamou
 *5/9/18
 *Display each of the defined processes and their descriptions
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
    public partial class ProcessDefinitions : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd = new SqlCommand();
        private string source; //Database source to query
        private string dbPath = "C:\\Users\\Student\\Documents\\Systems Project.mdf"; //Path to the database

        //Load all of the processes and descriptions on to the form
        public ProcessDefinitions()
        {
            InitializeComponent();

            source = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + dbPath + ";Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(source);

            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spFindProcess";
            SqlDataReader reader;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        process_num_rchtxtbx.Text += (String)reader.GetValue(0) + '\n';
                        description_rchtxtbx.Text += (String)reader.GetValue(1) + '\n';
                    }
                }
                else
                {
                    MessageBox.Show("Processes not found");
                }
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

        //Close this form and return the user to the Selection form
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Selection newSelectionScreen = new Selection();
            newSelectionScreen.Show();
            this.Close();
        }
    }
}
