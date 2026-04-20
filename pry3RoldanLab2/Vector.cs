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
        public struct RegCli
        {
            public Int32 Codigo;
            public String Nombre; // Renombrado desde Usuario a Nombre
            public Decimal Deuda;
            public Decimal Limite;
        }
        //Declaración del VECTOR
        static public RegCli[] Clientes = new RegCli[10];

        //Declaración del INDICE
        static public Int32 IND = 0;

        static public void CargaDatosDePrueba()
        {
            Clientes[IND].Codigo = 1;
            Clientes[IND].Nombre = "Nico";
            Clientes[IND].Deuda = 200;
            Clientes[IND].Limite = 1500;
            IND++;
            Clientes[IND].Codigo = 2;
            Clientes[IND].Nombre = "Ana";
            Clientes[IND].Deuda = 300;
            Clientes[IND].Limite = 4000;
            IND++;
            Clientes[IND].Codigo = 3;
            Clientes[IND].Nombre = "Diego";
            Clientes[IND].Deuda = 0;
            Clientes[IND].Limite = 3000;
            IND++;
            Clientes[IND].Codigo = 4;
            Clientes[IND].Nombre = "Seba";
            Clientes[IND].Deuda = 100;
            Clientes[IND].Limite = 2000;
            IND++;
        }
        public static void OrdenarPorCodigoAscendente()
        {
            Int32 i = 0;
            Int32 c = 0;
            RegCli Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Codigo > Clientes[i + 1].Codigo)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
        public static void OrdenarPorCodigoDescendente()
        {
            Int32 i = 0;
            Int32 c = 0;
            RegCli Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Codigo < Clientes[i + 1].Codigo)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
        public static void OrdenarPorNombreAscendente()
        {
            Int32 i = 0;
            Int32 c = 0;
            RegCli Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Nombre.CompareTo(Clientes[i + 1].Nombre) > 0)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
        public static void OrdenarPorNombreDescendente()
        {
            Int32 i = 0;
            Int32 c = 0;
            RegCli Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Nombre.CompareTo(Clientes[i + 1].Nombre) < 0)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
        public static void OrdenarPorLimiteAscendente()
        {
            Int32 i = 0;
            Int32 c = 0;
            RegCli Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Limite > Clientes[i + 1].Limite)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
        public static void OrdenarPorLimiteDescendente()
        {
            Int32 i = 0;
            Int32 c = 0;
            RegCli Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Limite < Clientes[i + 1].Limite)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
        public static void OrdenarPorDeudaAscendente()
        {
            Int32 i = 0;
            Int32 c = 0;
            RegCli Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Deuda > Clientes[i + 1].Deuda)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
        public static void OrdenarPorDeudaDescendente()
        {
            Int32 i = 0;
            Int32 c = 0;
            RegCli Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Deuda < Clientes[i + 1].Deuda)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }


    }
}
