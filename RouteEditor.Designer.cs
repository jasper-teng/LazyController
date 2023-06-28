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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            routesControl1 = new ArisakaController.RoutesControl();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(457, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 415);
            button2.Name = "button2";
            button2.Size = new Size(88, 23);
            button2.TabIndex = 2;
            button2.Text = "Add Route";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(routesControl1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 388);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // routesControl1
            // 
            routesControl1.Location = new Point(12, 13);
            routesControl1.Name = "routesControl1";
            routesControl1.Size = new Size(493, 72);
            routesControl1.TabIndex = 0;
            // 
            // RouteEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 450);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "RouteEditor";
            Text = "Route Editor";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Panel panel1;
        private ArisakaController.RoutesControl routesControl1;
    }
}