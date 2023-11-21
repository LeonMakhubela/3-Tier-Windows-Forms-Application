using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Module
    {
        public int ModuleID { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDuration { get; set; }
        public int ModuleTypeID { get; set; }
        public string ModuleStatus { get; set; }
        public Module()
        {
        }
        public Module(int moduleID)
        {
            ModuleID = moduleID;
        }
        public Module(int moduleID, string moduleName, string moduleDuration, int moduleTypeID, string moduleStatus)
        {
            ModuleID = moduleID;
            ModuleName = moduleName;
            ModuleDuration = moduleDuration;
            ModuleTypeID = moduleTypeID;
            ModuleStatus = moduleStatus;
        }
        public Module(string moduleName, string moduleDuration, int moduleTypeID, string moduleStatus)
        {
            ModuleName = moduleName;
            ModuleDuration = moduleDuration;
            ModuleTypeID = moduleTypeID;
            ModuleStatus = moduleStatus;
        }
    }
}
