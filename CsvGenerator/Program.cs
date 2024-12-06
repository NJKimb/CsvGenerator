namespace CsvGenerator;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        String r_line = "";
        String t_line = "";

        r_line += "doctor, patient\n";
        t_line += "doctor, age\n";

        for (int i = 0; i < Int32.Parse(args[0]); i++)
        {
            r_line += rnd.Next(0, 100).ToString() + "," + rnd.Next(0, 100).ToString() + "\n";
            t_line += rnd.Next(0, 100).ToString() + "," + rnd.Next(0, 100).ToString() + "\n";
        }
        
        File.WriteAllText("../../../r_table.csv", r_line);
        File.WriteAllText("../../../t_table.csv", t_line);
    }
}