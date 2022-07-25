using System.Text;
namespace HomeWork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Opa = "**************************";

            Beltelecom company = new Beltelecom();
            Abonent abonent1 = new Abonent(new Belarusisians("Nick", "Agent"));
            Contract contract1 = company.NewContract(abonent1);
            abonent1.DesignateTerminal(company.TakeTerminal(contract1));
            abonent1.Terminal.AssignPort(company.TakePort(contract1));
            abonent1.ConnectTP();

            Thread.Sleep(100);
            Abonent abonent2 = new Abonent(new Belarusisians("Mike", "Agent"));
            Contract contract2 = company.NewContract(abonent2);
            abonent2.DesignateTerminal(company.TakeTerminal(contract2));
            abonent2.Terminal.AssignPort(company.TakePort(contract2));
            abonent2.ConnectTP();

            Thread.Sleep(100);
            Abonent abonent3 = new Abonent(new Belarusisians("Umka", "Sobaken"));
            Contract contract3 = company.NewContract(abonent3);
            abonent3.DesignateTerminal(company.TakeTerminal(contract3));
            abonent3.Terminal.AssignPort(company.TakePort(contract3));
            abonent3.ConnectTP();

            Thread.Sleep(100);
            Abonent abonent4 = new Abonent(new Belarusisians("Chipalino", "Aleksandr"));
            Contract contract4 = company.NewContract(abonent4);
            abonent4.DesignateTerminal(company.TakeTerminal(contract4));
            abonent4.Terminal.AssignPort(company.TakePort(contract4));
            abonent4.ConnectTP();

            Console.WriteLine(Opa);

            var sortedClient = company.Contracts.OrderBy(n => n.Abonent.Name.Surname).ToList();
            foreach (var item in sortedClient)
            {
                Console.WriteLine($"{item.Abonent.Name.Surname} {item.Abonent.Name.FirstName} - {item.Number}");
            }

            Console.WriteLine(Opa);
            Thread.Sleep(1000);
            abonent1.OutСall(contract2.Number, Tariff.Yasna100);

            Console.WriteLine(Opa);
            Thread.Sleep(1000);
            abonent3.OutСall(contract2.Number, Tariff.ShpicUnlimited);

            Console.WriteLine(Opa);
            Thread.Sleep(1000);
            abonent4.OutСall(contract2.Number, Tariff.ShpicUnlimited);

            Console.WriteLine(Opa);
            Thread.Sleep(1000);
            abonent1.EndCall();
            abonent1.DisconnectTP();
            abonent2.EndCall();

            Console.WriteLine(Opa);
            abonent3.OutСall(contract2.Number, Tariff.Yasna100);

            abonent3.EndCall();
            abonent2.EndCall();
            abonent3.DisconnectTP();
            abonent3.DisconnectTP();



            using (var bw = new BinaryWriter(File.Open(@"D:\C#\chek1.txt", FileMode.Create, FileAccess.Write)))
            {

                foreach (var item in sortedClient)
                {
                    bw.Write($"{item.Abonent.Name.Surname} {item.Abonent.Name.FirstName} \t {item.Number}\n");
                }

            }
        }
    }
}