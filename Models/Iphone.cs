namespace DesafioPOO.Models
{
    // iPhone Herda da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Implementando herança entre os construtores da classe herdada e a classe abstrata
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string app)
        {
            Console.WriteLine($"Instalando o aplicativo {app} no iPhone");
        }
    }

}