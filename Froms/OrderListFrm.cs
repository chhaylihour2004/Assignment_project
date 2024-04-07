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
    public partial class OrderListFrm : Form
    {
        private readonly MyDatabaseContext _context;
        public OrderListFrm(MyDatabaseContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void OrderListFrm_Load(object sender, EventArgs e)
        {

            GetOrderList();

        }

        protected void GetOrderList()
        {

            string[,] par =
            {
                {"fDate",dtpFDate.Text },
                {"tDate",dtpTDate.Text }
            };

            grd_orderList.DataSource = CRUDService.ExecCRUD(_context, "order_list", par);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetOrderList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frm = new OrderFrm(_context);
            frm.ShowDialog();
        }
    }
}
