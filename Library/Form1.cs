using Library.Business.Abstract;
using Library.Business.Concrete;
using Library.DataAccess.Concrete.EntityFramework;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _bookService = new BookManager(new EfBookDal());
            _userService = new UserManager(new EfUserDal());
        }

        private IBookService _bookService;
        private IUserService _userService;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBook();
            LoadUser();
        }

        private void LoadUser()
        {
            dgwUser.DataSource = _userService.GetAll();
        }

        private void LoadBook()
        {
            dgwBook.DataSource = _bookService.GetAll();
            cbxSelectTheBook.DataSource = _bookService.GetAll();
            cbxSelectTheBook.DisplayMember = "BookName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _userService.Add(new User
            {
                UserName = tbxUserName.Text,
                UserSurname = tbxUserSurname.Text,
                UserNumber= tbxUserNumber.Text,
                BorrowedBook= cbxSelectTheBook.Text
            });
            MessageBox.Show("Eklendi");
            LoadUser();
        }
    }
}
