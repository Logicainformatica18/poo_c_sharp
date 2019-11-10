using System;
namespace POO_C_ {

    class Program {
        static void Main (string[] args) {
            var zona1=new zona("San Juan de Lurigancho");
            var alumno_cesca = new alumno ("Anthony", "Cardenas", "110869000805", zona1);
            Console.WriteLine (alumno_cesca.getNombres ());
            Console.WriteLine (alumno_cesca.getPaterno ());
            Console.WriteLine (alumno_cesca.getCod_carnet ());
            Console.WriteLine(zona1.getZonal());

        }
    }
}