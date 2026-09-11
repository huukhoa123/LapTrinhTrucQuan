namespace cau3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblHoTen = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnKetThuc = new Button();
            lblho = new Label();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHoTen.Location = new Point(345, 53);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(0, 28);
            lblHoTen.TabIndex = 7;
            lblHoTen.DoubleClick += lblHoTen_DoubleClick;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(300, 133);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(202, 27);
            txtHo.TabIndex = 8;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(255, 128, 255);
            txtTen.ForeColor = SystemColors.ActiveBorder;
            txtTen.Location = new Point(300, 181);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(202, 27);
            txtTen.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 133);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 10;
            label1.Text = "Họ Lót";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 184);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 11;
            label2.Text = "Tên";
            // 
            // btnHo
            // 
            btnHo.Location = new Point(204, 255);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(94, 29);
            btnHo.TabIndex = 12;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(345, 255);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(94, 29);
            btnTen.TabIndex = 13;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(513, 255);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(94, 29);
            btnHoTen.TabIndex = 14;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(345, 310);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(94, 29);
            btnKetThuc.TabIndex = 16;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // lblho
            // 
            lblho.AutoSize = true;
            lblho.Location = new Point(371, 41);
            lblho.Name = "lblho";
            lblho.Size = new Size(0, 20);
            lblho.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKetThuc);
            Controls.Add(lblho);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(lblHoTen);
            Name = "Form1";
            Text = "Bài Tập 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHoTen;
        private TextBox txtHo;
        private TextBox txtTen;
        private Label label1;
        private Label label2;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnKetThuc;
        private Label lblho;
    }
}