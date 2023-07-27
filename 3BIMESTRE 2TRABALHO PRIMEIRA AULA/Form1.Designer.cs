namespace _3BIMESTRE_2TRABALHO_PRIMEIRA_AULA
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
            this.dtp_calendario = new System.Windows.Forms.DateTimePicker();
            this.lb_resposta = new System.Windows.Forms.Label();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_calendario
            // 
            this.dtp_calendario.Location = new System.Drawing.Point(236, 88);
            this.dtp_calendario.Name = "dtp_calendario";
            this.dtp_calendario.Size = new System.Drawing.Size(200, 22);
            this.dtp_calendario.TabIndex = 0;
            // 
            // lb_resposta
            // 
            this.lb_resposta.AutoSize = true;
            this.lb_resposta.Location = new System.Drawing.Point(274, 185);
            this.lb_resposta.Name = "lb_resposta";
            this.lb_resposta.Size = new System.Drawing.Size(81, 16);
            this.lb_resposta.TabIndex = 1;
            this.lb_resposta.Text = "RESPOSTA";
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(277, 250);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(75, 23);
            this.bt_calcular.TabIndex = 2;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.lb_resposta);
            this.Controls.Add(this.dtp_calendario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_calendario;
        private System.Windows.Forms.Label lb_resposta;
        private System.Windows.Forms.Button bt_calcular;
    }
}

