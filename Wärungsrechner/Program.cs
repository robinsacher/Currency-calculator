namespace Wärungsrechner
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    public class CHF_Zu_Euro
    {
        public double berechne(double betrag)
        {
            
            double wechselkurs = 1.03; // Hier den aktuellen Wechselkurs einfügen
            return betrag * wechselkurs;
        }
    }

    public class CHF_Zu_Dollar
    {
        public double berechne(double betrag)
        {
            
            double wechselkurs = 1.13; // Hier den aktuellen Wechselkurs einfügen
            return betrag * wechselkurs;
        }
    }

    public class Euro_Zu_CHF
    {
        public double berechne(double betrag)
        {
            
            double wechselkurs = 0.97; // Hier den aktuellen Wechselkurs einfügen
            return betrag * wechselkurs;
        }
    }

    public class Euro_Zu_Dollar
    {
        public double berechne(double betrag)
        {
           
            double wechselkurs = 1.09; // Hier den aktuellen Wechselkurs einfügen
            return betrag * wechselkurs;
        }
    }

    public class Dollar_Zu_CHF
    {
        public double berechne(double betrag)
        {
            
            double wechselkurs = 0.88; // Hier den aktuellen Wechselkurs einfügen
            return betrag * wechselkurs;
        }
    }

    public class Dollar_Zu_Euro
    {
        public double berechne(double betrag)
        {
            
            double wechselkurs = 0.91; // Hier den aktuellen Wechselkurs einfügen
            return betrag * wechselkurs;
        }
    }
}