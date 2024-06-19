namespace CalculadoraPostfijaForms
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            btnCalcular = new Button();
            txtExpresion = new TextBox();
            txtExpresionPostfija = new TextBox();
            txtResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button17 = new Button();
            button18 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(20, 145);
            button1.Name = "button1";
            button1.Size = new Size(75, 54);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDigito_Click;
            // 
            // button2
            // 
            button2.Location = new Point(101, 145);
            button2.Name = "button2";
            button2.Size = new Size(75, 54);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnDigito_Click;
            // 
            // button3
            // 
            button3.Location = new Point(182, 145);
            button3.Name = "button3";
            button3.Size = new Size(75, 54);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDigito_Click;
            // 
            // button4
            // 
            button4.Location = new Point(20, 205);
            button4.Name = "button4";
            button4.Size = new Size(75, 54);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnDigito_Click;
            // 
            // button5
            // 
            button5.Location = new Point(101, 205);
            button5.Name = "button5";
            button5.Size = new Size(75, 54);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnDigito_Click;
            // 
            // button6
            // 
            button6.Location = new Point(182, 205);
            button6.Name = "button6";
            button6.Size = new Size(75, 54);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnDigito_Click;
            // 
            // button7
            // 
            button7.Location = new Point(20, 265);
            button7.Name = "button7";
            button7.Size = new Size(75, 54);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnDigito_Click;
            // 
            // button8
            // 
            button8.Location = new Point(101, 265);
            button8.Name = "button8";
            button8.Size = new Size(75, 54);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnDigito_Click;
            // 
            // button9
            // 
            button9.Location = new Point(182, 265);
            button9.Name = "button9";
            button9.Size = new Size(75, 54);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnDigito_Click;
            // 
            // button10
            // 
            button10.Location = new Point(101, 325);
            button10.Name = "button10";
            button10.Size = new Size(75, 54);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnDigito_Click;
            // 
            // button11
            // 
            button11.Location = new Point(273, 145);
            button11.Name = "button11";
            button11.Size = new Size(75, 37);
            button11.TabIndex = 10;
            button11.Text = "(";
            button11.UseVisualStyleBackColor = true;
            button11.Click += btnOperador_Click;
            // 
            // button12
            // 
            button12.Location = new Point(364, 145);
            button12.Name = "button12";
            button12.Size = new Size(75, 37);
            button12.TabIndex = 11;
            button12.Text = ")";
            button12.UseVisualStyleBackColor = true;
            button12.Click += btnOperador_Click;
            // 
            // button13
            // 
            button13.Location = new Point(273, 197);
            button13.Name = "button13";
            button13.Size = new Size(75, 37);
            button13.TabIndex = 12;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += btnOperador_Click;
            // 
            // button14
            // 
            button14.Location = new Point(364, 197);
            button14.Name = "button14";
            button14.Size = new Size(75, 37);
            button14.TabIndex = 13;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += btnOperador_Click;
            // 
            // button15
            // 
            button15.Location = new Point(273, 249);
            button15.Name = "button15";
            button15.Size = new Size(75, 37);
            button15.TabIndex = 14;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = true;
            button15.Click += btnOperador_Click;
            // 
            // button16
            // 
            button16.Location = new Point(364, 249);
            button16.Name = "button16";
            button16.Size = new Size(75, 37);
            button16.TabIndex = 15;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += btnOperador_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(273, 300);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(90, 38);
            btnCalcular.TabIndex = 16;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtExpresion
            // 
            txtExpresion.Location = new Point(165, 17);
            txtExpresion.Name = "txtExpresion";
            txtExpresion.Size = new Size(274, 23);
            txtExpresion.TabIndex = 17;
            // 
            // txtExpresionPostfija
            // 
            txtExpresionPostfija.Location = new Point(165, 57);
            txtExpresionPostfija.Name = "txtExpresionPostfija";
            txtExpresionPostfija.Size = new Size(274, 23);
            txtExpresionPostfija.TabIndex = 18;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(165, 103);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(274, 23);
            txtResultado.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 101);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 20;
            label1.Text = "RESULTADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 60);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 21;
            label2.Text = "Expresión postfija";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 20);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 22;
            label3.Text = "Expresión ingresada";
            // 
            // button17
            // 
            button17.Location = new Point(369, 300);
            button17.Name = "button17";
            button17.Size = new Size(70, 38);
            button17.TabIndex = 23;
            button17.Text = "BORRAR";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Location = new Point(273, 356);
            button18.Name = "button18";
            button18.Size = new Size(166, 34);
            button18.TabIndex = 24;
            button18.Text = "LIMPIAR TODO";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 427);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(txtExpresionPostfija);
            Controls.Add(txtExpresion);
            Controls.Add(btnCalcular);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button btnCalcular;
        private TextBox txtExpresion;
        private TextBox txtExpresionPostfija;
        private TextBox txtResultado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button17;
        private Button button18;
    }
}