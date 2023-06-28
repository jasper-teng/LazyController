namespace ArisakaController
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
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(7, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 9);
            label2.Name = "label2";
            label2.Size = new Size(38, 16);
            label2.TabIndex = 8;
            label2.Text = "Route";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 16);
            label1.TabIndex = 7;
            label1.Text = "Application Path";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(411, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RoutesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "RoutesControl";
            Size = new Size(501, 72);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}
