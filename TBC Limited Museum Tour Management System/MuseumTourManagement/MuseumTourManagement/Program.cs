﻿using MuseumTourManagement.Forms;
using System;
using System.Windows.Forms;

namespace MuseumTourManagement
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());  // Ensure LoginForm starts
        }
    }
}
