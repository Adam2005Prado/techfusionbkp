namespace Backup2
{
    partial class pagsoft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pagsoft));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label123 = new Label();
            preco = new Label();
            button1 = new Button();
            button2 = new Button();
            Pagar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 217, 223);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 828);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(302, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(604, 692);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(948, 560);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(272, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label123
            // 
            label123.AutoSize = true;
            label123.BackColor = Color.Transparent;
            label123.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label123.ForeColor = Color.White;
            label123.Location = new Point(937, 183);
            label123.Name = "label123";
            label123.Size = new Size(121, 38);
            label123.TabIndex = 3;
            label123.Text = "label123";
            label123.Click += label1_Click_1;
            // 
            // preco
            // 
            preco.AutoSize = true;
            preco.BackColor = Color.Transparent;
            preco.FlatStyle = FlatStyle.Flat;
            preco.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            preco.ForeColor = Color.White;
            preco.Location = new Point(1035, 373);
            preco.Name = "preco";
            preco.Size = new Size(185, 81);
            preco.TabIndex = 5;
            preco.Text = "preço";
            preco.Click += label1_Click_2;
            // 
            // button1
            // 
            button1.Location = new Point(310, 82);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(318, 90);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Pagar
            // 
            Pagar.Location = new Point(948, 605);
            Pagar.Name = "Pagar";
            Pagar.Size = new Size(311, 152);
            Pagar.TabIndex = 8;
            Pagar.Text = "Pagar";
            Pagar.UseVisualStyleBackColor = true;
            Pagar.Click += Pagar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1282, 828);
            Controls.Add(Pagar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(preco);
            Controls.Add(label123);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label123;
        private Label preco;
        private Button button1;
        private Button button2;
        private Button Pagar;
    }
}