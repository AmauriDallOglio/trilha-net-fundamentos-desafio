namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        /// <summary>
        // // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
        /// </summary>
        /// <param name="es"></param>
        /// <returns></returns>
        public Estacionamento AdicionarVeiculo(Estacionamento es)
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            es.veiculos.Add(placa);
            int contador = es.veiculos.Count();
            Console.WriteLine($"A placa digitada foi: {placa}");
            Console.WriteLine($"Existem: {contador} veículos");
            return es;
        }

        /// <summary>
        /// Pedir para o usuário digitar a placa e armazenar na variável placa
        /// Verifica se o veículo existe
        /// TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
        /// TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal  
        /// TODO: Remover a placa digitada da lista de veículos
        /// </summary>
        /// <param name="es"></param>
        public void RemoverVeiculo(Estacionamento es)
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                
                decimal valorTotal = es.precoInicial + es.precoPorHora * horas;

                es.veiculos.Remove(placa);
                int contador = es.veiculos.Count();
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal} ");
                Console.WriteLine($"Existem: {contador} veículos");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        /// <summary>
        /// Verifica se há veículos no estacionamento
        /// Realizar um laço de repetição, exibindo os veículos estacionados
        /// </summary>
        /// <param name="es"></param>
        public void ListarVeiculos(Estacionamento es)
        {
            if (es.veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                int contador = 0;
                foreach (var item in es.veiculos.ToList())
                {
                    contador++;
                    Console.WriteLine($"Placas: {item} ");
                }
                Console.WriteLine($"Existem: {contador} veículos");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
