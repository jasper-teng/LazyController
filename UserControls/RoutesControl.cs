using LazyController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArisakaController
{
    public partial class RoutesControl : UserControl
    {
        public RoutesControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            { filepath.Text = openFileDialog1.FileName; }
            else
            { filepath.Text = "You didn't select the file!"; }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public RoutesJson getData()
        {
            return new RoutesJson() { name = this.name.Text, configString = this.filepath.Text, FunctionType = FunctionType.LaunchProgram, Route = this.route.Text };
        }

        public void setData(string name, string configString, string route)
        {
            this.name.Text = name;
            this.filepath.Text = configString;
            this.route.Text = route;
        }

        private void filepath_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoutesControl_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
