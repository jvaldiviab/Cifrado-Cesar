﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrado_Cesar
{
    class CifradoCesar
    {
        public static string Cifrado(string cad, int mov)
        {
            int[] Ascii = new int[cad.Length];
            char[] Arr = new char[cad.Length];
            int aux;
            for (int i = 0; i < cad.Length; i++)
            {
                Ascii[i] = Encoding.ASCII.GetBytes(cad)[i];
                if (Ascii[i] + mov > 90)
                {
                    aux = Ascii[i] + mov - 90 - 1;
                    Ascii[i] = 65 + aux;
                    Arr[i] = (char)(Ascii[i]);
                }
                else
                {
                    Arr[i] = (char)(Ascii[i] + mov);
                }

            }
            string cad2 = new string(Arr);
            return cad2;
        }
        public static string Descifrado(string cad1, int mov1)
        {
            int[] Ascii = new int[cad1.Length];
            char[] Arr = new char[cad1.Length];
            int aux;
            for (int i = 0; i < cad1.Length; i++)
            {
                Ascii[i] = Encoding.ASCII.GetBytes(cad1)[i];
                if (Ascii[i] - mov1 < 65)
                {
                    aux = 65 - (Ascii[i] - mov1) - 1;
                    Ascii[i] = 90 - aux;
                    Arr[i] = (char)(Ascii[i]);
                }
                else
                {
                    Arr[i] = (char)(Ascii[i] - mov1);
                }

            }
            string cad2 = new string(Arr);
            return cad2;
        }
    }
}
