using Library.Business.Abstract;
using Library.Business.Concreate;
using Library.DataAccess.Concreate.EntityFramework;
using Library.Entities.Concreate;
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
            _authorService = new AuthorManager(new EfAuthorDal());
            _publisherService = new PublisherManager(new EfPublisherDal());
        }
        private IBookService _bookService;
        private ICategoryService _categoryService;
        private IAuthorService _authorService;
        private IPublisherService _publisherService;
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBook();
            LoadCategories();
            LoadAuthor();
            LoadPublisher();
        }
        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "Id";

            cbmCategory.DataSource = _categoryService.GetAll();
            cbmCategory.DisplayMember = "CategoryName";
            cbmCategory.ValueMember = "Id";

            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "Id";
        }
        private void LoadAuthor()
        {
            cbxAuthor.DataSource = _authorService.GetAll();
            cbxAuthor.DisplayMember = "AuthorName";
            cbxAuthor.ValueMember = "Id";

            cbxAuthorUpdate.DataSource = _authorService.GetAll();
            cbxAuthorUpdate.DisplayMember = "AuthorName";
            cbxAuthorUpdate.ValueMember = "Id";
        }
        private void LoadPublisher()
        {
            cbxPublisher.DataSource = _publisherService.GetAll();
            cbxPublisher.DisplayMember = "PublisherName";
            cbxPublisher.ValueMember = "Id";

            cbxPublisherUpdate.DataSource = _publisherService.GetAll();
            cbxPublisherUpdate.DisplayMember = "PublisherName";
            cbxPublisherUpdate.ValueMember = "Id";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _bookService.Add(new Book
            {
                CategoryId = Convert.ToInt32(cbmCategory.SelectedValue),
                Name = tbxBookName2.Text,
                Language = tbxLanguage.Text,
                NumberOfPages = Convert.ToInt32(tbxNumberOfPages.Text),
                NumberOfPrints = Convert.ToInt32(tbxNumberOfPrints.Text),
                ReleaseDate = Convert.ToDateTime(dtpRealeseDate.Text),
                AuthorId = Convert.ToInt32(cbxAuthor.SelectedValue),
                PublisherId = Convert.ToInt32(cbxPublisher.SelectedValue)

            }) ;
            MessageBox.Show("Kitap eklendi");
            LoadBook();
             
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _bookService.Update(new Book
            {
                Id = Convert.ToInt32(dgwbook.CurrentRow.Cells[0].Value),
                Name = txtBookNameUpdate.Text,
                CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                Language = tbxLangugeUpdate.Text,
                NumberOfPages = Convert.ToInt32(tbxPageNumberUpdate.Text),
                NumberOfPrints = Convert.ToInt32(tbxPrintNumberUpdate.Text),
                ReleaseDate = Convert.ToDateTime(dtpRealeseDateUpdate.Text),
                AuthorId = Convert.ToInt32(cbxAuthorUpdate.SelectedValue),
                PublisherId = Convert.ToInt32(cbxPublisherUpdate.SelectedValue)
            });
            MessageBox.Show("Kitap güncellendi");
            LoadBook();
        }

        private void dgwbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookNameUpdate.Text = dgwbook.CurrentRow.Cells[1].Value.ToString();
            cbxCategoryUpdate.SelectedValue = dgwbook.CurrentRow.Cells[6].Value;
            tbxLangugeUpdate.Text = dgwbook.CurrentRow.Cells[3].Value.ToString();
            tbxPageNumberUpdate.Text = dgwbook.CurrentRow.Cells[4].Value.ToString();
            tbxPrintNumberUpdate.Text = dgwbook.CurrentRow.Cells[5].Value.ToString();
            dtpRealeseDateUpdate.Value = Convert.ToDateTime(dgwbook.CurrentRow.Cells[2].Value.ToString());
            cbxAuthorUpdate.SelectedValue = dgwbook.CurrentRow.Cells[7].Value;
            cbxPublisherUpdate.SelectedValue= dgwbook.CurrentRow.Cells[8].Value;
        }
    }
}
