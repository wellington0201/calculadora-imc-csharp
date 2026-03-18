namespace WellingtonHenriqueDaSilva_IMC
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
            lbPeso = new Label();
            lbAltura = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            lbResultado = new Label();
            lbClassificacao = new Label();
            SuspendLayout();
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.Location = new Point(79, 57);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(148, 20);
            lbPeso.TabIndex = 0;
            lbPeso.Text = "Informe um Peso(Kg)";
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.Location = new Point(274, 57);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(161, 20);
            lbAltura.TabIndex = 1;
            lbAltura.Text = "Informe uma Altura(m)";
            lbAltura.Click += label2_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(79, 95);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(125, 27);
            txtPeso.TabIndex = 2;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(274, 95);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(110, 182);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(294, 164);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(75, 20);
            lbResultado.TabIndex = 5;
            lbResultado.Text = "Resultado";
            lbResultado.Click += lbResultado_Click;
            // 
            // lbClassificacao
            // 
            lbClassificacao.AutoSize = true;
            lbClassificacao.Location = new Point(294, 215);
            lbClassificacao.Name = "lbClassificacao";
            lbClassificacao.Size = new Size(94, 20);
            lbClassificacao.TabIndex = 6;
            lbClassificacao.Text = "Classificação";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbClassificacao);
            Controls.Add(lbResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(lbAltura);
            Controls.Add(lbPeso);
            Name = "Form1";
            Text = "CalculadoraIMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPeso;
        private Label lbAltura;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label lbResultado;
        private Label lbClassificacao;
    }
}
