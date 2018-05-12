/*Nicholas Weidman
 *11/15/17
 *
 * Contract class that allows a new contract to be created, and for its details to be entered, retreived, and editied
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Contract
    {
        private String contractNumber, startLocation, necessaryProcesses;
        private String dueDate, entryDate, expectedCompletion;

        //Creates and initializes a new contract
        public Contract(String newContractNumber, String newStartLocation, String newNecessaryProcesses, String newDueDate, String newEntryDate, String newExpectedCompletion)
        {
            contractNumber = newContractNumber;
            startLocation = newStartLocation;
            necessaryProcesses = newNecessaryProcesses;
            dueDate = newDueDate;
            entryDate = newEntryDate;
            expectedCompletion = newExpectedCompletion;
        }

        //Methods that return each variable for a contract
        public String getContractNumber() { return contractNumber; }
        public String getStartLocation() { return startLocation; }
        public String getNecessaryProcesses() { return necessaryProcesses; }
        public String getDueDate() { return dueDate; }
        public String getEntryDate() { return entryDate; }
        public String getExpectedCompletion() { return expectedCompletion; }

        //Methods that set variables for the contract
        public void setDueDate(String newDueDate) { dueDate = newDueDate; }
        public void setExpectedCompletion(String newExpectedCompletion) { expectedCompletion = newExpectedCompletion; }


        //Formats a contract's due date and number to be loaded on to the available contracts form
        public String ToString()
        {
            return dueDate + "      " + contractNumber + "\n";
        }

    }
}
