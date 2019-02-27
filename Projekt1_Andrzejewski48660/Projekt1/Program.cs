using System;

namespace Zaliczenie1
{
    class Program
    {
        //Metoda która pozwala w szybki sposób pobrać od użytkownika liczbę elementów "n"
        static int maLiczbyWybórN(char symol)
                {
                    int man;
                    do
                    {   //zapytanie o ilość elementów
                        Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                        //Pobieram od użytkownika liczbę elementów i używam while aby nie powstał błąd wpisania wartości
                        while(!int.TryParse(Console.ReadLine(),out man))
                            {
                                Console.WriteLine("\n\tPopraw to! Podana wartość musi być cyfrą."); 
                                Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                            }
                            //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                            if (man <0)
                                {
                                    Console.WriteLine("\n\tLiczba n musi być dodatnia.");
                                }
                            else
                            //ta instrukacja nie pozwala wprowadzić liczby równej 0
                                if(man==0)
                                {
                                    Console.WriteLine("\n\tLiczba n nie może być 0.");
                                }
                        } while (man <= 0);
                    return man;
                }
        
        //Metoda ta pobiera od użytkownika cyfry w ciągu
        static float maLiczbaA(char nazwa)
        {
            //deklaracja zmiennych
            float maa;
            //pobranie od użytkownika cyfry wraz z warunkiem  
            while (!float.TryParse(Console.ReadLine(), out maa))
            {
                Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                Console.Write("\n\tWpisz ponownie cyfrę: ");
            }
        return maa;
        }

        //Metoda ta pobiera od użytkownika cyfry w ciągu
        static float maLiczbaB(char nazwa)
        {
            //deklaracja zmiennych
            float mab;
            //pobranie od użytkownika liczb ze sprawdzeniem czy to liczba
            while (!float.TryParse(Console.ReadLine(), out mab))
                {
                    Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                    Console.Write("\n\tWpisz ponownie cyfrę: ");
                }
            return mab;
        }
        static float maObliczanieSumyCiągu(int n)
        {   
            //deklaracja zmiennych
            float mas=0.0F;
            string maOdpowiedz;
            float maa=0.0F;
            int mai;
            do
            { 
                //Wywołanie metody pobierającej od użytkownika ilość liczb n
                n=maLiczbyWybórN('n');
                Console.WriteLine("\n\tPodaj liczby ciągu: ");
                //pętla dzięki której możemy pobrać n-razy cyfrę a
                for( mai = 0; mai < n; mai++ )
                {   
                    Console.Write("\n\tLiczba {0} : ",mai+1);
                    maa = maLiczbaA('a');
                    mas += maa;
                }
                Console.Write("\n\tOdpowiedź: {0}", mas);
                Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                maOdpowiedz = Console.ReadLine().ToUpperInvariant();
                mas = 0;
            }while (maOdpowiedz== "T");
            return n;
        }
        static float maObliczanieIloczynuCiągu(int n)
        {            
            string maOdpowiedz;
            do
            {
            //deklaracja zmiennych
            float mas=1, maa;
            int mai;

                //Wywołanie metody pobierającej od użytkownika ilość liczb n
                n = maLiczbyWybórN('n');
                Console.WriteLine("\n\tPodaj liczby ciągu : ");
                //pętla dzięki której możemy pobrać n-razy cyfrę a
                for( mai = 0; mai < n; mai++ )
                    {
                        Console.Write("\n\tLiczba {0} : ",mai+1);
                        //Pobierz od użytkownika kolejny element
                        maa = maLiczbaA('a');
                        mas *= maa;
                    }
                Console.Write("\n\tOdpowiedź: {0}", mas);
                mas=0;
                Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                maOdpowiedz = Console.ReadLine().ToUpper();
            }while (maOdpowiedz== "T");
        return n;    
        }
        static float maObliczanieŚredniejArytmetycznej(int man)
        {
            //deklaracja zmiennych
            int mai;
            float maa, maw = 0.0F;
            string maOdpowiedz;
            do
            {                      
                //Wywołanie metody pobierającej od użytkownika ilość liczb n
                man=maLiczbyWybórN('n');
                //pętla dzięki której możemy pobrać n-razy cyfrę a
                for( mai = 0; mai < man; mai++ )
                    {
                        Console.Write("\n\tLiczba {0} : ",mai+1);
                        //Wywołanie metody pobierjącej od użytkonika liczby a
                        maa = maLiczbaA('a');
                        maw += maa;
                    }
                //Pokaz wynik
                Console.WriteLine("Średnia artmetyczna wynosi: {0}", maw/man);
                Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                maOdpowiedz = Console.ReadLine().ToUpper();
                maw=0;
                man=0;
            }while (maOdpowiedz== "T");
        return man;
        }
        static int maObliczanieŚredniejWażonej(int man)
        {
            //deklaracja zmiennych
            float maq=0.0F, mak=0.0F, maa, mab;
            string maOdpowiedz;
            do{
                //Wywołanie metody pobierającej od użytkownika ilość liczb n
                man = maLiczbyWybórN('n');
                //pętla dzięki której możemy pobrać n-razy cyfrę a oraz wagę liczby
                for(int mai = 0; mai<man; mai++)    
                {
                    do
                    {
                        Console.Write("\n\tLiczba {0} : ",mai+1);
                        //poobranie od użytkownika wartości liczb ciągu oraz warunek o przyjmowaniu tylko liczb
                        while (!float.TryParse(Console.ReadLine(), out maa))
                        {
                            Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                            Console.Write("\n\tWpisz ponownie liczbę: ");
                        }
                        //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                        if (maa <0)
                        {
                            Console.WriteLine("\n\tLiczba a musi być dodatnia.");
                        }
                    }while(maa<0);
                    do
                    {
                    Console.Write("Wprowadź wagę liczby {0} : ",mai+1);
                    //poobranie od użytkownika wagi liczb ciągu oraz warunek o przyjmowaniu tylko liczb
                    while (!float.TryParse(Console.ReadLine(), out mab))
                    {
                        Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                        Console.Write("\n\tWpisz ponownie wagę: ");
                    }
                    if (mab <0)
                    {
                        Console.WriteLine("\n\tWaga liczby musi być dodatnia.");
                    }
                    }while(mab<=0);
                //sumowanie iloczynu wartości liczb oraz ich wagi
                mak+=maa*mab;
                //sumowanie wagi liczb
                maq+=mab;                                             
                }
                Console.Write("\n\tWynik: {0}",mak/maq);
                mak=0;
                maq=0;
                Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                maOdpowiedz = Console.ReadLine().ToUpper();
            }while (maOdpowiedz== "T");
        return man;
        }
        static float maObliczanieŚredniejHarmonicznej(int man)
        {
            float maq=0.0F,map=0.0F, maa=0.0F;
            string maOdpowiedz;
            do
            {
                //Wywołanie metody pobierającej od użytkownika ilość liczb n
                maa=maLiczbyWybórN('n');
                //pętla dzięki której możemy pobrać n-razy cyfrę a
                for(int i = 0; i<maa; i++)    
                    {
                        Console.Write("\n\tLiczba {0} : ",i+1);
                        //Wywołanie metody pobierjącej od użytkonika liczby a
                        maa = maLiczbaA('a');
                        maq+=1/maa;
                        map=maa/maq;
                    }
                Console.Write("\n\tŚrednia harmoniczna wynosi: {0}",map);
                map=0;
                Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                maOdpowiedz = Console.ReadLine().ToUpper();
            }while (maOdpowiedz== "T");

            return man;
        }
        static float maObliczanieŚredniejGeometrycznej(int man)
        {
            float mar=1.0f, maq=0.0f, maa;
            string maOdpowiedz;
            do
            {
                //Wywołanie metody pobierającej od użytkownika ilość liczb n
                man = maLiczbyWybórN('n');
                float wynik=0;
                int i;
                //pętla dzięki której możemy pobrać n-razy cyfrę a
                for(i = 0; i<man; i++)    
                {
                    Console.Write("\n\tLiczba {0} : ",i+1);
                    //Wywołanie metody pobierjącej od użytkonika liczby a
                    maa = maLiczbaA('a');
                    maq=1.0f/man;
                    mar=mar*maa;
                    //wynik = (float)Math.Pow(r,q);
                }
                wynik = (float)Math.Pow(mar,maq);
                Console.Write("\n\tŚrednia geometryczna wynosi: {0}",wynik  );
                wynik = 0;
                Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                maOdpowiedz = Console.ReadLine().ToUpper();
            }while (maOdpowiedz== "T");
        return man;
        }
        static float maObliczanieŚredniejKwadratowej(int man)
        {
            int mai;
            float maq=0.0F, mar=0.0F, map=0.0F, maa;
            string maOdpowiedz;
            do
            {
                //Wywołanie metody pobierającej od użytkownika ilość liczb n
                man= maLiczbyWybórN('n');
                Console.WriteLine("\n\tWprowadź cyfry: ");
                //pętla dzięki której możemy pobrać n-razy cyfrę a
                for(mai = 0; mai<man; mai++)    
                    {
                        Console.Write("\n\tLiczba {0} : ",mai+1);
                        //Wywołanie metody pobierjącej od użytkonika liczby a
                        maa = maLiczbaA('a');
                        //funkcja podnosząca do potęgi
                        maq += (float)Math.Pow(maa,2);
                        mar = maq/man;
                        //funkcja pierwiastkująca
                        map = (float)Math.Sqrt(mar);    
                    }
                Console.Write("Średnia kwadratowa wynosi: {0}", map);
                map=0;
                Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                maOdpowiedz = Console.ReadLine().ToUpper();
            }while (maOdpowiedz== "T");
            return man;
        }
        static float maObliczanieŚredniejPotęgowej(int man)
        {
            //deklaracja zmiennych
            float mar=0.0F,maq=0.0F,mat=0.0F, maa, mab;
            int mai;
            string maOdpowiedz;
            do
            {            
                Console.Write("\n\tProgram do obliczania średniej uogólnionej"+
                "\n\tJeśli wprowadzisz rząd -1 zostanie obliczona średnia harmoniczna"+
                "\n\tJeśli wprowadzisz rząd 0 zostanie obliczona średnia geometryczna"+
                "\n\tJeśli wprowadzisz rząd 1 zostanie obliczona średnia arytmetyczna"+
                "\n\tJeśli wprowadzisz rząd 2 zostanie obliczona średnia kwadratowa"+
                "\n\tJeśli wprowadzisz liczbę inną od wypisanych zostanie obliczona średnia potęgowa");
                Console.Write("\n\tWprowadź średnią uogólnioną(rząd) : ");
                //Wywołanie metody pobierjącej od użytkonika liczby średnią uogólnioną
                mab = maLiczbaB('b');
                switch(mab)
                {
                    case -1:
                    {
                        maObliczanieŚredniejHarmonicznej('n');
                    break;
                    }
                    case 0:
                    {
                        maObliczanieŚredniejGeometrycznej('n');
                    break;
                    }
                    case 1:
                    {
                        maObliczanieŚredniejArytmetycznej('n');
                    break;
                    }
                    case 2:
                    {
                        maObliczanieŚredniejKwadratowej('n');
                    break;
                    }
                    default:
                    {
                        Console.WriteLine("\n\tWprowadź liczby: ");
                        //pętla dzięki której możemy pobrać n-razy cyfrę a
                        for(mai = 0; mai<man; mai++)    
                        {    
                            Console.Write("\n\tLiczba {0} : ",mai+1);
                            //Wywołanie metody pobierjącej od użytkonika liczby a
                            maa = maLiczbaA('a');

                            mar += (float)Math.Pow(maa,mab);
                            maq = mar/man;
                            mat = (float)Math.Pow(maq,1/mab);
                        }
                        Console.Write("\n\tŚrednia potęgowa wynosi: {0}", mat);
                    break;
                    }
                }
                Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                maOdpowiedz = Console.ReadLine().ToUpper();
            }while (maOdpowiedz== "T");
        return man;
        }
        static float maObliczanieCenyJednostkiPaszy(int man)
        {
            //deklaracja zmiennych
            float maq=0, mak=0, maa, mab;
            int mai;
            string maOdpowiedz;
            do
            {
                man = maLiczbyWybórN('n');
                //pętla dzięki której możemy pobrać n-razy cyfrę a
                for(mai = 0; mai<man; mai++)    
                {  
                    do
                    {
                        //poobranie od użytkownika ilości kilogramów paszy oraz warunek o przyjmowaniu tylko liczb
                        Console.Write("Wprowadź ilość kilogramów paszy: ");
                        while (!float.TryParse(Console.ReadLine(), out maa))
                        {
                            Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                            Console.Write("\n\tWpisz ponownie cyfrę: ");
                        }
                        //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                        if (maa <0)
                        {
                            Console.WriteLine("\n\tWaga musi być dodatnia.");
                        }
                    } while (maa <0);
                    //poobranie od użytkownika ceny paszy oraz warunek o przyjmowaniu tylko liczb
                    do
                    {
                        Console.Write("Wprowadź cenę paszy: ");
                        while (!float.TryParse(Console.ReadLine(), out mab))
                        {
                            Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                            Console.Write("\n\tWpisz ponownie cyfrę: ");
                        }
                        //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                        if (mab <0)
                        {
                            Console.WriteLine("\n\tCena musi być dodatnia.");
                        }
                    }while(mab<=0);
                    //wymnożenie masy paszy i jej ceny
                    mak+=maa*mab;
                    //suma masy paszy
                    maq+=maa;                                          
                }
                Console.Write("\n\tśrednia cena paszy wynosi: {0}",mak/maq);
                mak=0;
                maq=0;
                Console.Write("\n\n\n\tCzy chcesz ponownie obliczyć cenę paszy? (T/N) ");
                maOdpowiedz = Console.ReadLine().ToUpper();
            }while (maOdpowiedz== "T");
        return man;
        }

        static void Main(string[] args)
        {
            string mawybor, maOdpowiedz;
            float maa, mab;
            int man=0,mai;
            //Console.BackgroundColor=ConsoleColor.DarkRed;
            do{
                Console.Clear();
                //Opis programu
                Console.WriteLine("\n\tProgram do obliczania sumy ciągów, iloczynu ciągów...itp. ");
                //pokazuję użytkownikowi wszystkie fukncjie mojego programu 
                Console.WriteLine("\n\t Funkcje programu: ");
                Console.WriteLine("\n\tA.Obliczanie sumy wyrazów ciągu liczbowego (in-line)");
                Console.WriteLine("\n\tB.Obliczanie sumy wyrazów ciągu liczbowego (wywołanie metody)");
                Console.WriteLine("\n\tC.Obliczanie iloczynu wyrazów ciągu liczbowego (in-line)");
                Console.WriteLine("\n\tD.Obliczanie iloczynu wyrazów ciągu liczbowego (wywołanie metody)");
                Console.WriteLine("\n\tE.Obliczanie średniej artmetycznej (in-line)");
                Console.WriteLine("\n\tF.Obliczanie średniej artmetycznej (wywołanie metody)");
                Console.WriteLine("\n\tG.Obliczanie średniej ważonej (in-line)");
                Console.WriteLine("\n\tH.Obliczanie średniej ważonej (wywoływanie metody)");
                Console.WriteLine("\n\tI.Obliczanie ceny jednostki paszy (in-line)");
                Console.WriteLine("\n\tJ.Obliczanie ceny jednostki paszy (wywoływanie metody)");
                Console.WriteLine("\n\tK.Obliczanie średniej harmonicznej (in-line)");
                Console.WriteLine("\n\tL.Obliczanie średniej harmonicznej (wywoływanie metody)");
                Console.WriteLine("\n\tM.Obliczanie średniej geometrycznej (in-line)");
                Console.WriteLine("\n\tR.Obliczanie średniej geometrycznej (wywoływanie metody)");
                Console.WriteLine("\n\tS.Obliczanie średniej kwadratowej (in-line)");
                Console.WriteLine("\n\tT.Obliczanie średniej kwadratowej (wywoływanie metody)");
                Console.WriteLine("\n\tQ.Obliczanie średniej potęgowej <średniej uogólnionej> (in-line)");
                Console.WriteLine("\n\tU.Obliczanie średniej potęgowej <średniej uogólnionej> (wywoływanie metody)");
                Console.WriteLine("\n\tX.Zakończenie (wyjście z) programu");

                //wyświetla komunikat o wybo rze funkcji
                Console.Write("\n\t Którą opcję wybierasz : ");

                //wybór funkcji

                mawybor = Console.ReadLine();
                mawybor = mawybor.ToLower();
                Console.Clear(); 
                switch (mawybor)
                {
                    //A.Obliczanie sumy wyrazów ciągu liczbowego (in-line)
                    case "a":
                    {
                    float mas=0;    
                    //Pobieriam od użytkownika liczbe elementów
                    do
                    {                       
                        do
                        {   //zapytanie o ilość elementów
                            Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                            //Pobieram od użytkownika liczbę elementów i używam while aby nie powstał błąd wpisania wartości
                            while(!int.TryParse(Console.ReadLine(),out man))
                                {
                                    Console.WriteLine("\n\tPopraw to! Podana wartość musi być cyfrą."); 
                                    Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                }
                                //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                if (man <0)
                                {
                                    Console.WriteLine("\n\tLiczba n musi być dodatnia.");
                                }
                                else
                                //ta instrukacja nie pozwala wprowadzić liczby równej 0
                                    if(man==0)
                                    {
                                        Console.WriteLine("\n\tLiczba n nie może być 0.");
                                    }
                            } while (man <= 0);

                            //Pobieram od użytkownika liczby ciągu
                            Console.WriteLine("\n\tPodaj liczby ciągu: ");
                            //pętla dzięki której możemy pobrać n-razy cyfrę a
                            for( mai = 0; mai < man; mai++ )
                            {
                                Console.Write("\n\tLiczba {0} : ", mai+1);
                                //nie pozwala na wprowadzenie wartości innych niż liczby
                                while (!float.TryParse(Console.ReadLine(), out maa))
                                    {
                                        Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                                        Console.Write("\n\tWpisz ponownie cyfrę: ");
                                    }
                                //sumowanie liczb    
                                mas += maa;
                            }
                            //wypisanie odpowiedzi
                            Console.Write("\n\tOdpowiedź: {0}", mas);
                            mas=0;
                            Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                            maOdpowiedz = Console.ReadLine().ToUpper();
                        }while (maOdpowiedz== "T");

                    break;
                    }
                    //B.Obliczanie sumy wyrazów ciągu liczbowego (wywołanie metody)
                    case "b":
                    {
                        maObliczanieSumyCiągu('n');
                        break;
                    }
                    //C.Obliczanie iloczynu wyrazów ciągu liczbowego (in-line)
                    case "c":
                    {
                        float mas=1;
                        do
                        {
                            do
                            {   //zapytanie o ilość elementów
                                Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                //Pobieram od użytkownika liczbę elementów i używam while aby nie powstał błąd wpisania wartości
                                while(!int.TryParse(Console.ReadLine(),out man))
                                    {
                                        Console.WriteLine("\n\tPopraw to! Podana wartość musi być cyfrą."); 
                                        Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                    }
                                    //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                    if (man <0)
                                    {
                                        Console.WriteLine("\n\tLiczba n musi być dodatnia.");
                                    }
                                    else
                                    //ta instrukacja nie pozwala wprowadzić liczby równej 0
                                        if(man==0)
                                        {
                                            Console.WriteLine("\n\tLiczba n nie może być 0.");
                                        }
                            } while (man <= 0);


                            Console.WriteLine("\n\tPodaj liczby ciągu: ");
                            //pętla dzięki której możemy pobrać n-razy cyfrę a
                            for( mai = 0; mai < man; mai++ )
                                {
                                    Console.Write("\n\tLiczba {0} : ",mai+1);
                                    //poobranie od użytkownika wartości liczb ciągu oraz warunek o przyjmowaniu tylko liczb
                                    while (!float.TryParse(Console.ReadLine(), out maa))
                                        {
                                            Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                                            Console.Write("\n\tWpisz ponownie cyfrę: ");
                                        }
                                    //wymnażanie wszykstkich wyrazów ciągu
                                    mas *= maa;
                                }
                            //wypisanie odpowiedzi
                            Console.Write("\n\tOdpowiedź: {0}", mas);
                            mas=0;
                            Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                            maOdpowiedz = Console.ReadLine().ToUpper();
                        }while (maOdpowiedz== "T");
                            break;
                    }
                    //D.Obliczanie iloczynu wyrazów ciągu liczbowego (wywołanie metody)"
                    case "d":
                    {
                    maObliczanieIloczynuCiągu('n');
                        break;
                    }
                    //E.Obliczanie średniej artmetycznej (in-line)
                    case "e":
                    {
                    float maw = 0.0F;
                    
                    do
                    {
                        do
                        {   //zapytanie o ilość elementów
                            Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                            //Pobieram od użytkownika liczbę elementów i używam while aby nie powstał błąd wpisania wartości
                            while(!int.TryParse(Console.ReadLine(),out man))
                                {
                                    Console.WriteLine("\n\tPopraw to! Podana wartość musi być cyfrą."); 
                                    Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                }
                                //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                if (man <0)
                                {
                                    Console.WriteLine("\n\tLiczba n musi być dodatnia.");
                                }
                                else
                                //ta instrukacja nie pozwala wprowadzić liczby równej 0
                                    if(man==0)
                                    {
                                        Console.WriteLine("\n\tLiczba n nie może być 0.");
                                    }
                        } while (man <= 0);
                        //pętla dzięki której możemy pobrać n-razy cyfrę a
                        for( mai = 0; mai < man; mai++ )
                            {
                                Console.Write("\n\tLiczba {0} : ",mai+1);
                                //poobranie od użytkownika wartości liczb ciągu oraz warunek o przyjmowaniu tylko liczb
                                while (!float.TryParse(Console.ReadLine(), out maa))
                                    {
                                        Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                                        Console.Write("\n\tWpisz ponownie cyfrę: ");
                                    }
                                //sumowanie wszystkich wyrazów ciągu
                                maw += maa;
                            }
                        //Podzielenie sumy ciągu przez ilość liczb zawartych w nim oraz wypisanie wyniku
                        Console.WriteLine("Średnia artmetyczna wynosi: {0}", maw/man);
                        maw=0;
                        man=0;
                        Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                        maOdpowiedz = Console.ReadLine().ToUpper();
                    }while (maOdpowiedz== "T");
                    break;
                    }
                    //F.Obliczanie średniej artmetycznej (wywołanie metody)
                    case "f":
                    {
                    maObliczanieŚredniejArytmetycznej('n');
                        break;
                    }
                    //G.Obliczanie średniej ważonej (in-line)
                    case "g":
                    {
                        float maq=0, mak=0;
                    do
                    {
                        do
                        {   //zapytanie o ilość elementów
                            Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                            //Pobieram od użytkownika liczbę elementów i używam while aby nie powstał błąd wpisania wartości
                            while(!int.TryParse(Console.ReadLine(),out man))
                                {
                                    Console.Write("\n\tPopraw to! Podana wartość musi być cyfrą." 
                                    + "Cyfra: ");
                                }
                                //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                if (man <0)
                                {
                                    Console.WriteLine("\n\tLiczba n musi być dodatnia.");
                                }
                                else
                                //ta instrukacja nie pozwala wprowadzić liczby równej 0
                                if(man==0)
                                {
                                    Console.WriteLine("\n\tLiczba n nie może być 0.");
                                }
                        } while (man <= 0);
                                
                                
                                Console.WriteLine("\n\tPodaj liczby ciągu: ");
                                for(mai = 0; mai<man; mai++)    
                                {
                                    do
                                    {
                                        Console.Write("\n\tLiczba {0} : ",mai+1);
                                        //poobranie od użytkownika wartości liczb ciągu oraz warunek o przyjmowaniu tylko liczb
                                        while (!float.TryParse(Console.ReadLine(), out maa))
                                            {
                                                Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                                                Console.Write("\n\tWpisz ponownie liczbę: ");
                                            }
                                            //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                            if (maa <0)
                                            {
                                                Console.WriteLine("\n\tLiczba a musi być dodatnia.");
                                            }
                                        }while(maa<0);
                                    do
                                    {
                                        Console.Write("Wprowadź wagę liczby {0} : ",mai+1);
                                        //poobranie od użytkownika wagi liczb ciągu oraz warunek o przyjmowaniu tylko liczb
                                        while (!float.TryParse(Console.ReadLine(), out mab))
                                            {
                                                Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                                                Console.Write("\n\tWpisz ponownie wagę: ");
                                            }
                                            if (mab <0)
                                            {
                                                Console.WriteLine("\n\tWaga liczby musi być dodatnia.");
                                            }
                                    }while(mab<=0);
                                    //sumowanie iloczynu wartości liczb oraz ich wagi
                                    mak+=maa*mab;
                                    //sumowanie wagi liczb
                                    maq+=mab;                                
                                }
                            //podzielenie zmiennej k przez q i wypisanie wyniku
                            Console.Write("\n\tWynik: {0}",mak/maq);
                            mak=0;
                            maq=0;
                            Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                            maOdpowiedz = Console.ReadLine().ToUpper();
                        }while (maOdpowiedz== "T");
                        break;
                    }
                    //H.Obliczanie średniej ważonej (wywoływanie metody)
                    case "h":
                    {
                    maObliczanieŚredniejWażonej('n');
                        break;
                    }
                    //I.Obliczanie ceny jednostki paszy (in-line)
                    case "i":
                    {
                    //deklaracja zmiennych
                    float maq=0, mak=0;
                    do
                    {
                        do
                        {   //zapytanie o ilość elementów
                            Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                            //Pobieram od użytkownika liczbę elementów i używam while aby nie powstał błąd wpisania wartości
                            while(!int.TryParse(Console.ReadLine(),out man))
                                {
                                    Console.WriteLine("\n\tPopraw to! Podana wartość musi być cyfrą."); 
                                    Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                }
                                //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                if (man <0)
                                {
                                    Console.WriteLine("\n\tLiczba n musi być dodatnia.");
                                }
                                else
                                //ta instrukacja nie pozwala wprowadzić liczby równej 0
                                    if(man==0)
                                    {
                                        Console.WriteLine("\n\tLiczba n nie może być 0.");
                                    }
                            } while (man <= 0);

                            for(mai = 0; mai<man; mai++)    
                                {
                                    
                                    do{
                                        //poobranie od użytkownika ilości kilogramów paszy oraz warunek o przyjmowaniu tylko liczb
                                        Console.Write("Wprowadź ilość kilogramów paszy: ");
                                        while (!float.TryParse(Console.ReadLine(), out maa))
                                            {
                                                Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                                                Console.Write("\n\tWpisz ponownie cyfrę: ");
                                            }
                                            //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                            if (maa <0)
                                            {
                                                Console.WriteLine("\n\tWaga musi być dodatnia.");
                                            }
                                    } while (maa <0);
                                    //poobranie od użytkownika ceny paszy oraz warunek o przyjmowaniu tylko liczb
                                    do
                                    {
                                        Console.Write("Wprowadź cenę paszy: ");
                                        while (!float.TryParse(Console.ReadLine(), out mab))
                                            {
                                                Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                                                Console.Write("\n\tWpisz ponownie cyfrę: ");
                                            }
                                            //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                            if (mab <0)
                                            {
                                                Console.WriteLine("\n\tCena musi być dodatnia.");
                                            }
                                    }while(mab<=0);
                                    //wymnożenie masy paszy i jej ceny
                                    mak+=maa*mab;
                                    //suma masy paszy
                                    maq+=maa;                                
                                }
                            //podzielenie przez siebie iloczynu masy i ceny
                            //podzielenie przez sumę masy paszy i wypisanie wyniku
                            Console.Write("\n\tśrednia cena paszy wynosi: {0}",mak/maq);
                            mak=0;
                            maq=0;
                            Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                            maOdpowiedz = Console.ReadLine().ToUpper();
                        }while (maOdpowiedz== "T");
                        
                        break;
                    }
                    //J.Obliczanie ceny jednostki paszy (wywoływanie metody)
                    case "j":
                    {
                        maObliczanieCenyJednostkiPaszy('n');
                        break;
                    }
                    //K.Obliczanie średniej harmonicznej (in-line)
                    case "k":
                    {
                    float maq=0;
                    do
                    {
                        do
                        {   //zapytanie o ilość elementów
                            Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                            //Pobieram od użytkownika liczbę elementów i używam while aby nie powstał błąd wpisania wartości
                            while(!int.TryParse(Console.ReadLine(),out man))
                                {
                                    Console.WriteLine("\n\tPopraw to! Podana wartość musi być cyfrą."); 
                                    Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                }
                                //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                if (man <0)
                                {
                                    Console.WriteLine("\n\tLiczba n musi być dodatnia.");
                                }
                                else
                                //ta instrukacja nie pozwala wprowadzić liczby równej 0
                                    if(man==0)
                                    {
                                        Console.WriteLine("\n\tLiczba n nie może być 0.");
                                    }
                            } while (man <= 0);

                            for(mai = 0; mai<man; mai++)    
                            {
                                Console.Write("\n\tLiczba {0}: ",mai+1);
                                //poobranie od użytkownika wartości liczb ciągu oraz warunek o przyjmowaniu tylko liczb
                                while (!float.TryParse(Console.ReadLine(), out maa))
                                    {
                                        Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                                        Console.Write("\n\tWpisz ponownie cyfrę: ");
                                    }
                                    //sprowadzenie liczby a do ułamka
                                    maq+=1/maa;
                            }
                            //obliczenie wraz z wypisaniem
                            Console.Write("\n\tŚrednia harmoniczna wynosi: {0}",man/maq);
                            man=0;
                            maq=0;
                            Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                            maOdpowiedz = Console.ReadLine().ToUpper();
                        }while (maOdpowiedz== "T");

                        break;
                    }
                    //L.Obliczanie średniej harmonicznej (wywoływanie metody)
                    case "l":
                    {
                        maObliczanieŚredniejHarmonicznej('n');
                        break;
                    }
                    //M.Obliczanie średniej geometrycznej (in-line)
                    case "m":
                    {
                        float mar=1.0f, maq=0.0f, mawynik=0;
                        do
                        {
                            do
                            {   //zapytanie o ilość elementów
                                Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                //Pobieram od użytkownika liczbę elementów i używam while aby nie powstał błąd wpisania wartości
                                while(!int.TryParse(Console.ReadLine(),out man))
                                    {
                                        Console.WriteLine("\n\tPopraw to! Podana wartość musi być cyfrą."); 
                                        Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                    }
                                    //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                    if (man <0)
                                    {
                                        Console.WriteLine("\n\tLiczba n musi być dodatnia.");
                                    }
                                    else
                                    //ta instrukacja nie pozwala wprowadzić liczby równej 0
                                    if(man==0)
                                        {
                                            Console.WriteLine("\n\tLiczba n nie może być 0.");
                                        }
                                } while (man <= 0);
                            Console.WriteLine("\n\tWprowadź cyfry: ");                      
                            for(mai = 0; mai<man; mai++)    
                                {
                                Console.Write("\n\tLiczba {0}: ",mai+1);
                                    //poobranie od użytkownika wartości liczb ciągu oraz warunek o przyjmowaniu tylko liczb
                                    while (!float.TryParse(Console.ReadLine(), out maa))
                                    {
                                        Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                                        Console.Write("\n\tWpisz ponownie cyfrę: ");
                                    }
                                    //Sprowadzenie liczby n do ułamka 
                                    maq=1.0F/man;
                                    //wymnożenie wszystkich liczb ciągu
                                    mar*=maa;
                                    //wynik = (float)Math.Pow(r,q);
                                }
                                //wprowadzenie zmiennych do funkcji math
                                mawynik = (float)Math.Pow(mar,maq);
                                //wypisanie wyniku
                            Console.Write("\n\tŚrednia geometryczna wynosi: {0}",mawynik  );
                            mawynik=0;
                            Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                            maOdpowiedz = Console.ReadLine().ToUpper();
                        }while (maOdpowiedz== "T");
                        break;
                    }
                    //Obliczanie średniej geometrycznej (wywoływanie metody)
                    case "r":
                    {
                    maObliczanieŚredniejGeometrycznej('n');
                        break;
                    }
                    //Obliczanie średniej kwadratowej (in-line)
                    case "s":
                    {
                        float maq=0.0F, mar=0.0F, map=0.0F;
                        //wywołanie metody na pobieranie ilości elementów w ciągu
                    do
                    {
                        do
                        {   //zapytanie o ilość elementów
                            Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                            //Pobieram od użytkownika liczbę elementów i używam while aby nie powstał błąd wpisania wartości
                            while(!int.TryParse(Console.ReadLine(),out man))
                                {
                                    Console.WriteLine("\n\tPopraw to! Podana wartość musi być cyfrą."); 
                                    Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                }
                                //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                if (man <0)
                                {
                                    Console.WriteLine("\n\tLiczba n musi być dodatnia.");
                                }
                                else
                                //ta instrukacja nie pozwala wprowadzić liczby równej 0
                                    if(man==0)
                                    {
                                        Console.WriteLine("\n\tLiczba n nie może być 0.");
                                    }
                        } while (man <= 0);

                            Console.WriteLine("\n\tWprowadź cyfry: ");
                            //pętla dzięki której możemy pobrać n-razy cyfrę a
                            for(mai = 0; mai<man; mai++)    
                                {   //pobranie od użytkownika liczb wraz ze sprawdzeniem 
                                    Console.Write("\n\tCyfra {0}: ",mai+1);
                                    while (!float.TryParse(Console.ReadLine(), out maa))
                                    {
                                        Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                                        Console.Write("\n\tWpisz ponownie cyfrę: ");
                                    }
                                        //funkcja podnosząca do potęgi
                                        maq += (float)Math.Pow(maa,2);

                                        mar = maq/man;
                                        //funkcja pierwiastkująca
                                        map = (float)Math.Sqrt(mar);
                                        
                                }
                                Console.Write("Średnia kwadratowa wynosi: {0}", map);
                                map=0;
                                Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                                maOdpowiedz = Console.ReadLine().ToUpper();
                            }while (maOdpowiedz== "T");
                        break;
                    }
                    //T.Obliczanie średniej kwadratowej (wywoływanie metody)
                    case "t":
                    {
                    maObliczanieŚredniejKwadratowej('n');
                        break;
                    }
                    //Q.Obliczanie średniej potęgowej <średniej uogólnionej> (in-line)
                    case "q":
                    {
                        float mar=0.0F,maq=0.0F,mat=0.0F,mawynik=0.0F,maw=0.0F,map=0.0F;

                        do{   
                        //pobieranie średniej uogólnionej(potęgowej)
                        Console.Write("\n\tProgram do obliczania średniej uogólnionej"+
                        "\n\tJeśli wprowadzisz rząd -1 zostanie obliczona średnia harmoniczna"+
                        "\n\tJeśli wprowadzisz rząd 0 zostanie obliczona średnia geometryczna"+
                        "\n\tJeśli wprowadzisz rząd 1 zostanie obliczona średnia arytmetyczna"+
                        "\n\tJeśli wprowadzisz rząd 2 zostanie obliczona średnia kwadratowa"+
                        "\n\tJeśli wprowadzisz liczbę inną od wypisanych zostanie obliczona średnia potęgowa");
                        Console.Write("\n\tWprowadź średnią uogólnioną(rząd) : ");
                        while (!float.TryParse(Console.ReadLine(), out mab))
                        {
                            Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                            Console.Write("\n\tWpisz ponownie cyfrę: ");
                        }
                        switch(mab)
                        {
                            case -1:
                            {
                                do
                                {   //zapytanie o ilość elementów
                                    Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                    //Pobieram od użytkownika liczbę elementów i używam while aby nie powstał błąd wpisania wartości
                                    while(!int.TryParse(Console.ReadLine(),out man))
                                        {
                                            Console.WriteLine("\n\tPopraw to! Podana wartość musi być cyfrą."); 
                                            Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                        }
                                        //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                        if (man <0)
                                        {
                                            Console.WriteLine("\n\tLiczba n musi być dodatnia.");
                                        }
                                        else
                                        //ta instrukacja nie pozwala wprowadzić liczby równej 0
                                            if(man==0)
                                            {
                                                Console.WriteLine("\n\tLiczba n nie może być 0.");
                                            }
                                    } while (man <= 0);

                                for(mai = 0; mai<man; mai++)    
                                {
                                    Console.Write("\n\tLiczba {0}: ",mai+1);
                                    //poobranie od użytkownika wartości liczb ciągu oraz warunek o przyjmowaniu tylko liczb
                                    while (!float.TryParse(Console.ReadLine(), out maa))
                                        {
                                            Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                                            Console.Write("\n\tWpisz ponownie cyfrę: ");
                                        }
                                        //sprowadzenie liczby a do ułamka
                                        maq+=1/maa;
                                }
                                //obliczenie wraz z wypisaniem
                                Console.Write("\n\tŚrednia harmoniczna wynosi: {0}",man/maq);
                                man=0;
                                maq=0;
                                break;
                            }
                            

                            case 0:
                            {
                                do
                                {   //zapytanie o ilość elementów
                                    Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                    //Pobieram od użytkownika liczbę elementów i używam while aby nie powstał błąd wpisania wartości
                                    while(!int.TryParse(Console.ReadLine(),out man))
                                        {
                                            Console.WriteLine("\n\tPopraw to! Podana wartość musi być cyfrą."); 
                                            Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                        }
                                        //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                        if (man <0)
                                        {
                                            Console.WriteLine("\n\tLiczba n musi być dodatnia.");
                                        }
                                        else
                                        //ta instrukacja nie pozwala wprowadzić liczby równej 0
                                        if(man==0)
                                            {
                                                Console.WriteLine("\n\tLiczba n nie może być 0.");
                                            }
                                    } while (man <= 0);
                                    Console.WriteLine("\n\tWprowadź cyfry: ");                      
                                    for(mai = 0; mai<man; mai++)    
                                    {
                                        Console.Write("\n\tLiczba {0}: ",mai+1);
                                        //poobranie od użytkownika wartości liczb ciągu oraz warunek o przyjmowaniu tylko liczb
                                        while (!float.TryParse(Console.ReadLine(), out maa))
                                        {
                                            Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                                            Console.Write("\n\tWpisz ponownie cyfrę: ");
                                        }
                                        //Sprowadzenie liczby n do ułamka 
                                        maq=1.0F/man;
                                        //wymnożenie wszystkich liczb ciągu
                                        mar*=maa;
                                        //wynik = (float)Math.Pow(r,q);
                                    }
                                    //wprowadzenie zmiennych do funkcji math
                                    mawynik = (float)Math.Pow(mar,maq);
                                    //wypisanie wyniku
                                    Console.Write("\n\tŚrednia geometryczna wynosi: {0}",mawynik  );
                                    mawynik=0;
                            break;
                            }

                            case 1:
                            {
                                    do
                                    {   //zapytanie o ilość elementów
                                        Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                        //Pobieram od użytkownika liczbę elementów i używam while aby nie powstał błąd wpisania wartości
                                        while(!int.TryParse(Console.ReadLine(),out man))
                                            {
                                                Console.WriteLine("\n\tPopraw to! Podana wartość musi być cyfrą."); 
                                                Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                            }
                                            //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                            if (man <0)
                                            {
                                                Console.WriteLine("\n\tLiczba n musi być dodatnia.");
                                            }
                                            else
                                            //ta instrukacja nie pozwala wprowadzić liczby równej 0
                                                if(man==0)
                                                {
                                                    Console.WriteLine("\n\tLiczba n nie może być 0.");
                                                }
                                    } while (man <= 0);
                                    //pętla dzięki której możemy pobrać n-razy cyfrę a
                                    for( mai = 0; mai < man; mai++ )
                                        {
                                            Console.Write("\n\tLiczba {0} : ",mai+1);
                                            //poobranie od użytkownika wartości liczb ciągu oraz warunek o przyjmowaniu tylko liczb
                                            while (!float.TryParse(Console.ReadLine(), out maa))
                                                {
                                                    Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                                                    Console.Write("\n\tWpisz ponownie cyfrę: ");
                                                }
                                            //sumowanie wszystkich wyrazów ciągu
                                            maw += maa;
                                        }
                                    Console.Write("\n\tŚrednia arytmetyczna wynosi: {0}",maw/man);
                                    //Podzielenie sumy ciągu przez ilość liczb zawartych w nim oraz wypisanie wyniku
                                    maw=0;
                                    man=0;
                                    
                            break;
                            }
                            case 2:
                            {
                                do
                                {   //zapytanie o ilość elementów
                                    Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                    //Pobieram od użytkownika liczbę elementów i używam while aby nie powstał błąd wpisania wartości
                                    while(!int.TryParse(Console.ReadLine(),out man))
                                        {
                                            Console.WriteLine("\n\tPopraw to! Podana wartość musi być cyfrą."); 
                                            Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                        }
                                        //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                        if (man <0)
                                        {
                                            Console.WriteLine("\n\tLiczba n musi być dodatnia.");
                                        }
                                        else
                                        //ta instrukacja nie pozwala wprowadzić liczby równej 0
                                            if(man==0)
                                            {
                                                Console.WriteLine("\n\tLiczba n nie może być 0.");
                                            }
                                } while (man <= 0);

                                    Console.WriteLine("\n\tWprowadź cyfry: ");
                                    //pętla dzięki której możemy pobrać n-razy cyfrę a
                                    for(mai = 0; mai<man; mai++)    
                                        {   //pobranie od użytkownika liczb wraz ze sprawdzeniem 
                                            Console.Write("\n\tCyfra {0}: ",mai+1);
                                            while (!float.TryParse(Console.ReadLine(), out maa))
                                            {
                                                Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                                                Console.Write("\n\tWpisz ponownie cyfrę: ");
                                            }
                                                //funkcja podnosząca do potęgi
                                                maq += (float)Math.Pow(maa,2);

                                                mar = maq/man;
                                                //funkcja pierwiastkująca
                                                map = (float)Math.Sqrt(mar);
                                                
                                        }
                                        Console.Write("Średnia kwadratowa wynosi: {0}", map);
                                        map=0;
                            break;
                            }
                            default:
                            {
                            //wywołanie metody na pobieranie ilości elementów w ciągu
                                do
                                {   //zapytanie o ilość elementów
                                    Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                    //Pobieram od użytkownika liczbę elementów i używam while aby nie powstał błąd wpisania wartości
                                    while(!int.TryParse(Console.ReadLine(),out man))
                                        {
                                            Console.WriteLine("\n\tPopraw to! Podana wartość musi być cyfrą."); 
                                            Console.Write("\n\tPodaj liczbę elementów ciągu: ");
                                        }
                                        //ta instrukcja warunkowa nie pozwala użytkownikowi wprowadzić liczby mniejszej od 0
                                        if (man <0)
                                        {
                                            Console.WriteLine("\n\tLiczba n musi być dodatnia.");
                                        }
                                        else
                                        //ta instrukacja nie pozwala wprowadzić liczby równej 0
                                            if(man==0)
                                            {
                                                Console.WriteLine("\n\tLiczba n nie może być 0.");
                                            }
                                } while (man <= 0);
                            
                                //pętla pobierająca od użytkownika liczby
                                for(mai = 0; mai<man; mai++)    
                                    {
                                        Console.Write("\n\tLiczba {0} : ",mai+1);
                                        //pobieranie liczb a i b od użytkownika wraz z warunkami
                                        while (!float.TryParse(Console.ReadLine(), out maa))
                                        {
                                            Console.WriteLine("\n\tWpisałeś niepoprawny znak, POPRAW TO!");
                                            Console.Write("\n\tWpisz ponownie cyfrę: ");
                                        }
                                        //funkcja podnosząca do potęgi 
                                        mar += (float)Math.Pow(maa,mab);
                                        maq = mar/man;
                                        //funkcja podnosząca do potęgi
                                        mat = (float)Math.Pow(maq,1/mab);
                                    }
                                Console.Write("\n\tŚrednia potęgowa wynosi: {0}", mat);
                                mat=0;    
                                break;
                            }
                        }
                        Console.Write("\n\n\n\tCzy chcesz konntynuować obliczanie? (T/N) ");
                        maOdpowiedz = Console.ReadLine().ToUpper();
                        }while (maOdpowiedz== "T");
                    break;
                    }
                    //U.Obliczanie średniej potęgowej <średniej uogólnionej> (wywoływanie metody)
                    case "u":
                    {
                    maObliczanieŚredniejPotęgowej('n');
                        break;
                    }
                    case "x":
                    {
                        break;
                    }
                }
                Console.Write("\n\n\n\tCzy chcesz wyłączyć program? (T/N) ");
                maOdpowiedz = Console.ReadLine().ToUpper();
            } while (maOdpowiedz == "N");
        }
    }
}
    
