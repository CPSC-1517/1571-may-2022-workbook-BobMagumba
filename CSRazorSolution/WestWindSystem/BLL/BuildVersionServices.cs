using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindSystem.DAL;
using WestWindSystem.Entities;

namespace WestWindSystem.BLL
{
    public class BuildVersionServices
    {
        private readonly WestWindContext _context;

        internal BuildVersionServices(WestWindContext regcontext)
        {
            _context = regcontext; 
        }

        public BuildVersion GetBuildVersion()
        {
            BuildVersion info = _context.BuildVersions.FirstOrDefault();
            return info;
        }
    }
}
