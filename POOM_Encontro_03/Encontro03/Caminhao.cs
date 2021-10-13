using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public class Caminhao : MedidasVeiculo
    {
        public override string Proprietario
        {
            get => this.proprietario;
            set => this.proprietario = value;
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando o caminhão.");
        }


        public override void Desligar()
        {
            Console.WriteLine("Desligando o caminhão.");
        }

        public int QtdDeEixos { get; set; }

        public Caminhao() : base()
        { }

    }
}
