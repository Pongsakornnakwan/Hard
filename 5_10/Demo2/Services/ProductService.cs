using Dapper;
using Demo2.Data;
using MudBlazor.Charts;
using Npgsql;

namespace Demo2.Services
{
    public interface IProductService
    {
        List<product> GetAllProduct();
    }
    public class ProductService : IProductService
    {

        public List<product> GetAllProduct()
        {
            List<product> Res = new List<product>();
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(GbVer.ConnectionString))
                {
                    con.Open();
                    string SQL = "select * from product order by code";
                    Res = con.Query<product>(SQL).ToList();
                }
            }
            catch (Exception ex)
            { }
            return Res;
        }

    }
}
