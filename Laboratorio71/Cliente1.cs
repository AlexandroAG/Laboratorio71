﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio71
{
    internal class Cliente1
    {
        private string nombre;
        private int monto;

        public Cliente1(string nom)
        {
            nombre = nom;
            monto = 0;
        }

        public void Depositar(int m)
        {
            monto = monto + m;
        }

        public void Extraer(int m) 
        {
            monto = monto - m;
        }

        public int RetornarMonto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene depositado la suma de : " + monto);
        }

    }
}
