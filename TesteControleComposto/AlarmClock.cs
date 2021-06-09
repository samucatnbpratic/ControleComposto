using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TesteControleComposto
{
  public partial class AlarmClock : TesteControleComposto.ControlClock
  {
    private DateTime alarmTime;
    private bool alarmSet;
    private bool colorTicker=false;
    private Color backColorPadrao;

    public AlarmClock()
    {
      InitializeComponent();
      backColorPadrao = this.BackColor;
    }

    public DateTime AlarmTime { get => alarmTime; set => alarmTime = value; }
    public bool AlarmSet { get => alarmSet; set => alarmSet = value; }

    protected override void timer1_Tick(object sender, EventArgs e)
    {
      base.timer1_Tick(sender, e);

      if (AlarmSet == false)
      {
        lblAlarm.BackColor = backColorPadrao;
        lblAlarm.Visible = false;
        return;
      }
      else
      {
        if (AlarmTime.Date == DateTime.Now.Date && AlarmTime.Hour == DateTime.Now.Hour &&
           AlarmTime.Minute == DateTime.Now.Minute)
        {
          lblAlarm.Visible = true;
          if (colorTicker == false)
          {
            lblAlarm.BackColor = Color.Red;
            colorTicker = true;
          }
          else
          {
            lblAlarm.BackColor = Color.Blue;
            colorTicker = false;
          }
        }
        else
        {
          lblAlarm.Visible = false;
        }
      }

    }

    private void btnAlarmOff_Click(object sender, EventArgs e)
    {
      AlarmSet = false;
      lblAlarm.Visible = false;
    }
  }
}
