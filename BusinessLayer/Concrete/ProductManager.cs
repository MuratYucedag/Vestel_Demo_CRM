using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productdal;

        public ProductManager(IProductDal productdal)
        {
            _productdal = productdal;
        }

        public void TAdd(Product t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Product t)
        {
            throw new NotImplementedException();
        }

        public void Test1()
        {
            throw new NotImplementedException();
        }

        public Product TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> TGetList()
        {
            return _productdal.GetList();
        }

        public List<Product> TGetListWithCategory()
        {
            return _productdal.GetListWithCategory();
        }

        public void TUpdate(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
