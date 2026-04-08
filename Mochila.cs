public class Mochila
{
    private static int iterations = 0;

    public static int OrganizarMochila(int[] pesos, int[] valores, int capacidade)
    {
        // 3. Resolva o problema da mochila conforme o enuciado em sala de aula. 

        // * Ache uma solução que testa todas as combinações possíveis e seleciona a melhor, aplicando divisão-e-conquista ou não;
        // * Contabilize o número de iterações;
        // * Implemente e teste sua solução, para o caso exposto em aula e outros de mesmo porte (;-).

        int n = pesos.Length;
        int[,] K = new int[n + 1, capacidade + 1];
        for (int i = 1; i <= n; i++)
        {
            iterations++;
            for (int w = 0; w <= capacidade; w++)
            {
                iterations++;
                if (pesos[i - 1] > w)
                {
                    K[i, w] = K[i - 1, w];
                }
                else
                {
                    K[i, w] = Math.Max(K[i - 1, w], K[i - 1, w - pesos[i - 1]] + valores[i - 1]);
                }
            }
        }
        return K[n, capacidade];
    }

        public static void Main(string[] args)
    {
        // CASOS DE TESTE:
        // 1) Capacidade: 165
        //    Pesos:  23, 31, 29, 44, 53, 38, 63, 85, 89, 82
        //    Valores: 92, 57, 49, 68, 60, 43, 67, 84, 87, 72
        //    Blocos selecionados: 1, 2, 3, 4, 6

        // 2) Capacidade: 190
        //    Pesos:  56, 59, 80, 64, 75, 17
        //    Valores: 50, 50, 64, 46, 50, 05
        //    Blocos selecionados: 1, 2 e 5

            int[] pesos = {56, 59, 80, 64, 75, 17 };
            int[] valores = { 50, 50, 64, 46, 50, 05 };
            int capacidade = 190;
            iterations = 0;
            int resultado = OrganizarMochila(pesos, valores, capacidade);
            System.Console.WriteLine($"Valor máximo na mochila: {resultado}, Iterações: {iterations}");
    }

     /*
        --------------------------------------------
        | Execução    |      resultado             |
        --------------------------------------------
        | Caso 1      |Valor máximo na mochila: 309|
        |             |Iterações: 1670             |
        --------------------------------------------
        | Caso 2      |Valor máximo na mochila: 150|
        |             |Iterações: 1152             |
        --------------------------------------------
        */
}