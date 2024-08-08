using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //Bu Interfacede tablomuzla ilişkili olan tablodan veri çekmek için metod imzaları oluştururuz.
    //EntityFramework klasörü içindeki ilgili repositori içerisine de bu metodlar doldurulur.(25.)
    //Bu proje içerisinde ilişkili tablo olmadığı için şimdilik boş bıraktım. 
    public interface IAboutDal : IGenericDal<About>
    {
    }
}
