using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();

        public int InsertUser(classUser user, classAdministrator admin, classLecturer lecturer, classStudent student)
        {
            int x = dal.InsertUser(user, admin, lecturer, student);
            return x;
        }
        public int UpdateUser(classUser user)
        {
            int x = dal.UpdateUser(user);
            return x;
        }

        public int DeleteUser(classUser user)
        {
            int x = dal.DeleteUsers(user);
            return x;
        }
        public DataTable UserLogin(classUser user)
        {
            return dal.UserLogin(user);
        }

        public DataTable SelectHighAdminID(classAdministrator user)
        {
            return dal.SelectHighAdminID(user);
        }
        public DataTable SelectHighStudentID(classStudent user)
        {
            return dal.SelectHighStudentID(user);
        }
        public DataTable SelectHighLecturerID(classLecturer user)
        {
            return dal.SelectHighLecturerID(user);
        }
        public int DeleteAdmin(classAdministrator user)
        {
            int x = dal.DeleteAdmin(user);
            return x;
        }
        public int DeleteLecturer(classLecturer user)
        {
            int x = dal.DeleteLecturer(user);
            return x;
        }
        public int DeleteStudent(classStudent user)
        {
            int x = dal.DeleteStudent(user);
            return x;
        }

        public DataTable SelectUser(classUser user)
        {
            return dal.SelectUser(user);
        }
        public DataTable SelectStudents()
        {
            return dal.SelectStudents();
        }
        public DataTable SelectLecture()
        {
            return dal.SelectLecturer();
        }

        public DataTable GetModule()
        {
            return dal.GetModule();
        }

        public DataTable SelectAdminstrator(classAdministrator admin)
        {
            return dal.SelectAdministrator(admin);
        }
        public int InsertModuleTypes(ModuleType moduleType)
        {
            return dal.InsertModuleType(moduleType);
        }
        public DataTable ListModuleTypes()
        {
            return dal.ListModuleType();
        }
        public int UpdateModuleTypes(ModuleType moduleType)
        {
            return dal.UpdateModuleType(moduleType);
        }
        public int DeleteModuleTypes(ModuleType moduleType)
        {
            return dal.DeleteModuleType(moduleType);
        }
        public int InsertModules(Module module)
        {
            return dal.InsertModule(module);
        }
        public DataTable ListModules()
        {
            return dal.SelectModule();
        }
        public DataTable GetModuleType()
        {
            return dal.GetModuleType();
        }
        public int UpdateModules(Module module)
        {
            return dal.UpdateModule(module);
        }
        public int DeleteModules(Module module)
        {
            return dal.DeleteModule(module);
        }
        public int InsertLecturerModules(LecturerModule lecturerModule)
        {
            return dal.InsertLecturerModule(lecturerModule);
        }
        public DataTable ListLecturerModules()
        {
            return dal.ListLecturerModule();
        }
        public int UpdateLecturerModules(LecturerModule lecturerModule)
        {
            return dal.UpdateLecturerModule(lecturerModule);
        }
        public int DeleteLecturerModules(LecturerModule lecturerModule)
        {
            return dal.DeleteLecturerModule(lecturerModule);
        }
        public DataTable GetLecturerModule()
        {
            return dal.GetLecturerModule();
        }
        public DataTable GetStudentLecturerModule()
        {
            return dal.GetStudentLecturerModule();
        }
        //public DataTable ModulebyType()
        //{
        //    return dal.ModulebyType();
        //}
        //public DataTable GetAssessmentByType()
        //{
         //   return dal.GetAssessmentByType();
        //}

        public int InsertStudentModules(StudentModule studentModule)
        {
            return dal.InsertStudentModule(studentModule);
        }
        public DataTable ListStudentModules()
        {
            return dal.ListStudentModule();
        }
        public int UpdateStudentModules(StudentModule studentModule)
        {
            return dal.UpdateStudentModule(studentModule);
        }
        public int DeleteStudentModules(StudentModule studentModule)
        {
            return dal.DeleteStudentModule(studentModule);
        }

        public int InsertAssessments(Assessment assessment)
        {
            return dal.InsertAssessment(assessment);
        }
        public DataTable ListAssessments()
        {
            return dal.ListAssessment();
        }
        public DataTable SelectModuleType()
        {
            return dal.ListModuleType();
        }
        public int UpdateAssessments(Assessment assessment)
        {
            return dal.UpdateAssessment(assessment);
        }
        public int UpdateStudentAssessment(Assessment assessment)
        {
            return dal.UpdateStudentAssessment(assessment);
        }
        public int DeleteAssessments(Assessment assessment)
        {
            return dal.DeleteAssessment(assessment);
        }
        
        //public DataTable ModulebyType(int moduleTypeID)
        //{
        //    return dal.ModulebyType(moduleTypeID);
        //}

        public int InsertAssessmentTypes(AssessmentType assessmentType)
        {
            return dal.InsertAssessmentType(assessmentType);
        }
        public DataTable ListAssessmentTypes()
        {
            return dal.ListAssessmentType();
        }
        public int UpdateAssessmentTypes(AssessmentType assessmentType)
        {
            return dal.UpdateAssessmentType(assessmentType);
        }
        public int DeleteAssessmentTypes(AssessmentType assessmentType)
        {
            return dal.DeleteAssessmentType(assessmentType);
        }
        public DataTable GetAssessmentType()
        {
            return dal.GetAssessmentType();
        }

        public DataTable GetCompletedAssessments()
        {
            return dal.GetCompletedAssessment();
        }
        public DataTable GetMissedAssessments()
        {
            return dal.GetMissedAssessment();
        }
        public DataTable GetNotYetDueAssessments()
        {
            return dal.GetNotYetDueAssessment();
        }
        public DataTable AssessmentsbyType(int assessmentTypeID)
        {
            return dal.AssessmentbyType(assessmentTypeID);
        }
        public DataTable AssessmentbyDates(string startDate, string endDate)
        {
            return dal.AssessmentbyDate(startDate, endDate);
        }
        public DataTable ModuleSearch(string module)
        {
            return dal.ModuleSearch(module);
        }
    }
}