using Infrastructure.Services;

ServiceQuery serviceQuery = new ServiceQuery();



// QUERY 1  
// var res = serviceQuery.GetQuery1();
// foreach (var item in res)
// {
//     System.Console.WriteLine($"Id: {item.Customerid}, FullName: {item.FullName}, Email: {item.Email}, PhoneNumber: {item.PhoneNumber},   Address: {item.Address}, DateOfBirth: {item.DateOfBirth}, Balance: {item.Balance}");
// }


// QUERY2
// var res = serviceQuery.GetQuery2();
// foreach (var item in res)
// {
//     System.Console.WriteLine($"FullName: {item.FullName}, TransactionId: {item.TransactionId}, AccountId: {item.AccountId}, TransactionType: {item.TransactionType}, Amount: {item.Amount}, TransactionDate: {item.TransactionDate}, Description: {item.Description}");
// }



// QUERY3
// var res = serviceQuery.GetQuery3();
// System.Console.WriteLine($"Status: {res.Status}, Count: {res.Counts}");




// QUERY4
// var res = serviceQuery.GetQuery4();
// System.Console.WriteLine($"{res.Customerid}, {res.FullName}, {res.Email}, {res.PhoneNumber}, {res.Address}, {res.Balance}, {res.DateOfBirth}");


//QUERY5
// var res = serviceQuery.GetQuery5();
// foreach (var t in res)
// {
//     System.Console.WriteLine($"Accountid: {t.Accountid}, Customerid: {t.Customerid}, AccountNumber: {t.AccountNumber}, AccountType: {t.AccountType}, Balance: {t.Balance}, Sum: {t.Summ}");
// }


// QUERY6
// var res = serviceQuery.GetQuery6();
// foreach (var t in res)
// {
//     System.Console.WriteLine($"{t.Customerid}, {t.Appointmentid}, {t.FullName}, {t.Appointmentdate}, {t.Location}");
// }


// QUERY7
//!



// QUERY8
// var res = serviceQuery.GetQuery8();
// foreach (var i in res)
// {
//     System.Console.WriteLine($"{i.accounttype}, {i.AvgBalance}");
// }


// QUERY9
// var res = serviceQuery.GetQuery9();
// foreach (var i in res)
// {
//     System.Console.WriteLine($"{i.Customerid}, {i.FullName}, {i.Email}, {i.PhoneNumber}, {i.Address}, {i.DateOfBirth}, {i.TransactionType}, {i.Amount}");
// }


// QUERY10
// var res = serviceQuery.GetQuery10();
// foreach (var i in res)
// {
//     System.Console.WriteLine($"{i.Customerid}, {i.FullName}, {i.Email}, {i.phonenumber}, {i.Address}, {i.DateOfBirth}, {i.Status}");
// }