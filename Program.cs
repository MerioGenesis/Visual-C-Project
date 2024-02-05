using DryIoc.FastExpressionCompiler.LightExpression;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            // Run your WinForms application
            Application.Run(new LoginForm());
        }

        /// <summary>
        /// Subscribing LogError function to Exception Thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            LogError(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception ex)
            {
                LogError(ex);
            }
        }

        /// <summary>
        /// Creates an error log in the default directory
        /// </summary>
        /// <param name="ex"></param>
        private static void LogError(Exception ex)
        {
            string logFilePath = "Error Log" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine("Error Time: " + DateTime.Now.ToString());
                writer.WriteLine("Error encountered: " + ex.Message);
                writer.WriteLine("----------------------------------------------");
            }
        }
    }
}
