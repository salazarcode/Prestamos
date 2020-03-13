using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dominio.Fondeadores
{
    public class CoopacFondeador : AbstractFondeador
    {
        public CoopacFondeador() {
            this.Condiciones = new List<Condicion>() {
                (Prestamo p) => { 
                    //Se valida que una condicion x sea cierta
                    if(p.ID != 0)
                        return true;
                    return false;
                },
                (Prestamo p) => true,
                (Prestamo p) => true
            };
        }
    }
}
