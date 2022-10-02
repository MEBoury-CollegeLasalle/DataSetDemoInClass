using DataSetDemoInClass.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetDemoInClass.BLL {
    public class InitManager {

        public static DataSet APPLICATION_DATASET;
        public static SqlConnection CONNECTION;

        public static void OpenMainMenu() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DemoMainMenu());
        }

        public static DataSet GetDataSet() {
            if (InitManager.APPLICATION_DATASET == null) {
                InitManager.APPLICATION_DATASET = new DataSet();
            }
            return InitManager.APPLICATION_DATASET;
        }

        public static SqlConnection GetConnection() {
            if (InitManager.CONNECTION == null) {
                InitManager.CONNECTION = new SqlConnection("Server=.\\SQL2019EXPRESS;Integrated security=true; Database=db_demo1;");
            }
            return InitManager.CONNECTION;
        }

        public static void OpenDemoTableWindow() {
            DemoTableController.OpenDemoTableGridView();
        }
    }
}
