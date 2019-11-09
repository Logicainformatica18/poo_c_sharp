using System;

namespace POO_C_ {

    class persona {
        // atributes
       private string id;
       private string nombre;

        // SETTER Y GETTER
        public string getId() {
         return this.id; 
        }

        public void setId(string value_) {
            this.id = value_;
        }

        public string getNombre() {
           return  this.nombre; 
        }

        public void setNombre(string value) {
            this.nombre = value;
        }

    }
    class Program {
        static void Main (string[] args) {
            var alumno = new persona ();
            alumno.setId("1");
            alumno.setNombre("juan");
            Console.WriteLine(alumno.getId());
            Console.WriteLine(alumno.getNombre());
           
        }
    }
}