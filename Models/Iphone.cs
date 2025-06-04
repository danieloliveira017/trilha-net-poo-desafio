namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(List<string> nomeApp)
        {

            foreach (var app in nomeApp) {
            Console.WriteLine($"App instalados no {Modelo}: {app}");
        }
            
        }
    }
}