using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LecturerModule
    {
        public int LecturerModuleID { get; set; }
        public int UserID { get; set; }
        public int ModuleID { get; set; }
        public string Date { get; set; }
        public string ModLecturerStatus { get; set; }
        public LecturerModule()
        {
        }
        public LecturerModule(int lecturerModuleID)
        {
            LecturerModuleID = lecturerModuleID;
        }
        public LecturerModule(int userID, int moduleID, string date, string modLecturerStatus)
        {
            UserID = userID;
            ModuleID = moduleID;
            Date = date;
            ModLecturerStatus = modLecturerStatus;
        }
        public LecturerModule(int lecturerModuleID, int userID, int moduleID, string date, string modLecturerStatus)
        {
            LecturerModuleID = lecturerModuleID;
            UserID = userID;
            ModuleID = moduleID;
            Date = date;
            ModLecturerStatus = modLecturerStatus;
        }
    }
}
