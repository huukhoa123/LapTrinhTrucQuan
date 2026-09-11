namespace Cau2
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20F);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(285, 130);
            button1.Name = "button1";
            button1.Size = new Size(235, 119);
            button1.TabIndex = 0;
            button1.Text = "CLICK ME";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Cursor = Cursors.Default;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
