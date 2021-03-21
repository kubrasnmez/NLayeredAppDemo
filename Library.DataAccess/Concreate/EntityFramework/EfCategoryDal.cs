using Library.DataAccess.Abstract;
using Library.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concreate.EntityFramework
{
    public class EfCategoryDal: EfEntityRepositoryBase<Category, LibraryDb>,ICategoryDal
    {
    }
}
