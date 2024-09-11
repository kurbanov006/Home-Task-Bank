using Npgsql;
using Dapper;
using Infrastructure.Mappers;
using System.Diagnostics.SymbolStore;

namespace Infrastructure.Services
{
    public class ServiceQuery
    {
        #region Query1
        public IEnumerable<Query1> GetQuery1()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.Query<Query1>(SqlCommand.Query1);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region Query2
        public IEnumerable<Query2> GetQuery2()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.Query<Query2>(SqlCommand.Query2);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region Query3
        public Query3 GetQuery3()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.QueryFirst<Query3>(SqlCommand.Query3);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region Query4
        public Query4 GetQuery4()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.QueryFirst<Query4>(SqlCommand.Query4);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region Query5
        public IEnumerable<Query5> GetQuery5()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.Query<Query5>(SqlCommand.Query5);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region Query6
        public IEnumerable<Query6> GetQuery6()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.Query<Query6>(SqlCommand.Query6);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region Query7
        public IEnumerable<Query7> GetQuery7()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.Query<Query7>(SqlCommand.Query7);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region Query8
        public IEnumerable<Query8> GetQuery8()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.Query<Query8>(SqlCommand.Query8);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region Query9
        public IEnumerable<Query9> GetQuery9()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.Query<Query9>(SqlCommand.Query9);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region Query10
        public IEnumerable<Query10> GetQuery10()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.Query<Query10>(SqlCommand.Query10);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region Query11
        public IEnumerable<Query11> GetQuery11()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.Query<Query11>(SqlCommand.Query11);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region Query12
        public IEnumerable<Query12> GetQuery12()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.Query<Query12>(SqlCommand.Query12);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region Query13
        public IEnumerable<Query13> GetQuery13()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.Query<Query13>(SqlCommand.Query13);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region Query14
        public IEnumerable<Query14> GetQuery14()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.Query<Query14>(SqlCommand.Query14);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region Query15
        public IEnumerable<Query15> GetQuery15()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.Query<Query15>(SqlCommand.Query15);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion


        #region Query16
        public IEnumerable<Query16> GetQuery16()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringConnection))
                {
                    connection.Open();

                    return connection.Query<Query16>(SqlCommand.Query16);
                }
            }
            catch (NpgsqlException ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        #endregion

    }
}


file class SqlCommand
{
    public const string StringConnection = "Server=localhost; Port=5432; Database=bank_db; User Id=postgres; Password=12345";
    public const string Query1 = @"select c.customerid, c.firstname || ' ' || c.lastname as fullname,
                                    c.email, c.phonenumber, c.address, c.dateofbirth, a.balance
                                    from customers c
                                    join accounts a on c.customerid = a.customerid";
    public const string Query2 = @"select c.firstname || ' ' || c.lastname as fullname, 
                                    t.transactionid, t.accountid, t.transactiontype, t.amount, t.transactiondate, t.description
                                    from customers c
                                    join accounts a on a.customerid = c.customerid
                                    join transactions t on t.accountid = a.accountid
                                    where c.customerid = 1
                                    order by t.transactiondate desc";
    public const string Query3 = @"select status, count(customerid) as Counts
                                    from supporttickets 
                                    group by status
                                    having status = 'Open'";
    public const string Query4 = @"select c.customerid, c.firstname || ' ' || c.lastname as fullname,
                                    c.email, c.phonenumber, c.address, c.dateofbirth, a.balance 
                                    from customers c
                                    join accounts a on a.customerid = c.customerid
                                    where a.balance > 2000";
    public const string Query5 = @"select a.accountid, a.customerid, a.accountnumber, a.accounttype, a.balance, sum(t.amount) as summ
                                    from accounts a
                                    join transactions t on t.accountid = a.accountid
                                    group by a.accountid";
    public const string Query6 = @"select c.customerid, c.firstname || ' ' || c.lastname as fullname,
                                    ap.appointmentid, ap.appointmentdate, ap.location
                                    from customers c
                                    join appointments ap on c.customerid = ap.customerid";

    public const string Query7 = @"select transactionid, accountid, amount, transactiondate, description
                                        from transactions 
                                        where transactiondate >= current_date - interval '1 month'";

    public const string Query8 = @"select accounttype, avg(balance) as AvgBalance
                                    from accounts
                                    group by accounttype";

    public const string Query9 = @"select c.customerid, c.firstname|| ' ' ||c.lastname as fullname,
                                c.email, c.phonenumber, c.address, c.dateofbirth, t.transactiontype, t.amount
                                from customers c
                                join accounts a on a.customerid = c.customerid
                                join transactions t on t.accountid = a.accountid
                                where t.transactiontype = 'Deposit' and t.amount > 1000";

    public const string Query10 = @"select c.customerid, c.firstname|| ' ' ||c.lastname as fullname,
                                    c.email, c.phonenumber, c.address, c.dateofbirth, s.status
                                    from customers c
                                    left join supporttickets s on c.customerid = 	s.customerid
                                    where s.ticketid is null";
    public const string Query11 = @"select c.firstname || ' ' || c.lastname as fullname,
                                    count(a.appointmentid) as counts
                                    from customers c
                                    join appointments a on c.customerid = a.customerid
                                    group by fullname
                                    order by counts desc
                                    limit 5";
    public const string Query12 = @"select c.firstname || ' ' || c.lastname as fullname,
                                    sum(t.amount) as summ
                                    from customers c
                                    join accounts a on c.customerid = a.customerid
                                    join transactions t on a.accountid = t.accountid
                                    group by fullname";
    public const string Query13 = @"
                                    select c.firstname || ' ' || c.lastname as fullname,
                                    max(s.createdat) as maxtime
                                    from customers c
                                    join supporttickets s on c.customerid = s.customerid
                                    group by fullname
                                    ";
    public const string Query14 = @"
                                    select s.ticketid, s.issuetype, s.status
                                    from supporttickets s
                                    where s.status = 'Open' or s.status = 'In Progress'
                                    ";
    public const string Query15 = @"select c.firstname || ' ' || c.lastname as fullname,
                                        s.status
                                        from customers c
                                        join supporttickets s on c.customerid = s.customerid
                                        where s.createdat = (select max(createdat) from supporttickets)
                                    ";
    public const string Query16 = @"
                                    select c.customerid, c.firstname || ' ' || c.lastname as fullname, count(a.accountid) as counts
                                    from customers c
                                    join accounts a on c.customerid = a.customerid
                                    group by c.customerid
                                    having count(a.accountid) > 1
                                    ";


}