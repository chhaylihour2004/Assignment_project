namespace MyProject.Froms
{
    partial class OrderListFrm
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
            grd_orderList = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dtpFDate = new DateTimePicker();
            btnRefresh = new Button();
            btnAddNew = new Button();
            dtpTDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)grd_orderList).BeginInit();
            SuspendLayout();
            // 
            // grd_orderList
            // 
            grd_orderList.AllowUserToAddRows = false;
            grd_orderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd_orderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_orderList.Location = new Point(12, 171);
            grd_orderList.Name = "grd_orderList";
            grd_orderList.RowHeadersWidth = 62;
            grd_orderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd_orderList.Size = new Size(1209, 374);
            grd_orderList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(136, 26);
            label1.TabIndex = 1;
            label1.Text = "Order List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 111);
            label2.Name = "label2";
            label2.Size = new Size(137, 22);
            label2.TabIndex = 2;
            label2.Text = "Between Date";
            // 
            // dtpFDate
            // 
            dtpFDate.CustomFormat = "yyyy-MM-dd";
            dtpFDate.Format = DateTimePickerFormat.Custom;
            dtpFDate.Location = new Point(252, 106);
            dtpFDate.Name = "dtpFDate";
            dtpFDate.Size = new Size(300, 29);
            dtpFDate.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(977, 111);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(1109, 111);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(112, 34);
            btnAddNew.TabIndex = 4;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // dtpTDate
            // 
            dtpTDate.CustomFormat = "yyyy-MM-dd";
            dtpTDate.Format = DateTimePickerFormat.Custom;
            dtpTDate.Location = new Point(572, 106);
            dtpTDate.Name = "dtpTDate";
            dtpTDate.Size = new Size(300, 29);
            dtpTDate.TabIndex = 3;
            // 
            // OrderListFrm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 557);
            Controls.Add(btnAddNew);
            Controls.Add(btnRefresh);
            Controls.Add(dtpTDate);
            Controls.Add(dtpFDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grd_orderList);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "OrderListFrm";
            Text = "OrderListFrm";
            Load += OrderListFrm_Load;
            ((System.ComponentModel.ISupportInitialize)grd_orderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grd_orderList;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpFDate;
        private Button btnRefresh;
        private Button btnAddNew;
        private DateTimePicker dtpTDate;
    }
}