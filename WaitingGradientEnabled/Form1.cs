using Syncfusion.Windows.Forms.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_cells_border_margin_style
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i < this.gridControl1.RowCount; i++)
            {
                for (int j = 1; j < this.gridControl1.ColCount; j++)
                {
                    if (j != 2)
                        this.gridControl1[i, j].CellValue = i + j;
                }
            }
            gridControl1.ColStyles[2].CellType = GridCellTypeName.ProgressBar;

        }
        //Button click customization
        private void setProgressBar_Click_1(object sender, EventArgs e)
        {
            foreach (Control c in this.gridControl1.Controls)
            {
                if (c is GridProgressBar)
                {
                    GridProgressBar control = c as GridProgressBar;
                    //To set the value for waiting gradient.
                    control.WaitingGradientEnabled = true;
                }
            }
        }
    }
}
