using HR;
Console.WriteLine("**********************************");
Console.WriteLine("Enter email and password");
if(AuthManager.Validate(Console.ReadLine(),Console.ReadLine())){
    Employee employee1 = new SalesEmployee("7", "Ali", "Meghani",
                                            new DateTime(1985,10,1), "8881212", "am@gmail.com"
                                            , "Mumbai", 5000, 10000, 40000, 200000, 0);
    Employee employee2 = new SalesManager("5", "Saurav", "Patil",
                                            new DateTime(1998,9,5), "90908478", "sp@gmail.com"
                                            , "Mumbai", 10000, 100000, 400000, 500000, 1000000, 50000);
    employee1.DoWork();
    Console.WriteLine(employee1.ComputeSalary());
    employee2.DoWork();
    Console.WriteLine(employee2.ComputeSalary());
}
else{
    Console.WriteLine("Invalid Id or Password");
}