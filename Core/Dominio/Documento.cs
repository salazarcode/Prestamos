using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dominio
{
    public class Documento
    {
        public int ID { get; set; }
        public TipoDocumento tipo { get; set; }

        public string Url { get; set; }
    }
}
