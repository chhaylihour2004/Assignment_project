using Microsoft.EntityFrameworkCore;
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
    public partial class ProductFrm : Form
    {
        private readonly MyDatabaseContext _context;
        public ProductFrm(MyDatabaseContext context)
        {
            InitializeComponent();
            _context = context;
        }

        protected void GetBrand()
        {
            string[,] sp_par =
            {
                {"brand_id","" }
            };

            cboBrand.DataSource = CRUDService.ExecCRUD(_context, "production.sp_brand_list", sp_par);
            cboBrand.ValueMember = "brand_id";
            cboBrand.DisplayMember = "brand_name";
        }
        protected void GetCategory()
        {
            string[,] sp_par = { };
            cboCategory.DataSource = CRUDService.ExecCRUD(_context, "categories_list", sp_par);
            cboCategory.ValueMember = "category_id";
            cboCategory.DisplayMember = "category_name";
        }
        private void ProductFrm_Load(object sender, EventArgs e)
        {
            string eventType = ProductListFrm.eventType;
        
            if(eventType == "View")
            {
                btnCUD.Visible = false;
            }
            else
            {
                btnCUD.Visible = true;
            }

            btnCUD.Text = eventType;
            
            GetBrand();
            GetCategory();
            
        }
    }
}
