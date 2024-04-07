using MyProject.Models.Data;
using MyProject.Models.Response;
using MyProject.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.Froms
{
    public partial class OrderFrm : Form
    {
        private readonly MyDatabaseContext _context;
        private int isLoad = 0;
        List<OrderItemResponse> orderItemList = new List<OrderItemResponse>();
        public OrderFrm(MyDatabaseContext context)
        {
            InitializeComponent();
            _context = context;
        }
        protected void GetCustomer()
        {
            string[,] sp_par = { };
            cboCustomerId.DataSource = CRUDService.ExecCRUD(_context, "customer_list", sp_par);
            cboCustomerId.ValueMember = "customer_id";
            cboCustomerId.DisplayMember = "customer_name";
        }
        protected void GetStore()
        {
            string[,] sp_par = { };
            cboStoreId.DataSource = CRUDService.ExecCRUD(_context, "store_list", sp_par);
            cboStoreId.ValueMember = "store_id";
            cboStoreId.DisplayMember = "store_name";
        }
        protected void GetStaff()
        {
            string[,] sp_par = { };
            cboStaffId.DataSource = CRUDService.ExecCRUD(_context, "staff_list", sp_par);
            cboStaffId.ValueMember = "staff_id";
            cboStaffId.DisplayMember = "staff_name";
        }
        protected void GetCategory()
        {
            string[,] sp_par = { };
            cboCategory.DataSource = CRUDService.ExecCRUD(_context, "categories_list", sp_par);
            cboCategory.ValueMember = "category_id";
            cboCategory.DisplayMember = "category_name";
        }
        protected void GetBrand()
        {
            string[,] sp_par = { };
            cboBrand.DataSource = CRUDService.ExecCRUD(_context, "brand_list", sp_par);
            cboBrand.ValueMember = "brand_id";
            cboBrand.DisplayMember = "brand_name";
        }
        protected void GetProduct()
        {
            //string categoryValue = cboCategory.SelectedValue?.ToString() ?? string.Empty;
            //string brandValue = cboBrand.SelectedValue?.ToString() ?? string.Empty;
            //string[,] sp_par =
            //{
            //    {"category_id", categoryValue},
            //    {"brand_id", brandValue}
            //};
            string[,] sp_par =
            {
                {"category_id",cboCategory.SelectedValue.ToString()},
                {"brand_id",cboBrand.SelectedValue.ToString()}
            };
            cboProduct.DataSource = CRUDService.ExecCRUD(_context, "product_list_v2", sp_par);
            cboProduct.ValueMember = "product_id";
            cboProduct.DisplayMember = "product_name";
        }
        private void OrderFrm_Load(object sender, EventArgs e)
        {
            GetCustomer();
            GetStore();
            GetStaff();
            GetCategory();
            GetBrand();
            GetProduct();

            isLoad = 1;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoad == 1)
            {
                GetProduct();
            }
        }

        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoad == 1)
            {
                GetProduct();
            }
        }

        protected void TotalCal()
        {

            double Qty = 0, UnitPrice = 0, Discount = 0, Total = 0;

            try { Qty = Convert.ToDouble(txtQty.Text); }
            catch { }

            try { UnitPrice = Convert.ToDouble(txtUnitPrice.Text); }
            catch { }

            try { Discount = Convert.ToDouble(txtDiscount.Text); }
            catch { }

            try { Total = Convert.ToDouble(txtTotal.Text); }
            catch { }

            Total = Qty * UnitPrice * (1 - Discount);
            txtTotal.Text = Total.ToString("###,##0.00");

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            TotalCal();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            TotalCal();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            TotalCal();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            var item = new OrderItemResponse()
            {

                CategoryId = cboCategory.SelectedValue.ToString(),
                CategoryName = cboCategory.Text,
                BrandId = cboBrand.SelectedValue.ToString(),
                BrandName = cboBrand.Text,
                ProductId = cboProduct.SelectedValue.ToString(),
                ProductName = cboProduct.Text,
                Quantity = txtQty.Text,
                UnitPrice = txtUnitPrice.Text,
                Discount = txtDiscount.Text,
                Total = txtTotal.Text,

            };

            orderItemList.Add(item);
            var orderObj = (from i in orderItemList
                            select new
                            {

                                CategoryName = i.CategoryName,
                                BrandName = i.BrandName,
                                ProductName = i.ProductName,
                                Quantity = i.Quantity,
                                UnitPrice = i.UnitPrice,
                                Discount = i.Discount,
                                Total = i.Total

                            }).ToList();

            grd_OrderItem.DataSource = orderObj.ToList();

            //double grandTotal = 0.0;

            //for (int i = 0; i < grd_OrderItem.Rows.Count; i++)
            //{
            //    grandTotal += double.Parse(grd_OrderItem.Rows[i].Cells[6].Value.ToString());
            //}
            var grandTotal = orderObj.Sum(i => Convert.ToDouble(i.Total));
            txtGrandTotal.Text = grandTotal.ToString("###,##0.00");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var orderObj = (from i in orderItemList
                            select new
                            {

                                item_id = i.ProductId,
                                ProductId = i.ProductId,
                                Quantity = i.Quantity,
                                UnitPrice = i.UnitPrice,
                                Discount = i.Discount

                            }).ToList();
            
            var orderItemJson = JsonConvert.SerializeObject(orderObj);

            string[,] par =
            {

                { "OrderId", "0" },
                { "CustomerId", cboCustomerId.SelectedValue.ToString() },
                { "StoreId", cboStoreId.SelectedValue.ToString() },
                { "StaffId",cboStaffId.SelectedValue.ToString() },
                { "OrderItemsJson", orderItemJson }

            };

            var rv = CRUDService.ExecCRUD(_context, "order_ins", par);

            string status = "Error", message = "Something went wrong !";

            if (rv != null)
            {
                status = rv.Rows[0][0].ToString();
                message = rv.Rows[0][1].ToString();
            }

            MessageService.doMessage(status, message);

        }
    }
}
