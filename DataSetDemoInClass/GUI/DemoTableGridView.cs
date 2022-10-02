using DataSetDemoInClass.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetDemoInClass.GUI {
    public partial class DemoTableGridView : Form {

        public DemoTableGridView() {
            InitializeComponent();
        }

        public void BindTableToGridView(DataTable table) {
            this.dataGridView1.DataSource = table;
            this.Refresh();
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            DemoTableController.PushChangesToDatabase();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            DemoTableController.CloseDemoTableGridView();
        }
    }
}
