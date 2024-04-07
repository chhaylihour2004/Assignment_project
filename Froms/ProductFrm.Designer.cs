namespace MyProject.Froms
{
    partial class ProductFrm
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
            cboBrand = new ComboBox();
            label2 = new Label();
            cboCategory = new ComboBox();
            txtProductName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtProductId = new TextBox();
            label5 = new Label();
            txtModelYear = new TextBox();
            label6 = new Label();
            txtListPrice = new TextBox();
            btnCUD = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 221);
            label1.Name = "label1";
            label1.Size = new Size(63, 22);
            label1.TabIndex = 2;
            label1.Text = "Brand";
            // 
            // cboBrand
            // 
            cboBrand.FormattingEnabled = true;
            cboBrand.Location = new Point(283, 218);
            cboBrand.Name = "cboBrand";
            cboBrand.Size = new Size(440, 30);
            cboBrand.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 257);
            label2.Name = "label2";
            label2.Size = new Size(93, 22);
            label2.TabIndex = 2;
            label2.Text = "Category";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(283, 254);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(440, 30);
            cboCategory.TabIndex = 3;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(283, 183);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(440, 29);
            txtProductName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 186);
            label3.Name = "label3";
            label3.Size = new Size(137, 22);
            label3.TabIndex = 2;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 151);
            label4.Name = "label4";
            label4.Size = new Size(103, 22);
            label4.TabIndex = 2;
            label4.Text = "Product Id";
            // 
            // txtProductId
            // 
            txtProductId.Enabled = false;
            txtProductId.Location = new Point(283, 148);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(440, 29);
            txtProductId.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 293);
            label5.Name = "label5";
            label5.Size = new Size(109, 22);
            label5.TabIndex = 2;
            label5.Text = "Model Year";
            // 
            // txtModelYear
            // 
            txtModelYear.Location = new Point(283, 290);
            txtModelYear.Name = "txtModelYear";
            txtModelYear.Size = new Size(440, 29);
            txtModelYear.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(113, 328);
            label6.Name = "label6";
            label6.Size = new Size(91, 22);
            label6.TabIndex = 2;
            label6.Text = "List Price";
            // 
            // txtListPrice
            // 
            txtListPrice.Location = new Point(283, 325);
            txtListPrice.Name = "txtListPrice";
            txtListPrice.Size = new Size(440, 29);
            txtListPrice.TabIndex = 4;
            // 
            // btnCUD
            // 
            btnCUD.Location = new Point(611, 391);
            btnCUD.Name = "btnCUD";
            btnCUD.Size = new Size(112, 34);
            btnCUD.TabIndex = 5;
            btnCUD.Text = "CUD";
            btnCUD.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(113, 56);
            label7.Name = "label7";
            label7.Size = new Size(168, 26);
            label7.TabIndex = 2;
            label7.Text = "Product CUD";
            // 
            // ProductFrm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 509);
            Controls.Add(btnCUD);
            Controls.Add(txtProductId);
            Controls.Add(txtListPrice);
            Controls.Add(txtModelYear);
            Controls.Add(txtProductName);
            Controls.Add(cboCategory);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(cboBrand);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ProductFrm";
            Text = "ProductFrm";
            Load += ProductFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboBrand;
        private Label label2;
        private ComboBox cboCategory;
        private TextBox txtProductName;
        private Label label3;
        private Label label4;
        private TextBox txtProductId;
        private Label label5;
        private TextBox txtModelYear;
        private Label label6;
        private TextBox txtListPrice;
        private Button btnCUD;
        private Label label7;
    }
}