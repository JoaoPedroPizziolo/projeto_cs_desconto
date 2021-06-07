namespace Exe9_pag30_24
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtnprodutos = new System.Windows.Forms.TextBox();
            this.btncalcule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade de produtos:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(4, 30);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 2;
            // 
            // txtnprodutos
            // 
            this.txtnprodutos.Location = new System.Drawing.Point(4, 75);
            this.txtnprodutos.Name = "txtnprodutos";
            this.txtnprodutos.Size = new System.Drawing.Size(100, 20);
            this.txtnprodutos.TabIndex = 3;
            // 
            // btncalcule
            // 
            this.btncalcule.Location = new System.Drawing.Point(4, 103);
            this.btncalcule.Name = "btncalcule";
            this.btncalcule.Size = new System.Drawing.Size(100, 23);
            this.btncalcule.TabIndex = 4;
            this.btncalcule.Text = "Calcule";
            this.btncalcule.UseVisualStyleBackColor = true;
            this.btncalcule.Click += new System.EventHandler(this.btncalcule_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 138);
            this.Controls.Add(this.btncalcule);
            this.Controls.Add(this.txtnprodutos);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtnprodutos;
        private System.Windows.Forms.Button btncalcule;
    }
}

