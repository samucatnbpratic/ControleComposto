
namespace TesteApp
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.alarmClock1 = new TesteControleComposto.AlarmClock();
      this.dtpTest = new System.Windows.Forms.DateTimePicker();
      this.lblTest = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // alarmClock1
      // 
      this.alarmClock1.AlarmSet = false;
      this.alarmClock1.AlarmTime = new System.DateTime(((long)(0)));
      this.alarmClock1.ColBColor = System.Drawing.Color.Empty;
      this.alarmClock1.ColFColor = System.Drawing.Color.Empty;
      this.alarmClock1.Location = new System.Drawing.Point(-143, -3);
      this.alarmClock1.Name = "alarmClock1";
      this.alarmClock1.Size = new System.Drawing.Size(431, 212);
      this.alarmClock1.TabIndex = 0;
      // 
      // dtpTest
      // 
      this.dtpTest.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dtpTest.Location = new System.Drawing.Point(500, 12);
      this.dtpTest.Name = "dtpTest";
      this.dtpTest.Size = new System.Drawing.Size(234, 20);
      this.dtpTest.TabIndex = 1;
      this.dtpTest.ValueChanged += new System.EventHandler(this.dtpTest_ValueChanged);
      // 
      // lblTest
      // 
      this.lblTest.AutoSize = true;
      this.lblTest.Location = new System.Drawing.Point(497, 50);
      this.lblTest.Name = "lblTest";
      this.lblTest.Size = new System.Drawing.Size(35, 13);
      this.lblTest.TabIndex = 2;
      this.lblTest.Text = "label1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lblTest);
      this.Controls.Add(this.dtpTest);
      this.Controls.Add(this.alarmClock1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TesteControleComposto.AlarmClock alarmClock1;
    private System.Windows.Forms.DateTimePicker dtpTest;
    private System.Windows.Forms.Label lblTest;
  }
}

