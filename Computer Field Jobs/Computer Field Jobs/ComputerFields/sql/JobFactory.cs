using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFields.sql
{
    public class JobFactory
    {
        public static IJobRepo jobRepo()
        {
            return new sqlJobMaintenance();
        }
    }
}
