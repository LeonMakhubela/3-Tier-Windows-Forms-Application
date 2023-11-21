using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ModuleType
    {
        public int ModuleTypeID { get; set; }
        public string ModuleTypeDescription { get; set; }
        public ModuleType()
        {
        }
        public ModuleType(int moduleTypeID)
        {
            ModuleTypeID = moduleTypeID;
        }
        public ModuleType(int moduleTypeID, string moduleTypeDescription)
        {
            ModuleTypeID = moduleTypeID;
            ModuleTypeDescription = moduleTypeDescription;
        }
        public ModuleType(string moduleTypeDescription)
        {
            ModuleTypeDescription = moduleTypeDescription;
        }
    }
}
