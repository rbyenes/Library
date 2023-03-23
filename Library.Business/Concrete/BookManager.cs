using Library.Business.Abstract;
using Library.DataAccess.Abstract;
using Library.DataAccess.Concrete.EntityFramework;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }
    }
}
