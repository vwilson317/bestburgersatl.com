using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace BestBurgersAtl.Resources.DA
{
    public class PostRepository : IPostRepository// LookupRepositoryBase<PostResource>, IPostRepository
    {
        SqlConnection Connection { get; set; }
        private string CONNECTION_STRING = "Server=bbatlsqlexpress.cibtf39dd2gv.us-east-1.rds.amazonaws.com,1433\\SQLEXPRESS;Database=BestBurgersAtl;User ID=admin;Password=falcons1;";
        public  IEnumerable<PostResource> GetAll()
        {
            using (Connection = new SqlConnection(CONNECTION_STRING))
            {
                return Connection.Query<PostResource>("select * from dbo.Post");
            }
        }
    }
}
