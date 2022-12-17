using Lab5_Misuiro.Kirill;
using Clinic.Patient;

namespace Lab5_Misyuro.Kirill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer pc1 = new Computer();
            Computer pc2 = new Computer("MSI", 300,
                "Samsung", 32, "Seagate", 500, 1);

            Console.WriteLine(pc1.Info());
            Console.WriteLine(pc2.Info());


            ATM atm = new ATM(20, 30, 40);
            Console.WriteLine("Money in ATM {0}",atm.MoneyInAtm());
            atm.AddMoney(5, 23, 0);
            Console.WriteLine("Money in ATM {0}", atm.MoneyInAtm());
            string status = atm.RemoveMoney(6790) ? "Task completed successfully" : "Error";
            Console.WriteLine(status);
            Console.WriteLine("Money in ATM {0}", atm.MoneyInAtm());

            Console.WriteLine();
            Patient first = new Patient("John", 1);
            first.AppointDoctor();
            Console.WriteLine(first.GetPatientInfo());
        }
    }
}