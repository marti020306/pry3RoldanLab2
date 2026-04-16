using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry3RoldanLab2
{
    internal class Vector
    {
        //Declaración de REGISTRO
        public struct RegCliente
        {
            public Int32 Codigo;
            public String Usuario;
            public Decimal Deuda;
            public Decimal Limite;
        }
        //Declaración del VECTOR
        static public RegCliente[] Clientes = new RegCliente[10];

        //Declaración del INDICE
        static public Int32 IND = 0;
    }
}
