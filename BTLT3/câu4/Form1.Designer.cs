namespace câu4
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
            txtNhapTen = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            groupBox2 = new GroupBox();
            chkUnderLine = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            label2 = new Label();
            lblLapTrinh = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(257, 51);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(306, 27);
            txtNhapTen.TabIndex = 0;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(120, 54);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 1;
            label1.Text = "Nhập tên";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(radBlack);
            groupBox1.Controls.Add(radBlue);
            groupBox1.Controls.Add(radGreen);
            groupBox1.Controls.Add(radRed);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(120, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(178, 199);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBlack.ForeColor = Color.Black;
            radBlack.Location = new Point(30, 131);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(67, 24);
            radBlack.TabIndex = 3;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.Click += radBlack_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(31, 98);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(61, 24);
            radBlue.TabIndex = 2;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.Click += radBlue_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radGreen.ForeColor = Color.Lime;
            radGreen.Location = new Point(31, 64);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(72, 24);
            radGreen.TabIndex = 1;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.Click += radGreen_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(31, 32);
            radRed.Name = "radRed";
            radRed.Size = new Size(57, 24);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            radRed.Click += radRed_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 224, 192);
            groupBox2.Controls.Add(chkUnderLine);
            groupBox2.Controls.Add(chkItalic);
            groupBox2.Controls.Add(chkBold);
            groupBox2.Location = new Point(438, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(158, 199);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font";
            // 
            // chkUnderLine
            // 
            chkUnderLine.AutoSize = true;
            chkUnderLine.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            chkUnderLine.ForeColor = Color.Blue;
            chkUnderLine.Location = new Point(24, 131);
            chkUnderLine.Name = "chkUnderLine";
            chkUnderLine.Size = new Size(105, 24);
            chkUnderLine.TabIndex = 2;
            chkUnderLine.Text = "Gạch Chân";
            chkUnderLine.UseVisualStyleBackColor = true;
            chkUnderLine.Click += chkUnderLine_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkItalic.ForeColor = Color.Blue;
            chkItalic.Location = new Point(24, 85);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(129, 24);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Nghiêm Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.Click += chkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkBold.ForeColor = Color.Blue;
            chkBold.Location = new Point(23, 46);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(104, 24);
            chkBold.TabIndex = 0;
            chkBold.Text = " Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            chkBold.Click += chkBold_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(174, 375);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 12;
            label2.Text = "Lập Trình Bởi";
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.AutoSize = true;
            lblLapTrinh.BorderStyle = BorderStyle.FixedSingle;
            lblLapTrinh.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLapTrinh.Location = new Point(319, 360);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(139, 43);
            lblLapTrinh.TabIndex = 13;
            lblLapTrinh.Text = "Tèo 2011";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLapTrinh);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtNhapTen);
            ForeColor = Color.FromArgb(0, 192, 192);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNhapTen;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private GroupBox groupBox2;
        private CheckBox chkUnderLine;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private RadioButton radBlack;
        private Label label2;
        private Label lblLapTrinh;
    }
}
