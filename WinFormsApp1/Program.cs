using System;
using System.Windows.Forms;
using Autofac;

namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread] //атрибут
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var container = Bootstrapper.Configure();

            var mainForm = container.Resolve<MainForm>();
            Application.Run(mainForm);
        }
    }
}