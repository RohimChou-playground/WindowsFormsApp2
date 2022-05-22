using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void btnReport_Click(object sender, EventArgs e) {
      this.loadForm(new frmReport());
    }

    private void btnSettings_Click(object sender, EventArgs e) {
      this.loadForm(new frmSettings());
    }

    private void loadForm(Form form) {

      form.TopLevel = false;
      form.Dock = DockStyle.Fill;

      this.panelMain.Controls.Clear();
      this.panelMain.Controls.Add(form);
      this.panelMain.Tag = form;

      form.Show();
    }

  }
}
