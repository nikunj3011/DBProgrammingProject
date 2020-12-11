using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFields.sql
{
    public class SubjectFactory
    {
        public static ISubjectRepo subjectRepo()
        {
            return new sqlSubjectMaintenance();
        }
    }
}
