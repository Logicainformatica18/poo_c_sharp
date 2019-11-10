using System;
namespace POO_C_ {

    class Program {
        static void Main (string[] args) {
            var alumno_cesca = new alumno("Anthony","Cardenas","110869000805");
          Console.WriteLine(alumno_cesca.getNombres());
           Console.WriteLine(alumno_cesca.getPaterno());
          Console.WriteLine(alumno_cesca.getCod_carnet());
        }
    }
}