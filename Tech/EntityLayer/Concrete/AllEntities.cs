using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AllEntities
    {
        public List<About> Abouts { get; set; }
        public List<Admin> Admins { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Service> Services { get; set; }
        public List<ServiceHeader> ServiceHeaders { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<TeamMember> TeamMembers { get; set; }
        public Service Service { get; set; }
    }
}
