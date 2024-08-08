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
    public class TeamMemberManager : ITeamMemberService
    {
        ITeamMemberDal _teamMemberDal;
        public TeamMemberManager(ITeamMemberDal teamMemberDal)
        {
            _teamMemberDal = teamMemberDal;
        }
        public List<TeamMember> GetListAll()
        {
            return _teamMemberDal.GetListAll();
        }

        public TeamMember GetTById(int id)
        {
            return _teamMemberDal.GetById(id);
        }

        public void TAdd(TeamMember t)
        {
            _teamMemberDal.Insert(t);
        }

        public void TDelete(TeamMember t)
        {
            _teamMemberDal.Delete(t);
        }

        public void TUpdate(TeamMember t)
        {
            _teamMemberDal.Update(t);
        }
    }
}
