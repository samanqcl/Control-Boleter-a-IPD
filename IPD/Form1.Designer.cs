namespace IPD
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
            MainPanel = new Panel();
            button_utileria = new Button();
            label2 = new Label();
            buttonAlquiler = new Button();
            buttonEntrada = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified Hans", 40.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 100);
            label1.Name = "label1";
            label1.Size = new Size(397, 77);
            label1.TabIndex = 2;
            label1.Text = "BIENVENIDO";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 205);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(550, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.Controls.Add(button_utileria);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(buttonAlquiler);
            MainPanel.Controls.Add(buttonEntrada);
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Controls.Add(label1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(682, 953);
            MainPanel.TabIndex = 1;
            // 
            // button_utileria
            // 
            button_utileria.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_utileria.Location = new Point(181, 799);
            button_utileria.Name = "button_utileria";
            button_utileria.Size = new Size(300, 100);
            button_utileria.TabIndex = 15;
            button_utileria.Text = "ALQUILAR UTILERIA";
            button_utileria.UseVisualStyleBackColor = true;
            button_utileria.Click += button_utileria_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified Hans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(380, 50);
            label2.Name = "label2";
            label2.Size = new Size(241, 32);
            label2.TabIndex = 14;
            label2.Text = "      (01) 204 - 8420";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAlquiler
            // 
            buttonAlquiler.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAlquiler.Location = new Point(181, 677);
            buttonAlquiler.Name = "buttonAlquiler";
            buttonAlquiler.Size = new Size(300, 100);
            buttonAlquiler.TabIndex = 9;
            buttonAlquiler.Text = "ALQUILAR ESPACIO";
            buttonAlquiler.UseVisualStyleBackColor = true;
            buttonAlquiler.Click += buttonAlquiler_Click;
            // 
            // buttonEntrada
            // 
            buttonEntrada.Font = new Font("HP Simplified Hans", 40.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEntrada.Location = new Point(132, 551);
            buttonEntrada.Name = "buttonEntrada";
            buttonEntrada.Size = new Size(400, 100);
            buttonEntrada.TabIndex = 8;
            buttonEntrada.Text = "ENTRADA";
            buttonEntrada.UseVisualStyleBackColor = true;
            buttonEntrada.Click += buttonEntrada_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 953);
            Controls.Add(MainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IPD";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel MainPanel;
        private Button buttonAlquiler;
        private Button buttonEntrada;
        private Label label2;
        private Button button_utileria;
    }
}