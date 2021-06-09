using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteControleComposto
{
    public partial class ControlClock: UserControl
    {
    private Color colFColor;
    private Color colBColor;

        public ControlClock()
        {
            InitializeComponent();
        }

    public Color ColFColor 
    { 
      get => colFColor; 
      set 
      { 
        colFColor = value;
        lblDisplay.ForeColor = ColFColor;
      }
    }
    public Color ColBColor
    {
      get => colBColor;
      set
      {
        colBColor = value;
        lblDisplay.BackColor = ColBColor;
      }
    }

    protected virtual void timer1_Tick(object sender, EventArgs e)
    {
      lblDisplay.Text = DateTime.Now.ToLongTimeString();
    }
  }
}
