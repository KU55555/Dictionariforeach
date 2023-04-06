namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("koolid");

            Dictionary<int, string> koolid = new Dictionary<int, string>

{

    {1, "Jakob Westholmi Gümnaasium" },

    {2, "Kadrioru Saksa Gümnaasium" },

    {3, "Gustav Adolfi Gümnaasium"}

};

            foreach (KeyValuePair<int, string> pair in koolid)

            {

                Console.WriteLine("{1} on {0}", pair.Value, pair.Key);

            }


        }

    }
}
