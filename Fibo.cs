public class Fibonacci
{
    private static int iterations = 0;
    private static int instructions = 0;

    public static int FiboRec(int n)
    {
//         ```
//          FIBO-REC (n)
//              se n ≤ 1
//              então devolva n
//              senão a ← FIBO-REC (n − 1)
//                  b ← FIBO-REC (n − 2)
//                  devolva a + b
//          ```
        iterations++;
        if (n <= 1) {
            instructions++;
            return n;
        }
        instructions++;
        return FiboRec(n - 1) + FiboRec(n - 2);
    }

    public static int Fibo(int n)
    {
//          ```
//          FIBO (n)
//              f [0] ← 0 
// 	        f [1] ← 1
// 	        para i ← 2 até n faça
//                    f[i] ← f[i-1]+f[i-2]
//   	        devolva f [n]
//          ```
        instructions++;
        int[] f = new int[n + 1];
        instructions++;
        f[0] = 0;
        instructions++;
        f[1] = 1;
        for (int i = 2; i <= n; i++)
        {
            instructions++;
            f[i] = f[i - 1] + f[i - 2];
            iterations++;
        }
        instructions++;
        return f[n];
    }

    public static int MemoizedFibo(int[] f, int n)
    {
//          ```
//          MEMOIZED-FIBO (f, n)
// 	        para i ← 0 até n faça
// 	            f [i] ← −1
// 	        devolva LOOKUP-FIBO (f, n)

        for (int i = 0; i <= n; i++)
        {
            instructions++;
            f[i] = -1;
            iterations++;
        }
        instructions++;
        return LookupFibo(f, n);
    }

    public static int LookupFibo(int[] f, int n)
    {
//          LOOKUP-FIBO (f, n)
// 	        se f [n] ≥ 0
//              então devolva f [n]
//       	se n ≤ 1
// 	        então f [n] ← n
// 	        senão f [n] ← LOOKUP-FIBO(f, n − 1) + LOOKUP-FIBO(f, n − 2)
// 	        devolva f [n]
//          ``` 
        iterations++;
        if (f[n] >= 0) {
            instructions++;
            return f[n];
        }
        if (n <= 1) {
            instructions++;
            f[n] = n;
        } else {
            instructions++;
            f[n] = LookupFibo(f, n - 1) + LookupFibo(f, n - 2);
        }
        return f[n];
    }

    public static void Main(string[] args)
    {
        // 1. Dadas as três versões de implementação de Fibonacci abaixo:
    
        //  * implemente os algortimos;
        iterations = 0;
        instructions = 0;

        //  * teste todos para os inteiros 4, 8, 16, 32;
        System.Console.WriteLine($"FiboRec(4) = {FiboRec(4)}");
        System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        iterations = 0;
        instructions = 0;
        System.Console.WriteLine($"Fibo(4) = {Fibo(4)}");
        System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        iterations = 0;
        instructions = 0;
        System.Console.WriteLine($"MemoizedFibo(4) = {MemoizedFibo(new int[5], 4)}");
        System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        iterations = 0;
        instructions = 0;

        // System.Console.WriteLine($"FiboRec(8) = {FiboRec(8)}");
        // System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        // iterations = 0;
        // instructions = 0;
        // System.Console.WriteLine($"Fibo(8) = {Fibo(8)}");
        // System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        // iterations = 0;
        // instructions = 0;
        // System.Console.WriteLine($"MemoizedFibo(8) = {MemoizedFibo(new int[9], 8)}");
        // System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        // iterations = 0;
        // instructions = 0;

        // System.Console.WriteLine($"FiboRec(16) = {FiboRec(16)}");
        // System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        // iterations = 0;
        // instructions = 0;
        // System.Console.WriteLine($"Fibo(16) = {Fibo(16)}");
        // System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        // iterations = 0;
        // instructions = 0;
        // System.Console.WriteLine($"MemoizedFibo(16) = {MemoizedFibo(new int[17], 16)}");
        // System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        // iterations = 0;
        // instructions = 0;

        // System.Console.WriteLine($"FiboRec(32) = {FiboRec(32)}");
        // System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        // iterations = 0;
        // instructions = 0;
        // System.Console.WriteLine($"Fibo(32) = {Fibo(32)}");
        // System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        // iterations = 0;
        // instructions = 0;
        // System.Console.WriteLine($"MemoizedFibo(32) = {MemoizedFibo(new int[33], 32)}");
        // System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        // iterations = 0;
        // instructions = 0;

        // //  * teste os dois últimos também para os inteiro 128, 1000 e 10.000.
        // System.Console.WriteLine($"Fibo(128) = {Fibo(128)}");
        // System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        // iterations = 0;
        // instructions = 0;
        // System.Console.WriteLine($"MemoizedFibo(128) = {MemoizedFibo(new int[129], 128)}");
        // System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        // iterations = 0;
        // instructions = 0;

        // System.Console.WriteLine($"Fibo(1000) = {Fibo(1000)}");
        // System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        // iterations = 0;
        // instructions = 0;
        // System.Console.WriteLine($"MemoizedFibo(1000) = {MemoizedFibo(new int[1001], 1000)}");
        // System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        // iterations = 0;
        // instructions = 0;

        // System.Console.WriteLine($"Fibo(10000) = {Fibo(10000)}");
        // System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        // iterations = 0;
        // instructions = 0;
        // System.Console.WriteLine($"MemoizedFibo(10000) = {MemoizedFibo(new int[10001], 10000)}");
        // System.Console.WriteLine($"Iterações: {iterations}, Instruções: {instructions}");
        // iterations = 0;
        // instructions = 0;

        // 2. Monte uma tabela com a contabilização das execuções anteriores (número de iterações e número 
        // de instruções) e com os resultados das execuções. As linhas da tabela são os algoritmos implementados,
        // as colunas os valores para testar e contabilizar.

        /*
        --------------------------------------------------------------------------------------------------------
        | Algoritmo    |      4      |       8      |    16    |    32    |   128   |   1000   |    10000      |
        --------------------------------------------------------------------------------------------------------
        | FiboRec      |Iterações:9  |              |          |          |         |          |               |
        |              |Intruções:9  |              |          |          |         |          |               |
        --------------------------------------------------------------------------------------------------------
        | Fibo         |Iterações:3  |              |          |          |         |          |               |
        |              |Intruções:7  |              |          |          |         |          |               |
        --------------------------------------------------------------------------------------------------------
        | MemoizedFibo |Iterações:12 |              |          |          |         |          |               |
        |              |Intruções:13 |              |          |          |         |          |               |
        --------------------------------------------------------------------------------------------------------
        */

    }
}