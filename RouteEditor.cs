using ArisakaController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyController
{
    public partial class RouteEditor : Form
    {
        public int Ycoord = 0;

        public bool firstIndex = true;

        private void RouteEditor_Load(object sender, System.EventArgs e)
        {
            //fucking initialize the combo box list using the Enum
            comboBox1.DataSource = Enum.GetValues(typeof(FunctionType));
            //sweet


        }

        public RouteEditor()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Functions.AppFunctions.ToggleVolume();
        }

        private void AddRoute_Click(object sender, EventArgs e)
        {
            //switch case using enum compared with value of combobox


            switch (comboBox1.SelectedValue)
            {
                case FunctionType.LaunchProgram:
                    IncrementY();
                    this.panel1.Controls.Add(new RoutesControl() { Location = new System.Drawing.Point(12, Ycoord) });
                    break;

                case FunctionType.ToggleVolume:
                    IncrementY();
                    this.panel1.Controls.Add(new ToggleVolumeControl() { Location = new System.Drawing.Point(12, Ycoord) });
                    break;

                case FunctionType.SetPcToHibernate:
                    break;

                default:
                    break;
            }
        }


        private void IncrementY()
        {
            if (firstIndex)
            {
                firstIndex= false;
            }
            else
            {
                Ycoord += 70;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
