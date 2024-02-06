using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekstiseikkailu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aloitetaan peli!");
            Console.WriteLine("Lähdet kaupunkiin.");
            {
                Console.WriteLine("Menet bussilla, mutta bussi on täynnä.");
                Console.WriteLine("Seisotko vai istutko bussissa? Jos istut, valitse 3. Jos seisot, valitse 4.");
                string choice = Console.ReadLine();

                if (choice == "3")
                {
                    Console.WriteLine("Istut tuntemattoman vieressä koko matkan.");
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Seisot koko matkan ja jalkoihisi alkaa sattumaan.");
                }   
            }
            {
                {
                    Console.WriteLine("Saavuit kaupunkiin!");
                    Console.WriteLine("Onko rahaa yli 20€? Vastaa kyllä tai ei.");
                    string choice2 = Console.ReadLine();

                    if (choice2 == "kyllä")
                    {
                        Console.WriteLine("Rahaa on riittävästi syömiseen!");
                        Console.WriteLine("Haluatko burgerin vai pizzan? Valitse 7 jos haluat pizzan. Jos haluat burgerin valitse 8.");
                        string valinta3 = Console.ReadLine();

                        if (valinta3 == "7")
                        {
                            Console.WriteLine("Pizza oli hyvää ja sitä jäi vähän yli!");
                            Console.WriteLine("Haluat lähteä kotiin.");
                            Console.WriteLine("Menetkö bussilla vai äidin kyydillä? Jos äidin kyydillä, valitse 13. Jos bussilla, valitse 14.");
                            string valinta7 = Console.ReadLine();

                            if (valinta7 == "13")
                            {
                                Console.WriteLine("Matka meni hyvin ja aikakin kului nopeasti jutellessa.");
                            }
                            else if (valinta7 =="14")
                            {
                                Console.WriteLine("bussimatka sujui hyvin, mutta matka tuntui tosi pitkältä.");
                            }
                            {
                                Console.WriteLine("Pääsit kotiin!");
                            }
                        }
                        else if (valinta3 == "8")
                        {
                            Console.WriteLine("Burger oli hyvää!");
                            Console.WriteLine("Haluat lähteä kotiin.");
                            Console.WriteLine("Menetkö bussilla vai äidin kyydillä? Jos äidin kyydillä, valitse 13. Jos bussilla, valitse 14.");
                            string valinta6 = Console.ReadLine();

                            if (valinta6 == "13")
                            {
                                Console.WriteLine("Matka meni hyvin ja aikakin kului nopeasti jutellessa.");
                            }
                            else if (valinta6 == "14")
                            {
                                Console.WriteLine("bussimatka sujui hyvin, mutta matka tuntui tosi pitkältä.");
                            }
                            {
                                Console.WriteLine("Pääsit kotiin!");
                            }
                        }
                    }
                    if (choice2 == "ei")
                    {
                        Console.WriteLine("Käyt ostamassa kaupsta kolmioleivän.");
                        Console.WriteLine("Otatko kana- vai kinkkuleivän? Jos kanan valitse 9. jos kinkun valitse 10.");
                        string choice3 = Console.ReadLine();

                        if (choice3 == "9")
                        {
                            Console.WriteLine("Kana ei ollut niin hyvää kun muistit, joten jätit puolet leivästä syömättä.");
                            Console.WriteLine("Haluat lähteä kotiin.");
                            Console.WriteLine("Menetkö bussilla vai äidin kyydillä) Jos busilla, valitse 11. Jos äidin kyydillä, valitse 12.");
                            string valinta8 = Console.ReadLine();

                            if (valinta8 == "11")
                            {
                                Console.WriteLine("Bussimatka sujui hyvin, mutta matka tuntui tosi pitkältä.");
                            }
                            else if (valinta8 == "12")
                            {
                               Console.WriteLine("Matka meni hyvin ja aikakin kului nopeasti jutellessa.");
                            }
                            {
                                Console.WriteLine("Pääsit kotiin!");
                            }
                        }
                        else if (choice3 == "10")
                        {
                            { 
                            Console.WriteLine("Kinkku oli hyvää ja söit koko leivän!");
                            Console.WriteLine("Haluat lähteä kotiin.");
                            Console.WriteLine("Menetkö bussilla vai äidin kyydillä) Jos busilla, valitse 11. Jos äidin kyydillä, valitse 12.");
                            string valinta4 = Console.ReadLine();

                            if (valinta4 == "11")
                            {
                                Console.WriteLine("Bussimatka sujui hyvin, utta matka tuntui tosi pitkältä.");
                            }
                            else if (valinta4 == "12")
                            {
                                Console.WriteLine("Matka meni hyvin ja aikakin kului nopeasti jutellessa.");
                            }
                                {
                                    Console.WriteLine("Pääsit kotiin!");
                                }
                            }
                        }
                    }

                }

            }

            Console.ReadKey();
        }
    }
}
