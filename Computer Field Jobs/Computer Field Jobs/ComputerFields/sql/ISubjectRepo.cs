using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFields
{
    public interface ISubjectRepo
    {
        int SaveSubjectChanges(
                int SubjectID,
                string SubjectName,
                string SubjectLevel,
                double Duration,
                string Description,
                string Language);
        int CreateNewSubject(
                string SubjectName,
                string SubjectLevel,
                double Duration,
                string Description,
                string Language
            );
        int DeleteSubject(int subjectID);
        int GetFirstSubject();
        DataSet statements(int s);

    }
}
