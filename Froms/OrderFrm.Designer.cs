namespace MyProject.Froms
{
    partial class OrderFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtOrderId = new TextBox();
            groupBox1 = new GroupBox();
            grd_OrderItem = new DataGridView();
            btnAddItem = new Button();
            txtTotal = new TextBox();
            txtDiscount = new TextBox();
            txtUnitPrice = new TextBox();
            txtQty = new TextBox();
            label13 = new Label();
            cboBrand = new ComboBox();
            label12 = new Label();
            label8 = new Label();
            label11 = new Label();
            cboProduct = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            cboCategory = new ComboBox();
            label7 = new Label();
            label3 = new Label();
            txtGrandTotal = new TextBox();
            cboCustomerId = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cboStoreId = new ComboBox();
            label6 = new Label();
            cboStaffId = new ComboBox();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd_OrderItem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 19);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 73);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 0;
            label2.Text = "Order Id";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(194, 70);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(445, 29);
            txtOrderId.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grd_OrderItem);
            groupBox1.Controls.Add(btnAddItem);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtDiscount);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtQty);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(cboBrand);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cboProduct);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cboCategory);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(33, 254);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1484, 346);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order Item";
            // 
            // grd_OrderItem
            // 
            grd_OrderItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_OrderItem.Location = new Point(23, 129);
            grd_OrderItem.Name = "grd_OrderItem";
            grd_OrderItem.RowHeadersWidth = 62;
            grd_OrderItem.Size = new Size(1445, 211);
            grd_OrderItem.TabIndex = 5;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(1356, 70);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(112, 34);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(1200, 73);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(137, 29);
            txtTotal.TabIndex = 4;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(1057, 73);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(137, 29);
            txtDiscount.TabIndex = 4;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(914, 73);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(137, 29);
            txtUnitPrice.TabIndex = 4;
            txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(771, 73);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(137, 29);
            txtQty.TabIndex = 4;
            txtQty.TextChanged += txtQty_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1200, 48);
            label13.Name = "label13";
            label13.Size = new Size(53, 22);
            label13.TabIndex = 0;
            label13.Text = "Total";
            // 
            // cboBrand
            // 
            cboBrand.FormattingEnabled = true;
            cboBrand.Location = new Point(290, 73);
            cboBrand.Name = "cboBrand";
            cboBrand.Size = new Size(222, 30);
            cboBrand.TabIndex = 3;
            cboBrand.SelectedIndexChanged += cboBrand_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1057, 48);
            label12.Name = "label12";
            label12.Size = new Size(87, 22);
            label12.TabIndex = 0;
            label12.Text = "Discount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(290, 48);
            label8.Name = "label8";
            label8.Size = new Size(63, 22);
            label8.TabIndex = 0;
            label8.Text = "Brand";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(914, 48);
            label11.Name = "label11";
            label11.Size = new Size(96, 22);
            label11.TabIndex = 0;
            label11.Text = "Unit Price";
            // 
            // cboProduct
            // 
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(518, 73);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(248, 30);
            cboProduct.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(771, 48);
            label10.Name = "label10";
            label10.Size = new Size(42, 22);
            label10.TabIndex = 0;
            label10.Text = "Qty";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(518, 48);
            label9.Name = "label9";
            label9.Size = new Size(78, 22);
            label9.TabIndex = 0;
            label9.Text = "Product";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(23, 73);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(260, 30);
            cboCategory.TabIndex = 3;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 48);
            label7.Name = "label7";
            label7.Size = new Size(93, 22);
            label7.TabIndex = 0;
            label7.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(932, 624);
            label3.Name = "label3";
            label3.Size = new Size(114, 22);
            label3.TabIndex = 0;
            label3.Text = "Grand Total";
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Enabled = false;
            txtGrandTotal.Location = new Point(1090, 621);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.Size = new Size(427, 29);
            txtGrandTotal.TabIndex = 1;
            // 
            // cboCustomerId
            // 
            cboCustomerId.FormattingEnabled = true;
            cboCustomerId.Location = new Point(194, 105);
            cboCustomerId.Name = "cboCustomerId";
            cboCustomerId.Size = new Size(445, 30);
            cboCustomerId.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 108);
            label4.Name = "label4";
            label4.Size = new Size(98, 22);
            label4.TabIndex = 0;
            label4.Text = "Customer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 144);
            label5.Name = "label5";
            label5.Size = new Size(59, 22);
            label5.TabIndex = 0;
            label5.Text = "Store";
            // 
            // cboStoreId
            // 
            cboStoreId.FormattingEnabled = true;
            cboStoreId.Location = new Point(194, 141);
            cboStoreId.Name = "cboStoreId";
            cboStoreId.Size = new Size(445, 30);
            cboStoreId.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 180);
            label6.Name = "label6";
            label6.Size = new Size(52, 22);
            label6.TabIndex = 0;
            label6.Text = "Staff";
            // 
            // cboStaffId
            // 
            cboStaffId.FormattingEnabled = true;
            cboStaffId.Location = new Point(194, 177);
            cboStaffId.Name = "cboStaffId";
            cboStaffId.Size = new Size(445, 30);
            cboStaffId.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(687, 177);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // OrderFrm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 674);
            Controls.Add(btnSave);
            Controls.Add(cboStaffId);
            Controls.Add(cboStoreId);
            Controls.Add(cboCustomerId);
            Controls.Add(groupBox1);
            Controls.Add(txtGrandTotal);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(txtOrderId);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "OrderFrm";
            Text = "OrderFrm";
            Load += OrderFrm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd_OrderItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtOrderId;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtGrandTotal;
        private ComboBox cboCustomerId;
        private Label label4;
        private Label label5;
        private ComboBox cboStoreId;
        private Label label6;
        private ComboBox cboStaffId;
        private ComboBox cboBrand;
        private Label label8;
        private ComboBox cboCategory;
        private Label label7;
        private TextBox txtDiscount;
        private TextBox txtUnitPrice;
        private TextBox txtQty;
        private Label label12;
        private Label label11;
        private ComboBox cboProduct;
        private Label label10;
        private Label label9;
        private Button btnAddItem;
        private TextBox txtTotal;
        private Label label13;
        private Button btnSave;
        private DataGridView grd_OrderItem;
    }
}