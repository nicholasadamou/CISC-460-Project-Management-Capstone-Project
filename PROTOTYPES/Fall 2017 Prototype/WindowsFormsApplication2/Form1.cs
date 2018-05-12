/*Nicholas Weidman
 * 11/16/17
 * 
 * Sign in form that allows users to attempt logging into the system
 * If a user enters incorrect credentials into the system ten times in a row,
 * they are required to wait ten minutes before trying again
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
    public partial class Sign_in_form : Form
    {
        int signInCounter = 0;//Sign in counter that will prevent users from attempting a sign in more than 10 times
        Timer signInTimer = new Timer();//Timer used for the ten minute wait if users enter credentials incorrectly ten times

        public Sign_in_form()
        {
            InitializeComponent();
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

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Allows the user to sign into the system if they provide the correct credentials
        //If credentials are incorrect, the user is asked to try again
        private void sign_in_btn_Click(object sender, EventArgs e)
        {
            //The user is only allowed to attempt a sign in ten times every ten minutes
            if (signInCounter < 10)
            {

                if (username_textbx.Text.Equals("admin"))
                {
                    if (password_textbx.Text.Equals("admin"))
                    {
                        //If the username and password is entered correctly, the user is granted access to the system
                        this.Hide();
                        Selection newSelectionScreen = new Selection();
                        newSelectionScreen.Show();
                    }
                    else
                    {
                        password_textbx.Clear();
                        MessageBox.Show("Please reenter your password", "", MessageBoxButtons.OK);
                        signInCounter++;
                    }
                }
                else
                {
                    username_textbx.Clear();
                    password_textbx.Clear();
                    MessageBox.Show("Please reenter your username", "", MessageBoxButtons.OK);
                    signInCounter++;
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
    }
}
