using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    public class PedidoLocal : Pedido
    {
        private const double PctServico = 0.10;

        public PedidoLocal() : base()
        {
        }

        private double TaxaServico()
        {
            return Subtotal() * PctServico; 
        }

        public override double PrecoAPagar()
        {
            return Subtotal() + TaxaServico();
        }

        protected override string RodapePedido()
        {
            StringBuilder relat = new StringBuilder();
            relat.AppendLine($"TAXA DE SERVIÇO (10%): {TaxaServico():C2}");
            relat.AppendLine($"\nTOTAL DO PEDIDO: {PrecoAPagar():C2}");
            return relat.ToString();
        }
    }
}
