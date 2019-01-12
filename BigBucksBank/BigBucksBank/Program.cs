/* This program works as a ATM. Program asks user for their user name
 * and password and provides up tothree attemps for user inputs.  After 
 * three attemps, program is going to ask for bank office account
 * for further attemps.  Only user name can allow enter, if it's a bank
 * officer's user name, using enter key to release password option.  Then
 * enter password by using enter key.  After that, button for logging in 
 * release.  At the same, bank office can use this to close the program. 
 * After logging in, user can choose to transactions or exit program
 * to log in page.  In each transaction, validation for money asks for
 * specific formate(ex. "1" as "1.00").  After each transactions, a 
 * receipt will print except option for "check balance". In additon,
 * program goes back to main menu.  User can keep doing what they
 * want. Futhermore, program considers uppercase and lowercase letters from
 * user name are same.
 * 
 * Conditions for all entries:
 * user name (8 characters, contain digits and letters, with a leading
 * letter), password (4 digits which means it's a number), money(well format,
 * not negative, a decimal number, enough money to do transaction), 
 * account Number (8 digits number, reflect to accounts under user name),
 */

//Ruifeng Zhang
//Mar 4,2016
//CIT-287-S1






using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBank
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
