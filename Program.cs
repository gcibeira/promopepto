using System.Diagnostics;
using System.Reflection;

namespace promopepto
{
    internal static class Program
    {
        static Mutex mutex = new Mutex(true, Assembly.GetExecutingAssembly().GetName().Name);

        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Application already running!");
            }
        }
    }
}