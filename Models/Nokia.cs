namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        public override void InstalarAplicativo(List<string> nomeApp)
        {
            foreach (var app in nomeApp)
            {
                Console.WriteLine($"App instalado no {Modelo}:{app}");
            }
            
        
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}