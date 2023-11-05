namespace LazyController.UserControls
{
    partial class OpenWebsite
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
            name = new TextBox();
            label3 = new Label();
            route = new TextBox();
            label2 = new Label();
            label1 = new Label();
            filepath = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(8, 20);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 1);
            label3.Name = "label3";
            label3.Size = new Size(38, 16);
            label3.TabIndex = 16;
            label3.Text = "Name";
            // 
            // route
            // 
            route.Location = new Point(114, 20);
            route.Name = "route";
            route.Size = new Size(100, 23);
            route.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 1);
            label2.Name = "label2";
            label2.Size = new Size(38, 16);
            label2.TabIndex = 14;
            label2.Text = "Route";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 1);
            label1.Name = "label1";
            label1.Size = new Size(28, 16);
            label1.TabIndex = 13;
            label1.Text = "URL";
            // 
            // filepath
            // 
            filepath.Location = new Point(220, 20);
            filepath.Name = "filepath";
            filepath.Size = new Size(292, 23);
            filepath.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(598, 20);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 18;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OpenWebsite
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(route);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(filepath);
            Name = "OpenWebsite";
            Size = new Size(624, 52);
            Load += OpenWebsite_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private Label label3;
        private TextBox route;
        private Label label2;
        private Label label1;
        private TextBox filepath;
        private Button button1;
    }
}
