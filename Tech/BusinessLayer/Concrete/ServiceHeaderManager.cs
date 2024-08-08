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
    public class ServiceHeaderManager : IServiceHeaderService
    {
        IServiceHeaderDal _serviceHeaderDal;

        public ServiceHeaderManager(IServiceHeaderDal serviceHeaderDal)
        {
            _serviceHeaderDal = serviceHeaderDal;
        }
        public List<ServiceHeader> GetListAll()
        {
            return _serviceHeaderDal.GetListAll();
        }

        public ServiceHeader GetTById(int id)
        {
            return _serviceHeaderDal.GetById(id);
        }

        public void TAdd(ServiceHeader t)
        {
            _serviceHeaderDal.Insert(t);
        }

        public void TDelete(ServiceHeader t)
        {
            _serviceHeaderDal.Delete(t);
        }

        public void TUpdate(ServiceHeader t)
        {
            _serviceHeaderDal.Update(t);
        }
    }
}
