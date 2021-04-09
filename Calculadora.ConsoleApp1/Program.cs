using System;

namespace Calculadora.ConsoleApp1
{
    class Program
    {
        #region Requisito 01 [OK]
        //Nossa calculadora deve ter a possibilidade de somar dois números
        #endregion

        #region Requisito 02 [OK]
        //Nossa calculadora deve ter a possibilidade fazer várias operações de soma
        #endregion

        #region Requisito 03 [OK]
        //Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração
        #endregion

        #region Requisito 04 [OK]
        //Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática
        #endregion

        #region Requisito 05 [OK]
        //Nossa calculadora deve validar a opções do menu [OK]
        #endregion

        #region BUG 01 [OK]
        //Nossa calculadora deve realizar as operações com "0"
        #endregion

        #region Requisito 06
        /** Nossa calculadora deve permitir visualizar as operações já realizadas
         *  Critérios:
         *      1 - A descrição da operação realizada deve aparecer assim, exemplo:
         *          2 + 2 = 4
         *          10 - 5 = 5
         */
        #endregion
        static void Main(string[] args)
        {
            string[] operacoesRealizadas = new string[100];
            int contadorOperacoes = 0;
            string opcao = "";
            

            while (true)
            {
                //1.5.1 app 1 verão 5 correção de bug 1
                Console.WriteLine("Calculador 1.5.1");
                Console.WriteLine("Digite 1 para somar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4 para dividir");
                Console.WriteLine("Digite 5 para visualizar as operações");
                Console.WriteLine("Digite S para sair");
                opcao = Console.ReadLine();
                if(opcao !="1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "s" && opcao != "S")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida Tente novamente");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
              
                if (opcao == "5")
                {
                    if (contadorOperacoes == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nenhuma operação realizada");
                        Console.ResetColor();
                    }
                    else
                    {
                        for (int i = 0; i < operacoesRealizadas.Length; i++)
                        {
                            if (operacoesRealizadas[i] != null)
                            {
                                Console.WriteLine(operacoesRealizadas[i]);
                            }
                        }
                    }
                    Console.ReadLine();
                    Console.Clear();
                    
                    continue;
                }
                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                double segundoNumero, primeiroNumero;
               
                    Console.WriteLine("Digite o primeiro número");

                    double.TryParse(Console.ReadLine(), out primeiroNumero);
               
                do
                {
                    Console.WriteLine("Digite o segundo número");
                    double.TryParse(Console.ReadLine(), out segundoNumero);
                    if (opcao == "4" && segundoNumero == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Impossível dividir por Zero");
                        Console.ResetColor();
                    }

                } while (opcao == "4" && segundoNumero == 0);
                string simboloOperacao="";
                string operacaoRealizada = "";
                double resultado = 0;
                switch (opcao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero; break;
                    case "2": resultado = primeiroNumero - segundoNumero; break;
                    case "3": resultado = primeiroNumero * segundoNumero; break;
                    case "4": resultado = primeiroNumero / segundoNumero; break;
                   
                    default: break;
                }
                switch (opcao)
                {
                    case "1": simboloOperacao = " + "; break;
                    case "2": simboloOperacao = " - "; break;
                    case "3": simboloOperacao = " * "; break;
                    case "4": simboloOperacao = " / "; break;
                    default: break;
                }
                operacaoRealizada = $"{primeiroNumero} {simboloOperacao} {segundoNumero} = {resultado}";
                
                operacoesRealizadas[contadorOperacoes] = operacaoRealizada;
                contadorOperacoes++;
                Console.WriteLine("Resultado: "+resultado);
                Console.ReadLine();
                Console.Clear();
            } 

            
        }
        private static bool validaNumero()
        {
            double numeroValido;
            try
            {
                 numeroValido = Convert.ToDouble(Console.ReadLine());
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
