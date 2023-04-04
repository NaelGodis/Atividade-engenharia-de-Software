
namespace Calculadora
{
    partial class Calculadora
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
            this.conteiner = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.btdividir = new System.Windows.Forms.Button();
            this.btSubtrair = new System.Windows.Forms.Button();
            this.btSomar = new System.Windows.Forms.Button();
            this.textNr2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNr1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.conteiner.SuspendLayout();
            this.SuspendLayout();
            // 
            // conteiner
            // 
            this.conteiner.Controls.Add(this.lblResultado);
            this.conteiner.Controls.Add(this.lblRes);
            this.conteiner.Controls.Add(this.btMultiplicar);
            this.conteiner.Controls.Add(this.btdividir);
            this.conteiner.Controls.Add(this.btSubtrair);
            this.conteiner.Controls.Add(this.btSomar);
            this.conteiner.Controls.Add(this.textNr2);
            this.conteiner.Controls.Add(this.label2);
            this.conteiner.Controls.Add(this.textNr1);
            this.conteiner.Controls.Add(this.label1);
            this.conteiner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conteiner.Location = new System.Drawing.Point(39, -5);
            this.conteiner.Name = "conteiner";
            this.conteiner.Size = new System.Drawing.Size(347, 273);
            this.conteiner.TabIndex = 0;
            this.conteiner.TabStop = false;
            this.conteiner.Text = "  ";
            this.conteiner.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(86, 136);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(16, 16);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "0";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(7, 136);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(73, 16);
            this.lblRes.TabIndex = 8;
            this.lblRes.Text = "Resultado:";
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.Location = new System.Drawing.Point(250, 106);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btMultiplicar.TabIndex = 7;
            this.btMultiplicar.Text = "Multiplicar";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // btdividir
            // 
            this.btdividir.Location = new System.Drawing.Point(169, 106);
            this.btdividir.Name = "btdividir";
            this.btdividir.Size = new System.Drawing.Size(75, 23);
            this.btdividir.TabIndex = 6;
            this.btdividir.Text = "Dividir";
            this.btdividir.UseVisualStyleBackColor = true;
            this.btdividir.Click += new System.EventHandler(this.btdividir_Click);
            // 
            // btSubtrair
            // 
            this.btSubtrair.Location = new System.Drawing.Point(88, 106);
            this.btSubtrair.Name = "btSubtrair";
            this.btSubtrair.Size = new System.Drawing.Size(75, 23);
            this.btSubtrair.TabIndex = 5;
            this.btSubtrair.Text = "Subtrair";
            this.btSubtrair.UseVisualStyleBackColor = true;
            this.btSubtrair.Click += new System.EventHandler(this.btSubtrair_Click);
            // 
            // btSomar
            // 
            this.btSomar.Location = new System.Drawing.Point(0, 106);
            this.btSomar.Name = "btSomar";
            this.btSomar.Size = new System.Drawing.Size(75, 23);
            this.btSomar.TabIndex = 4;
            this.btSomar.Text = "Somar";
            this.btSomar.UseVisualStyleBackColor = true;
            this.btSomar.Click += new System.EventHandler(this.btSomar_Click);
            // 
            // textNr2
            // 
            this.textNr2.Location = new System.Drawing.Point(0, 79);
            this.textNr2.Name = "textNr2";
            this.textNr2.Size = new System.Drawing.Size(100, 22);
            this.textNr2.TabIndex = 3;
            this.textNr2.TextChanged += new System.EventHandler(this.textNr2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Segundo Número";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textNr1
            // 
            this.textNr1.Location = new System.Drawing.Point(0, 36);
            this.textNr1.Name = "textNr1";
            this.textNr1.Size = new System.Drawing.Size(100, 22);
            this.textNr1.TabIndex = 1;
            this.textNr1.TextChanged += new System.EventHandler(this.textNr1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro Número";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 270);
            this.Controls.Add(this.conteiner);
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.conteiner.ResumeLayout(false);
            this.conteiner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox conteiner;
        private System.Windows.Forms.TextBox textNr2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNr1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btdividir;
        private System.Windows.Forms.Button btSubtrair;
        private System.Windows.Forms.Button btSomar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btMultiplicar;
    }
}

