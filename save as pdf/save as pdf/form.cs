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
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.A4.Rotate());
            PdfWriter.GetInstance(doc, new FileStream("FaturaNo.pdf", FileMode.Create));


            //                                      columns
            var headerTable = new PdfPTable(new[] { .1f, .02f,.5f })
            {
                HorizontalAlignment = Left,

                WidthPercentage = 50,

                DefaultCell = { MinimumHeight = 22f }

            };
            var cell = new PdfPCell(new Phrase("Fatura No"));
            cell.Border = 0;
            headerTable.AddCell(cell);

            cell = new PdfPCell(new Phrase(":"));
            cell.Border = 0;
            headerTable.AddCell(cell);



            cell = new PdfPCell(new Phrase("22"));
            cell.Border = 0;
            headerTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Date"));
            cell.Border = 0;
            headerTable.AddCell(cell);

            cell = new PdfPCell(new Phrase(":"));
            cell.Border = 0;
            headerTable.AddCell(cell);

            cell = new PdfPCell(new Phrase(DateTime.Now.ToString()));
            cell.Border = 0;
            headerTable.AddCell(cell);



            doc.Open();
            doc.Add(headerTable);
            doc.Close();
        }
    }
}
