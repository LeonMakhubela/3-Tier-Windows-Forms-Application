using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class DataAccessLayer
    {
        static string sConn = "Data Source=MRROBOT\\INSTANCE;Initial Catalog=AssessmentDB;Integrated Security=True";

        SqlConnection dbConn = new SqlConnection(sConn);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;


        public int InsertUser(classUser user, classAdministrator admin,classLecturer lecturer,classStudent student)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_InsertUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Uid", user.ID);
            dbComm.Parameters.AddWithValue("@Uname", user.Name);
            dbComm.Parameters.AddWithValue("@Usurname", user.Surname);
            dbComm.Parameters.AddWithValue("@Utitle", user.Title);
            dbComm.Parameters.AddWithValue("@Urole", user.Role);
            dbComm.Parameters.AddWithValue("@Uemail", user.Email);
            dbComm.Parameters.AddWithValue("@Upassword", user.Password);
            dbComm.Parameters.AddWithValue("@Ustatus", user.Userstatus);

            

            int x = dbComm.ExecuteNonQuery();



            dbConn.Close();

            if (user.Role == "Administrator")
            {
                try
                {
                    if (dbConn.State != ConnectionState.Open)
                    {
                        dbConn.Open();
                    }
                }
                catch { }

                dbComm = new SqlCommand("sp_InserAdmin", dbConn);
                dbComm.CommandType = CommandType.StoredProcedure;

                dbComm.Parameters.AddWithValue("@Uid", user.ID);



                x = dbComm.ExecuteNonQuery();
            }
            else if(user.Role == "Lecture") 
            {
                try
                {
                    if (dbConn.State != ConnectionState.Open)
                    {
                        dbConn.Open();
                    }
                }
                catch { }

                dbComm = new SqlCommand("sp_InserLecture", dbConn);
                dbComm.CommandType = CommandType.StoredProcedure;

                dbComm.Parameters.AddWithValue("@Uid", user.ID);



                x = dbComm.ExecuteNonQuery();
            }
            else if(user.Role == "Student") 
            {
                try
                {
                    if (dbConn.State != ConnectionState.Open)
                    {
                        dbConn.Open();
                    }
                }
                catch { }

                dbComm = new SqlCommand("sp_InsertStudent", dbConn);
                dbComm.CommandType = CommandType.StoredProcedure;

                dbComm.Parameters.AddWithValue("@Uid", user.ID);



                x = dbComm.ExecuteNonQuery();
            }

            dbConn.Close();

            return x;
        }

        public int DeleteUsers(classUser user)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_DeleteUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", user.ID);

            int x = dbComm.ExecuteNonQuery();

            return x;
        }public int DeleteAdmin(classAdministrator admin)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_DeleteAdmin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", admin.ID);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }public int DeleteLecturer(classLecturer lecturer)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_DeleteLecturer", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", lecturer.ID);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int DeleteStudent(classStudent student)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_DeleteStudent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", student.ID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }

        public int UpdateUser(classUser user)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_UpdateUserInfo", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", user.ID);
            dbComm.Parameters.AddWithValue("@NewName", user.Name);
            dbComm.Parameters.AddWithValue("@NewSurname", user.Surname);
            dbComm.Parameters.AddWithValue("@NewTitle", user.Title);
            dbComm.Parameters.AddWithValue("@NewRole", user.Role);
            dbComm.Parameters.AddWithValue("@NewEmail", user.Email);
            dbComm.Parameters.AddWithValue("@NewPassword", user.Password);
            dbComm.Parameters.AddWithValue("@NewUserStatus", user.Userstatus);



            int x = dbComm.ExecuteNonQuery();



            dbConn.Close();

           


            
            return x;
        }

        public DataTable SelectUser(classUser user)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_SelectAllUsers", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public DataTable SelectHighAdminID(classAdministrator user)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_GetHighestAdminID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public DataTable SelectHighStudentID(classStudent user)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_GetHighestStudentID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;



            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public DataTable SelectHighLecturerID(classLecturer user)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_GetHighestLecturerID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;



            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public DataTable UserLogin(classUser user)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_UserLogin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Email", user.Email);
            dbComm.Parameters.AddWithValue("@Password", user.Password);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public DataTable SelectStudents()
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_SelectStudent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public DataTable SelectLecturer()
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_SelectLecture", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public DataTable SelectAdministrator(classAdministrator admin)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_SelectAdmin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }


        public int InsertModuleType(ModuleType moduleType)
        {
            dbComm = new SqlCommand("sp_InsertModuleType", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@ModDes", moduleType.ModuleTypeDescription);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable ListModuleType()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_SelectModuleType", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateModuleType(ModuleType moduleType)
        {
            dbComm = new SqlCommand("sp_UpdateModuleType", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@Uid", moduleType.ModuleTypeID);
            dbComm.Parameters.AddWithValue("@ModDes", moduleType.ModuleTypeDescription);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int DeleteModuleType(ModuleType moduleType)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_DeleteModuleType", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@moduleTypeID", moduleType.ModuleTypeID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetModuleType()
        {
            dbComm = new SqlCommand("sp_SelectModuleType", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            return dt;
        }
        public DataTable GetAssessmentType()
        {
            dbComm = new SqlCommand("sp_GetAssessmentType", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            return dt;
        }
        public DataTable GetStudentLecturerModule()
        {
            dbComm = new SqlCommand("sp_GetStudentLecturerModule", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            return dt;
        }

        public int InsertModule(Module module)
        {
            dbComm = new SqlCommand("sp_InsertModule", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@Name", module.ModuleName);
            dbComm.Parameters.AddWithValue("@Duration", module.ModuleDuration);
            dbComm.Parameters.AddWithValue("@ModID", module.ModuleTypeID);


            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable SelectModule()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_SelectModule", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateModule(Module module)
        {
            dbComm = new SqlCommand("sp_UpdateModule", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@Uid", module.ModuleID);
            dbComm.Parameters.AddWithValue("@Name", module.ModuleName);
            dbComm.Parameters.AddWithValue("@Duration", module.ModuleDuration);
            dbComm.Parameters.AddWithValue("@ModID", module.ModuleTypeID);


            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetModule()
        {
            dbComm = new SqlCommand("sp_SelectModule", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            return dt;
        }

        /*public DataTable GetStudent()
        {
            dbComm = new SqlCommand("sp_GetStudent", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            return dt;
        }*/
        public int DeleteModule(Module module)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_DeleteModule", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@ModID", module.ModuleID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public DataTable ModuleSearch(string module)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("SearchModuleDetails", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@ModuleName", module);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetLecturerModule()
        {
            dbComm = new SqlCommand("sp_GetLecModule", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            return dt;
        }

        public DataTable ModulebyType(string moduleTypeID)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_SelectByModuleType", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@ModuleTypeDescription", moduleTypeID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }

        public int InsertLecturerModule(LecturerModule lecturerModule)
        {
            dbComm = new SqlCommand("sp_InsertLectureModule", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@UserID", lecturerModule.UserID);
            dbComm.Parameters.AddWithValue("@ModuleID", lecturerModule.ModuleID);
            dbComm.Parameters.AddWithValue("@Date", lecturerModule.Date);
            dbComm.Parameters.AddWithValue("@Status", lecturerModule.ModLecturerStatus);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable ListLecturerModule()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_SelectLecturerModule", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateLecturerModule(LecturerModule lecturerModule)
        {
            dbComm = new SqlCommand("sp_UpdateLectureModule", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@Uid", lecturerModule.LecturerModuleID);
            dbComm.Parameters.AddWithValue("@UserID", lecturerModule.UserID);
            dbComm.Parameters.AddWithValue("@ModID", lecturerModule.ModuleID);
            dbComm.Parameters.AddWithValue("@Date", lecturerModule.Date);
            dbComm.Parameters.AddWithValue("@Status", lecturerModule.ModLecturerStatus);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int DeleteLecturerModule(LecturerModule lecturerModule)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_DeleteLecturerModule", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@UserID", lecturerModule.LecturerModuleID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int InsertStudentModule(StudentModule studentModule)
        {
            dbComm = new SqlCommand("sp_InsertStudentModule", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@ModuleID", studentModule.LecturerModuleID);
            dbComm.Parameters.AddWithValue("@UserID", studentModule.UserID);
            dbComm.Parameters.AddWithValue("@Date", studentModule.Date);
            dbComm.Parameters.AddWithValue("@Status", studentModule.StudModStatus);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable ListStudentModule()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_SelectStudentModule", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateStudentModule(StudentModule studentModule)
        {
            dbComm = new SqlCommand("sp_UpdateStudentModule", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@Uid", studentModule.StudentModuleID);
            dbComm.Parameters.AddWithValue("@ModuleID", studentModule.LecturerModuleID);
            dbComm.Parameters.AddWithValue("@UserID", studentModule.UserID);
            dbComm.Parameters.AddWithValue("@Date", studentModule.Date);
            dbComm.Parameters.AddWithValue("@Status", studentModule.StudModStatus);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int DeleteStudentModule(StudentModule studentModule)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_DeleteStudentModule", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@UserID", studentModule.StudentModuleID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }


        public int InsertAssessmentType(AssessmentType assessmentType)
        {
            dbComm = new SqlCommand("sp_InsertAssessmentType", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@assessmentTypeDescription", assessmentType.AssessmentTypeDescription);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable ListAssessmentType()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_SelectAssessmentType", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetCompletedAssessment()
        {
            dbComm = new SqlCommand("sp_CompletedAssessment", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            return dt;
        }
        public DataTable GetMissedAssessment()
        {
            dbComm = new SqlCommand("sp_MissedAssessment", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            return dt;
        }
        public DataTable GetNotYetDueAssessment()
        {
            dbComm = new SqlCommand("sp_NotYetDueAssessment", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            return dt;
        }
        public DataTable AssessmentbyType(int assessmentTypeID)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_AssessmentbyType", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@AssessmentTypeID", assessmentTypeID);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetAssessmentByType(string assessmentTypeDescr)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_SelectByAssessType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure ;
            dbComm.Parameters.AddWithValue("@AssessmentTypeDescription", assessmentTypeDescr);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable AssessmentbyDate(string startDate, string endDate)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_AssessmentbyDates", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.Add(new SqlParameter("@StartDate", SqlDbType.NVarChar)).Value = startDate;
            dbComm.Parameters.Add(new SqlParameter("@EndDate", SqlDbType.NVarChar)).Value = endDate;
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public int UpdateAssessmentType(AssessmentType assessmentType)
        {
            dbComm = new SqlCommand("sp_UpdateAssessmentType", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@Uid", assessmentType.AssessmentTypeID);
            dbComm.Parameters.AddWithValue("@assessmentTypeDescription", assessmentType.AssessmentTypeDescription);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int DeleteAssessmentType(AssessmentType assessmentType)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_DeleteAssessmentType", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@assessmentTypeID", assessmentType.AssessmentTypeID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int InsertAssessment(Assessment assessment)
        {
            dbComm = new SqlCommand("sp_AssessmentInsert", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@studentLecturerModuleID", assessment.StudentLecturerModuleID);
            dbComm.Parameters.AddWithValue("@dueDate", assessment.DueDate);
            dbComm.Parameters.AddWithValue("@assessmentTypeID", assessment.AssessmentTypeID);
            dbComm.Parameters.AddWithValue("@assessmentStatus", assessment.AssessmentStatus);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable ListAssessment()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_AssessmentSelect", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateAssessment(Assessment assessment)
        {
            dbComm = new SqlCommand("sp_AssessmentUpdate", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@assessmentID", assessment.AssessmentID);
            dbComm.Parameters.AddWithValue("@studentLecturerModuleID", assessment.StudentLecturerModuleID);
            dbComm.Parameters.AddWithValue("@dueDate", assessment.DueDate);
            dbComm.Parameters.AddWithValue("@assessmentTypeID", assessment.AssessmentTypeID);
            dbComm.Parameters.AddWithValue("@assessmentStatus", assessment.AssessmentStatus);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int UpdateStudentAssessment(Assessment assessment)
        {
            dbComm = new SqlCommand("sp_StudentAssessmentUpdate", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@assessmentID", assessment.AssessmentID);
            dbComm.Parameters.AddWithValue("@assessmentStatus", assessment.AssessmentStatus);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int DeleteAssessment(Assessment assessment)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbComm = new SqlCommand("sp_AssessmentDelete", dbConn)
            { CommandType = CommandType.StoredProcedure };
            dbComm.Parameters.AddWithValue("@assessmentID", assessment.AssessmentID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }


    }

}
