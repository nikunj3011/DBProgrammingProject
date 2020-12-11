using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFields
{
    class sqlSubjectMaintenance : ISubjectRepo
    {
        public int SaveSubjectChanges(
                int SubjectID,
                string SubjectName,
                string SubjectLevel,
                double Duration,
                string Description,
                string Language)
        {
            string sqlUpdateProduct = @"
                UPDATE CSSubjects
                SET SubjectName= @SubjectName
                ,SubjectLevel = @SubjectLevel
                ,Duration = @Duration
                ,Descriptions = @Description
                ,PrimaryLanguage = @Language
                WHERE SubjectID = @SubjectID
            ".Replace(Environment.NewLine, "");

            SqlCommand cmd = new SqlCommand(sqlUpdateProduct);
            cmd.Parameters.AddWithValue("@SubjectName", SubjectName);
            cmd.Parameters.AddWithValue("@SubjectLevel", SubjectLevel);
            cmd.Parameters.AddWithValue("@Duration", Duration);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@Language", Language);
            cmd.Parameters.AddWithValue("@SubjectID", SubjectID);


            int rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;
        }


        public int CreateNewSubject(
                string SubjectName,
                string SubjectLevel,
                double Duration,
                string Description,
                string Language
            )
        {
            string sqlInsertProduct = $@"
                    INSERT INTO CSSubjects 
                    (
                        [SubjectName]
                       ,[SubjectLevel]
                       ,[Duration]
                       ,[Descriptions]
                       ,[PrimaryLanguage]) 
                    VALUES 
                    (
                        @SubjectName
                        ,@SubjectLevel
                        ,@Duration
                        ,@Description
                        ,@Language
                    )".Replace(Environment.NewLine, "");

            SqlCommand cmd = new SqlCommand(sqlInsertProduct);
            cmd.Parameters.AddWithValue("@SubjectName", SubjectName);
            cmd.Parameters.AddWithValue("@SubjectLevel", SubjectLevel);
            cmd.Parameters.AddWithValue("@Duration", Duration);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@Language", Language); 

            int rowsAffected = DataAccess.ExecuteNonQuery(cmd);
            return rowsAffected;


        }

        public int DeleteSubject(int subjectID)
        {
            string deleteSqlQuery = "DELETE FROM CSSubjects WHERE SubjectID = @subjectID";

            SqlCommand cmd = new SqlCommand(deleteSqlQuery);
            cmd.Parameters.AddWithValue("@subjectID", subjectID);

            int rowsAffected = DataAccess.ExecuteNonQuery(cmd);

            return rowsAffected;
        }

        public int GetFirstSubject()
        {
            string cmd = "SELECT TOP (1) SubjectID FROM CSSubjects ORDER BY SubjectName";
            //var cmd = new SqlCommand(query);
            var dt = DataAccess.GetValue(cmd);
            return (int)dt;
        }

        public DataSet statements(int s)
        {
            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM CSSubjects WHERE SubjectID = {s}",
                $@"
                SELECT 
                (
                    SELECT TOP(1) SubjectID as FirstSubjectId FROM CSSubjects ORDER BY SubjectName
                ) as FirstSubjectId,
                q.PreviousSubjectId,
                q.NextSubjectId,
                (
                    SELECT TOP(1) SubjectID as LastSubjectId FROM CSSubjects ORDER BY SubjectName Desc
                ) as LastSubjectId,
                q.RowNumber
                FROM
                (
                    SELECT SubjectID, SubjectName,
                    LEAD(SubjectID) OVER(ORDER BY SubjectName) AS NextSubjectId,
                    LAG(SubjectID) OVER(ORDER BY SubjectName) AS PreviousSubjectId,
                    ROW_NUMBER() OVER(ORDER BY SubjectName) AS 'RowNumber'
                    FROM CSSubjects
                ) AS q
                WHERE q.SubjectID = {s}
                ORDER BY q.SubjectName".Replace(System.Environment.NewLine," "),
                "SELECT COUNT(SubjectID) as SubjectCount FROM CSSubjects"
            };


            DataSet ds = new DataSet();
            ds = DataAccess.GetDataa(sqlStatements);
            return ds;
        }
    }
}
