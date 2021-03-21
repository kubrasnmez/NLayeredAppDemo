using Library.Business.Abstract;
using Library.Business.Concreate;
using Library.DataAccess.Concreate.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _bookService = new BookManager(new EfBookDal());
           _categoryService = new CategoryManager(new EfCategoryDal());
        }
        private IBookService _bookService;
        private ICategoryService _categoryService;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBook();
            LoadCategories();
        }
        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "Id";
        }

        private void LoadBook()
        {
            dgwbook.DataSource = _bookService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwbook.DataSource = _bookService.GetBookByCategory(Convert.ToInt32(cbxCategory.SelectedValue));

            }
            catch
            {

            }
        }

        private void tbxBookName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxBookName.Text))
            {
                dgwbook.DataSource = _bookService.GetBooksByBookName(tbxBookName.Text);
            }
            else
            {
                LoadBook();
            }
            
        }
    }
}
