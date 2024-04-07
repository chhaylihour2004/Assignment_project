using MyProject.Models.Data;
using MyProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.Froms
{
    public partial class ProductListFrm : Form
    {
        private readonly MyDatabaseContext _context;
        public static string eventType = "";
        public static string productId = "";
        public ProductListFrm(MyDatabaseContext context)
        {
            InitializeComponent();
            _context = context;
        }
        protected void GetProductList()
        {
            string[,] par =
            {
                {"product_id","" }

            };

            grd_product.DataSource = CRUDService.ExecCRUD(_context, "product_list", par);
        }

        private void ProductListFrm_Load(object sender, EventArgs e)
        {
            GetProductList();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ProductFrm(_context);
            eventType = "View";
            frm.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frm = new ProductFrm(_context);
            eventType = "Save";
            frm.ShowDialog();
        }
    }
}
