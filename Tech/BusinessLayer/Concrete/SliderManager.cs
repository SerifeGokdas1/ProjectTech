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
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }
        public List<Slider> GetListAll()
        {
            return _sliderDal.GetListAll();
        }

        public Slider GetTById(int id)
        {
            return _sliderDal.GetById(id);
        }

        public void TAdd(Slider t)
        {
            _sliderDal.Insert(t);
        }

        public void TDelete(Slider t)
        {
            _sliderDal.Delete(t);
        }

        public void TUpdate(Slider t)
        {
            _sliderDal.Update(t);
        }
    }
}
