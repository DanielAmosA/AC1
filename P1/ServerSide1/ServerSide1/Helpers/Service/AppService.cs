using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace danielAmosServer_Core.Helpers.Service
{
    /// <summary>
    /// The class responsible for helper action.
    /// </summary>
    
    public class AppService
    {
        

        #region Generic

        // We will create a generic function
        // that converts a DataTable
        // into a list of objects of the desired model.
        public static List<T> ConvertDataTableToList<T>(DataTable dataTable) where T : new()
        {
            var list = new List<T>();

            foreach (DataRow row in dataTable.Rows)
            {
                T obj = new T();

                foreach (DataColumn column in dataTable.Columns)
                {
                    var property = typeof(T).GetProperty(column.ColumnName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                    if (property != null)
                    {
                        var value = row[column];
                        if (value == DBNull.Value)
                        {
                            property.SetValue(obj, null);
                        }
                        else
                        {
                            property.SetValue(obj, Convert.ChangeType(value, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType));
                        }
                    }
                }

                list.Add(obj);
            }

            return list;
        }



        // We will create a generic function
        // that converts a Model
        // into a array of params of the desired model.
        public static SqlParameter[] GenerateSqlParameters<T>(T model)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            var parameters = new List<SqlParameter>();
            foreach (var property in properties)
            {
                var value = property.GetValue(model);

                if (value != null)
                {
                    string paramName = $"@{property.Name}";
                    parameters.Add(new SqlParameter(paramName, value));
                }
            }
            return parameters.ToArray();
        }

        #endregion

    }
}
