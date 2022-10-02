using DataSetDemoInClass.DAL;
using DataSetDemoInClass.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetDemoInClass.BLL {
    public class DemoTableController {

        public static DemoTableGridView DEMO_TABLE_GRIDVIEW;


        public static DemoTableGridView GetGridView() {
            if (DemoTableController.DEMO_TABLE_GRIDVIEW == null) {
                DemoTableController.DEMO_TABLE_GRIDVIEW = new DemoTableGridView();
            }
            return DemoTableController.DEMO_TABLE_GRIDVIEW;
        }

        public static DataTable GetDataTable() {
            DataSet dataSet = InitManager.GetDataSet();
            DataTable demoTable;

            if (!dataSet.Tables.Contains("DemoTable")) {
                InitManager.GetConnection().Open();
                DemoTable.GetDataAdapter(InitManager.GetConnection()).Fill(dataSet, "DemoTable");
                InitManager.GetConnection().Close();

                demoTable = dataSet.Tables["DemoTable"];

                demoTable.PrimaryKey = new DataColumn[1] { demoTable.Columns["id"] };
                demoTable.Columns["id"].AutoIncrementSeed = 0;
                demoTable.Columns["id"].AutoIncrementStep = -1;
                demoTable.Columns["id"].ReadOnly = true;
                demoTable.Columns["aRelationshipId"].AllowDBNull = true;
                demoTable.Columns["aDateTime"].ReadOnly = true;
                demoTable.Columns["aDateTime"].AllowDBNull = true;

            } else {
                demoTable = dataSet.Tables["DemoTable"];
            }
            return demoTable;
        }

        public static void OpenDemoTableGridView() {
            DataTable demoTable = DemoTableController.GetDataTable();
            DemoTableController.GetGridView().BindTableToGridView(demoTable);
            DemoTableController.GetGridView().ShowDialog();
        }

        public static void CloseDemoTableGridView() {
            DemoTableController.GetGridView().DialogResult = DialogResult.Cancel;
        }

        public static void PushChangesToDatabase() {
            SqlDataAdapter adapter = DemoTable.GetDataAdapter(InitManager.GetConnection());
            DataTable demoTable = DemoTableController.GetDataTable();
            InitManager.GetConnection().Open();
            adapter.Update(demoTable);
            InitManager.GetConnection().Close();
            demoTable.AcceptChanges();
        }
    }
}
