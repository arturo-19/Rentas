using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
   public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var ciudad1 = new Ciudad();
            ciudad1.Residencia = "San Pedro Sula";
            contexto.Ciudades.Add(ciudad1);

            var ciudad2 = new Ciudad();
            ciudad2.Residencia = "La Ceiba";
            contexto.Ciudades.Add(ciudad2);

            var ciudad3 = new Ciudad();
            ciudad3.Residencia = "Teguscigalpa";
            contexto.Ciudades.Add(ciudad3);

            var ciudad4 = new Ciudad();
            ciudad4.Residencia = "Olancho";
            contexto.Ciudades.Add(ciudad4);

            var ciudad5 = new Ciudad();
            ciudad5.Residencia = "Santa Barbara";
            contexto.Ciudades.Add(ciudad5);


            base.Seed(contexto);
        }
    }
}
