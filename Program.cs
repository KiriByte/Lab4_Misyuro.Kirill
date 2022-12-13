namespace Lab4_Misyuro.Kirill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone first = new Phone();
            Phone second = new Phone();
            Phone third = new Phone();

            first.SetSpecs("+14564846", "Vertu", 563);
            first.ShowPhone();

            second.SetSpecs("12315242", "BlackBerry", 351);
            second.ShowPhone();

            third.SetSpecs("42455134", "DynaTAC", 1212);
            third.ShowPhone();


            first.ReceiveCall("Mike");
            second.ReceiveCall("Alan");
            third.ReceiveCall("Martin");

            Console.WriteLine(first.GetNumber());
            Console.WriteLine(second.GetNumber());
            Console.WriteLine(third.GetNumber());

            first.ReceiveCall("Mike", "436553412");
            second.ReceiveCall("Alan", "3415436432");
            third.ReceiveCall("Martin", "09075083");

            string[] listNumbers = new string[] { "1244614", "235434623", "452567735", "46252462" };
            first.SendMessage(listNumbers);

        }
    }

    class Phone
    {
        private string? number;
        private string? model;
        private int weight;

        public void SetSpecs(string number, string model, int weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }
        public void ShowPhone()
        {
            Console.WriteLine("Number: {0}\nModel: {1}\nWeight: {2}g", number, model, weight);
        }

        public void ReceiveCall(string Name)
        {
            Console.WriteLine("{0} is calling!", Name);
        }

        public string? GetNumber() { return number; }

        public void ReceiveCall(string name, string number)
        {
            Console.WriteLine("{0}\n{1} is calling!", number, name);
        }

        public void SendMessage(params string[] numbers)
        {
            Console.WriteLine("Message sending to:");
            foreach (string n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}