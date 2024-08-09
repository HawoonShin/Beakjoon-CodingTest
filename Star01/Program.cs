namespace Star01
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 9일
        /// 문제 : (2439) 첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제
        /// url : https://www.acmicpc.net/problem/2438
        /// </summary>
        static void Main(string[] args)
        {
            //몇번줄을 받을지 반복
            int n = int.Parse(Console.ReadLine());

            //포문 두번이면 될것도 같고...
            //줄수 포문
            for (int i = 0; i < n; i++)
            {
                //별 개수 포문
                for(int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
