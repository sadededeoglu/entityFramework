namespace entityFramework
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.stockAmount = new System.Windows.Forms.Label();
            this.lblunitPrice = new System.Windows.Forms.Label();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbupdate = new System.Windows.Forms.GroupBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxStockAupdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.lblStockAupdate = new System.Windows.Forms.Label();
            this.lblUnitpUpdate = new System.Windows.Forms.Label();
            this.tbxunitpupdate = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbxsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbupdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gb.Controls.Add(this.btnAdd);
            this.gb.Controls.Add(this.tbxName);
            this.gb.Controls.Add(this.tbxStockAmount);
            this.gb.Controls.Add(this.lblName);
            this.gb.Controls.Add(this.stockAmount);
            this.gb.Controls.Add(this.lblunitPrice);
            this.gb.Controls.Add(this.tbxUnitPrice);
            this.gb.Location = new System.Drawing.Point(12, 199);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(303, 116);
            this.gb.TabIndex = 9;
            this.gb.TabStop = false;
            this.gb.Text = "addAproduct";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Fuchsia;
            this.btnAdd.Location = new System.Drawing.Point(228, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(91, 19);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(127, 20);
            this.tbxName.TabIndex = 2;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(91, 71);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(127, 20);
            this.tbxStockAmount.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // stockAmount
            // 
            this.stockAmount.AutoSize = true;
            this.stockAmount.Location = new System.Drawing.Point(16, 74);
            this.stockAmount.Name = "stockAmount";
            this.stockAmount.Size = new System.Drawing.Size(69, 13);
            this.stockAmount.TabIndex = 5;
            this.stockAmount.Text = "stockAmount";
            // 
            // lblunitPrice
            // 
            this.lblunitPrice.AutoSize = true;
            this.lblunitPrice.Location = new System.Drawing.Point(16, 48);
            this.lblunitPrice.Name = "lblunitPrice";
            this.lblunitPrice.Size = new System.Drawing.Size(48, 13);
            this.lblunitPrice.TabIndex = 3;
            this.lblunitPrice.Text = "unitPrice";
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(91, 45);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(127, 20);
            this.tbxUnitPrice.TabIndex = 4;
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 28);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(608, 165);
            this.dgwProducts.TabIndex = 8;
            // 
            // gbupdate
            // 
            this.gbupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbupdate.Controls.Add(this.btnupdate);
            this.gbupdate.Controls.Add(this.tbxNameUpdate);
            this.gbupdate.Controls.Add(this.tbxStockAupdate);
            this.gbupdate.Controls.Add(this.lblNameUpdate);
            this.gbupdate.Controls.Add(this.lblStockAupdate);
            this.gbupdate.Controls.Add(this.lblUnitpUpdate);
            this.gbupdate.Controls.Add(this.tbxunitpupdate);
            this.gbupdate.Location = new System.Drawing.Point(312, 199);
            this.gbupdate.Name = "gbupdate";
            this.gbupdate.Size = new System.Drawing.Size(308, 116);
            this.gbupdate.TabIndex = 10;
            this.gbupdate.TabStop = false;
            this.gbupdate.Text = "updateAproduct";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Aqua;
            this.btnupdate.Location = new System.Drawing.Point(233, 93);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(101, 19);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(127, 20);
            this.tbxNameUpdate.TabIndex = 2;
            // 
            // tbxStockAupdate
            // 
            this.tbxStockAupdate.Location = new System.Drawing.Point(101, 71);
            this.tbxStockAupdate.Name = "tbxStockAupdate";
            this.tbxStockAupdate.Size = new System.Drawing.Size(127, 20);
            this.tbxStockAupdate.TabIndex = 6;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(26, 22);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name";
            // 
            // lblStockAupdate
            // 
            this.lblStockAupdate.AutoSize = true;
            this.lblStockAupdate.Location = new System.Drawing.Point(26, 74);
            this.lblStockAupdate.Name = "lblStockAupdate";
            this.lblStockAupdate.Size = new System.Drawing.Size(74, 13);
            this.lblStockAupdate.TabIndex = 5;
            this.lblStockAupdate.Text = "Stock Amount";
            // 
            // lblUnitpUpdate
            // 
            this.lblUnitpUpdate.AutoSize = true;
            this.lblUnitpUpdate.Location = new System.Drawing.Point(26, 48);
            this.lblUnitpUpdate.Name = "lblUnitpUpdate";
            this.lblUnitpUpdate.Size = new System.Drawing.Size(48, 13);
            this.lblUnitpUpdate.TabIndex = 3;
            this.lblUnitpUpdate.Text = "unitPrice";
            // 
            // tbxunitpupdate
            // 
            this.tbxunitpupdate.Location = new System.Drawing.Point(101, 45);
            this.tbxunitpupdate.Name = "tbxunitpupdate";
            this.tbxunitpupdate.Size = new System.Drawing.Size(127, 20);
            this.tbxunitpupdate.TabIndex = 4;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRemove.Location = new System.Drawing.Point(545, 321);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbxsearch
            // 
            this.tbxsearch.Location = new System.Drawing.Point(66, 2);
            this.tbxsearch.Name = "tbxsearch";
            this.tbxsearch.Size = new System.Drawing.Size(100, 20);
            this.tbxsearch.TabIndex = 12;
            this.tbxsearch.TextChanged += new System.EventHandler(this.tbxsearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(14, 5);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(41, 13);
            this.lblsearch.TabIndex = 13;
            this.lblsearch.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(629, 346);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.tbxsearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbupdate);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbupdate.ResumeLayout(false);
            this.gbupdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label stockAmount;
        private System.Windows.Forms.Label lblunitPrice;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox gbupdate;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.TextBox tbxStockAupdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Label lblStockAupdate;
        private System.Windows.Forms.Label lblUnitpUpdate;
        private System.Windows.Forms.TextBox tbxunitpupdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbxsearch;
        private System.Windows.Forms.Label lblsearch;
    }
}

