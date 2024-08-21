namespace LittelNum
{
    /// <summary>
    /// 2024년 8월 20일
    /// 문제 : (10871) 정수 N개로 이루어진 수열 A와 정수 X가 주어진다. 
    /// 이때, A에서 X보다 작은 수를 모두 출력하는 프로그램을 작성하시오.
    /// url : https://www.acmicpc.net/problem/10871
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //n 과 x 받아요
            string[] input = Console.ReadLine().Split();
            int.TryParse(input[0], out int n );
            int.TryParse(input[1], out int x );

            //수열 a 정수 n개 주어짐
            string[] input2 = Console.ReadLine().Split();
            int[] array = new int[n];
            for (int i = 0; i < n; i++) 
            {
                int.TryParse(input2[i],out array[i]);
            }
            //x보다 작은 수 출력
            for (int i = 0; i < n; i++) 
            {
                if (array[i] < x)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
