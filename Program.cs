using System;

namespace primeAssurance
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            int valeurAuto = 0;
            string accidentAuto = "";
            int nbAccidents = 0;
            double montantPrime = 0;
            bool assurable = true; 
            
            Console.WriteLine("Bienvenue dans le programme de calcul d'une prime d'assurance automobile.\n Afin d'être en mesure de calculer votre prime, veuillez répondre aux 3 questions suivantes:");

            Console.Write("Quel est votre âge? ");
            int.TryParse(Console.ReadLine(), out age);

            Console.Write("Avez-vous déjà eu un accident automobile? (o/n) ");
            accidentAuto = Console.ReadLine();

            if(accidentAuto.ToUpper() == "O") {
                Console.Write("Veuillez préciser le nombre d'accidents des 10 dernières années: ");   
                int.TryParse(Console.ReadLine(), out nbAccidents);
            }

            Console.Write("Quel est la valeur de la voiture à assurer ? ");
            int.TryParse(Console.ReadLine(), out valeurAuto);

            // Détermination de la prime pour les personnes entre 16 et 25 ans
            if(age >= 16 && age <= 25) 
            {
                montantPrime = valeurAuto * 0.05;   // prime de base
                if(nbAccidents >= 1 && nbAccidents <= 3) 
                {
                    montantPrime += valeurAuto * 0.04;    // prime additionnelle en cas d'accidents
                }
                else if(nbAccidents > 3)
                {
                    assurable = false;  // personne non assurable
                }
            } 
            // Détermination de la prime pour les personnes de plus de 25 ans
            else if (age > 25)
            {
                montantPrime = valeurAuto * 0.03;   // prime de base
                if(nbAccidents >= 1 && nbAccidents <= 5) 
                {
                    montantPrime += valeurAuto * 0.02;  // prime additionnelle en cas d'accidents
                }
                else if(nbAccidents > 5)
                {
                    assurable = false;  // personne non assurable
                }
            }
            // Attention de ne pas oublier les personnes de moins de 16 ans!
            else
            {
                assurable = false; // la personne est trop jeune pour être assurée
            }

            if(!assurable) 
            {
                Console.WriteLine("Nous ne pouvons pas vous assurer.");
            } 
            else
            {
                Console.WriteLine($"Le montant de votre prime est de : {montantPrime}");
            }

            Console.ReadLine();
        }
    }
}
