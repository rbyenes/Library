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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }
    }
}
