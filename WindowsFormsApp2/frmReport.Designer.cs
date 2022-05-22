
namespace WindowsFormsApp2 {
  partial class frmReport {
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
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(312, 204);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(120, 29);
      this.label2.TabIndex = 0;
      this.label2.Text = "frmReport";
      // 
      // frmReport
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label2);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmReport";
      this.Text = "frmReport";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label2;
  }
}