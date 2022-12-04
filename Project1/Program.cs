// See https://aka.ms/new-console-template for more information


using Service.Service;

Console.WriteLine("Write password");
string password = Console.ReadLine();

Console.WriteLine("Write Email");
string email = Console.ReadLine();

int role = 0;

Account account = new Account();

account.Login(email, password, role);

