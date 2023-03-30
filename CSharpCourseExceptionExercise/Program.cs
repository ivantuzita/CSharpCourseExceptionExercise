using CSharpCourseExceptionExercise.Entities;
using CSharpCourseExceptionExercise.Entities.Exceptions;

Console.WriteLine("Enter account data:");
Console.Write("Number: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
string name =  Console.ReadLine();
Console.Write("Initial balance: ");
double bal = double.Parse(Console.ReadLine());
Console.Write("Withdraw limit: ");
double limit = double.Parse(Console.ReadLine());

try {
    Account acc = new(num, name, bal, limit);
    try {
        Console.Write("\nEnter amount for withdraw: ");
        double with = double.Parse(Console.ReadLine());
        acc.withdraw(with);
        Console.WriteLine($"New balance: {acc.Balance}");
    }
    catch (DomainException e) {
        Console.WriteLine($"Withdraw error: {e.Message}");
    }
}
catch (DomainException e) {
    Console.WriteLine($"Account creating error: {e.Message}");
}

