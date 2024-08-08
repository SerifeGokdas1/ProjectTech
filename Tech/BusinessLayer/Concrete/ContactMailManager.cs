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
    public class ContactMailManager : IContactMailService
    {
        IContactMailDal _contactMailDal;

        public ContactMailManager(IContactMailDal contactMailDal)
        {
            _contactMailDal = contactMailDal;
        }

        public List<ContactMail> GetListAll()
        {
            throw new NotImplementedException();
        }

        public ContactMail GetTById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(ContactMail t)
        {
            try
            {
                _contactMailDal.Insert(t);
            }
            catch(Exception ex)
            {
                var message = ex;
            }
            
        }

        public void TDelete(ContactMail t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ContactMail t)
        {
            throw new NotImplementedException();
        }

        //public void ContactMailAdd(ContactMail contactMail)
        //{
        //    _contactMailDal.Insert(contactMail);
        //}
    }
}
