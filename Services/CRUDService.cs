using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyProject.Models.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class CRUDService
    {

        public static DataTable ExecCRUD(MyDatabaseContext _context,string commandText, string[,] sp_par)
        {
            var dt = new DataTable();

            try
            {
                using (var cmd = _context.Database.GetDbConnection().CreateCommand())
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = commandText;

                    int arrIndex = sp_par.GetLength(0);
                    for (var i = 0; i < arrIndex; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter("@" + sp_par[i, 0] , sp_par[i,1]));
                    }

                    _context.Database.OpenConnection();

                    using (var result = cmd.ExecuteReader())
                    {

                        dt.Load(result);

                    }
                }
                return dt;
            }
            catch (Exception)
            {
                return null;
            }

        }

    }
}
