﻿namespace ArisakaController
{
    partial class RoutesControl
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
            route = new TextBox();
            label2 = new Label();
            label1 = new Label();
            filepath = new TextBox();
            button1 = new Button();
            name = new TextBox();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // route
            // 
            route.Location = new Point(114, 20);
            route.Name = "route";
            route.Size = new Size(100, 23);
            route.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 1);
            label2.Name = "label2";
            label2.Size = new Size(38, 16);
            label2.TabIndex = 8;
            label2.Text = "Route";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 1);
            label1.Name = "label1";
            label1.Size = new Size(95, 16);
            label1.TabIndex = 7;
            label1.Text = "Application Path";
            // 
            // filepath
            // 
            filepath.Location = new Point(220, 20);
            filepath.Name = "filepath";
            filepath.Size = new Size(292, 23);
            filepath.TabIndex = 6;
            filepath.TextChanged += filepath_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(518, 20);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // name
            // 
            name.Location = new Point(8, 20);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 11;
            name.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 1);
            label3.Name = "label3";
            label3.Size = new Size(38, 16);
            label3.TabIndex = 10;
            label3.Text = "Name";
            // 
            // button2
            // 
            button2.Location = new Point(598, 20);
            button2.Name = "button2";
            button2.Size = new Size(23, 23);
            button2.TabIndex = 12;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // RoutesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(route);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(filepath);
            Controls.Add(button1);
            Name = "RoutesControl";
            Size = new Size(624, 52);
            Load += RoutesControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox route;
        private Label label2;
        private Label label1;
        private TextBox filepath;
        private Button button1;
        private TextBox name;
        private Label label3;
        private Button button2;
    }
}
