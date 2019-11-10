using System.Runtime.CompilerServices;
namespace POO_C_ {
    class alumno : persona{
        // atributes
        private string cod_carnet;
        public object zonal;
        //constructor
        public alumno(string nombres_,string paterno_, string cod_carnet_,object zonal_) {
            base.nombres=nombres_;
            base.paterno = paterno_;
            this.cod_carnet=cod_carnet_;
            this.zonal=zonal_;
        }
        //GETTER
        public string getCod_carnet() {
            return this.cod_carnet;
        }

    }
}