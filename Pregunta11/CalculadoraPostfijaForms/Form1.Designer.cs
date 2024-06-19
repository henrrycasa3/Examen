namespace CalculadoraPostfijaForms
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
            label1 = new Label();
            txtExpresion = new TextBox();
            btnEvaluar = new Button();
            lblResultado = new Label();
            lblExpresionInfija = new Label();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 29);
            label1.Name = "label1";
            label1.Size = new Size(299, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese una expresión postfija: separado por un espacio";
            // 
            // txtExpresion
            // 
            txtExpresion.Location = new Point(26, 100);
            txtExpresion.Name = "txtExpresion";
            txtExpresion.Size = new Size(314, 23);
            txtExpresion.TabIndex = 1;
            // 
            // btnEvaluar
            // 
            btnEvaluar.Location = new Point(26, 144);
            btnEvaluar.Name = "btnEvaluar";
            btnEvaluar.Size = new Size(314, 34);
            btnEvaluar.TabIndex = 2;
            btnEvaluar.Text = "Calcular";
            btnEvaluar.UseVisualStyleBackColor = true;
            btnEvaluar.Click += btnEvaluar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(26, 202);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado:";
            // 
            // lblExpresionInfija
            // 
            lblExpresionInfija.AutoSize = true;
            lblExpresionInfija.Location = new Point(26, 243);
            lblExpresionInfija.Name = "lblExpresionInfija";
            lblExpresionInfija.Size = new Size(90, 15);
            lblExpresionInfija.TabIndex = 4;
            lblExpresionInfija.Text = "Expresión infija:";
            // 
            // button2
            // 
            button2.Location = new Point(248, 259);
            button2.Name = "button2";
            button2.Size = new Size(92, 43);
            button2.TabIndex = 5;
            button2.Text = "Calculadora";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 66);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 6;
            label2.Text = "Por ejemplo: 2 8 * 15 2 / + 2 -";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 316);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(lblExpresionInfija);
            Controls.Add(lblResultado);
            Controls.Add(btnEvaluar);
            Controls.Add(txtExpresion);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtExpresion;
        private Button btnEvaluar;
        private Label lblResultado;
        private Label lblExpresionInfija;
        private Button button2;

        
            // Agregamos el método para manejar el evento del botón "Evaluar"
            private void btnEvaluar_Click(object sender, EventArgs e)
            {
                string expresion = txtExpresion.Text;

                try
                {
                    // Creamos una instancia del evaluador de expresiones postfijas
                    CalculadoraPostfija.Logica.EvaluadorPostfijo evaluador = new CalculadoraPostfija.Logica.EvaluadorPostfijo();

                    // Evaluamos la expresión postfija
                    decimal resultado = evaluador.Evaluar(expresion);

                    // Mostramos el resultado en el label
                    lblResultado.Text = $"Resultado: {resultado}";

                    // Mostramos la expresión infija en el label
                    lblExpresionInfija.Text = $"Expresión infija: {evaluador.ObtenerExpresionInfija()}";
                }
                catch (Exception ex)
                {
                    // En caso de error, mostramos un mensaje
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }

        private Label label2;
    }
}


