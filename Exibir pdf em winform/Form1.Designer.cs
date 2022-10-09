
namespace Exibir_pdf_em_winform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTTN_pesquisar_pdf = new System.Windows.Forms.Button();
            this.TB_id_pdf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTTN_pesquisar_pdf
            // 
            this.BTTN_pesquisar_pdf.BackColor = System.Drawing.Color.SeaGreen;
            this.BTTN_pesquisar_pdf.FlatAppearance.BorderSize = 0;
            this.BTTN_pesquisar_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTTN_pesquisar_pdf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTN_pesquisar_pdf.ForeColor = System.Drawing.Color.White;
            this.BTTN_pesquisar_pdf.Location = new System.Drawing.Point(254, 310);
            this.BTTN_pesquisar_pdf.Name = "BTTN_pesquisar_pdf";
            this.BTTN_pesquisar_pdf.Size = new System.Drawing.Size(261, 49);
            this.BTTN_pesquisar_pdf.TabIndex = 0;
            this.BTTN_pesquisar_pdf.Text = "Abrir PDF";
            this.BTTN_pesquisar_pdf.UseVisualStyleBackColor = false;
            this.BTTN_pesquisar_pdf.Click += new System.EventHandler(this.BTTN_pesquisar_pdf_Click);
            // 
            // TB_id_pdf
            // 
            this.TB_id_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_id_pdf.Location = new System.Drawing.Point(216, 143);
            this.TB_id_pdf.Name = "TB_id_pdf";
            this.TB_id_pdf.Size = new System.Drawing.Size(338, 38);
            this.TB_id_pdf.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_id_pdf);
            this.Controls.Add(this.BTTN_pesquisar_pdf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTTN_pesquisar_pdf;
        private System.Windows.Forms.TextBox TB_id_pdf;
    }
}

