using PrimerParcial.DAL;
using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace PrimerParcial.BLL
{
    public class VendedorBLL
    {


        // <summary
        /// </summary>
        /// <param name="vendedor"></param>
        /// <returns>retorna true si guardo y false sino guardo</returns>
        public static bool Guardar(Vendedor vendedor)
        {
            bool paso = false;
            // nuestra variable que nos dara acceso a la base de dato
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Vende.Add(vendedor) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Vendedor vendedor)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(vendedor).State = System.Data.Entity.EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Vendedor vendedor = contexto.Vende.Find(id);
                contexto.Vende.Remove(vendedor);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static Vendedor Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Vendedor vende = new Vendedor();
            try
            {
                vende = contexto.Vende.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return vende;
        }

        public static List<Vendedor> GetList(Expression<Func<Vendedor, bool>>expression)
        {
            List<Vendedor>  vendedor = new List<Vendedor>();
            Contexto contexto = new Contexto();

            try
            {
                vendedor = contexto.Vende.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return vendedor;
        }

        public decimal calculo(decimal retencion,decimal sueldo)
        {

            return retencion * sueldo;
        }

    }
}
