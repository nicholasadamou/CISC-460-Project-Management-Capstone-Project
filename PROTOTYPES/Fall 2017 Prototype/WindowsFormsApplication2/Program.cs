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
        static private List<Contract> contractList = new List<Contract>(); //List of all contracts currently available 
        static private Contract[] loadList; //Array version of the contract list, used for manipulation of the list
        static private String contractDetails; //Concatenated list of all available contract's indexes, due dates, and contract numbers

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

        //Adds a new contract, and its details, to the list of contracts available for manufacturing 
        public static void AddContract(Contract newContract)
        {
            contractList.Add(newContract);
        }

        //Loads the list of available contracts on to the available contracts form
        public static String LoadContracts()
        {
            //Formats each contract in the array and adds it to the string
            for (int i = 0; i < contractList.Count; i++)
            {
                contractDetails += i + "      " + contractList[i].ToString();
            }

            //Returns the formatted list to be printed
            return contractDetails;
        }

        //Finds a user selected contract so the user can view the complete details of the contract
        public static Contract findContract(String chosenContract)
        {
            //loadList = contractList.ToArray();
            for (int i = 0; i < contractList.Count; i++)
            {
                if (chosenContract.Equals(contractList[i].getContractNumber()))
                {
                    return contractList[i];
                }
            }

            return null;
        }

        //Updates the due date and expected completion date for a specific contract
        public static void updateContract(String selectedContractNumber, String newDueDate, String newExpectedCompletionDate)
        {
            loadList = contractList.ToArray();

            for (int i = 0; i < contractList.Count; i++)
            {
                if (selectedContractNumber.Equals(loadList[i].getContractNumber()))
                {
                    contractList[i].setDueDate(newDueDate);
                    contractList[i].setExpectedCompletion(newExpectedCompletionDate);
                }
            }
        }

        //Shows the sign in form, allowing the user to sign in again
        public static void showSignInForm()
        {
            newSignInForm.Show();
        }
         
    }
}
