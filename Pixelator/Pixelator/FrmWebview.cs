using System;
using System.Windows.Forms;

namespace Pixelator
{
    public partial class FrmWebview : Form
    {
        public FrmWebview()
        {
            InitializeComponent();
        }

        private void FrmWebview_Load(object sender, EventArgs e)
        {
            WebviewControl.Url = new Uri("http://www.html5test.com");
        }
    }
}
