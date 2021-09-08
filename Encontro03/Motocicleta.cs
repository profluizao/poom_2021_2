using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public class Motocicleta : Veiculo
    {
        public override string Proprietario
        {
            get => this.proprietario;
            set => this.proprietario = value;
        }

        public int Cilindradas { get; set; }

        public override void Ligar()
        {
            Console.WriteLine("Ligando a motocicleta.");
        }

        public override void Desligar()
        {
            Console.WriteLine("Desligando a motocicleta.");
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Classe Motocicleta tem estes valores:");
            Console.WriteLine("Cilindradas: {0}", this.Cilindradas);
        }

        public Motocicleta()
        { }
    }
}
