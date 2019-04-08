﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class SubCelebridade {
        //Todos
        public string InfoPublica = "Tenho um instagram!";

        //herança
        protected string CorDosOlhos = "Verde";

        //mesmo projeto (assembly)
        internal ulong NumeroCelular = 445565442245;

        //herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //mesma class ou herança no mesmo projeto (C# >= 7.2)
        private protected string SegredoFamilia = "Bla Bla";

        //private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("SubCElebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
