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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(60, 75);
            label1.Name = "label1";
            label1.Size = new Size(166, 19);
            label1.TabIndex = 1;
            label1.Text = "Seleccione un cliente ...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(60, 217);
            label2.Name = "label2";
            label2.Size = new Size(185, 19);
            label2.TabIndex = 2;
            label2.Text = "Seleccione un producto ...";
            // 
            // numericUpDown1
            // 
            numericUpDown1.ForeColor = SystemColors.ControlDark;
            numericUpDown1.Location = new Point(387, 276);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(78, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(382, 232);
            label4.Name = "label4";
            label4.Size = new Size(35, 19);
            label4.TabIndex = 6;
            label4.Text = "Kgs";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(603, 276);
            label5.Name = "label5";
            label5.Size = new Size(83, 19);
            label5.TabIndex = 7;
            label5.Text = "Subtotal: $";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(719, 276);
            label7.Name = "label7";
            label7.Size = new Size(18, 19);
            label7.TabIndex = 9;
            label7.Text = "0";
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = SystemColors.ControlDark;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(60, 118);
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
            listBox1.Location = new Point(60, 261);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(270, 137);
            listBox1.TabIndex = 13;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(528, 48);
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
            button1.Location = new Point(528, 374);
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
            label3.Location = new Point(387, 121);
            label3.Name = "label3";
            label3.Size = new Size(18, 19);
            label3.TabIndex = 16;
            label3.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(352, 75);
            label6.Name = "label6";
            label6.Size = new Size(123, 19);
            label6.TabIndex = 17;
            label6.Text = "Saldo de cliente:";
            // 
            // button2
            // 
            button2.Location = new Point(688, 370);
            button2.Name = "button2";
            button2.Size = new Size(157, 46);
            button2.TabIndex = 18;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // FormVenderAClientes
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 428);
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
    }
}