using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using deneme_design.Model;
using Guna.UI2.WinForms;
using deneme_design.RestClient;

namespace deneme_design.Forms.AdminForms.UserControls
{
    public partial class TablesControl : UserControl
    {
        Table table;
        JsonService jsonService;
        AdminTables adminTables;
        public TablesControl()
        {
            InitializeComponent();  
        }
        public TablesControl(Table table, AdminTables adminTables)
        {
            InitializeComponent();
            this.table = table;
            lblNo.Text = table.id.ToString();
            jsonService = new JsonService();
            this.adminTables = adminTables;
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {

            if (this.table._status)
            {
                MessageBox.Show("Masa durumu açık şu an silme işlemi yapamazsınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = 
                MessageBox.Show(table.id + ". Masa bilgileri tamamen silenecek\nDevam etmek istioyrmusunuz?",
                                    "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes.Equals(result))
            {
                long id = jsonService.deleteTableById(this.table.id);
                if (table.id == id)
                {
                    MessageBox.Show(id + ". Masa bşarıyla silindi","İşlem Tamamlandı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    adminTables.ListAllTables();
                }
                else
                    MessageBox.Show("Hata Oluştu");
            }
        }
    }
}
