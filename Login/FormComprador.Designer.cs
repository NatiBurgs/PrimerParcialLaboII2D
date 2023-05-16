namespace Login
{
    partial class FormComprador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComprador));
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            button2 = new Button();
            label10 = new Label();
            label9 = new Label();
            listBox1 = new ListBox();
            label11 = new Label();
            button3 = new Button();
            listBox2 = new ListBox();
            label3 = new Label();
            label7 = new Label();
            label12 = new Label();
            label13 = new Label();
            numericUpDown1 = new NumericUpDown();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(541, 330);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 6;
            label6.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(503, 277);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 5;
            label5.Text = "Precio por Kg $";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(500, 403);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Cantidad en Kg.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(705, 310);
            label1.Name = "label1";
            label1.Size = new Size(0, 22);
            label1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1149, 694);
            button1.Name = "button1";
            button1.Size = new Size(159, 53);
            button1.TabIndex = 3;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(886, 34);
            label4.Name = "label4";
            label4.Size = new Size(246, 19);
            label4.TabIndex = 4;
            label4.Text = "Monto disponible para operar: $";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(886, 608);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.WhiteSmoke;
            label8.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(1174, 34);
            label8.Name = "label8";
            label8.Size = new Size(51, 19);
            label8.TabIndex = 8;
            label8.Text = "label8";
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(37, 702);
            button2.Name = "button2";
            button2.Size = new Size(122, 45);
            button2.TabIndex = 9;
            button2.Text = "Cerrar Sesión";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.WhiteSmoke;
            label10.ForeColor = SystemColors.ControlDark;
            label10.Location = new Point(994, 90);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 10;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.WhiteSmoke;
            label9.ForeColor = SystemColors.ControlDark;
            label9.Location = new Point(886, 90);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 9;
            label9.Text = "Usuario: ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(37, 78);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(405, 584);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(37, 33);
            label11.Name = "label11";
            label11.Size = new Size(157, 20);
            label11.TabIndex = 12;
            label11.Text = "Seleccione Productos :";
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(461, 614);
            button3.Name = "button3";
            button3.Size = new Size(133, 48);
            button3.TabIndex = 13;
            button3.Text = "Agregar a mi carrito";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.InactiveBorder;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(876, 145);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(349, 324);
            listBox2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(1174, 592);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 15;
            label3.Text = "Subtotal: $";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(1208, 642);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 16;
            label7.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Highlight;
            label12.Location = new Point(461, 145);
            label12.Name = "label12";
            label12.Size = new Size(211, 19);
            label12.TabIndex = 17;
            label12.Text = "Stock Producto Seleccionado";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.Highlight;
            label13.Location = new Point(540, 206);
            label13.Name = "label13";
            label13.Size = new Size(18, 19);
            label13.TabIndex = 18;
            label13.Text = "0";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(527, 456);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(67, 27);
            numericUpDown1.TabIndex = 19;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(1110, 485);
            button4.Name = "button4";
            button4.Size = new Size(115, 43);
            button4.TabIndex = 20;
            button4.Text = "Quitar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // FormComprador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1329, 759);
            Controls.Add(button4);
            Controls.Add(numericUpDown1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(label10);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormComprador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Retirá o recibí tu pedido en el día!";
            Load += FormComprador_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label4;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label8;
        private Button button2;
        private Label label10;
        private Label label9;
        private ListBox listBox1;
        private Label label11;
        private Button button3;
        private ListBox listBox2;
        private Label label3;
        private Label label7;
        private Label label12;
        private Label label13;
        private NumericUpDown numericUpDown1;
        private Button button4;
    }
}