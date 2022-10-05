using Dapper;
using Demo2.Data;
using MudBlazor.Charts;
using Npgsql;

namespace Demo2.Services
{
    public interface ICustomerService
    {
        List<customer> GetAllCustomer();
    }
    public class CustomerService : ICustomerService
    {
        public List<customer> GetAllCustomers()
        {
            List<customer> Res = new List<customer>();
            try
            {
                using (NpgsqlConnection can = new NpgsqlConnection(GbVer.ConnectionString))
                {
                    con.Open();
                    string SQL = "Select * from customer order by name1";
                    Res = con.Query<customer>(SQL).ToList();
                }
            }
            catch (Exception ex)
            { }
            return Res;
        }

    }
}
