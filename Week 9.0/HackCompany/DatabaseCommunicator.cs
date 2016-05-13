using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HackCompany
{
    class DatabaseCommunicator
    {
        private string connectionString;

        public DatabaseCommunicator(string connectionString)
        {
            this.connectionString = connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        private int ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                return command.ExecuteNonQuery();
            }
        }

        public void UpdateOrInsert(Category category)
        {
            string query = $@"IF EXISTS (SELECT TOP 1 * 
			                            FROM Categories
			                            WHERE CategoryID = '{category.Id}')
	                                BEGIN
		                                UPDATE Categories
		                                SET Name = '{category.Name}'
		                                WHERE CategoryID = '{category.Id}'
	                                END
                            ELSE
	                                BEGIN
		                                INSERT INTO Categories
		                                VALUES ('{category.Id}', '{category.Name}');
	                                END";
            ExecuteNonQuery(query);
        }

        public void UpdateOrInsert(Customer customer)
        {
            string query = $@"IF EXISTS (SELECT TOP 1 *
                                        FROM Customers
                                        WHERE CustomerID = '{customer.CustomerId}')
                                    BEGIN
                                        UPDATE Customers
                                        SET Name = '{customer.Name}'
                                        SET Email = '{customer.Email}'
                                        SET Address = '{customer.Address}'
                                        SET Discount = '{customer.Discount}'
                                        WHERE CustomerID = '{customer.CustomerId}'
                                    END
                                ELSE
                                    BEGIN 
                                        SET IDENTITY_INSERT Customers ON
                                        INSERT INTO Customers
                                        VALUES ('{customer.CustomerId}', '{customer.Name}', '{customer.Email}', '{customer.Address}', '{customer.Discount}')
                                        SET IDENTITY_INSERT Customers OFF
                                    END";
            ExecuteNonQuery(query);
        }

        public void UpdateOrInsert(Department department)
        {
            string query = $@"IF EXISTS (SELECT TOP 1 *
                                        FROM Departments
                                        WHERE DepartmentID = '{department.DepartmentId}')
                                    BEGIN 
                                        UPDATE Departments
                                        SET Name = '{department.Name}'
                                        WHERE DepartmentID = '{department.DepartmentId}'
                                    END
                                ELSE
                                    BEGIN 
                                        SET IDENTITY_INSERT Departments ON
                                        INSERT INTO Departments 
                                        VALUES ('{department.DepartmentId}', '{department.Name}')
                                        SET IDENTITY_INSERT Departments OFF
                                    END";
            ExecuteNonQuery(query);
        }

        public void UpdateOrInsert(Employee employee)
        {
            string query = $@"IF EXISTS (SELECT TOP 1 * 
                                        FROM Employees
                                        WHERE EmployeeID = '{employee.EmployeeId}'
                                    BEGIN
                                        UPDATE Employees
                                        SET FirstName = '{employee.FirstName}'
                                        SET LastName = '{employee.LastName}'
                                        SET Email = '{employee.Email}'
                                        SET DateOfBirth = '{employee.DateOfBirth}'
                                        SET ManagerID = '{employee.ManagerId}'
                                        SET DepartmentID = '{employee.DepartmentId}'
                                        WHERE EmployeeID = '{employee.EmployeeId}'
                                    END
                                ELSE
                                    BEGIN
                                        SET IDENTITY_INSERT Employees ON
                                        INSERT INTO Employees 
                                        VALUES ('{employee.EmployeeId}', '{employee.FirstName}', '{employee.LastName}', '{employee.Email}', '{employee.DateOfBirth}', '{employee.ManagerId}', '{employee.DepartmentId}')
                                        SET IDENTITY_INSERT Employees OFF
                                    END";
            ExecuteNonQuery(query);
        }

        public void UpdateOrInsert(OrderProduct orderProduct)
        {
            string query = $@"IF EXISTS (SELECT TOP 1 *
                                        FROM OrderProducts
                                        WHERE OrderID = '{orderProduct.OrderId}' AND ProductID = '{orderProduct.ProductId}')
                                    BEGIN
                                        UPDATE OrderProducts
                                        SET Quantity = '{orderProduct.Quantity}'
                                        WHERE OrderID = '{orderProduct.OrderId}' AND ProductID = '{orderProduct.ProductId}'
                                    END
                                ELSE
                                    BEGIN
                                        SET IDENTITY_INSERT OrderProducts ON
                                        INSERT INTO OrderProducts
                                        VALUES ('{orderProduct.OrderId}', '{orderProduct.ProductId}', '{orderProduct.Quantity}')
                                        SET Identity_INSERT OrderProducts OFF
                                    END";
            ExecuteNonQuery(query);
        }

        public void UpdateOrInsert(Order order)
        {
            string query = $@"IF EXISTS (SELECT TOP 1 *
                                        FROM Orders
                                        WHERE OrderID = '{order.OrderId}')
                                    BEGIN
                                        UPDATE Orders
                                        SET DateOfOrder = '{order.DateOfOrder}'
                                        SET CustomerID = '{order.CustomerId}'
                                        SET TotalPrice = '{order.TotalPrice}'
                                        WHERE OrderID = '{order.OrderId}'
                                    END
                                ELSE
                                    BEGIN
                                        SET IDENTITY_INSERT Orders ON
                                        INSERT INTO Orders
                                        VALUES ('{order.OrderId}', '{order.DateOfOrder}', '{order.CustomerId}', '{order.TotalPrice}')
                                        SET IDENTITY_INSERT Orders OFF
                                    END";
            ExecuteNonQuery(query);
        }

        public void UpdateOrInsert(Product product)
        {
            string query = $@"IF EXISTS (SELECT TOP 1 *
                                        FROM Products
                                        WHERE ProductID = '{product.ProductId}')
                                    BEGIN 
                                        UPDATE Products
                                        SET Name = '{product.Name}'
                                        SET Price = '{product.Price}'
                                        SET CategoryID = '{product.CategoryId}'
                                        WHERE ProductID = '{product.ProductId}'
                                    END
                                ELSE
                                    BEGIN
                                        SET IDENTITY_INSERT Products ON
                                        INSERT INTO Products
                                        VALUES ('{product.ProductId}', '{product.Name}', '{product.Price}', '{product.CategoryId}')
                                        SET IDENTITY_INSERT Products OFF
                                    END";
            ExecuteNonQuery(query);
        }

        public bool DeleteCategory(string id)
        {
            string query = $@"DELETE FROM Categories
                                WHERE CategoryID = '{id}'";

            try
            {
                int affectedRows = ExecuteNonQuery(query);

                if (affectedRows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool DeleteCustomer(int id)
        {
            string query = $@"DELETE FROM Customers
                                WHERE CustomerID = '{id}'";

            try
            {
                int affectedRows = ExecuteNonQuery(query);

                if (affectedRows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool DeleteDepartment(int id)
        {
            string query = $@"DELETE FROM Departments
                            WHERE DepartmentID = '{id}'";

            try
            {
                int affectedRows = ExecuteNonQuery(query);

                if (affectedRows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool DeleteEmployee(int id)
        {
            string query = $@"DELETE FROM Employees
                            WHERE EmployeeID = '{id}'";

            try
            {
                int affectedRows = ExecuteNonQuery(query);

                if (affectedRows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool DeleteOrderProduct(int orderId, int productId)
        {
            string query = $@"DELETE FROM OrderProducts
                            WHERE OrderID = '{orderId}' AND ProductID = '{productId}'";

            try
            {
                int affectedRows = ExecuteNonQuery(query);

                if (affectedRows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool DeleteOrder(int id)
        {
            string query = $@"DELETE FROM Orders
                            WHERE OrderID = '{id}'";

            try
            {
                int affectedRows = ExecuteNonQuery(query);

                if (affectedRows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool DeleteProduct(int id)
        {
            string query = $@"DELETE FROM Products
                            WHERE ProductID = '{id}'";

            try
            {
                int affectedRows = ExecuteNonQuery(query);

                if (affectedRows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public List<Category> GetCategories()
        {
            List<Category> rows = new List<Category>();
            string query = @"SELECT * FROM Categories";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rows.Add(new Category((string)reader["CategoryID"], (string)reader["Name"]));
                    }
                }
            }

            return rows;
        }
       
        public List<Customer> GetCustomers()
        {
            List<Customer> rows = new List<Customer>();
            string query = @"SELECT * FROM Customers";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(query, connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rows.Add(new Customer((int)reader["CustomerID"], (string)reader["Name"],
                                                (string)GetObjectOrNull(reader["Email"]),
                                                (string)reader["Address"],
                                                (decimal?)GetObjectOrNull(reader["Discount"])));
                    }
                }
            }

            return rows;
        }

        public List<Department> GetDepartments()
        {
            List<Department> rows = new List<Department>();
            string query = @"SELECT * FROM Departments";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(query, connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rows.Add(new Department((int)reader["DepartmentID"], (string)reader["Name"]));
                    }
                }
            }


            return rows;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> rows = new List<Employee>();

            string query = @"SELECT * FROM Employees";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(query, connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employee emp = new Employee(
                                (int)reader["EmployeeID"],
                                (string)reader["FirstName"],
                                (string)reader["LastName"],
                                (string)GetObjectOrNull(reader["Email"]),
                                (DateTime)reader["DateOfBirth"],
                                (int?)GetObjectOrNull(reader["MANAGER"]),
                                (int?)GetObjectOrNull(reader["Department"])
                                );
                        rows.Add(emp);
                    }
                }
            }

            return rows;
        }

        public List<OrderProduct> GetOrderProducts()
        {
            List<OrderProduct> rows = new List<OrderProduct>();

            string query = @"SELECT * FROM OrderProducts";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(query, connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rows.Add(new OrderProduct(
                                (int)reader["OrderID"],
                                (int)reader["ProductID"],
                                (int)reader["Quantity"]
                                ));
                    }
                }
            }

            return rows;
        }

        public List<Order> GetOrders()
        {
            List<Order> rows = new List<Order>();

            string query = @"SELECT * FROM Orders";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(query, connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rows.Add(new Order(
                                (int)reader["OrderID"],
                                (DateTime)reader["DateOfOrder"],
                                (int)reader["Customer"],
                                (double)reader["TotalPrice"]
                                ));
                    }
                }
            }

            return rows;
        }

        public List<Product> GetProducts()
        {
            List<Product> rows = new List<Product>();

            string query = @"SELECT * FROM Products";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(query, connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rows.Add(new Product(
                                (int)reader["ProductID"],
                                (string)reader["Name"],
                                (double)reader["Price"],
                                (int)GetObjectOrNull(reader["CategoryID"])
                                ));
                    }
                }
            }

            return rows;
        }

        private object GetObjectOrNull(object v)
        {
            if (v is DBNull)
            {
                return null;
            }

            else
            {
                return v;
            }
        }
    }
}
