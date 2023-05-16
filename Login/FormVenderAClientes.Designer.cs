namespace Login
{
    partial class FormVenderAClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenderAClientes));
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            label3 = new Label();
            label6 = new Label();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            button3 = new Button();
            label11 = new Label();
            label12 = new Label();
            listBox2 = new ListBox();
            button4 = new Button();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(27, 228);
            label1.Name = "label1";
            label1.Size = new Size(166, 19);
            label1.TabIndex = 1;
            label1.Text = "Seleccione un cliente ...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(27, 355);
            label2.Name = "label2";
            label2.Size = new Size(185, 19);
            label2.TabIndex = 2;
            label2.Text = "Seleccione un producto ...";
            // 
            // numericUpDown1
            // 
            numericUpDown1.ForeColor = SystemColors.ControlDark;
            numericUpDown1.Location = new Point(396, 485);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(78, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(354, 487);
            label4.Name = "label4";
            label4.Size = new Size(35, 19);
            label4.TabIndex = 6;
            label4.Text = "Kgs";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(784, 708);
            label5.Name = "label5";
            label5.Size = new Size(125, 19);
            label5.TabIndex = 7;
            label5.Text = "TOTAL PAGAR: $";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(915, 708);
            label7.Name = "label7";
            label7.Size = new Size(18, 19);
            label7.TabIndex = 9;
            label7.Text = "0";
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = SystemColors.ControlDark;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 276);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 27);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.ForeColor = SystemColors.ControlDark;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(27, 390);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(309, 308);
            listBox1.TabIndex = 13;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(784, 512);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 167);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Método de Pago";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(72, 125);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(155, 23);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Tarjeta de Crédito";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(72, 82);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(149, 23);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tarjeta de Débito";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(72, 37);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 23);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Efectivo";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(477, 712);
            button1.Name = "button1";
            button1.Size = new Size(106, 42);
            button1.TabIndex = 15;
            button1.Text = "Atrás";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(442, 284);
            label3.Name = "label3";
            label3.Size = new Size(18, 19);
            label3.TabIndex = 16;
            label3.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(313, 284);
            label6.Name = "label6";
            label6.Size = new Size(123, 19);
            label6.TabIndex = 17;
            label6.Text = "Saldo de cliente:";
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(1069, 712);
            button2.Name = "button2";
            button2.Size = new Size(157, 46);
            button2.TabIndex = 18;
            button2.Text = "Continuar ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(354, 390);
            label8.Name = "label8";
            label8.Size = new Size(82, 19);
            label8.TabIndex = 19;
            label8.Text = "Precio Kg :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(442, 390);
            label9.Name = "label9";
            label9.Size = new Size(18, 19);
            label9.TabIndex = 20;
            label9.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDark;
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(-8, -23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1270, 217);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(198, 120);
            label10.Name = "label10";
            label10.Size = new Size(331, 50);
            label10.TabIndex = 0;
            label10.Text = "Venta a Clientes";
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(354, 541);
            button3.Name = "button3";
            button3.Size = new Size(144, 38);
            button3.TabIndex = 22;
            button3.Text = "Agregar a Carrito";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(354, 442);
            label11.Name = "label11";
            label11.Size = new Size(54, 19);
            label11.TabIndex = 23;
            label11.Text = "Stock :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.Highlight;
            label12.Location = new Point(414, 442);
            label12.Name = "label12";
            label12.Size = new Size(18, 19);
            label12.TabIndex = 24;
            label12.Text = "0";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 19;
            listBox2.Location = new Point(784, 255);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(323, 251);
            listBox2.TabIndex = 25;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(1126, 468);
            button4.Name = "button4";
            button4.Size = new Size(100, 38);
            button4.TabIndex = 26;
            button4.Text = "Quitar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.ForeColor = SystemColors.Highlight;
            label13.Location = new Point(784, 218);
            label13.Name = "label13";
            label13.Size = new Size(109, 19);
            label13.TabIndex = 27;
            label13.Text = "Carrito Cliente";
            // 
            // FormVenderAClientes
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 783);
            Controls.Add(label13);
            Controls.Add(button4);
            Controls.Add(listBox2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVenderAClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta a Clientes";
            Load += FormVenderAClientes_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Label label5;
        private Label label7;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private Label label3;
        private Label label6;
        private Button button2;
        private Label label8;
        private Label label9;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Label label10;
        private Button button3;
        private Label label11;
        private Label label12;
        private ListBox listBox2;
        private Button button4;
        private Label label13;
    }
}