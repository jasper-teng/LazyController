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
using ControllerServer;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using FluentValidation.Results;

namespace LazyController
{
    public partial class RouteEditor : Form
    {
        public int Ycoord = 0;

        public bool firstIndex = true;

        public static HttpServer httpserver;

        private void RouteEditor_Load(object sender, System.EventArgs e)
        {
            //fucking initialize the combo box list using the Enum
            comboBox1.DataSource = Enum.GetValues(typeof(FunctionType));
            //sweet
            loadConfig();
        }

        public RouteEditor()
        {
            InitializeComponent();
        }

        private void saveConfig()
        {
            RoutesArrayJson savedConfig = new RoutesArrayJson();


            foreach (UserControl p in this.panel1.Controls)
            {
                //explicit cast from usercontrol > whatever control
                //someone should tell me something better

                if (p.GetType() == typeof(RoutesControl))
                {
                    RoutesControl temp = (RoutesControl)p;
                    savedConfig.routes.Add(temp.getData());
                }

                if (p.GetType() == typeof(ToggleVolumeControl))
                {
                    ToggleVolumeControl temp = (ToggleVolumeControl)p;
                    savedConfig.routes.Add(temp.getData());
                }

            }

            //perform shoddy validation
            if(JsonConfigHelper.DuplicateRoutes(savedConfig))
            {
                MessageBox.Show("Please remove duplicate routes.", "Duplicate Routes",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            JsonConfigHelper.WriteJson(savedConfig);

            HttpServer _serverSingleton = HttpServer.GetInstance();

            _serverSingleton.loadConfig();

        }

        private void loadConfig()
        {
            RoutesArrayJson savedConfig = JsonConfigHelper.ReadJson();
            if (savedConfig == null)
            {
                return;
            }

            foreach (RoutesJson p in savedConfig.routes) //this part can be better probably dont need the if statement
            {
                if (p.FunctionType == FunctionType.LaunchProgram)
                {
                    RoutesControl temp = new RoutesControl();
                    temp.setData(p.name, p.configString, p.Route);
                    IncrementY();
                    temp.Location = new System.Drawing.Point(12, Ycoord);
                    this.panel1.Controls.Add(temp);
                };

                if (p.FunctionType == FunctionType.ToggleVolume)
                {
                    ToggleVolumeControl temp = new ToggleVolumeControl();
                    temp.setData(p.name, p.configString, p.Route);
                    IncrementY();
                    temp.Location = new System.Drawing.Point(12, Ycoord);
                    this.panel1.Controls.Add(temp);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveConfig();
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

                case FunctionType.PowerOptions:
                    break;

                case FunctionType.OpenWebsite:
                    break;

                default:
                    break;
            }
        }
        private void redrawList() //fuck it, just do it the way saveconfig works
        {//you need to re edit this whenever new features are added

            RoutesArrayJson tempList = new RoutesArrayJson();

            foreach (UserControl p in this.panel1.Controls)
            {
                //explicit cast from usercontrol > whatever control
                //someone should tell me something better

                if (p.GetType() == typeof(RoutesControl))
                {
                    RoutesControl temp = (RoutesControl)p;
                    tempList.routes.Add(temp.getData());
                }

                if (p.GetType() == typeof(ToggleVolumeControl))
                {
                    ToggleVolumeControl temp = (ToggleVolumeControl)p;
                    tempList.routes.Add(temp.getData());
                }

            }

            resetY();

            this.panel1.Controls.Clear();

            foreach (RoutesJson p in tempList.routes) //this part can be better probably dont need the if statement
            {
                if (p.FunctionType == FunctionType.LaunchProgram)
                {
                    RoutesControl temp = new RoutesControl();
                    temp.setData(p.name, p.configString, p.Route);
                    IncrementY();
                    temp.Location = new System.Drawing.Point(12, Ycoord);
                    this.panel1.Controls.Add(temp);
                };

                if (p.FunctionType == FunctionType.ToggleVolume)
                {
                    ToggleVolumeControl temp = new ToggleVolumeControl();
                    temp.setData(p.name, p.configString, p.Route);
                    IncrementY();
                    temp.Location = new System.Drawing.Point(12, Ycoord);
                    this.panel1.Controls.Add(temp);
                }
            }

        }

        private void IncrementY()
        {
            if (firstIndex)
            {
                firstIndex = false;
            }
            else
            {
                Ycoord += 70;
            }
        }
        private void resetY()
        {
            firstIndex = true;
            Ycoord = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelChanged(object sender, ControlEventArgs e)
        {
            redrawList();
        }
    }
}
