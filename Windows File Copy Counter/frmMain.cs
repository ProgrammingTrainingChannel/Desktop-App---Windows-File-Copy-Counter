using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_File_Copy_Counter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            Loaded += frmMain_Load;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ClipboardHelper.OnClipboardChange += ClipboardMonitor_OnClipboardChange;
            ClipboardHelper.Start();
        }

        private void ClipboardMonitor_OnClipboardChange(ClipboardFormat format, object data)
        {
            MessageBox.Show("Copied");
        }
    }
}
