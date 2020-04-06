using System;
using System.Windows.Forms;

namespace Terminal2012
{
    static class Program
    {
        //-----------------------------------------------------------------------------------------------------------//
        
        [MTAThread]
        static void Main()
        {
            // Create Form
            frm00_MainMenu frm = new frm00_MainMenu();

            // Set WindowsState
            alfaTerm.SetWindowsState(frm);

            // Run MainForm
            Application.Run(frm);
        }

        //-----------------------------------------------------------------------------------------------------------//
    }
}