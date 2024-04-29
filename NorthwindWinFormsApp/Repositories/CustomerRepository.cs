using NorthwindWinFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindWinFormsApp.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace NorthwindWinFormsApp.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Add(Customer customer)
        {
            using (var context = new NorthwindContext())
            {
                var parameters = new[]
                {
                            new SqlParameter("@CustomerId", customer.CustomerId),
                            new SqlParameter("@CompanyName", customer.CompanyName),
                            new SqlParameter("@ContactName", customer.ContactName),
                            new SqlParameter("@ContactTitle", customer.ContactTitle),
                            new SqlParameter("@Address", customer.Address),
                            new SqlParameter("@City", customer.City),
                            new SqlParameter("@Region", customer.Region),
                            new SqlParameter("@PostalCode", customer.PostalCode),
                            new SqlParameter("@Country", customer.Country),
                            new SqlParameter("@Phone", customer.Phone),
                            new SqlParameter("@Fax", customer.Fax)

                };
                context.Database.ExecuteSqlRaw("EXEC InsertCustomer @CustomerId, @CompanyName, @ContactName," +
                    " @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax", parameters);

            }

        }

        public void Delete(string customerId)
        {
            using (var context = new NorthwindContext())
            {

                // Define the parameter for the stored procedure
                var customerIdParam = new SqlParameter("@CustomerId", customerId);

                // Execute the stored procedure
                context.Database.ExecuteSqlRaw("EXEC DeleteCustomer @CustomerId", customerIdParam);
            }
        }

        public void Edit(Customer customer)
        {
            using (var context = new NorthwindContext())
            {
                // Define the parameters for the stored procedure
                var customerIdParam = new SqlParameter("@CustomerId", customer.CustomerId);
                var companyNameParam = new SqlParameter("@CompanyName", customer.CompanyName);
                var contactNameParam = new SqlParameter("@ContactName", customer.ContactName);
                var contactTitleParam = new SqlParameter("@ContactTitle", customer.ContactTitle);
                var addressParam = new SqlParameter("@Address", customer.Address);
                var cityParam = new SqlParameter("@City", customer.City);
                var regionParam = new SqlParameter("@Region", customer.Region);
                var postalCodeParam = new SqlParameter("@PostalCode", customer.PostalCode);
                var countryParam = new SqlParameter("@Country", customer.Country);
                var phoneParam = new SqlParameter("@Phone", customer.Phone);
                var faxParam = new SqlParameter("@Fax", customer.Fax);

                // Execute the stored procedure
                context.Database.ExecuteSqlRaw("EXEC UpdateCustomer @CustomerId, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax",
                    customerIdParam, companyNameParam, contactNameParam, contactTitleParam, addressParam, cityParam, regionParam, postalCodeParam, countryParam, phoneParam, faxParam);
            }
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
