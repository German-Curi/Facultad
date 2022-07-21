using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class alumno
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String TipoDocumento { get; set; }
        public int NroDocumento { get; set; }
        public int Edad { get; set; }   //DEBERIA SER FECHA DE NACIMIENTO
        public int Telefono { get; set; }
        public String Email { get; set; }
        public String Clave { get; set; }
        public String DVH { get; set; }
        public bool Estado { get; set; }

        public alumno() : this(0, "", "", "", 0, 0, 0, "", "", false) { }

        public alumno(int ID, String Nombre, String Apellido, String TipoDocumento, int NroDocumento, int Edad, int Telefono, String Email, String Clave, bool Estado)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.TipoDocumento = TipoDocumento;
            this.NroDocumento = NroDocumento;
            this.Edad = Edad;
            this.Telefono = Telefono;
            this.Email = Email;
            this.Clave = Clave;
            this.Estado = Estado;
        }
    }
}
