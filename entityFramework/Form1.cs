using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal=new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            /* using(ETradeContext context=new ETradeContext())
             {
                 //using kullanmadan yazdıgında bellek temizliği 
                 dgwProducts.DataSource = _productDal.GetAll();
             }*/

            /*yukardakini kullanmak için onu methot yaptım ve onu 
             buraya cektim*/

            LoadProducts();/*ürünleri ekleyen yer burası*/
        }
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product/*burda olusturup gönderiyorum*/
            {
                Name=tbxName.Text,
                UnitPrice=Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount=Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("added");
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product { 
            Id=Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
            Name=tbxNameUpdate.Text,
            UnitPrice=Convert.ToDecimal(tbxunitpupdate.Text),
            StockAmount=Convert.ToInt32(tbxStockAupdate.Text)
            });
            LoadProducts();
            MessageBox.Show("updated");
        }
        private void dgwProducts_CellClick(object sender,DataGridViewCellCancelEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxunitpupdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAupdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product{ 
            Id=Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
            });
            LoadProducts();
            MessageBox.Show("deleted");
        }
        private void SearchProducts(string key)
        {
            //var result = _productDal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList();
            /*gelen liste üstünde filtreleme*/
            var result = _productDal.GetByName(key);
            dgwProducts.DataSource = result;
        }
        private void tbxsearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxsearch.Text);
        }
    }
}
