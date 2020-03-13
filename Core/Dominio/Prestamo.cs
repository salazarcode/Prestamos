using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dominio
{
    public class Prestamo
    {
        public int ID;
        public DateTime Creacion;
        public double Capital;
        public List<Documento> DocumentosCargados;
    }
}
