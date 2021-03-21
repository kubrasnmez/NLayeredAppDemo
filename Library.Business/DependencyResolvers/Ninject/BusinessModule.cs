using Library.Business.Abstract;
using Library.Business.Concreate;
using Library.DataAccess.Abstract;
using Library.DataAccess.Concreate.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            //InSingletonScope : Bir üretildiğinde bir daha üretilmesin, performans arttırıcı
            Bind<IBookService>().To<BookManager>().InSingletonScope();
            Bind<IBookDal>().To<EfBookDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind<IPublisherService>().To<PublisherManager>().InSingletonScope();
            Bind<IPublisherDal>().To<EfPublisherDal>().InSingletonScope();

            Bind<IAuthorService>().To<AuthorManager>().InSingletonScope();
            Bind<IAuthorDal>().To<EfAuthorDal>().InSingletonScope();

        }
    }
}
