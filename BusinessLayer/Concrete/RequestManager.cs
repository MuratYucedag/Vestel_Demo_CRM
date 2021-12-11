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
    public class RequestManager : IRequestService
    {
        IRequestDal _requestDal;

        public RequestManager(IRequestDal requestDal)
        {
            _requestDal = requestDal;
        }

        public void TAdd(Request t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Request t)
        {
            throw new NotImplementedException();
        }

        public Request TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Request> TGetList()
        {
            return _requestDal.GetList();
        }

        public void TUpdate(Request t)
        {
            throw new NotImplementedException();
        }
    }
}
