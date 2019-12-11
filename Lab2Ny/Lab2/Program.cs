using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ShowMenu = true;
            while (ShowMenu)
            {
                ShowMenu = MainMenu();
            }
        }

        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Välj ett alternativ genom att skriva siffran och klicka enter");
            Console.WriteLine("(1) Gångertabell för 1 till 9");
            Console.WriteLine("(2) Kalkylator");
            Console.WriteLine("(3) Slump");
            Console.WriteLine("(4) Avsluta");

            switch(Console.ReadLine())
            {
                case "1":
                Tabell();
                return false;
                
                case "2":
                Kalkylator();
                return false;

                case "3":
                Slump();
                return false;

                case "4":
                return false; 
                default: 
                return true;
            }
        }

        static void Tabell()
        {
        
        int a, b; 
        Console.WriteLine("\n");
            for(a=1;a<=9;a++)
            {
            Console.Write(a+"\t");
            for(b=1;b<=9;b++)
            {
                Console.Write(a*b+ ("\t"));
            }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Vill du återgå till menyn? Programmet kommer avslutas om du svarar nej. (JA/NEJ)");
            string svar = "ja";
            svar = Console.ReadLine();
            svar = svar.ToLower();

            if(svar == "ja")
            {
                MainMenu();
            }
        }

    
        static void Kalkylator()
        {
            
            int i;
            int value;
            
            Console.WriteLine("Skriv in hur många tal du vill använda: ");
            value = int.Parse(Console.ReadLine());
            double[] tal = new double[value];
            Console.WriteLine("Skriv in dina tal, klicka på enter efter varje tal: ");
            for(i=0;i<tal.Length;i++)
            {
                tal[i]=double.Parse(Console.ReadLine());
            }
            Console.Write("\nDina tal är:");
            for(i=0;i<tal.Length;i++)
            {
                Console.Write(" "+tal[i]);
            }
            double sum = 0;
            for(i=0;i<tal.Length;i++)
            {
               sum +=tal[i];
            }
            Console.WriteLine("\nSumman av dina tal är: "+sum);

           double medel = 0;
            for(i=0;i<tal.Length;i++)
            {
                medel +=tal[i]/tal.Length;
            }
            
            Console.WriteLine("Medelvärdet av dina tal är: "+medel);

            double min = tal[0];
            for(i=0;i<tal.Length;i++)
            {
                if(tal[i] < min)
                {
                    min = tal[i];
                }
            }
            Console.WriteLine("Minsta värdet av dina tal är: "+min);

            double max = tal[0];
            for(i=0;i<tal.Length;i++)
            {
                if(tal[i] > max)
                {
                    max = tal[i];
                }
            }
            Console.WriteLine("Största värdet av dina tal är: "+max);            
            Console.WriteLine("\n");
            Console.WriteLine("Vill du återgå till menyn? Programmet kommer avslutas om du svarar nej. (JA/NEJ)");
            string svar = "ja";
            svar = Console.ReadLine();
            svar = svar.ToLower();

            if(svar == "ja")
            {
                MainMenu();
            }
        }

        static void Slump()
        {   
            
            Random ran = new Random();
            int storlek;
            int i;

            Console.WriteLine("Hur många slumpade tal vill du ha?");
            storlek = int.Parse(Console.ReadLine());
            int[] arr = new int[storlek];
            Console.WriteLine("\n");
            Console.WriteLine("Dina slumpade tal är följande: ");
            for (i=0;i<arr.Length;i++)
            {
                arr[i] = ran.Next(1, 100);
                Console.WriteLine(arr[i] +" ");
            }
            Console.WriteLine("\nDin tal i sorterad ordning ser ut sä här: ");
            Array.Sort(arr);
            /*
            foreach(int value in arr)
            {
                Console.Write(value+ " ");
            } */
            for(i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
            Console.WriteLine("\n");         
            Console.WriteLine("Vill du återgå till menyn? Programmet kommer avslutas om du svarar nej. (JA/NEJ)");
            string svar = "ja";
            svar = Console.ReadLine();
            svar = svar.ToLower();

            if(svar == "ja")
            {
                MainMenu();
            }
        }
    }
}
 