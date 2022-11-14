using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        ToolStripMenuItem r;
        ToolStripMenuItem t = new ToolStripMenuItem();
        int names = 2;
        public Form1()
        {
            InitializeComponent();
            r = toolStripMenuItem1;
        }

        private void toolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            r.DropDownItems.Add(t);
            t.Text = names.ToString();
            names++;
            r = t;
            r.MouseEnter += toolStripMenuItem1_MouseEnter;
            t = new ToolStripMenuItem();
        }
    }
}


