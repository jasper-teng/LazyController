using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyController.UserControls
{
    public partial class OpenWebsite : UserControl
    {
        public OpenWebsite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this);
        }

        private void OpenWebsite_Load(object sender, EventArgs e)
        {

        }
    }
}
