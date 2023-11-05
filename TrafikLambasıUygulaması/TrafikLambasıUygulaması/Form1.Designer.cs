namespace TrafikLambasıUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(286, 303);
            button1.Name = "button1";
            button1.Size = new Size(265, 261);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(578, 303);
            button2.Name = "button2";
            button2.Size = new Size(265, 261);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(870, 303);
            button3.Name = "button3";
            button3.Size = new Size(265, 261);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(642, 698);
            label1.Name = "label1";
            label1.Size = new Size(45, 54);
            label1.TabIndex = 3;
            label1.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1412, 1008);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlLight;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}