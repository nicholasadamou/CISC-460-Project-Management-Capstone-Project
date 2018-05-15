/*Nicholas Weidman, Nicholas Adamou, Jared Loucks, Farheen Fatima
 * Last Updated 4/18/18
 * 
 * Sign in form that allows users to attempt logging into the system.
 * 
 * If a user enters incorrect credentials into the system ten times in a row,
 * they are required to wait ten minutes before trying again.
 * 
 * If the user successfully logs in, a string representing access level is passed to the next form for authentication
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
    struct Verification
    {
        public static String verification;
    }
    public partial class Sign_in_form : Form
    {
        int signInCounter = 0; //Sign in counter that will prevent users from attempting a sign in more than 10 times
        Timer signInTimer = new Timer(); //Timer used for the ten minute wait if users enter credentials incorrectly ten times
        private SqlConnection conn;
        private SqlCommand cmd = new SqlCommand();
        private string source; //Database source to query
        private string verification; //Employee access level to pass to the next form
        private string dbPath = "C:\\Users\\Student\\Documents\\Systems Project.mdf"; //Path to the database

        public Sign_in_form()
        {
            InitializeComponent();
        }

        //Create the database connection
        private void Sign_in_form_Load(object sender, EventArgs e)
        {
            source = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + dbPath + ";Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(source);
        }

        //Allows the user to sign into the system if they provide the correct credentials
        //If credentials are incorrect, the user is asked to try again
        private void sign_in_btn_Click(object sender, EventArgs e)
        {
            //The user is only allowed to attempt a sign in ten times every ten minutes
            if (signInCounter < 5)
            {
                if ((username_textbx.Text == "") || (password_textbx.Text == ""))
                {
                    MessageBox.Show("Please enter a username and password");
                    username_textbx.Focus();
                }
                else
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spFindUser";
                    SqlDataReader reader;
                    cmd.Parameters.AddWithValue("@Username", username_textbx.Text).Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@Password", password_textbx.Text).Direction = ParameterDirection.Input;

                    try
                    {
                        conn.Open();
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            //Load the next form and pass the access level string to it for user authentication
                            reader.Read();
                            verification = (string) reader.GetValue(2);
                            Verification.verification = verification;
                            Selection selectionForm = new Selection();
                            selectionForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Access Denied");
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
            }
            else
            {
                //If the user enters credentials incorrectly ten times in ten minutes, they are required to wait before trying again
                MessageBox.Show("Please try again in 10 minutes");
                signInTimer.Interval = 600000;
                username_textbx.ReadOnly = password_textbx.ReadOnly = true;
                signInTimer.Tick += new EventHandler(readOnlyChanger);
                signInTimer.Start();
            }
        }

        //Display a user's password hint in a message box
        private void forgotPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            source = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + dbPath + ";Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(source);

            if ((username_textbx.Text == ""))
            {
                MessageBox.Show("Please enter a username.");
                username_textbx.Focus();
            }
            else
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spFindHint";
                SqlDataReader reader;
                cmd.Parameters.AddWithValue("@Username", username_textbx.Text).Direction = ParameterDirection.Input;
                
                try
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //Print the password hint in a message box
                        reader.Read();
                        string pwhint = (String) reader.GetValue(0);
                        MessageBox.Show(pwhint);
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Access Denied");
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
        }

        //Toggles the ability for users to enter data in the textboxes
        //Used if the user enters credentials incorrectly ten times, and is required to wait before trying again
        private void readOnlyChanger(object sender, EventArgs e)
        {
            if (username_textbx.ReadOnly == password_textbx.ReadOnly == true)
            {
                username_textbx.ReadOnly = password_textbx.ReadOnly = false;
            }
            else
            {
                username_textbx.ReadOnly = password_textbx.ReadOnly = true;
            }
        }

        //Exit the form and close the program
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
