using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurBoissonChaude
{
    public class DistributeurBoissonClass
    {
        public static Dictionary<string, double> prixIngredients = new Dictionary<string, double>()
        {
            {"Café",1},
            {"Sucre",0.1},
            {"Créme",0.5},
            {"Thé",2},
            {"Eau",0.2},
            {"Chocolat",1},
            {"Lait",0.4}

            //ici On peut ajouter des nouveaux ingredients avec leur prix pour le future.
        };


        public static  Dictionary<string, Dictionary<string, int>> compositionBoisson = new Dictionary<string, Dictionary<string, int>>()
        {
            {"Expresso",new Dictionary<string,int>() 
            {{"Café",1},
            {"Eau",1}}},

            {"Allongé",new Dictionary<string,int>() 
            {{"Café",1},
            {"Eau",2}}},

            {"Capuccino",new Dictionary<string,int>() 
            {{"Café",1},
            {"Créme",1},
            {"Chocolat",1},
            {"Eau",1}}},

            {"Chocolat",new Dictionary<string,int>() 
            {{"Chocolat",3},
            {"Sucre",1},
            {"Lait",2},
            {"Eau",1}}},

            {"Thé",new Dictionary<string,int>() 
            {{"Thé",1},
            {"Eau",2}}}

            //ici on peut ajouter de nouvelles composition de boisson si besoin pour le future. 
        };

        public static double CalculerPrixBoisson(string boisson)
        {
            double prixBoisson = 0;
            double prixTotale = 0;
            if (!compositionBoisson.ContainsKey(boisson)) // Verification si la boisson existe.
            {
                Console.WriteLine("Cette boisson " + boisson + " n'existe pas veuiller verifier votre saisie ou l'orthographe");
                return prixTotale;
            }
            else
            {
                foreach (var item in compositionBoisson[boisson])
                {
                    prixBoisson = prixBoisson + (prixIngredients[item.Key] * item.Value); // Calcule prix boisson

                }
                prixTotale = prixBoisson + (prixBoisson * 0.3); // Ajout 30% marge
                return prixTotale;
                

            }

        }
    }
}
