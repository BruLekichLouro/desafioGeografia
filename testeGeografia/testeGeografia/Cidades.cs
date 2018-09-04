using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeGeografia
{
    class Cidades: Estado
    {

        List<string> parana = new List<string>
        {
            "Maringá", "Curitiba","Londrina","Pinhais"
        };
        List<string> santaCatarina = new List<string>
        {
            "Chapecó","Blumenau","Florianópolis", "Joinvile"
        };
        List<string> rioGrandeDoSul = new List<string>
        {
            "Porto Alegre","Gramado"
        };




        public void procuraCidade(string local)
        {
            
             if(parana.Contains(local))
                { if(local == "Curitiba")
                {
                    Console.WriteLine("Esta cidade é capital e pertence ao PR");
                }
                else
                {
                    Console.WriteLine("Esta cidade pertence ao PR");
                }
                    
             }  else if (santaCatarina.Contains(local))
                {
                    if(local == "Florianópolis")
                    {
                        Console.WriteLine("Esta cidade é capital e pertence a SC");
                    }
                    else
                    {
                        Console.WriteLine("Esta cidade pertence ao SC");
                    }

            }
            else
            { 
                  if (local == "Porto Alegre")
                    {
                        Console.WriteLine("Esta cidade é capital e pertence a RS");
                    }
                    else
                    {
                        Console.WriteLine("Esta cidade pertence ao RS");
                    }

             }

        }

    }
}
