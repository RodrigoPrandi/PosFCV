namespace Exercicio2
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
            this.btnInterruptor = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInterruptor
            // 
            this.btnInterruptor.Location = new System.Drawing.Point(96, 12);
            this.btnInterruptor.Name = "btnInterruptor";
            this.btnInterruptor.Size = new System.Drawing.Size(75, 23);
            this.btnInterruptor.TabIndex = 0;
            this.btnInterruptor.Text = "Interruptor";
            this.btnInterruptor.UseVisualStyleBackColor = true;
            this.btnInterruptor.Click += new System.EventHandler(this.btnInterruptor_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(70, 132);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(0, 31);
            this.lblValorTotal.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.btnInterruptor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInterruptor;
        private System.Windows.Forms.Label lblValorTotal;
    }
}

