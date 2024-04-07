using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyProject.Models.Data;
using MyProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.Froms
{
    public partial class BrandFrm : Form
    {
        private readonly MyDatabaseContext _context;
        public BrandFrm(MyDatabaseContext context)
        {
            _context = context;
            InitializeComponent();
        }
        string status, message;

        protected void GetBrand()
        {
            string[,] sp_par =
            {
                {"brand_id","" }

            };

            grd_brand.DataSource = CRUDService.ExecCRUD(_context, "production.sp_brand_list", sp_par);
        }
        protected void CUDBrand(string cud)
        {

            string[,] sp_par =
            {
                {"brand_id", txtBrandId.Text},
                {"brand_name", txtBrandName.Text},
                {"cud",cud }

            };

            var rv = CRUDService.ExecCRUD(_context, "production.brands_cud", sp_par);
            if (rv != null)
            {
                status = rv.Rows[0]["cud_status"].ToString();
                message = rv.Rows[0]["cud_message"].ToString();

                if (status == "Succeed")
                {
                    GetBrand();
                }
            }
            else
            {
                status = "Error";
                message = "Something went wrong !";
            }
            MessageService.doMessage(status, message);

        }
        private void BrandFrm_Load(object sender, EventArgs e)
        {

            GetBrand();

        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageService.doMessageQuestion("Do you want to save ?") == DialogResult.Yes)
            {
                CUDBrand("C");
            }

        }

        private void grd_brand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBrandId.Text = grd_brand.SelectedRows[0].Cells[0].Value.ToString();
            txtBrandName.Text = grd_brand.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageService.doMessageQuestion("Do you want to update ?") == DialogResult.Yes)
            {
                CUDBrand("U");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageService.doMessageQuestion("Do you want to delete ?") == DialogResult.Yes)
            {
                CUDBrand("D");
            }
        }
    }
}
