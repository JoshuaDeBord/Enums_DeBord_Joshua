namespace Enums_DeBord_Joshua
{
    internal class Program
    {
        enum Months
        {
            Janaury=1,
            Febuary,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {
            int myBirthMonth = (int)Months.April;
            int myBirthDay = 6;
            int myBirthYear = 2005;
            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}.";
            
            File.WriteAllText("myFile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("myFile.txt"));
            File.AppendAllText("myFile.txt", " My name is Joshua DeBord");

            File.Copy("myFile.txt", "newfile.txt");
        }
    }
}