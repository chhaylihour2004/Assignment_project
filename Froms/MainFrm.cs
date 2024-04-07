using MyProject.Models.Data;
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
    public partial class MainFrm : Form
    {
        private readonly MyDatabaseContext _context;
        public MainFrm(MyDatabaseContext context)
        {
            _context = context;
            InitializeComponent();
        }
        private void showForm(Form frm)
        {
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new BrandFrm(_context);
            showForm(frm);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ProductListFrm(_context);
            showForm(frm);
        }

        private void orderItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new OrderListFrm(_context);
            showForm(frm);
        }
    }
}
