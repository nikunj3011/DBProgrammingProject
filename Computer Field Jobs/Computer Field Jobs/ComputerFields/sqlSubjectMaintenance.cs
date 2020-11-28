using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFields
{
    class sqlSubjectMaintenance
    {
        public static int SaveSubjectChanges(
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


        public static int CreateNewSubject(
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

        public static int DeleteSubject(int subjectID)
        {
            string deleteSqlQuery = "DELETE FROM CSSubjects WHERE SubjectID = @subjectID";

            SqlCommand cmd = new SqlCommand(deleteSqlQuery);
            cmd.Parameters.AddWithValue("@subjectID", subjectID);

            int rowsAffected = DataAccess.ExecuteNonQuery(cmd);

            return rowsAffected;
        }

    }
}
