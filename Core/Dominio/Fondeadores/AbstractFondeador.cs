using System;
using System.Collections.Generic;
using System.Text;
using Core.Dominio;

namespace Core.Dominio.Fondeadores
{
    public abstract class AbstractFondeador
    {
        private int ID;
        private string Nombre;
        protected delegate bool Condicion(Prestamo prestamo);
        protected List<Condicion> Condiciones;
        public List<TipoDocumento> DocumentosRequeridos;

        public bool CumpleCondiciones(Prestamo prestamo) {
            foreach (var _condicion in Condiciones)
            {
                if (!_condicion(prestamo)) 
                    return false;                
            }
            return true;            
        }
    }
}
