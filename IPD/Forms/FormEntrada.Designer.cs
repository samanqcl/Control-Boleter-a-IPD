namespace IPD.Forms
{
    partial class FormEntrada
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntrada));
            panel1 = new Panel();
            textBoxTarifas = new TextBox();
            label4 = new Label();
            buttonMoneda = new Button();
            label7 = new Label();
            labelSegundos = new Label();
            label3 = new Label();
            buttonCancelar = new Button();
            comboBoxDeporte = new ComboBox();
            textBoxDNI = new TextBox();
            buttonPagar = new Button();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            errorEPago = new ErrorProvider(components);
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorEPago).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxTarifas);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonMoneda);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(labelSegundos);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(comboBoxDeporte);
            panel1.Controls.Add(textBoxDNI);
            panel1.Controls.Add(buttonPagar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 906);
            panel1.TabIndex = 16;
            // 
            // textBoxTarifas
            // 
            textBoxTarifas.BackColor = SystemColors.Control;
            textBoxTarifas.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTarifas.Location = new Point(304, 484);
            textBoxTarifas.Name = "textBoxTarifas";
            textBoxTarifas.Size = new Size(186, 45);
            textBoxTarifas.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(101, 487);
            label4.Name = "label4";
            label4.Size = new Size(206, 37);
            label4.TabIndex = 33;
            label4.Text = "TARIFA:       S/";
            // 
            // buttonMoneda
            // 
            buttonMoneda.Font = new Font("HP Simplified Hans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMoneda.Location = new Point(70, 812);
            buttonMoneda.Name = "buttonMoneda";
            buttonMoneda.Size = new Size(225, 40);
            buttonMoneda.TabIndex = 32;
            buttonMoneda.Text = "PAGO SIMULADO";
            buttonMoneda.UseVisualStyleBackColor = true;
            buttonMoneda.Click += buttonMoneda_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("HP Simplified Hans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(216, 50);
            label7.Name = "label7";
            label7.Size = new Size(90, 19);
            label7.TabIndex = 31;
            label7.Text = "SEGUNDOS";
            // 
            // labelSegundos
            // 
            labelSegundos.AutoSize = true;
            labelSegundos.Font = new Font("HP Simplified Hans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSegundos.Location = new Point(185, 47);
            labelSegundos.Name = "labelSegundos";
            labelSegundos.Size = new Size(32, 23);
            labelSegundos.TabIndex = 30;
            labelSegundos.Text = "99";
            labelSegundos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HP Simplified Hans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 50);
            label3.Name = "label3";
            label3.Size = new Size(145, 19);
            label3.TabIndex = 29;
            label3.Text = "TIEMPO RESTANTE";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(421, 802);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(200, 50);
            buttonCancelar.TabIndex = 28;
            buttonCancelar.Text = "CANCELAR";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // comboBoxDeporte
            // 
            comboBoxDeporte.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDeporte.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDeporte.FormattingEnabled = true;
            comboBoxDeporte.Location = new Point(101, 400);
            comboBoxDeporte.Name = "comboBoxDeporte";
            comboBoxDeporte.Size = new Size(450, 45);
            comboBoxDeporte.TabIndex = 27;
            comboBoxDeporte.SelectedIndexChanged += comboBoxDeporte_SelectedIndexChanged;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDNI.Location = new Point(101, 259);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(450, 45);
            textBoxDNI.TabIndex = 24;
            // 
            // buttonPagar
            // 
            buttonPagar.Font = new Font("HP Simplified Hans", 40.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPagar.Location = new Point(170, 623);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(300, 100);
            buttonPagar.TabIndex = 23;
            buttonPagar.Text = "PAGAR";
            buttonPagar.UseVisualStyleBackColor = true;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(101, 336);
            label5.Name = "label5";
            label5.Size = new Size(387, 37);
            label5.TabIndex = 21;
            label5.Text = "SELECCIONE UN DEPORTE:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(101, 209);
            label6.Name = "label6";
            label6.Size = new Size(83, 37);
            label6.TabIndex = 18;
            label6.Text = "DNI: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified Hans", 34.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 100);
            label1.Name = "label1";
            label1.Size = new Size(271, 66);
            label1.TabIndex = 17;
            label1.Text = "ENTRADA";
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
            label2.TabIndex = 16;
            label2.Text = "      (01) 204 - 8420";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorEPago
            // 
            errorEPago.ContainerControl = this;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormEntrada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 906);
            Controls.Add(panel1);
            Name = "FormEntrada";
            Text = "FormEntrada";
            Load += FormEntrada_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorEPago).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxDeporte;
        private TextBox textBoxDNI;
        private Button buttonPagar;
        private Label label5;
        private Label label6;
        private Button buttonCancelar;
        private ErrorProvider errorEPago;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Label label7;
        private Label labelSegundos;
        private Button buttonMoneda;
        private TextBox textBoxTarifas;
        private Label label4;
    }
}