namespace Login
{
    partial class FormVendedorVerStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendedorVerStock));
            button1 = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(667, 409);
            button1.Name = "button1";
            button1.Size = new Size(104, 38);
            button1.TabIndex = 1;
            button1.Text = "Atrás";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(284, 48);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 2;
            label1.Text = "Stock en Heladera";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.GradientInactiveCaption;
            listBox1.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = SystemColors.ControlDark;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(26, 110);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(745, 289);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // FormVendedorVerStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVendedorVerStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock";
            Load += FormVendedorVerStock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private ListBox listBox1;
    }
}