using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Assessment
    {
        public int AssessmentID { get; set; }
        public int StudentLecturerModuleID { get; set; }
        public string DueDate { get; set; }
        public int AssessmentTypeID { get; set; }
        public string AssessmentStatus { get; set; }
        public Assessment()
        {
        }
        public Assessment(int assessmentID)
        {
            AssessmentID = assessmentID;
        }
        public Assessment(int assessmentID,string assessmentStatus)
        {
            AssessmentID = assessmentID;
            AssessmentStatus = assessmentStatus;
        }
        public Assessment(int assessmentID, int studentLecturerModueID, string dueDate, int assessmentTypeID, string assessmentStatus)
        {
            AssessmentID = assessmentID;
            StudentLecturerModuleID = studentLecturerModueID;
            DueDate = dueDate;
            AssessmentTypeID = assessmentTypeID;
            AssessmentStatus = assessmentStatus;
        }
        public Assessment(int studentLecturerModueID, string dueDate, int assessmentTypeID, string assessmentStatus)
        {
            StudentLecturerModuleID = studentLecturerModueID;
            DueDate = dueDate;
            AssessmentTypeID = assessmentTypeID;
            AssessmentStatus = assessmentStatus;
        }
    }
}
