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
        }
        private IBookService _bookService;

        private void Form1_Load(object sender, EventArgs e)
        {
            dgwbook.DataSource = _bookService.GetAll();
        }
    }
}
