﻿using System;
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

            public decimal Sueldo { get; set; }

            public decimal Rotacion { get; set; }

            public decimal Retencion { get; set; }

        public DateTime Fecha { get; set; }

        public Vendedor()
            {
                VendedorId = 0;
                Nombre = string.Empty;
                Sueldo = 0;
                Rotacion = 0;
                Retencion = 0;
                Fecha = DateTime.Now;
            }


        }
    }
