using System;

namespace POO_C_ {

    class persona {
        // atributes
       private string id;
       private string nombre;
        //constructor
        public persona (string id_, string nombre_) {
            this.id=id_;
            this.nombre=nombre_;
        }
        // SETTER Y GETTER
        public string getId() {
         return this.id; 
        }
        public string getNombre() {
           return  this.nombre; 
        }

    }
    class Program {
        static void Main (string[] args) {
            var alumno = new persona("1","juan");
            Console.WriteLine(alumno.getId());
            Console.WriteLine(alumno.getNombre());
           
        }
    }
}