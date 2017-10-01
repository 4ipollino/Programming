using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;

namespace SimpleCalculator
{
    class Program
    {
        private static CalcUI mainForm;
        private static Engineer engForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            mainForm = new CalcUI();
            Application.Run(mainForm);
        }

        public static void SetEngineer()
        {
            try
            {
                engForm.Hide();
            }
            catch
            {

            }

            mainForm.Hide();
            engForm = new Engineer();
            engForm.Show();
            engForm.FormClosed += EngForm_FormClosed;
        }

        private static void EngForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }

        public static void SetDefault()
        {
            try
            {
                engForm.Hide();
            }
            catch
            {

            }
            
            mainForm.Hide();
            engForm = null;
            mainForm.Show();
        }


    }
}
