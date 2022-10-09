using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//instanciando biblioteca nuget
using PdfiumViewer;

namespace Exibir_pdf_em_winform
{
    public partial class Form2 : Form
    {


        //instanciando o pacote nuget
        PdfiumViewer.PdfViewer pdf;


        public Form2(string end_pdf)
        {

            InitializeComponent();

            //criando objeto do pacote
            pdf = new PdfViewer();

            //estilização do pdf
            pdf.Width = this.Width - 20;
            pdf.Height = this.Height - 40;


            //adcionando objeto pdf no forms
            this.Controls.Add(pdf);


            byte[] bytes = System.IO.File.ReadAllBytes(end_pdf);
            var stream = new System.IO.MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;

        }


        //estilização do pdf ao maximizar o winform
        private void Form2_Resize(object sender, EventArgs e)
        {

            pdf.Width = this.Width - 20;
            pdf.Height = this.Height - 40;

        }
    }
}
