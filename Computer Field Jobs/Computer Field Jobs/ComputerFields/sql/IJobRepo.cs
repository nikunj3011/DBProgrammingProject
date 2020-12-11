using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFields
{
    public interface IJobRepo
    {
        int SaveJobChanges(int JobID,
                string JobName,
                string JobLevel,
                double EstimatedPay,
                string Type,
                string Description);
        int CreateNewJob(string JobName,
                string JobLevel,
                double EstimatedPay,
                string Type,
                string Description);
        int DeleteJob(int JobID);
        int GetFirstJob();
        DataSet statements(int s);

    }
}
