namespace atividade1
{
    partial class Atividade1
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
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.lblsalario = new System.Windows.Forms.Label();
            this.lblcomissao = new System.Windows.Forms.Label();
            this.txtcomissao = new System.Windows.Forms.TextBox();
            this.lblsalarioS = new System.Windows.Forms.Label();
            this.txtsalarioS = new System.Windows.Forms.TextBox();
            this.lblsalarioF = new System.Windows.Forms.Label();
            this.txtsalarioF = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblvendaT = new System.Windows.Forms.Label();
            this.lblvalorT = new System.Windows.Forms.Label();
            this.txtvendaT = new System.Windows.Forms.TextBox();
            this.txtvalorT = new System.Windows.Forms.TextBox();
            this.txtporcentagem = new System.Windows.Forms.TextBox();
            this.lblporcentagem = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(201, 72);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 0;
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Location = new System.Drawing.Point(34, 75);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(161, 13);
            this.lblsalario.TabIndex = 1;
            this.lblsalario.Text = "Digite o salário fixo do vendedor:";
            // 
            // lblcomissao
            // 
            this.lblcomissao.AutoSize = true;
            this.lblcomissao.Location = new System.Drawing.Point(34, 110);
            this.lblcomissao.Name = "lblcomissao";
            this.lblcomissao.Size = new System.Drawing.Size(163, 13);
            this.lblcomissao.TabIndex = 2;
            this.lblcomissao.Text = "Digite a comissão fixa por venda:";
            // 
            // txtcomissao
            // 
            this.txtcomissao.Location = new System.Drawing.Point(201, 107);
            this.txtcomissao.Name = "txtcomissao";
            this.txtcomissao.Size = new System.Drawing.Size(100, 20);
            this.txtcomissao.TabIndex = 3;
            // 
            // lblsalarioS
            // 
            this.lblsalarioS.AutoSize = true;
            this.lblsalarioS.Location = new System.Drawing.Point(37, 202);
            this.lblsalarioS.Name = "lblsalarioS";
            this.lblsalarioS.Size = new System.Drawing.Size(117, 13);
            this.lblsalarioS.TabIndex = 4;
            this.lblsalarioS.Text = "Salário final sem os 5%:";
            // 
            // txtsalarioS
            // 
            this.txtsalarioS.Location = new System.Drawing.Point(161, 195);
            this.txtsalarioS.Name = "txtsalarioS";
            this.txtsalarioS.ReadOnly = true;
            this.txtsalarioS.Size = new System.Drawing.Size(100, 20);
            this.txtsalarioS.TabIndex = 5;
            // 
            // lblsalarioF
            // 
            this.lblsalarioF.AutoSize = true;
            this.lblsalarioF.Location = new System.Drawing.Point(37, 226);
            this.lblsalarioF.Name = "lblsalarioF";
            this.lblsalarioF.Size = new System.Drawing.Size(118, 13);
            this.lblsalarioF.TabIndex = 6;
            this.lblsalarioF.Text = "Salário final com os 5%:";
            // 
            // txtsalarioF
            // 
            this.txtsalarioF.Location = new System.Drawing.Point(161, 221);
            this.txtsalarioF.Name = "txtsalarioF";
            this.txtsalarioF.ReadOnly = true;
            this.txtsalarioF.Size = new System.Drawing.Size(100, 20);
            this.txtsalarioF.TabIndex = 7;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(40, 306);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblvendaT
            // 
            this.lblvendaT.AutoSize = true;
            this.lblvendaT.Location = new System.Drawing.Point(34, 138);
            this.lblvendaT.Name = "lblvendaT";
            this.lblvendaT.Size = new System.Drawing.Size(177, 13);
            this.lblvendaT.TabIndex = 9;
            this.lblvendaT.Text = "Digite o número de carros vendidos:";
            // 
            // lblvalorT
            // 
            this.lblvalorT.AutoSize = true;
            this.lblvalorT.Location = new System.Drawing.Point(37, 172);
            this.lblvalorT.Name = "lblvalorT";
            this.lblvalorT.Size = new System.Drawing.Size(153, 13);
            this.lblvalorT.TabIndex = 10;
            this.lblvalorT.Text = "Digite o valor total das vendas:";
            // 
            // txtvendaT
            // 
            this.txtvendaT.Location = new System.Drawing.Point(218, 138);
            this.txtvendaT.Name = "txtvendaT";
            this.txtvendaT.Size = new System.Drawing.Size(100, 20);
            this.txtvendaT.TabIndex = 11;
            // 
            // txtvalorT
            // 
            this.txtvalorT.Location = new System.Drawing.Point(201, 167);
            this.txtvalorT.Name = "txtvalorT";
            this.txtvalorT.Size = new System.Drawing.Size(100, 20);
            this.txtvalorT.TabIndex = 12;
            // 
            // txtporcentagem
            // 
            this.txtporcentagem.Location = new System.Drawing.Point(114, 261);
            this.txtporcentagem.Name = "txtporcentagem";
            this.txtporcentagem.ReadOnly = true;
            this.txtporcentagem.Size = new System.Drawing.Size(99, 20);
            this.txtporcentagem.TabIndex = 13;
            // 
            // lblporcentagem
            // 
            this.lblporcentagem.AutoSize = true;
            this.lblporcentagem.Location = new System.Drawing.Point(37, 264);
            this.lblporcentagem.Name = "lblporcentagem";
            this.lblporcentagem.Size = new System.Drawing.Size(71, 13);
            this.lblporcentagem.TabIndex = 14;
            this.lblporcentagem.Text = "Valor dos 5%:";
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(151, 306);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 15;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(267, 306);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 16;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // Atividade1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.lblporcentagem);
            this.Controls.Add(this.txtporcentagem);
            this.Controls.Add(this.txtvalorT);
            this.Controls.Add(this.txtvendaT);
            this.Controls.Add(this.lblvalorT);
            this.Controls.Add(this.lblvendaT);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtsalarioF);
            this.Controls.Add(this.lblsalarioF);
            this.Controls.Add(this.txtsalarioS);
            this.Controls.Add(this.lblsalarioS);
            this.Controls.Add(this.txtcomissao);
            this.Controls.Add(this.lblcomissao);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.txtsalario);
            this.Name = "Atividade1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atividade 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.Label lblcomissao;
        private System.Windows.Forms.TextBox txtcomissao;
        private System.Windows.Forms.Label lblsalarioS;
        private System.Windows.Forms.TextBox txtsalarioS;
        private System.Windows.Forms.Label lblsalarioF;
        private System.Windows.Forms.TextBox txtsalarioF;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblvendaT;
        private System.Windows.Forms.Label lblvalorT;
        private System.Windows.Forms.TextBox txtvendaT;
        private System.Windows.Forms.TextBox txtvalorT;
        private System.Windows.Forms.TextBox txtporcentagem;
        private System.Windows.Forms.Label lblporcentagem;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
    }
}

