using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;

namespace Exibir_pdf_em_winform
{
    public partial class Form1 : Form
    {
       


        public Form1()
        {
            InitializeComponent();

           
        }


        private void BTTN_pesquisar_pdf_Click(object sender, EventArgs e)
        {

            //coletando nome do documento digitado no textbox
            string id_pdf = TB_id_pdf.Text;

            //caminho padrão para procurar o pdf
            string caminho_pdf = @"C:\caminho\";

            //concat caminho padrão + nome do arquivo
            string pdf = caminho_pdf+id_pdf;


            //code abrir pdf com visualizador padrão do pc
                //System.Diagnostics.Process.Start(pdf);


            //visualizar pdf dentro winform

                //intanciando form 2 passando caminho do documento a ser aberto como parametro
                Form2 formfilho = new Form2(pdf);

                formfilho.Show();


            
        }
    }
}
