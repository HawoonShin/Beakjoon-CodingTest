namespace Star02
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 9일
        /// 문제 : (2439) 첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제
        /// url : https://www.acmicpc.net/problem/2439
        /// </summary>
        static void Main(string[] args)
        {
            //줄수 n 
            int n = int.Parse(Console.ReadLine());

            //역으로 별찍기
            for (int i = 0; i < n; i++) 
            {
                for(int j = n; j >i+1; j--)
                {
                    Console.Write(" ");
                }
                for(int j = 0;j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
