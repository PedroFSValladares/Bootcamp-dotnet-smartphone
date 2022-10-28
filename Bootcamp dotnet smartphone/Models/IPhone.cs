using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_dotnet_smartphone.Models {
    public class IPhone : Smartphone{

        public IPhone(string Numero, string Modelo, string IMEI, int Memoria) : 
            base(Numero, Modelo, IMEI, Memoria){
        }

        public override void InstalarAplicacao(string nome) {
            Console.WriteLine($"Instalando aplicação IOS {nome}...");
        }
    }
}
