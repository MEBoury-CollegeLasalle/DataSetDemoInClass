namespace DataSetDemoInClass.GUI {
    partial class DemoMainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonOpenDemoTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenDemoTable
            // 
            this.buttonOpenDemoTable.Location = new System.Drawing.Point(304, 176);
            this.buttonOpenDemoTable.Name = "buttonOpenDemoTable";
            this.buttonOpenDemoTable.Size = new System.Drawing.Size(176, 63);
            this.buttonOpenDemoTable.TabIndex = 0;
            this.buttonOpenDemoTable.Text = "Open Demo Table";
            this.buttonOpenDemoTable.UseVisualStyleBackColor = true;
            this.buttonOpenDemoTable.Click += new System.EventHandler(this.buttonOpenDemoTable_Click);
            // 
            // DemoMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOpenDemoTable);
            this.Name = "DemoMainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenDemoTable;
    }
}

