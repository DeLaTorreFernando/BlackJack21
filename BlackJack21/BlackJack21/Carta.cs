using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack21
{
    class Carta
    {
        public Palo palo { get; set; }
        public Cara cara { get; set; }
        public int Valor { get; set; }

        public enum Palo
        {
            Corazon,
            Diamante,
            Espada,
            Club
        }

        public enum Cara
        {
            As,
            Dos,
            Tres,
            Cuatro,
            Cinco,
            Seis,
            Siete,
            Ocho,
            Nueve,
            Diez,
            Payaso,
            Reyna,
            Rey,
        }
        
    }
}
