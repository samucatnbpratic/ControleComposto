
namespace TesteControleComposto
{
  partial class AlarmClock
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
      this.lblAlarm = new System.Windows.Forms.Label();
      this.btnAlarmOff = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblAlarm
      // 
      this.lblAlarm.AutoSize = true;
      this.lblAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblAlarm.Location = new System.Drawing.Point(215, 113);
      this.lblAlarm.Name = "lblAlarm";
      this.lblAlarm.Size = new System.Drawing.Size(86, 16);
      this.lblAlarm.TabIndex = 1;
      this.lblAlarm.Text = "Assustador";
      this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnAlarmOff
      // 
      this.btnAlarmOff.Location = new System.Drawing.Point(206, 161);
      this.btnAlarmOff.Name = "btnAlarmOff";
      this.btnAlarmOff.Size = new System.Drawing.Size(111, 23);
      this.btnAlarmOff.TabIndex = 2;
      this.btnAlarmOff.Text = "Desabilitar Alarme";
      this.btnAlarmOff.UseVisualStyleBackColor = true;
      this.btnAlarmOff.Click += new System.EventHandler(this.btnAlarmOff_Click);
      // 
      // AlarmClock
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.Controls.Add(this.btnAlarmOff);
      this.Controls.Add(this.lblAlarm);
      this.Name = "AlarmClock";
      this.Controls.SetChildIndex(this.lblAlarm, 0);
      this.Controls.SetChildIndex(this.btnAlarmOff, 0);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblAlarm;
    private System.Windows.Forms.Button btnAlarmOff;
  }
}
