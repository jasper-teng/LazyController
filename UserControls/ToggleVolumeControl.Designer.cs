namespace LazyController
{
    partial class ToggleVolumeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            name = new TextBox();
            route = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 1);
            label1.Name = "label1";
            label1.Size = new Size(38, 16);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 1);
            label2.Name = "label2";
            label2.Size = new Size(38, 16);
            label2.TabIndex = 1;
            label2.Text = "Route";
            // 
            // name
            // 
            name.Location = new Point(8, 20);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 2;
            // 
            // route
            // 
            route.Location = new Point(114, 20);
            route.Name = "route";
            route.Size = new Size(100, 23);
            route.TabIndex = 3;
            route.TextChanged += route_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 20);
            label3.Name = "label3";
            label3.Size = new Size(146, 16);
            label3.TabIndex = 4;
            label3.Text = "nabei cheebye honggan la";
            // 
            // button1
            // 
            button1.Location = new Point(598, 20);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 5;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ToggleVolumeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(route);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ToggleVolumeControl";
            Size = new Size(624, 52);
            Load += ToggleVolumeControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox name;
        private TextBox route;
        private Label label3;
        private Button button1;
    }
}
