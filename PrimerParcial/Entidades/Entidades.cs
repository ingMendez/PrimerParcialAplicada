using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PrimerParcial.Entidades
{
    
  
        public class Vendedor
        {

            [Key]

            public int VendedorId { get; set; }

            public string Nombre { get; set; }

            public int sueldo { get; set; }

            public int rotacion { get; set; }

            public int retencion { get; set; }

            public Vendedor()
            {
                VendedorId = 0;
                 Nombre = string.Empty;
                sueldo = 0;
                rotacion = 0;
                retencion = 0;
            }


        }
    }
