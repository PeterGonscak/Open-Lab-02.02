using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            string a = "";
            foreach (var cislo in numbers)
            {
                string zaokruhlene = Math.Round(cislo, 2).ToString().Replace(',', '.');
                a += zaokruhlene + " ";
            }
            string b = a.Remove(a.LastIndexOf(" "));
            Console.Write(b);
        }
    }
}
