namespace Login
{
    partial class FormVendedorFijarCortes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendedorFijarCortes));
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(60, 393);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 0;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(260, 66);
            label1.Name = "label1";
            label1.Size = new Size(231, 19);
            label1.TabIndex = 1;
            label1.Text = "Ingresar un tipo de Corte nuevo";
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ControlDark;
            textBox1.Location = new Point(280, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ControlDark;
            textBox2.Location = new Point(405, 265);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(77, 27);
            textBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(337, 380);
            button2.Name = "button2";
            button2.Size = new Size(154, 51);
            button2.TabIndex = 5;
            button2.Text = "Ingresar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(265, 189);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 6;
            label2.Text = "Cantidad en Kg.";
            // 
            // numericUpDown1
            // 
            numericUpDown1.ForeColor = SystemColors.ControlDark;
            numericUpDown1.Location = new Point(410, 181);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(72, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(265, 269);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 8;
            label3.Text = "Precio por Kg.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FormVendedorFijarCortes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVendedorFijarCortes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar tipo de Corte Nuevo";
            Load += FormVendedorFijarCortes_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}