using ArisakaController;
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
    public partial class RouteEditor : Form
    {
        public int Ycoord = 13;

        public RouteEditor()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoutesControl routesControl = new RoutesControl();
            Ycoord += 78;
            routesControl.Location = new System.Drawing.Point(12, Ycoord);
            this.panel1.Controls.Add(routesControl);
        }
    }
}
