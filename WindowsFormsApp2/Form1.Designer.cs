
namespace WindowsFormsApp2 {
  partial class Form1 {
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
      this.panelHeader = new System.Windows.Forms.Panel();
      this.panelSide = new System.Windows.Forms.Panel();
      this.panelMain = new System.Windows.Forms.Panel();
      this.btnSettings = new System.Windows.Forms.Button();
      this.btnReport = new System.Windows.Forms.Button();
      this.panelSide.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelHeader
      // 
      this.panelHeader.BackColor = System.Drawing.SystemColors.ControlLight;
      this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelHeader.Location = new System.Drawing.Point(0, 0);
      this.panelHeader.Name = "panelHeader";
      this.panelHeader.Size = new System.Drawing.Size(1581, 93);
      this.panelHeader.TabIndex = 0;
      // 
      // panelSide
      // 
      this.panelSide.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.panelSide.Controls.Add(this.btnSettings);
      this.panelSide.Controls.Add(this.btnReport);
      this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelSide.Location = new System.Drawing.Point(0, 93);
      this.panelSide.Name = "panelSide";
      this.panelSide.Size = new System.Drawing.Size(269, 960);
      this.panelSide.TabIndex = 1;
      // 
      // panelMain
      // 
      this.panelMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelMain.Location = new System.Drawing.Point(269, 93);
      this.panelMain.Name = "panelMain";
      this.panelMain.Size = new System.Drawing.Size(1312, 960);
      this.panelMain.TabIndex = 2;
      // 
      // btnSettings
      // 
      this.btnSettings.BackColor = System.Drawing.SystemColors.GrayText;
      this.btnSettings.FlatAppearance.BorderSize = 0;
      this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSettings.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSettings.ForeColor = System.Drawing.Color.White;
      this.btnSettings.Image = global::WindowsFormsApp2.Properties.Resources.settings_16px;
      this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSettings.Location = new System.Drawing.Point(-2, 74);
      this.btnSettings.Name = "btnSettings";
      this.btnSettings.Size = new System.Drawing.Size(271, 68);
      this.btnSettings.TabIndex = 0;
      this.btnSettings.Text = "Settings";
      this.btnSettings.UseVisualStyleBackColor = false;
      this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
      // 
      // btnReport
      // 
      this.btnReport.BackColor = System.Drawing.SystemColors.GrayText;
      this.btnReport.FlatAppearance.BorderSize = 0;
      this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnReport.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnReport.ForeColor = System.Drawing.Color.White;
      this.btnReport.Image = global::WindowsFormsApp2.Properties.Resources.report_16px;
      this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnReport.Location = new System.Drawing.Point(-2, 0);
      this.btnReport.Name = "btnReport";
      this.btnReport.Size = new System.Drawing.Size(271, 68);
      this.btnReport.TabIndex = 0;
      this.btnReport.Text = "Report";
      this.btnReport.UseVisualStyleBackColor = false;
      this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1581, 1053);
      this.Controls.Add(this.panelMain);
      this.Controls.Add(this.panelSide);
      this.Controls.Add(this.panelHeader);
      this.Name = "Form1";
      this.Text = "Form1";
      this.panelSide.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelHeader;
    private System.Windows.Forms.Panel panelSide;
    private System.Windows.Forms.Panel panelMain;
    private System.Windows.Forms.Button btnReport;
    private System.Windows.Forms.Button btnSettings;
  }
}

