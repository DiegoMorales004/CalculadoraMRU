namespace CalculadorMRU
{
    partial class FormMRU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMRU));
            btnCerrar = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtTiempo = new TextBox();
            Distancia = new Label();
            txtDistancia = new TextBox();
            label3 = new Label();
            btnCalcular = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            txtVelocidad = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom;
            btnCerrar.BackColor = Color.IndianRed;
            btnCerrar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ButtonFace;
            btnCerrar.Location = new Point(333, 516);
            btnCerrar.MaximumSize = new Size(135, 40);
            btnCerrar.MinimumSize = new Size(135, 40);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(135, 40);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(278, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(356, 21);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 5;
            label2.Text = "Tiempo (s)";
            // 
            // txtTiempo
            // 
            txtTiempo.Dock = DockStyle.Fill;
            txtTiempo.Location = new Point(0, 0);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(248, 31);
            txtTiempo.TabIndex = 4;
            txtTiempo.TextAlign = HorizontalAlignment.Center;
            txtTiempo.KeyPress += txtTiempo_KeyPress;
            // 
            // Distancia
            // 
            Distancia.AutoSize = true;
            Distancia.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Distancia.Location = new Point(75, 21);
            Distancia.Name = "Distancia";
            Distancia.Size = new Size(133, 25);
            Distancia.TabIndex = 7;
            Distancia.Text = "Distancia (m)";
            // 
            // txtDistancia
            // 
            txtDistancia.Dock = DockStyle.Fill;
            txtDistancia.Location = new Point(0, 0);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(248, 31);
            txtDistancia.TabIndex = 6;
            txtDistancia.TextAlign = HorizontalAlignment.Center;
            txtDistancia.KeyPress += txtDistancia_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(597, 21);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 9;
            label3.Text = "Velocidad (m/s)";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(70, 136, 71);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(333, 126);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(135, 40);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtDistancia);
            panel1.Location = new Point(12, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 31);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTiempo);
            panel2.Location = new Point(278, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 31);
            panel2.TabIndex = 12;
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(540, 61);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(248, 31);
            txtVelocidad.TabIndex = 8;
            txtVelocidad.TextAlign = HorizontalAlignment.Center;
            txtVelocidad.TextChanged += txtVelocidad_TextChanged;
            txtVelocidad.KeyPress += txtVelocidad_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(69, 558);
            label1.Name = "label1";
            label1.Size = new Size(226, 21);
            label1.TabIndex = 13;
            label1.Text = "Diego Morales 5990 24 15055";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 538);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // FormMRU
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 592);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(txtVelocidad);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(Distancia);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMRU";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora MRU";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtTiempo;
        private Label Distancia;
        private TextBox txtDistancia;
        private Label label3;
        private Button btnCalcular;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtVelocidad;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
