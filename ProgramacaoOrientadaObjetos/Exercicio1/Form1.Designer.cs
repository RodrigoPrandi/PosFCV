namespace Exercicio1
{
    partial class Form1
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
            this.btnAdicionarConsumacao = new System.Windows.Forms.Button();
            this.buttonDividirConta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConsumacao = new System.Windows.Forms.TextBox();
            this.textBoxQuantidadePessoas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorPorPessoa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPagarParte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdicionarConsumacao
            // 
            this.btnAdicionarConsumacao.Location = new System.Drawing.Point(130, 39);
            this.btnAdicionarConsumacao.Name = "btnAdicionarConsumacao";
            this.btnAdicionarConsumacao.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarConsumacao.TabIndex = 0;
            this.btnAdicionarConsumacao.Text = "Adicionar";
            this.btnAdicionarConsumacao.UseVisualStyleBackColor = true;
            this.btnAdicionarConsumacao.Click += new System.EventHandler(this.btnAdicionarConsumacao_Click);
            // 
            // buttonDividirConta
            // 
            this.buttonDividirConta.Location = new System.Drawing.Point(91, 180);
            this.buttonDividirConta.Name = "buttonDividirConta";
            this.buttonDividirConta.Size = new System.Drawing.Size(75, 23);
            this.buttonDividirConta.TabIndex = 1;
            this.buttonDividirConta.Text = "Dividir Conta";
            this.buttonDividirConta.UseVisualStyleBackColor = true;
            this.buttonDividirConta.Click += new System.EventHandler(this.buttonDividirConta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Conta:";
            // 
            // textBoxConsumacao
            // 
            this.textBoxConsumacao.Location = new System.Drawing.Point(24, 41);
            this.textBoxConsumacao.Name = "textBoxConsumacao";
            this.textBoxConsumacao.Size = new System.Drawing.Size(100, 20);
            this.textBoxConsumacao.TabIndex = 3;
            // 
            // textBoxQuantidadePessoas
            // 
            this.textBoxQuantidadePessoas.Location = new System.Drawing.Point(24, 180);
            this.textBoxQuantidadePessoas.Name = "textBoxQuantidadePessoas";
            this.textBoxQuantidadePessoas.Size = new System.Drawing.Size(49, 20);
            this.textBoxQuantidadePessoas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantidade Pessoas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Consumação";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(289, 41);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(72, 20);
            this.lblValorTotal.TabIndex = 7;
            this.lblValorTotal.Text = "R$ 0,00";
            // 
            // lblValorPorPessoa
            // 
            this.lblValorPorPessoa.AutoSize = true;
            this.lblValorPorPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPorPessoa.Location = new System.Drawing.Point(199, 170);
            this.lblValorPorPessoa.Name = "lblValorPorPessoa";
            this.lblValorPorPessoa.Size = new System.Drawing.Size(72, 20);
            this.lblValorPorPessoa.TabIndex = 9;
            this.lblValorPorPessoa.Text = "R$ 0,00";
            this.lblValorPorPessoa.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor Por Pessoa:";
            // 
            // buttonPagarParte
            // 
            this.buttonPagarParte.Location = new System.Drawing.Point(91, 218);
            this.buttonPagarParte.Name = "buttonPagarParte";
            this.buttonPagarParte.Size = new System.Drawing.Size(75, 23);
            this.buttonPagarParte.TabIndex = 10;
            this.buttonPagarParte.Text = "Pagar Parte";
            this.buttonPagarParte.UseVisualStyleBackColor = true;
            this.buttonPagarParte.Click += new System.EventHandler(this.buttonPagarParte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 288);
            this.Controls.Add(this.buttonPagarParte);
            this.Controls.Add(this.lblValorPorPessoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuantidadePessoas);
            this.Controls.Add(this.textBoxConsumacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDividirConta);
            this.Controls.Add(this.btnAdicionarConsumacao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarConsumacao;
        private System.Windows.Forms.Button buttonDividirConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConsumacao;
        private System.Windows.Forms.TextBox textBoxQuantidadePessoas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblValorPorPessoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPagarParte;
    }
}

