using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_dotnet_smartphone.Models {
    public abstract class Smartphone {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string Numero, string Modelo, string IMEI, int Memoria) {
            this.Numero = Numero;
            this.Modelo = Modelo;
            this.IMEI = IMEI;
            this.Memoria = Memoria;
        }

        public void Ligar() {
            Console.WriteLine("ligando...");
        }

        public void ReceberLigacao() {
            Console.WriteLine("Recebendo ligação");
        }

        public abstract void InstalarAplicacao(string nome); 

    }
}
