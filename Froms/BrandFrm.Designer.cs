namespace MyProject.Froms
{
    partial class BrandFrm
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
            grd_brand = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            txtBrandId = new TextBox();
            label3 = new Label();
            txtBrandName = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)grd_brand).BeginInit();
            SuspendLayout();
            // 
            // grd_brand
            // 
            grd_brand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_brand.Location = new Point(62, 332);
            grd_brand.Name = "grd_brand";
            grd_brand.RowHeadersWidth = 62;
            grd_brand.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd_brand.Size = new Size(877, 191);
            grd_brand.TabIndex = 0;
            grd_brand.CellDoubleClick += grd_brand_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(374, 34);
            label1.Name = "label1";
            label1.Size = new Size(244, 26);
            label1.TabIndex = 1;
            label1.Text = "Brand Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 190);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 1;
            label2.Text = "Brand Id";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(566, 229);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtBrandId
            // 
            txtBrandId.Enabled = false;
            txtBrandId.Location = new Point(220, 183);
            txtBrandId.Name = "txtBrandId";
            txtBrandId.Size = new Size(281, 29);
            txtBrandId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 239);
            label3.Name = "label3";
            label3.Size = new Size(122, 22);
            label3.TabIndex = 1;
            label3.Text = "Brand Name";
            // 
            // txtBrandName
            // 
            txtBrandName.Location = new Point(220, 232);
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(281, 29);
            txtBrandName.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(697, 229);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(827, 229);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // BrandFrm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 556);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtBrandName);
            Controls.Add(txtBrandId);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grd_brand);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "BrandFrm";
            Text = "BrandFrm";
            Load += BrandFrm_Load;
            ((System.ComponentModel.ISupportInitialize)grd_brand).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grd_brand;
        private Label label1;
        private Label label2;
        private Button btnSave;
        private TextBox txtBrandId;
        private Label label3;
        private TextBox txtBrandName;
        private Button btnUpdate;
        private Button btnDelete;
    }
}