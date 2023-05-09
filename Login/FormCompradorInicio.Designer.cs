namespace Login
{
    partial class FormCompradorInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompradorInicio));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(138, 224);
            label1.Name = "label1";
            label1.Size = new Size(295, 25);
            label1.TabIndex = 0;
            label1.Text = "Bienvenid@ a nuestra Tienda Online";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(187, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 297);
            label2.Name = "label2";
            label2.Size = new Size(289, 20);
            label2.TabIndex = 2;
            label2.Text = "Ingrese monto disponible para compras: $";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(344, 294);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(281, 382);
            button1.Name = "button1";
            button1.Size = new Size(143, 56);
            button1.TabIndex = 4;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(125, 398);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 5;
            button2.Text = "Cerrar sesión";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormCompradorInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(586, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.Highlight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCompradorInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tienda Online!";
            Load += FormCompradorInicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}