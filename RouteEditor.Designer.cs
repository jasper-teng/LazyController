using System.Windows.Forms;

namespace LazyController
{
    partial class RouteEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Save = new Button();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            AddRoute = new Button();
            SuspendLayout();
            // 
            // Save
            // 
            Save.Location = new Point(584, 414);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 1;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 388);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 414);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 24);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // AddRoute
            // 
            AddRoute.Location = new Point(150, 415);
            AddRoute.Name = "AddRoute";
            AddRoute.Size = new Size(88, 23);
            AddRoute.TabIndex = 7;
            AddRoute.Text = "Add Route";
            AddRoute.UseVisualStyleBackColor = true;
            AddRoute.Click += AddRoute_Click;
            // 
            // RouteEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 450);
            Controls.Add(AddRoute);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(Save);
            Name = "RouteEditor";
            Text = "Route Editor";
            Load += RouteEditor_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button Save;
        private Panel panel1;
        private ComboBox comboBox1;
        private Button AddRoute;
    }
}