using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoomDigital
{
    public class AcertijoComputadora : Acertijo, IResoluble
    {
        private int numeroSecreto;

        public AcertijoComputadora()
        {
            Random rand = new Random();
            int a = rand.Next(2, 9); // Evitamos el 1 y el 0 para que sea más interesante
            int b = rand.Next(2, 9);

            // Regla lógica del acertijo matemático
            numeroSecreto = (a * b) + 10;

            // Guardamos la pregunta con formato legible para la interfaz
            Pregunta = $"[SISTEMA BLOQUEADO]\n\nPara acceder, ingresa el código de verificación.\n\nPista del procesador: (X * Y) + 10\nDonde X = {a} e Y = {b}";
            Intentos = 3;
        }

        public override bool ValidarRespuesta(string respuesta)
        {
            return respuesta == numeroSecreto.ToString();
        }

        public bool Resolver(string respuesta)
        {
            if (ValidarRespuesta(respuesta))
            {
                return true;
            }
            else
            {
                Intentos--; // Restamos un intento si falla
                return false;
            }



        }
    }
}
