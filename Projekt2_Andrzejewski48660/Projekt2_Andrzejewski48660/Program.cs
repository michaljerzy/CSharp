using System;

namespace Projekt2_Andrzejewski48660
{
    class Program
    {//deklaracje metod
        static float maWczytajLiczbęRzeczywistą(string maZaproszenieDoPodaniaDanej)
        {
            float maX;
            Console.Write("\n\t" + maZaproszenieDoPodaniaDanej + ": ");
            //wczytywanie
            while (!float.TryParse(Console.ReadLine(), out maX))
            {
                Console.WriteLine("\n\tERROR: wystąpił niedozwolony znak w zapisie liczby rzeczywistej");
                Console.Write("\n\tponownie " + maZaproszenieDoPodaniaDanej + ": ");
            }
            return maX;
        }
        static void maObliczSumęSzeregu(float maX, float maEps, out float maSumaSzeregu, out int maN)
        {//deklaracje pomocnicze
            float maw; //dla przechowywania wartości n-tego wyrazu szeregu
                     //ustalenie początkowego stanu obliczeń
            maSumaSzeregu = 0.0f;
            maw = maX;
            maN = 0;
            //iteracyjne obliczanie sumy szeregu
            while (Math.Abs(maw) > maEps) //Abs - moduł = |w|
            {// zwiększenie licznika zsumowanych wyrazów szeregu
                maN++;
                //obliczenie n - tej sumy częściowej szeregu
                maSumaSzeregu += maw;
                //obliczenie n - tego wyrazu szeregu
                maw *= (-1.0f) * (float)Math.Pow(maX, 2)*((2 * maN) - 1) / ((2 * maN) + 1);
            }

        }
        static void Main(string[] args)
        {
            // szereg               
            //        n      n    1      2n+1
            // S(x) = E   (-1) -------- X
            //       k = 0        2n+1
            //

            //deklaracje lokalne
            ConsoleKeyInfo maWybranaFunkcjonalność;
            //wypisanie metryki
            Console.WriteLine("\n\tProgram umożlwia obliczania\n\t wybranych wielkości metodami przybliżnymi");
            //wypisywanie aktualnej daty i godziny
            Console.WriteLine("\n\tDzisiejsza data: {0}, godzina: {1}", DateTime.Today.ToShortDateString(), DateTime.Now.ToLongTimeString());

            do
            {//wypisanie menu Programu
                Console.WriteLine("\n\tMenu (funkcjonalne) programu: " +
                    "\n\tA. Obliczanie sumy szeregu potęgowego" +
                    "\n\tB. Tablicowanie wartości szeregu potęgowego" +
                    "\n\tX. Zakończenie (wyjście) działania programu");
                //wypisanie odpowiedzi dla użytkownika
                Console.Write("\n\tNaciśnięciem odpowiedniego klawisza wybierz\n\t jedną z podanych funkcjonalności: ");
                maWybranaFunkcjonalność = Console.ReadKey();
                //Console.Clear();
                //rozpoznanie wybranej funkcjonalnosci
                switch (maWybranaFunkcjonalność.Key)
                {
                    case ConsoleKey.A:
                        //A. Obliczanie sumy szeregu potęgowego
                        //deklaracje lokalne
                        float maX, maEps;
                        //wypisujemy potwierdzenie wybranej funkcjonalności
                        Console.WriteLine("\n\tObliczamy sumę szeregu potęgowego: ");
                        //wczytanie wartości zmiennej niezależnej maX
                        maX = maWczytajLiczbęRzeczywistą("Podaj wartość zmiennej niezależnej maX");
                        //wczytanie dokladności obliczeń
                        do
                        {
                            //wczytanie Eps
                            maEps = maWczytajLiczbęRzeczywistą("Podaj dokładność oliczeń Eps");
                            //sprawdzanie warunku wejściowego
                            if (maEps <= 0 || maEps >= 1.0f)
                            {
                                Console.WriteLine("\n\n\tERROR: dokłaność obliczeń musi być z zakresu od 0 do 1!");
                            }
                        } while (maEps <= 0 || maEps >= 1.0f);
                        //deklaracje pomocnicze
                        float maSumaSzeregu;
                        int maLiczbaWyrazówSzeregu;
                        //wywołanie metody sumującej wyrazy szeregu potęgowego
                        maObliczSumęSzeregu(maX, maEps, out maSumaSzeregu, out maLiczbaWyrazówSzeregu);
                        //wypisanie wyniku obliczeń
                        Console.WriteLine("\n\n\tWyniki obliczeń: suma szeregu: S(X) = {0},\n\t Liczba zsumowanych wyrazów szeregu: n = {1}", maSumaSzeregu, maLiczbaWyrazówSzeregu);

                        Console.WriteLine("\n\n\n\n\\tPress any key to continue...");
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.B:
                        // B. Tablicowanie wartości szeregu potęgowego
                        //deklaracje lokalne
                        float maXd, maXg, maXb, mah, maEpsB;
                        //wypisujemy potwierdzenie wybranej funkcjonalności
                        Console.WriteLine("\n\tObliczamy sumę szeregu potęgowego: ");
                        //wczytanie krańców przedziału zmian wartości maX
                        do
                        {
                            maXd = maWczytajLiczbęRzeczywistą("Podaj wartość zmiennej dolnej granicy \n\tprzedziału zmian wartości zmiennej maX");
                            maXg = maWczytajLiczbęRzeczywistą("Podaj wartość zmiennej gornej granicy \n\tprzedziału zmian wartości zmiennej maX");
                            //sprawdzenie warunku
                            if (maXd >= maXg)
                            {
                                Console.WriteLine("\n\n\tEROR: dolna granica przedziału " +
                                    "zmian wartości zmiennej maX musi być mniejsza od górnej");
                            }
                        } while (maXd >= maXg);
                        //wczytanie kroku 'h' zmian wartości zmiennej
                        do
                        {
                            //wczytanie Eps
                            mah = maWczytajLiczbęRzeczywistą("Podaj wartość kroku 'h' zmian wartości zmiennej");
                            if ((mah == 0) || (mah > (maXg - maXd)))
                            {
                                Console.WriteLine("\n\n\tERROR: krok 'h' zmian zmiennej \n\tniezależnej maX musi być !=0.0 i nie może być większy od\n\tod szerokości przedziału: maXg - maXd");
                            }
                        } while ((mah == 0) || (mah > (maXg - maXd)));
                        //wczytanie dokladności obliczeń
                        do
                        {
                            //wczytanie Eps
                            maEpsB = maWczytajLiczbęRzeczywistą("Podaj dokładność oliczeń Eps");
                            //sprawdzanie warunku wejściowego
                            if (maEpsB <= 0 || maEpsB >= 1.0f)
                            {
                                Console.WriteLine("\n\n\tERROR: dokłaność obliczeń musi być z zakresu od 0 do 1!");
                            }
                        } while (maEpsB <= 0 || maEpsB >= 1.0f);
                        Console.WriteLine("Wybierz w jakim formacie chcesz wyprowadzić tabelkę zmian szeregu");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("A. Wartości w formacie domyślinym");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("B. Wartości w formacie wykładniczym");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("C. Wartości w formacie stałopozycyjnym");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("D. Wartości w formacie zwięzłym");
                        Console.ResetColor();
                        Console.Write("\n\tNaciśnięciem odpowiedniego klawisza wybierz jedną z podanych funkcjonalności: \n ");
                        maWybranaFunkcjonalność = Console.ReadKey();
                        Console.Clear();
                        switch (maWybranaFunkcjonalność.Key)
                        {
                            case ConsoleKey.A:
                                {
                                    for (maXb = maXd; maXb <= maXg; maXb = maXb + mah)
                                    {
                                        //obliczanie sumy szeregu w punkcie maXb oraz wydruk wyniku
                                        maObliczSumęSzeregu(maXb, maEpsB, out maSumaSzeregu, out maLiczbaWyrazówSzeregu);
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("\t\t{0}\t\t",maXb , maSumaSzeregu );
                                        Console.ResetColor();
                                    }
                                    break;
                                }
                            case ConsoleKey.B:
                                {
                                    for (maXb = maXd; maXb <= maXg; maXb = maXb + mah)
                                    {
                                        maObliczSumęSzeregu(maXb, maEpsB, out maSumaSzeregu, out maLiczbaWyrazówSzeregu);
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\t\t{0}\t\t{1,8:E2}\t\t", maXb, maSumaSzeregu);
                                        Console.ResetColor();
                                    }
                                    break;
                                }
                            case ConsoleKey.C:
                                {
                                    Console.WriteLine("\tWartość zmiennej\tWartość szeregu potęgowego\t\t\n");
                                    Console.WriteLine("\t\t______________________");
                                    for (maXb = maXd; maXb <= maXg; maXb = maXb + mah)
                                    {
                                        maObliczSumęSzeregu(maXb, maEpsB, out maSumaSzeregu, out maLiczbaWyrazówSzeregu);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        //Console.WriteLine("\t\tWartość zmiennej\t\tWartość szeregu potęgowego\t\t");
                                        Console.WriteLine("\t\t{0}\t\t{1,8:F2}\t\t", maXb, maSumaSzeregu);
                                        Console.ResetColor();
                                    }
                                    break;
                                }
                            case ConsoleKey.D:
                                {
                                    for (maXb = maXd; maXb <= maXg; maXb = maXb + mah)
                                    {
                                        maObliczSumęSzeregu(maXb, maEpsB, out maSumaSzeregu, out maLiczbaWyrazówSzeregu);
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("\t\t{0}\t\t{1,8:G2}\t\t", maXb, maSumaSzeregu);
                                        Console.ResetColor();
                                    }
                                    break;
                                }
                        }
                        break;
                    case ConsoleKey.X:
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\n\tWybrałeś literę lub znak nienależący do menu!" +
                            "\n\twybierz ponownie jedną z moich funkcjonalności!");
                        System.Threading.Thread.Sleep(2500);
                        break;
                }


            } while (maWybranaFunkcjonalność.Key != ConsoleKey.X);


            //chwilowe zatrzymanie programu
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\tPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
