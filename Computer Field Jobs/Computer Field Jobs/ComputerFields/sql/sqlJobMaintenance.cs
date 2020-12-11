using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFields
{
    public class sqlJobMaintenance : IJobRepo
    {
        public int SaveJobChanges(
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


        public int CreateNewJob(
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

        public int DeleteJob(int JobID)
        {
            string deleteSqlQuery = "DELETE FROM Jobs WHERE JobID = @JobID";

            SqlCommand cmd = new SqlCommand(deleteSqlQuery);
            cmd.Parameters.AddWithValue("@JobID", JobID);

            int rowsAffected = DataAccess.ExecuteNonQuery(cmd);

            return rowsAffected;
        }

        public int GetFirstJob()
        {
            string cmd = "SELECT TOP (1) JobID FROM Jobs ORDER BY JobName";
            //var cmd = new SqlCommand(query);
            var dt = DataAccess.GetValue(cmd);
            return (int)dt;
        }

        public DataSet statements(int s)
        {
            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Jobs WHERE JobID = {s}",
                $@"
                SELECT 
                (
                    SELECT TOP(1) JobID as FirstJobId FROM Jobs ORDER BY JobName
                ) as FirstJobId,
                q.PreviousJobId,
                q.NextJobId,
                (
                    SELECT TOP(1) JobID as LastJobId FROM Jobs ORDER BY JobName Desc
                ) as LastJobId,
                q.RowNumber
                FROM
                (
                    SELECT JobID, JobName,
                    LEAD(JobID) OVER(ORDER BY JobName) AS NextJobId,
                    LAG(JobID) OVER(ORDER BY JobName) AS PreviousJobId,
                    ROW_NUMBER() OVER(ORDER BY JobName) AS 'RowNumber'
                    FROM Jobs
                ) AS q
                WHERE q.JobID = {s}
                ORDER BY q.JobName".Replace(System.Environment.NewLine," "),
                "SELECT COUNT(JobID) as JobCount FROM Jobs"
            };
            DataSet ds = new DataSet();
            ds = DataAccess.GetDataa(sqlStatements);
            return ds;
        }

    }
}
