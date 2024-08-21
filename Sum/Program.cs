namespace Sum
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 7일
        /// 문제 : (8393)n이 주어졌을 때, 1부터 n까지 합을 구하는 프로그램을 작성하시오.
        /// url : https://www.acmicpc.net/problem/8393
        /// </summary>
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
               
            }

            Console.WriteLine(sum);
        }
    }
}
