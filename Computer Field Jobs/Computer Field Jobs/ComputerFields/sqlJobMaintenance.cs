using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFields
{
    class sqlJobMaintenance
    {
        public static int SaveJobChanges(
                int JobID,
                string JobName,
                string JobLevel,
                double EstimatedPay,
                string Type,
                string Description)
        {
            string sqlUpdateProduct = @"
                UPDATE Jobs
                SET JobName= @JobName
                ,JobLevel = @JobLevel
                ,EstimatedPay = @EstimatedPay
                ,Typee = @Type
                ,Descriptions = @Description
                WHERE JobID = @JobID
            ".Replace(Environment.NewLine, "");

            SqlCommand cmd = new SqlCommand(sqlUpdateProduct);
            cmd.Parameters.AddWithValue("@JobName", JobName);
            cmd.Parameters.AddWithValue("@JobLevel", JobLevel);
            cmd.Parameters.AddWithValue("@Duration", EstimatedPay);
            cmd.Parameters.AddWithValue("@Type", Type);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@JobID", JobID);


            int rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }


        public static int CreateNewJob(
                string JobName,
                string JobLevel,
                double EstimatedPay,
                string Type,
                string Description
            )
        {
            string sqlInsertProduct = $@"
                    INSERT INTO Jobs 
                    (
                        [JobName]
                       ,[JobLevel]
                       ,[EstimatedPay]
                       ,[Typee]
                       ,[Descriptions]) 
                    VALUES 
                    (
                        @JobName
                        ,@JobLevel
                        ,@EstimatedPay
                        ,@Type
                        ,@Description
                    )".Replace(Environment.NewLine, "");

            SqlCommand cmd = new SqlCommand(sqlInsertProduct);
            cmd.Parameters.AddWithValue("@JobName", JobName);
            cmd.Parameters.AddWithValue("@JobLevel", JobLevel);
            cmd.Parameters.AddWithValue("@EstimatedPay", EstimatedPay);
            cmd.Parameters.AddWithValue("@Type", Type);
            cmd.Parameters.AddWithValue("@Description", Description);

            int rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;


        }

        public static int DeleteJob(int JobID)
        {
            string deleteSqlQuery = "DELETE FROM Jobs WHERE JobID = @JobID";

            SqlCommand cmd = new SqlCommand(deleteSqlQuery);
            cmd.Parameters.AddWithValue("@JobID", JobID);

            int rowsAffected = DataAccess.ExecuteNonQuery(cmd);

            return rowsAffected;
        }

    }
}
