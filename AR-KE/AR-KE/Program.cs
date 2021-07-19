using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace IO
{
    class Program
    {
        static void tkmm()
        {
            Console.WriteLine(" _____ _____ _____ ", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.WriteLine("|_   _|  |  |     |", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.WriteLine("  | | |    -| | | |", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.WriteLine("  |_| |__|__|_|_|_|", Console.ForegroundColor = ConsoleColor.DarkYellow);
        }
        static void iscii()
        {
            Console.WriteLine(" _ _____ __    _____ _____ ", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.WriteLine("| |   __|  |  |   __|     |", Console.ForegroundColor = ConsoleColor.DarkCyan);
            Console.WriteLine("| |__   |  |__|   __| | | |", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("|_|_____|_____|_____|_|_|_|", Console.ForegroundColor = ConsoleColor.DarkGreen);
        }
        static void hata()
        {
            Console.WriteLine(" _____ _____ _____ _____ ", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("|  |  |  _  |_   _|  _  |", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("|     |     | | | |     |", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("|__|__|__|__| |_| |__|__|", Console.ForegroundColor = ConsoleColor.Red);
        }
        static void Main(string[] args)
        {
            string path = @"E:\reg.txt";
            string[] lines;
            char[] ayrac = { ' ', ',' };
            string userdass, passdass, user, pass, choose, npass, text, logreg, islem, makinesec, pressany, reguser, regpass, reginfo;
            int userline = 0, sayibil;
            string[] parcalar;
            float s1, s2, sonuc;
            int carpım = 1, secilen1;


            while (true)
            {
                Console.Clear();
            menü:
                Thread.Sleep(300);
                Console.WriteLine("\n    █████╗ ██████╗       ██╗  ██╗███████╗", Console.ForegroundColor = ConsoleColor.Blue);
                Thread.Sleep(300);
                Console.WriteLine("   ██╔══██╗██╔══██╗      ██║ ██╔╝██╔════╝", Console.ForegroundColor = ConsoleColor.Red);
                Thread.Sleep(300);
                Console.WriteLine("   ███████║██████╔╝█████╗█████╔╝ █████╗  ", Console.ForegroundColor = ConsoleColor.Cyan);
                Thread.Sleep(300);
                Console.WriteLine("   ██╔══██║██╔══██╗╚════╝██╔═██╗ ██╔══╝  ", Console.ForegroundColor = ConsoleColor.Green);
                Thread.Sleep(300);
                Console.WriteLine("   ██║  ██║██║  ██║      ██║  ██╗███████╗ Programmed by Kemal", Console.ForegroundColor = ConsoleColor.DarkMagenta);
                Thread.Sleep(300);
                Console.WriteLine("   ╚═╝  ╚═╝╚═╝  ╚═╝      ╚═╝  ╚═╝╚══════╝ Designed by Arda v2.0", Console.ForegroundColor = ConsoleColor.DarkRed);
                Thread.Sleep(300);
                Console.ResetColor();
            label:
                Console.Write("\n\n\na.Login\nb.Register\n");
                Console.Write("\nHesabınız Var İse (a). Hesabınız Yok İse (b) Ye Basınız:");

                logreg = Console.ReadLine();
                logreg = logreg.ToLower();
                lines = File.ReadAllLines(path);



                if (logreg == "a")
                {


                    while (true)
                    {


                    login:
                        //login
                        Console.Clear();
                        Console.WriteLine(" __    _____ _____ _ _____ ", Console.ForegroundColor = ConsoleColor.Red);
                        Console.WriteLine("|  |  |     |   __| |   | |", Console.ForegroundColor = ConsoleColor.Red);
                        Console.WriteLine("|  |__|  |  |  |  | | | | |", Console.ForegroundColor = ConsoleColor.Red);
                        Console.WriteLine("|_____|_____|_____|_|_|___|", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ResetColor();


                        try
                        {
                            Console.Write("\n\nUserLine:");
                            userline = int.Parse(Console.ReadLine());

                            parcalar = lines[userline].Split(ayrac);
                            userdass = parcalar[0];
                            passdass = parcalar[1];
                        }
                        catch (System.IndexOutOfRangeException)
                        {

                            Console.Write("\nBu Line'da Kullanıcı Bulunmamaktadır. Oncelikle Yeni Bir Kullanıcı Yaratınız.");
                            Thread.Sleep(1500);
                            Console.Clear();
                            goto menü;

                        }





                        Console.Write("UserName:");
                        user = Console.ReadLine();

                        Console.Write("Password:");
                        pass = Console.ReadLine();

                        if (user == userdass && pass == passdass)
                        {
                        gerigit:
                            while (true)
                            {
                              //  Console.Clear();
                               // Console.Write(" \t\t\t\t\t\t\t\t\tYükleniyor...\n");
                               // Console.ForegroundColor = ConsoleColor.Green;
                               // for (int i = 0; i < 166; i++)
                                {
                              //      Console.Write("█");
                              //      Thread.Sleep(15);
                                }
                                Console.ResetColor();
                                Console.Clear();
                                Console.WriteLine(" _____ _____ _____ _____ ", Console.ForegroundColor = ConsoleColor.Red);
                                Console.WriteLine("|     |   __|   | |  |  |", Console.ForegroundColor = ConsoleColor.Gray);
                                Console.WriteLine("| | | |   __| | | |  |  |", Console.ForegroundColor = ConsoleColor.Yellow);
                                Console.WriteLine("|_|_|_|_____|_|___|_____|", Console.ForegroundColor = ConsoleColor.Green);
                                Console.ResetColor();
                                Console.Write("\n\n1.Hesap Makinesi\n2.0 İle 20 Arası Sayı Bulma Oyunu\n3.Taş Kağıt Makas\n4.Program\n\nGirmek İstediğiniz Programı Seçin:");
                                islem = Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                            if (islem == "1")
                            {
                                while (true)
                                {
                                hesap:
                                    Console.WriteLine(" _____ _____ _____ _____ _____ ", Console.ForegroundColor = ConsoleColor.Yellow);
                                    Console.WriteLine("|  |  |   __|   __|  _  |  _  |", Console.ForegroundColor = ConsoleColor.DarkCyan);
                                    Console.WriteLine("|     |   __|__   |     |   __|", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.WriteLine("|__|__|_____|_____|__|__|__|   ", Console.ForegroundColor = ConsoleColor.DarkGreen);
                                    Console.ResetColor();
                                    Console.Write("\n1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme\n5-Faktöriyel\n\nPress Q to Quit");
                                    Console.Write("\n\n\nBir Operatör Seçiniz:");
                                    makinesec = Console.ReadLine();
                                    Console.Clear();
                                    try
                                    {
                                        if (makinesec == "q" || makinesec == "Q")
                                        {
                                            Console.Clear();
                                            goto gerigit;
                                        }
                                        else if (makinesec == "1")
                                        {
                                            iscii();
                                            Console.ResetColor();
                                            Console.Write("\n1. Sayıyı Giriniz:");
                                            s1 = float.Parse(Console.ReadLine());
                                            Console.Write("2. Sayıyı Giriniz:");
                                            s2 = float.Parse(Console.ReadLine());
                                            sonuc = s1 + s2;
                                            Console.Write("\nSonuç:{0}", sonuc);
                                            Thread.Sleep(1000);
                                            Console.Clear();
                                            goto hesap;
                                        }
                                        else if (makinesec == "2")
                                        {
                                            iscii();
                                            Console.ResetColor();
                                            Console.Write("\n1. Sayıyı Giriniz:");
                                            s1 = float.Parse(Console.ReadLine());
                                            Console.Write("2. Sayıyı Giriniz:");
                                            s2 = float.Parse(Console.ReadLine());
                                            sonuc = s1 - s2;
                                            Console.Write("\nSonuç:{0}", sonuc);
                                            Thread.Sleep(1000);
                                            Console.Clear();
                                            goto hesap;
                                        }
                                        else if (makinesec == "3")
                                        {
                                            iscii();
                                            Console.ResetColor();
                                            Console.Write("\n1. Sayıyı Giriniz:");
                                            s1 = float.Parse(Console.ReadLine());
                                            Console.Write("2. Sayıyı Giriniz:");
                                            s2 = float.Parse(Console.ReadLine());
                                            sonuc = s1 * s2;
                                            Console.Write("\nSonuç:{0}", sonuc);
                                            Thread.Sleep(1000);
                                            Console.Clear();
                                            goto hesap;
                                        }
                                        else if (makinesec == "4")
                                        {
                                            iscii();
                                            Console.ResetColor();
                                            Console.Write("\n1. Sayıyı Giriniz:");
                                            s1 = float.Parse(Console.ReadLine());
                                            Console.Write("2. Sayıyı Giriniz:");
                                            s2 = float.Parse(Console.ReadLine());
                                            sonuc = s1 / s2;
                                            Console.Write("\nSonuç:{0}", sonuc);
                                            Thread.Sleep(1000);
                                            Console.Clear();
                                            goto hesap;
                                        }
                                        else if (makinesec == "5")
                                        {
                                            Console.Write("Sayıyı Giriniz:");
                                            secilen1 = int.Parse(Console.ReadLine());


                                            for (int i = 1; i < secilen1 + 1; i++)
                                            {
                                                carpım = carpım * i;
                                            }

                                            Console.Write("{0} Sayısının Faktoriyeli {1}", secilen1, carpım);
                                            Thread.Sleep(1000);
                                            Console.Clear();
                                            goto hesap;

                                        }
                                        else if (makinesec == "6")
                                        {


                                        }
                                        else
                                        {
                                            Console.Clear();
                                            hata();
                                            Console.ResetColor();
                                            Console.Write("\nLütfen Bir Operatör Seçiniz!");
                                            Thread.Sleep(1000);
                                            Console.Clear();
                                            goto hesap;
                                        }
                                    }
                                    catch (System.FormatException)
                                    {
                                        Console.Clear();
                                        hata();
                                        Console.ResetColor();
                                        Console.Write("\nLütfen Bir Sayı Giriniz!");
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        goto hesap;
                                    }
                                }
                            }
                            else if (islem == "2")
                            {
                            yanlısbuldun:
                                Random random = new Random();
                                int randomNumber = random.Next(1, 21);
                                Console.WriteLine("                                                   _____ ", Console.ForegroundColor = ConsoleColor.Blue);
                                Console.WriteLine(" _____ _____ _____ _____ _ _____    _____ _____   |___  |", Console.ForegroundColor = ConsoleColor.Yellow);
                                Console.WriteLine("|_   _|  _  |  |  |     | |   | |  |   __|_   _|    |  _|", Console.ForegroundColor = ConsoleColor.Red);
                                Console.WriteLine("  | | |     |     | | | | | | | |  |   __| | |      |_|  ", Console.ForegroundColor = ConsoleColor.Green);
                                Console.WriteLine("  |_| |__|__|__|__|_|_|_|_|_|___|  |_____| |_|      |_|  ", Console.ForegroundColor = ConsoleColor.DarkMagenta);
                                Console.ResetColor();
                                for (int i = 1; i < 4; i++)
                                {
                                    try
                                    {
                                        Console.Write("\nTahmin Ettiğiniz Sayıyı Giriniz:");
                                        sayibil = int.Parse(Console.ReadLine());
                                        if (sayibil == randomNumber)
                                        {
                                            Console.Write("\nBravo Doğru Bildiniz.");
                                            Console.Write("\nGeri Dönmek İçin Herhangi Bir Tuşa Basınız...");
                                            pressany = Console.ReadLine();
                                            Console.Clear();
                                            goto gerigit;
                                        }
                                        else if (sayibil < 0 || sayibil > 20)
                                        {
                                            Console.Clear();
                                            Console.Write("\nLütfen 1 İle 20 Arası Bir Sayı Giriniz.");
                                            Thread.Sleep(1000);
                                            Console.Clear();
                                            goto yanlısbuldun;
                                        }
                                        else if (sayibil != randomNumber)
                                        {
                                            Console.Write("Yanlış Buldunuz.\n\n");
                                            Thread.Sleep(1000);
                                        }
                                    }
                                    catch (System.FormatException)
                                    {
                                        Console.Clear();
                                        hata();
                                        Console.ResetColor();
                                        Console.Write("\nLütfen 0 İle 20 Arası Sayıları Giriniz");
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        goto yanlısbuldun;
                                    }
                                }
                                Console.Write("\nCevap={0}", randomNumber);
                                Thread.Sleep(2500);
                                Console.Clear();
                                goto gerigit;

                            }
                            else if (islem == "3")
                            {
                                int modsec;
                                Console.Write("1-Online");
                                Console.WriteLine("2-Offline");
                                Console.Write("\nOyun Modunu Seçiniz:");
                                modsec = int.Parse(Console.ReadLine());
                                if (modsec==1)
                                {
                                    
                                    int o1puan = 0, o2puan = 0;
                                    
                                    string sec2,sec3;
                                    string[] tkmo = { "Taş", "Kağıt", "Makas" };


                                    while (true)
                                    {
                                        Console.Clear();

                                        tkmm();
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("\n\nOyuncu 1 Puanı={0}\n", o1puan);
                                        Console.Write("Oyuncu 2 Puanı={0}", o2puan);

                                        Console.Write("\n\n1-Taş\n2-Kağıt\n3-Makas\n");
                                        Console.Write("\nOyuncu 1 Seçiyor:");
                                        sec2 = Console.ReadLine();
                                        Console.Clear();
                                        Console.Write("\n\n1-Taş\n2-Kağıt\n3-Makas\n");
                                        Console.Write("\nOyuncu 2 Seçiyor:");
                                        sec3=Console.ReadLine();

                                        if (sec2=="1")
                                        {
                                            if (sec3=="1")
                                            {
                                                Console.Write("'Oyuncu1'=Taş");
                                                Console.Write("\n'Oyuncu2'=Taş");
                                                Console.Write("\n\nİkiside Taş Kimse Puan Kazanamadı!");

                                                Thread.Sleep(3000);
                                                Console.Clear();
                                            }
                                            if (sec3=="2")
                                            {
                                                Console.Write("'Oyuncu1'=Taş");
                                                Console.Write("\n'Oyuncu2'=Kağıt");
                                                Console.Write("\n\n'Oyuncu 2' Puan Kazandı!");
                                                o2puan = o2puan + 1;

                                                Thread.Sleep(3000);
                                                Console.Clear();
                                            }
                                            if (sec3=="3")
                                            {
                                                Console.Write("'Oyuncu1'=Taş");
                                                Console.Write("\n'Oyuncu2'=Makas");
                                                Console.Write("'Oyuncu 1'Puan Kazandı!");
                                                o1puan = o1puan + 1;

                                                Thread.Sleep(3000);
                                                Console.Clear();
                                            }
                                        }
                                        else if (sec2 == "2")
                                        {
                                            if (sec3 == "1")
                                            {
                                                Console.Write("'Oyuncu1'=Kağıt");
                                                Console.Write("\n'Oyuncu2'=Taş");
                                                Console.Write("\n\n'Oyuncu 1'Puan Kazandı!");
                                                o1puan = o1puan + 1;

                                                Thread.Sleep(3000);
                                                Console.Clear();
                                            }
                                            if (sec3 == "2")
                                            {
                                                Console.Write("'Oyuncu1'=Kağıt");
                                                Console.Write("\n'Oyuncu2'=Kağıt");
                                                Console.Write("\n\nİkiside Kağıt Kimse Puan Kazanamadı!");
                                                

                                                Thread.Sleep(3000);
                                                Console.Clear();
                                            }
                                            if (sec3 == "3")
                                            {
                                                Console.Write("'Oyuncu1'=Kağıt");
                                                Console.Write("\n'Oyuncu2'=Makas");
                                                Console.Write("'Oyuncu 2'Puan Kazandı!");
                                                o2puan = o2puan + 1;
                                            }
                                        }
                                        else if (sec2 == "3")
                                        {
                                            if (sec3 == "1")
                                            {
                                                Console.Write("'Oyuncu1'=Makas");
                                                Console.Write("\n'Oyuncu2'=Taş");
                                                Console.Write("\n\n'Oyuncu 2'Puan Kazandı!");
                                                o2puan = o2puan + 1;

                                                Thread.Sleep(3000);
                                                Console.Clear();
                                            }
                                            if (sec3 == "2")
                                            {
                                                Console.Write("'Oyuncu1'=Makas");
                                                Console.Write("\n'Oyuncu2'=Kağıt");
                                                Console.Write("\n\n'Oyuncu 1' Puan Kazandı!");
                                                o1puan = o1puan + 1;

                                                Thread.Sleep(3000);
                                                Console.Clear();
                                            }
                                            if (sec3 == "3")
                                            {
                                                Console.Write("'Oyuncu1'=Makas");
                                                Console.Write("\n'Oyuncu2'=Makas");
                                                Console.Write("\n\nİkiside Makas Kimse Puan Kazanamadı!");
                                                
                                            }
                                        }
                                        if (o1puan == 3)
                                        {
                                            tkmm();
                                            Console.ResetColor();
                                            Console.WriteLine("\n\n-----Oyuncu1 Kazandı-----");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.ResetColor();
                                            Thread.Sleep(1500);
                                            goto gerigit;


                                        }
                                        else if (o2puan == 3)
                                        {
                                            tkmm();
                                            Console.ResetColor();
                                            Console.WriteLine("\n\n-----Oyuncu2 Kazandı-----");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.ResetColor();
                                            Thread.Sleep(1500);
                                            goto gerigit;

                                        }





                                    }

                                }
                                else if (modsec==2)
                                {
                                    int round = 0;
                                    Random rand = new Random();
                                    int ipuan = 0, bpuan = 0;
                                    int secilen;
                                    string sec;
                                    string[] tkm = { "Taş", "Kağıt", "Makas" };
                                    while (true)
                                    {
                                        Console.Clear();

                                        tkmm();

                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("\n\nİnsan Puanı={0}\n", ipuan);
                                        Console.Write("Bilgisayar Puanı={0}", bpuan);


                                        Console.Write("\n\n\n1-Taş\n2-Kağıt\n3-Makas\n");
                                        Console.Write("\nÜsttekilerden Birini Seçiniz:");
                                        sec = Console.ReadLine();
                                        secilen = rand.Next(0, 3);
                                        if (secilen == 0)
                                        {
                                            Console.WriteLine("\nBilgisayarın Seçtiği={0}", tkm[secilen]);
                                            if (sec == "1")
                                            {
                                                Console.Write("İnsanın Seçtiği=Taş\n\n");
                                                Console.Write("Taş vs Taş = Berabere!\n");
                                                Console.Write("Kimse Puan Kazanamadı!");

                                                Thread.Sleep(3000);
                                                Console.Clear();



                                            }
                                            if (sec == "2")
                                            {
                                                Console.Write("İnsanın Seçtiği=Kağıt\n\n");
                                                Console.Write("Kağıt Taşı Yener = İnsan Kazandı!\n");
                                                Console.Write("İnsan 1 Puan Kazandı!");
                                                ipuan++;


                                                Thread.Sleep(3000);
                                                Console.Clear();


                                            }
                                            if (sec == "3")
                                            {
                                                Console.Write("İnsanın Seçtiği=Makas\n\n");
                                                Console.Write("Taş Makası Yener = Bilgisayar Kazandı!\n");
                                                Console.Write("Bilgisayar 1 Puan Kazandı!");
                                                bpuan++;

                                                Thread.Sleep(3000);
                                                Console.Clear();

                                            }
                                            else
                                            {
                                                Console.Clear();
                                                hata();
                                                Console.Write("\n\nLütfen 1,2 veya 3 Yazınız!");
                                                Thread.Sleep(1500);
                                                Console.Clear();

                                            }

                                        }
                                        if (secilen == 1)
                                        {
                                            Console.WriteLine("\nBilgisayarın Seçtiği={0}", tkm[secilen]);
                                            if (sec == "1")
                                            {
                                                Console.Write("İnsanın Seçtiği=Taş\n\n");
                                                Console.Write("Kağıt Taşı Yener = Bilgisayar Kazandı!\n");
                                                Console.Write("Bilgisayar 1 Puan Kazandı!");
                                                bpuan++;


                                                Thread.Sleep(3000);
                                                Console.Clear();


                                            }
                                            if (sec == "2")
                                            {
                                                Console.Write("İnsanın Seçtiği=Kağıt\n\n");
                                                Console.Write("Kağıt vs Kağıt Berabere!\n");
                                                Console.Write("Kimse Puan Kazanamadı!");

                                                Thread.Sleep(3000);
                                                Console.Clear();
                                            }
                                            if (sec == "3")
                                            {
                                                Console.Write("İnsanın Seçtiği=Makas\n\n");
                                                Console.Write("Makas Kağıdı Yener = İnsan Kazandı!\n");
                                                Console.Write("İnsan 1 Puan Kazandı!");
                                                ipuan++;


                                                Thread.Sleep(3000);
                                                Console.Clear();


                                            }

                                        }
                                        if (secilen == 2)
                                        {
                                            Console.WriteLine("\nBilgisayarın Seçtiği={0}", tkm[secilen]);
                                            if (sec == "1")
                                            {
                                                Console.Write("İnsanın Seçtiği=Taş\n\n");
                                                Console.Write("Taş Makası Yener=İnsan Kazandı!\n");
                                                Console.Write("İnsan 1 Puan Kazandı!");
                                                ipuan++;


                                                Thread.Sleep(3000);
                                                Console.Clear();

                                            }
                                            if (sec == "2")
                                            {
                                                Console.Write("İnsanın Seçtiği=Kağıt\n\n");
                                                Console.Write("Makas Kağıdı Yener = Bilgisayar Kazandı!\n");
                                                Console.Write("Bilgisayar 1 Puan Kazandı!");
                                                bpuan++;


                                                Thread.Sleep(3000);
                                                Console.Clear();


                                            }
                                            if (sec == "3")
                                            {
                                                Console.Write("İnsanın Seçtiği=Makas\n\n");
                                                Console.Write("Makas vs Makas = Berabere\n");
                                                Console.Write("Kimse Puan Kazanamadı!");

                                                Thread.Sleep(3000);
                                                Console.Clear();


                                            }

                                        }
                                        if (ipuan == 3)
                                        {
                                            tkmm();
                                            Console.ResetColor();
                                            Console.WriteLine("\n\n-----İnsan Kazandı-----");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.ResetColor();
                                            Thread.Sleep(1500);
                                            goto gerigit;


                                        }
                                        else if (bpuan == 3)
                                        {
                                            tkmm();
                                            Console.ResetColor();
                                            Console.WriteLine("\n\n-----Bilgisayar Kazandı-----");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.ResetColor();
                                            Thread.Sleep(1500);
                                            goto gerigit;

                                        }
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    hata();
                                    Console.ResetColor();
                                    Console.Write("\nLütfen 1 ile 4 Arası Sayıları Giriniz.");
                                    Thread.Sleep(1200);
                                    Console.Clear();
                                    goto gerigit;
                                }
                            }
                                
                        }

                        else if (user == userdass && pass != passdass)
                        {
                            Console.Clear();
                            hata();
                            Console.Write("\n\nŞifre Yanlış!");
                            Console.Write("\nŞifre Değiştirmek İstermisiniz? Y/N:");
                            choose = Console.ReadLine();
                            choose = choose.ToLower();

                            if (choose == "y")
                            {
                                Console.Write("\n\nYeni Şifrenizi Giriniz:");
                                npass = Console.ReadLine();

                                text = File.ReadAllText(path);
                                text = text.Replace(passdass, npass);
                                File.WriteAllText(path, text);

                            }

                            else if (choose == "n")
                            {
                                goto login;
                            }

                        }
                        else if (user != userdass && pass == passdass)
                        {
                            Console.Clear();
                            hata();
                            Console.ResetColor();
                            Console.Write("\nKullanıcı Adı Yanlış.");
                            Thread.Sleep(1000);
                            Console.Clear();
                            goto login;

                        }

                    }

                }



                else if (logreg == "b")
                {
                    Console.Clear();
                    Console.WriteLine(" _____         _     _           ", Console.ForegroundColor = ConsoleColor.DarkYellow);
                    Console.WriteLine("| __  |___ ___|_|___| |_ ___ ___ ", Console.ForegroundColor = ConsoleColor.DarkYellow);
                    Console.WriteLine("|    -| -_| . | |_ -|  _| -_|  _|", Console.ForegroundColor = ConsoleColor.DarkYellow);
                    Console.WriteLine("|__|__|___|_  |_|___|_| |___|_|  ", Console.ForegroundColor = ConsoleColor.DarkYellow);
                    Console.WriteLine("          |___|                  ", Console.ForegroundColor = ConsoleColor.DarkYellow);
                    Console.ResetColor();
                    Console.Write("\nYeni Kullanıcı Adınızı Giriniz:");
                    reguser = Console.ReadLine();

                    Console.Write("\nYeni Şifrenizi Giriniz:");
                    regpass = Console.ReadLine();

                    reginfo = reguser + " " + regpass;

                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine(reginfo);
                    }



                    Console.WriteLine("\n\nKullanıcı Sıralamanız(Saklayınız)={0}  ", lines.Length);
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto menü;
                }
                else
                {
                    Console.Clear();
                    hata();
                    Console.ResetColor();
                    Console.Write("Lütfen a Veya b Yazınız");
                    Thread.Sleep(1000);
                    Console.Clear();

                }







            }


        }
    }
}
