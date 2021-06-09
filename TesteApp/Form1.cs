using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      lblTest.Text = "";
    }

    private void dtpTest_ValueChanged(object sender, EventArgs e)
    {
      alarmClock1.AlarmTime = dtpTest.Value;
      alarmClock1.AlarmSet = true;
      lblTest.Text = "Alarm Time is " + alarmClock1.AlarmTime.ToShortTimeString();
    }
  }
}
