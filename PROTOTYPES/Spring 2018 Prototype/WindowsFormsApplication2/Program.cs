/*Nicholas Weidman
 *11/16/17
 *
 * Main program to run the system.  Also provides methods to manipulate contract information,
 * as well as the sign in form
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication2
{
    static class Program
    {

        static private Sign_in_form newSignInForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        //Begins the program by loading the sign in form
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            newSignInForm = new Sign_in_form();

            Application.Run(newSignInForm);

            Application.Exit();
        }

        //Shows the sign in form, allowing the user to sign in again
        public static void showSignInForm()
        {

            newSignInForm.Show();
        }
         
    }
}
