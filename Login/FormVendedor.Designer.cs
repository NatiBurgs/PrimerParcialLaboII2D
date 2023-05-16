namespace Login
{
    partial class FormVendedor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendedor));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pictureBox2 = new PictureBox();
            button7 = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(82, 75);
            label1.Name = "label1";
            label1.Size = new Size(661, 50);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al sitio del vendedor!";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(511, 249);
            button1.Name = "button1";
            button1.Size = new Size(266, 59);
            button1.TabIndex = 2;
            button1.Text = "Vender a clientes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(511, 403);
            button2.Name = "button2";
            button2.Size = new Size(266, 60);
            button2.TabIndex = 3;
            button2.Text = "Ver detalles de stock en Heladera";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(511, 488);
            button3.Name = "button3";
            button3.Size = new Size(266, 60);
            button3.TabIndex = 4;
            button3.Text = "Reponer stock en Heladera";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(511, 572);
            button4.Name = "button4";
            button4.Size = new Size(266, 61);
            button4.TabIndex = 5;
            button4.Text = "Fijar precios por Kilo";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.RoyalBlue;
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(511, 650);
            button5.Name = "button5";
            button5.Size = new Size(266, 67);
            button5.TabIndex = 6;
            button5.Text = "Fijar tipo de cortes";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.RoyalBlue;
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(573, 740);
            button6.Name = "button6";
            button6.Size = new Size(146, 50);
            button6.TabIndex = 7;
            button6.Text = "Cerrar Sesión";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(791, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(179, 166);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // button7
            // 
            button7.BackColor = Color.RoyalBlue;
            button7.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(511, 326);
            button7.Name = "button7";
            button7.Size = new Size(266, 60);
            button7.TabIndex = 10;
            button7.Text = "Ver Facturas";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Location = new Point(-6, -41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1323, 262);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // FormVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1282, 802);
            Controls.Add(groupBox1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sitio del vendedor";
            Load += FormVendedor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox2;
        private Button button7;
        private GroupBox groupBox1;
    }
}