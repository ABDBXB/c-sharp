using deneme_design.Context;
using deneme_design.Forms.AdminForms.UserControls;
using deneme_design.Model;
using deneme_design.RestClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_design.Forms.AdminForms
{
    public partial class AdminTables : Form
    {
        public AdminForm adminForm;
        JsonService jsonService;
        public AdminTables()
        {
            InitializeComponent();
        }
        public AdminTables(AdminForm admin)
        {
            InitializeComponent();
            this.adminForm = admin;
            jsonService = new JsonService();
        }
        public  void AdminTables_Load(object sender, EventArgs e)
        {
            ListAllTables();    
        }

        public void ListAllTables()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Table> tableList = jsonService.getTableList();
            tableList.ForEach(table =>
            {
                TablesControl tablesControl = new TablesControl(table, this);
                flowLayoutPanel1.Controls.Add(tablesControl);
            });
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                long tableId = long.Parse(txtTableNo.Text);
                int seatCount = int.Parse(txtSeatCount.Text);

                TableContext tableContext = new TableContext(tableId, seatCount);
                long id = jsonService.AddTable(tableContext);
                if (id == tableId)
                {
                    MessageBox.Show(id + ". Masa bşarıyla kayidedildi", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListAllTables();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata olustu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
