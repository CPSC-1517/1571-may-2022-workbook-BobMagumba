using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using WestWindSystem.DAL;
using WestWindSystem.Entities;
#endregion


namespace WestWindSystem.BLL
{
    public class RegionServices
    {
        private readonly WestWindContext _context;

        internal RegionServices(WestWindContext regcontext)
        {
            _context = regcontext;
        }

        public List<Region> Region_List()
        {
            return _context.Regions.ToList();
        }

        public Region Region_GetByID(int id)
        {
            
            //return _context.Regions.Find(id);
            return _context.Regions.Where(x => x.RegionID == id).FirstOrDefault();
        }
    }
}
