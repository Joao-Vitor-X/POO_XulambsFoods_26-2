using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    public class Bebida : ItemPedido
    {
        public EBebida _tipo;

        public Bebida(EBebida tipo)
        {
            _tipo = tipo;
        }

        public override double CalcularValorFinal()
        {
            return _tipo switch
            {
                EBebida.AguaDaCasa => 0.0,
                EBebida.AguaComGas => 4.0,
                EBebida.ChaComGas => 6.0,
                EBebida.Sucos => 9.0,
                EBebida.Cerveja => 15.0,
                EBebida.TacaDeVinho => 18.0,
                _ => 0.0
            };
        }

        public override string ToString()
        {
            string nome = _tipo switch
            {
                EBebida.AguaDaCasa => "Água da Casa",
                EBebida.AguaComGas => "Água com Gás",
                EBebida.ChaComGas => "Chá com Gás",
                EBebida.Sucos => "Sucos",
                EBebida.Cerveja => "Cerveja",
                EBebida.TacaDeVinho => "Taça de Vinho",
                _ => _tipo.ToString()
            };
            return $"Bebida: {nome} - {CalcularValorFinal():C2}";
        }
    }
}
