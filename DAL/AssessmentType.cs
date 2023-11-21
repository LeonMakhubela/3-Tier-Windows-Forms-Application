using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AssessmentType
    {
        public int AssessmentTypeID { get; set; }
        public string AssessmentTypeDescription { get; set; }
        public AssessmentType()
        {
        }
        public AssessmentType(int assessmentTypeID)
        {
            AssessmentTypeID = assessmentTypeID;
        }
        public AssessmentType(int assessmentTypeID, string assessmentTypeDescription)
        {
            AssessmentTypeID = assessmentTypeID;
            AssessmentTypeDescription = assessmentTypeDescription;
        }
        public AssessmentType(string assessmentTypeDescription)
        {
            AssessmentTypeDescription = assessmentTypeDescription;
        }
    }
}
