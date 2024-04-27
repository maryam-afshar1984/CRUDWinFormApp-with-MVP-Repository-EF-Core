using NorthwindWinFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindWinFormsApp.Configuration;
using NorthwindWinFormsApp.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace NorthwindWinFormsApp.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(string customerId)
        {
            throw new NotImplementedException();
        }

        public void Edit(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            var customerList = new List<Customer>();
            using (var context = new NorthwindContext())
            {
                customerList = context.GetAllCustomer().ToList();
            }
            return customerList;
        }

        public IEnumerable<Customer> GetByValue(string customerId)
        {
            var customerList = new List<Customer>();

            AppConfig con = ConfigurationManager.LoadConfiguration();

            string connectionStrings = con.ConnectionStrings.MyConnectionString.ToString();
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetCustomersByCustomerId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Set parameters
                    command.Parameters.AddWithValue("@CustomerID", customerId);

                    // Execute the stored procedure
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Customer customer = new Customer
                        {
                            CustomerId = row["CustomerID"].ToString(),
                            CompanyName = row["CompanyName"].ToString(),
                            ContactName = row["ContactName"].ToString(),
                            ContactTitle = row["ContactTitle"].ToString(),
                            Address = row["Address"].ToString(),
                            City = row["City"].ToString(),
                            Region = row["Region"].ToString(),
                            PostalCode = row["PostalCode"].ToString(),
                            Country = row["Country"].ToString(),
                            Phone = row["Phone"].ToString(),
                            Fax = row["Fax"].ToString(),

                        };
                        customerList.Add(customer);
                    }

                }
            }
            return customerList;
        }
    }
}
