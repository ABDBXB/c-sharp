using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace save_as_pdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tab = "              ";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("yemek adı"+tab);
            stringBuilder.Append("Fiyat \n");
            stringBuilder.Append("----------------\n");
            stringBuilder.Append("Garsonadı"+tab);
            stringBuilder.Append("Adet \n");
            stringBuilder.Append("====================\n");

            Document doc = new Document(PageSize.A4.Rotate());
            PdfWriter.GetInstance(doc, new FileStream("C:/Users/abdal/Desktop/FaturaNo.pdf", FileMode.Create));
            doc.Open();
            doc.Add(new Paragraph(stringBuilder.ToString()));
            doc.Close();
            MessageBox.Show("Fatura Basıldı");



        }
    }
}
