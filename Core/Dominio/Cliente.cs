using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dominio
{
    public class Cliente
    {
        public int ID;
        public string Nombres;
        public List<Prestamo> prestamos;
    }
}
