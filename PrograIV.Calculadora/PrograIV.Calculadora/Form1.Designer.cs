namespace PrograIV.Calculadora
{
    partial class frmCalculadora
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
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.lblOperador1 = new System.Windows.Forms.Label();
            this.lblOperador2 = new System.Windows.Forms.Label();
            this.txtOperador1 = new System.Windows.Forms.TextBox();
            this.txtOperador2 = new System.Windows.Forms.TextBox();
            this.cbOperador = new System.Windows.Forms.ComboBox();
            this.lblSeleccione = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.Location = new System.Drawing.Point(235, 29);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(63, 13);
            this.lblCalculadora.TabIndex = 0;
            this.lblCalculadora.Text = "Calculadora";
            // 
            // lblOperador1
            // 
            this.lblOperador1.AutoSize = true;
            this.lblOperador1.Location = new System.Drawing.Point(59, 96);
            this.lblOperador1.Name = "lblOperador1";
            this.lblOperador1.Size = new System.Drawing.Size(127, 13);
            this.lblOperador1.TabIndex = 1;
            this.lblOperador1.Text = "Digite el Primer Operador ";
            // 
            // lblOperador2
            // 
            this.lblOperador2.AutoSize = true;
            this.lblOperador2.Location = new System.Drawing.Point(338, 96);
            this.lblOperador2.Name = "lblOperador2";
            this.lblOperador2.Size = new System.Drawing.Size(138, 13);
            this.lblOperador2.TabIndex = 2;
            this.lblOperador2.Text = "Digite el Segundo Operador";
            // 
            // txtOperador1
            // 
            this.txtOperador1.Location = new System.Drawing.Point(73, 112);
            this.txtOperador1.Name = "txtOperador1";
            this.txtOperador1.Size = new System.Drawing.Size(100, 20);
            this.txtOperador1.TabIndex = 3;
            // 
            // txtOperador2
            // 
            this.txtOperador2.Location = new System.Drawing.Point(357, 112);
            this.txtOperador2.Name = "txtOperador2";
            this.txtOperador2.Size = new System.Drawing.Size(100, 20);
            this.txtOperador2.TabIndex = 4;
            // 
            // cbOperador
            // 
            this.cbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperador.FormattingEnabled = true;
            this.cbOperador.Items.AddRange(new object[] {
            "Suma ",
            "Resta ",
            "Multiplicacion ",
            "Division "});
            this.cbOperador.Location = new System.Drawing.Point(197, 154);
            this.cbOperador.Name = "cbOperador";
            this.cbOperador.Size = new System.Drawing.Size(138, 21);
            this.cbOperador.TabIndex = 5;
            // 
            // lblSeleccione
            // 
            this.lblSeleccione.AutoSize = true;
            this.lblSeleccione.Location = new System.Drawing.Point(205, 138);
            this.lblSeleccione.Name = "lblSeleccione";
            this.lblSeleccione.Size = new System.Drawing.Size(121, 13);
            this.lblSeleccione.TabIndex = 6;
            this.lblSeleccione.Text = "Seleccione el Operador ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(223, 203);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(235, 252);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(208, 268);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 328);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSeleccione);
            this.Controls.Add(this.cbOperador);
            this.Controls.Add(this.txtOperador2);
            this.Controls.Add(this.txtOperador1);
            this.Controls.Add(this.lblOperador2);
            this.Controls.Add(this.lblOperador1);
            this.Controls.Add(this.lblCalculadora);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.Label lblOperador1;
        private System.Windows.Forms.Label lblOperador2;
        private System.Windows.Forms.TextBox txtOperador1;
        private System.Windows.Forms.TextBox txtOperador2;
        private System.Windows.Forms.ComboBox cbOperador;
        private System.Windows.Forms.Label lblSeleccione;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

