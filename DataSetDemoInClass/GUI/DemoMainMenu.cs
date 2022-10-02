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
    public partial class DemoMainMenu : Form {
        public DemoMainMenu() {
            InitializeComponent();
        }

        private void buttonOpenDemoTable_Click(object sender, EventArgs e) {
            InitManager.OpenDemoTableWindow();
        }
    }
}
