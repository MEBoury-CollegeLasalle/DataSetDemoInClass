using DataSetDemoInClass.BLL;
using DataSetDemoInClass.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetDemoInClass {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            InitManager.OpenMainMenu();
        }
    }
}
