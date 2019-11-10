namespace POO_C_ {
    class alumno : persona{
        // atributes
        private string cod_carnet;
        //constructor
        public alumno(string nombres_,string paterno_, string cod_carnet_) {
            base.nombres=nombres_;
            base.paterno = paterno_;
            this.cod_carnet=cod_carnet_;
        }
        //GETTER
        public string getCod_carnet() {
            return this.cod_carnet;
        }

    }
}