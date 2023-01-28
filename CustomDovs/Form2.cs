using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDovs
{
    public partial class pBarSaveForm : Form
    {
        public pBarSaveForm()
        {
            InitializeComponent();
        }

        public int bar
        {
            get { return pBarSaveFile.Value; }
            set { pBarSaveFile.Value = value; }
        }
    }
}
