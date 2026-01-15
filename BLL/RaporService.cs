using miniCRMProje.DAL;
using miniCRMProje.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCRMProje.BLL
{
    public  class RaporService
    {
        private readonly RaporDAL _dal = new RaporDAL();

        public List<TalepRapor> GetRapor(
            DateTime start,
            DateTime end,
            int? hizmetId,
            string durum)
        {
            return _dal.GetRapor(start, end, hizmetId, durum);
        }
    }
}
