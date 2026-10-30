using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    public class Sobremesa : ItemPedido
    {
        private ESobremesa _tipo;
        public Sobremesa(ESobremesa tipo)
        {
            _tipo = tipo;
        }

        public override double CalcularValorFinal()
        {
            return _tipo switch
            {
                ESobremesa.BrigadeiroColher => 8.0,
                ESobremesa.PudimLeiteCondensado => 10.0,
                ESobremesa.DoceDeLeitePires => 9.0,
                _ => 0.0
            };
        }

        public override string ToString()
        {
            string nome = _tipo switch
            {
                ESobremesa.BrigadeiroColher => "Brigadeiro na Colher",
                ESobremesa.PudimLeiteCondensado => "Pudim de Leite Condensado",
                ESobremesa.DoceDeLeitePires => "Doce de Leite no Pires",
                _ => _tipo.ToString()
            };
            return $"Sobremesa: {nome} - {CalcularValorFinal():C2}";
        }
    }
}
