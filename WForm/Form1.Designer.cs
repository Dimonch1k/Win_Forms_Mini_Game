namespace WForm
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
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(34, 18);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Count:";
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(126, 18);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 2;
            label2.Text = "Count:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(836, 550);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Label label2;
    }
}
