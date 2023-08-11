using ExercicioFixacao2.Entities;
using ExercicioFixacao2.Services;
using System.Diagnostics.Contracts;
using System.Globalization;
namespace ExercicioFixacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (MM/dd/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Entities.Contract contract = new Entities.Contract(number, date, totalValue);

            ContractService contractService = new ContractService(new PaypalService());

            contractService.ProcessContract(contract, months);

            Console.WriteLine("INSTALLMENTS");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}