namespace câu_7
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
            label1 = new Label();
            txtName = new TextBox();
            picLightOn = new PictureBox();
            lblMessage = new Label();
            lblDesignBy = new Label();
            btnExit = new Button();
            picLightOff = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picLightOn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLightOff).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 71);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "NAME";
            // 
            // txtName
            // 
            txtName.Location = new Point(360, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(247, 27);
            txtName.TabIndex = 1;
            txtName.Text = "JACK";
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // picLightOn
            // 
            picLightOn.BackColor = SystemColors.ButtonFace;
            picLightOn.Image = Properties.Resources.light;
            picLightOn.Location = new Point(264, 116);
            picLightOn.Name = "picLightOn";
            picLightOn.Size = new Size(343, 179);
            picLightOn.SizeMode = PictureBoxSizeMode.Zoom;
            picLightOn.TabIndex = 2;
            picLightOn.TabStop = false;
            toolTip1.SetToolTip(picLightOn, "Click me to Turn ON the Light!");
            picLightOn.Click += picLightOn_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BorderStyle = BorderStyle.FixedSingle;
            lblMessage.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(326, 327);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(238, 22);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "Jack Turn On The Light ,Please!";
            // 
            // lblDesignBy
            // 
            lblDesignBy.AutoSize = true;
            lblDesignBy.Location = new Point(264, 396);
            lblDesignBy.Name = "lblDesignBy";
            lblDesignBy.Size = new Size(211, 20);
            lblDesignBy.TabIndex = 4;
            lblDesignBy.Text = "Design By______________________";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Location = new Point(532, 387);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // picLightOff
            // 
            picLightOff.Image = Properties.Resources.light2_save;
            picLightOff.Location = new Point(264, 116);
            picLightOff.Name = "picLightOff";
            picLightOff.Size = new Size(343, 179);
            picLightOff.SizeMode = PictureBoxSizeMode.Zoom;
            picLightOff.TabIndex = 6;
            picLightOff.TabStop = false;
            toolTip1.SetToolTip(picLightOff, "Click me to Turn OFF the Light!");
            picLightOff.Click += picLightOff_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(picLightOff);
            Controls.Add(btnExit);
            Controls.Add(lblDesignBy);
            Controls.Add(lblMessage);
            Controls.Add(picLightOn);
            Controls.Add(txtName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLights";
            ((System.ComponentModel.ISupportInitialize)picLightOn).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLightOff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private PictureBox picLightOn;
        private Label lblMessage;
        private Label lblDesignBy;
        private Button btnExit;
        private PictureBox picLightOff;
        private ToolTip toolTip1;
    }
}
