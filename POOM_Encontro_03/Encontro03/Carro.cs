using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public class Carro : MedidasVeiculo
    {
        public override string Proprietario
        {
            get => this.proprietario;
            set => this.proprietario = value;
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando o carro.");
        }

        public override void Desligar()
        {
            Console.WriteLine("Desligando o carro.");
        }


        public bool Conversivel { get; set; }

        public Carro() : base()
        { }
    }
}
