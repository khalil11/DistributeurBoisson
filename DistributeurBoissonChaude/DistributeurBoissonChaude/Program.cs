using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DistributeurBoissonChaude
{
    public class Program
    {              
        static void Main(string[] args)
        {
           //DistributeurBoissonClass distributeurBoissonClass = new DistributeurBoissonClass();
           Console.WriteLine("Veuillez saisir une Boisson parmi la liste");
           foreach (var item in DistributeurBoissonClass.compositionBoisson)
           {
               Console.WriteLine(item.Key + ":");

           }
           string boisson = Console.ReadLine();
           double prixTotale = DistributeurBoissonClass.CalculerPrixBoisson(boisson);
           if (prixTotale != 0)
           {
               Console.WriteLine("Prix " + boisson + " = " + prixTotale + " euros");
           }

           Console.ReadLine();
        }
    }
}
