using System.Globalization;
using System.Runtime.CompilerServices;
using System;

namespace POO_C_ {

    class persona {
        // atributes
        public string id;
        public string nombre;
        //constructor
        public persona (string id_,string nombre_) {
            this.id=id_;
            this.nombre = nombre_;
        }
    }
    class Program {
        static void Main (string[] args) {
            var alumno = new persona ("1","juan");
            Console.WriteLine ("El id es : " + alumno.id);
            Console.WriteLine ("El nombre es : " + alumno.nombre);
        }
    }
}