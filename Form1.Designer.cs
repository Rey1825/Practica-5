namespace Practica_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Stencil", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(595, 49);
            label1.TabIndex = 0;
            label1.Text = "Dimensiones de un cilindro";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(240, 94);
            label2.Name = "label2";
            label2.Size = new Size(73, 24);
            label2.TabIndex = 2;
            label2.Text = "Datos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(240, 129);
            label3.Name = "label3";
            label3.Size = new Size(69, 22);
            label3.TabIndex = 3;
            label3.Text = "Radio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(432, 129);
            label4.Name = "label4";
            label4.Size = new Size(72, 22);
            label4.TabIndex = 4;
            label4.Text = "Altura:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(304, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(499, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 31);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(240, 177);
            label5.Name = "label5";
            label5.Size = new Size(126, 24);
            label5.TabIndex = 7;
            label5.Text = "Resultados:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(258, 221);
            label6.Name = "label6";
            label6.Size = new Size(108, 22);
            label6.TabIndex = 8;
            label6.Text = "Base Area:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(240, 258);
            label7.Name = "label7";
            label7.Size = new Size(128, 22);
            label7.TabIndex = 9;
            label7.Text = "Lateral Area:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(258, 297);
            label8.Name = "label8";
            label8.Size = new Size(110, 22);
            label8.TabIndex = 10;
            label8.Text = "Total Area:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(271, 335);
            label9.Name = "label9";
            label9.Size = new Size(97, 22);
            label9.TabIndex = 11;
            label9.Text = "Volumen:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(372, 218);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 31);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(372, 255);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 31);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(372, 294);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(249, 31);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(372, 332);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(249, 31);
            textBox6.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveBorder;
            button1.Font = new Font("Rockwell", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(329, 382);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 16;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(642, 444);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
    }
}