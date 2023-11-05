using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyController
{
    public partial class ToggleVolumeControl : UserControl
    {
        public ToggleVolumeControl()
        {
            InitializeComponent();
        }

        public RoutesJson getData()
        {
            return new RoutesJson() { name = this.name.Text, FunctionType = FunctionType.ToggleVolume, Route = this.route.Text };
        }

        public void setData(string name, string configString, string route)
        {
            this.name.Text = name;
            this.route.Text = route;
        }

        private void ToggleVolumeControl_Load(object sender, EventArgs e)
        {

        }

        private void route_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
