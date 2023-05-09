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
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            label4 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            button2 = new Button();
            groupBox2 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(43, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 263);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Orden";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(289, 100);
            label6.Name = "label6";
            label6.Size = new Size(18, 19);
            label6.TabIndex = 6;
            label6.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 61);
            label5.Name = "label5";
            label5.Size = new Size(109, 19);
            label5.TabIndex = 5;
            label5.Text = "Precio por Kg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 61);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 4;
            label3.Text = "Producto";
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = SystemColors.ControlDark;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 27);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.ForeColor = SystemColors.ControlDark;
            numericUpDown1.Location = new Point(201, 180);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(55, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 182);
            label2.Name = "label2";
            label2.Size = new Size(124, 19);
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
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.RoyalBlue;
            groupBox3.Location = new Point(490, 70);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(269, 204);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Método de pago";
            
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(79, 109);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(139, 23);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tarjeta Crédito";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(79, 52);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(135, 23);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tarjeta Débito";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(615, 368);
            button1.Name = "button1";
            button1.Size = new Size(127, 49);
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
            label4.Location = new Point(6, 39);
            label4.Name = "label4";
            label4.Size = new Size(246, 19);
            label4.TabIndex = 4;
            label4.Text = "Monto disponible para operar: $";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(595, 310);
            label7.Name = "label7";
            label7.Size = new Size(92, 22);
            label7.TabIndex = 6;
            label7.Text = "Total $ =  ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(415, 299);
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
            label8.Location = new Point(258, 39);
            label8.Name = "label8";
            label8.Size = new Size(51, 19);
            label8.TabIndex = 8;
            label8.Text = "label8";
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(75, 393);
            button2.Name = "button2";
            button2.Size = new Size(122, 45);
            button2.TabIndex = 9;
            button2.Text = "Atrás";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(25, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 133);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.WhiteSmoke;
            label10.ForeColor = SystemColors.ControlDark;
            label10.Location = new Point(100, 84);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 10;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlDark;
            label9.Location = new Point(18, 84);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 9;
            label9.Text = "Usuario: ";
            // 
            // FormComprador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormComprador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Retirá o recibí tu pedido en el día!";
            Load += FormComprador_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label8;
        private Button button2;
        private GroupBox groupBox2;
        private Label label10;
        private Label label9;
    }
}