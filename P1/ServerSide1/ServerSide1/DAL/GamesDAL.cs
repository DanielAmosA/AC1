using danielAmosServer_Core.Helpers.Service;
using Microsoft.Data.SqlClient;
using ServerSide1.Helpers.DB;
using System.Data;

namespace ServerSide1.DAL
{
    /// <summary>
    /// The GamesDAL class responsible for Calling the procedures and their data 
    /// According to the games' area.
    /// </summary>
    public class GamesDAL
    {
        private readonly string connectionString;
        private readonly DataHelper dataHelper;

        public GamesDAL(DataHelper dataHelper)
        {
            //Reading Connection String from the XML
            connectionString = DbConfigReader.GetConnectionString();
            // Calling and executing helper functions for SQL services.
            this.dataHelper = dataHelper;
        }
        public async Task<string?> GetThePasswordByEmail(string email)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@email", email);
            Object? res = await dataHelper.ExecSPAsScalar("Employee_GetThePasswordByEmail", sqlParameters);
            if (res != null)
            {
                return res as string;
            }
            else
            {
                return null;
            }
        }


        //public async Task<List<EmployeeWithManagerData>> SelectByEmail(string email)
        //{
        //    SqlParameter[] sqlParameters = new SqlParameter[1];
        //    sqlParameters[0] = new SqlParameter("@email", email);
        //    DataTable? res = await dataHelper.ExecSPWithRes("Employee_SelectByEmail", sqlParameters);
        //    List<EmployeeWithManagerData> employeeWithManagerData;
        //    if (res != null)
        //    {
        //        employeeWithManagerData = AppService.ConvertDataTableToList<EmployeeWithManagerData>(res);
        //    }
        //    else
        //    {
        //        employeeWithManagerData = new List<EmployeeWithManagerData>();
        //    }
        //    return employeeWithManagerData;

        //}


    }
}
