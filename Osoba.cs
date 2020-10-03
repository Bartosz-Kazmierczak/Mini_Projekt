namespace Mini_Projekt
{
    internal class Osoba
    {
      
        public string imie = "Mariano";
        public string nazwisko = "Italiano";
        public static double pesel = 97123199999;
        public static double wzrost = 175;
        public static double wiek = 23;
        public string adres = "ul.Jakaś 12, 63-330 Dobrzyca";
        public string info = "Jeździ: Golfem V";

        public void printInfo()
        {
            System.Console.WriteLine("Imię: " + imie);
            System.Console.WriteLine("Nazwisko: " + nazwisko);
            System.Console.WriteLine("Pesel: " + pesel);
            System.Console.WriteLine("Wzrost: " + wzrost);
            System.Console.WriteLine("Wiek: " + wiek);
            System.Console.WriteLine("Adres: " + adres);
            System.Console.WriteLine("Informacja: " + info);
            System.Console.WriteLine(" ");
        }
    }
}