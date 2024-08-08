using System.Text;

namespace Fast_A_B
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 9일
        /// 문제 : (1552) 첫 줄에 테스트케이스의 개수 T가 주어진다.
        /// T는 최대 1,000,000이다.
        /// 다음 T줄에는 각각 두 정수 A와 B가 주어진다.
        /// A와 B는 1 이상, 1,000 이하이다.
        /// url : https://www.acmicpc.net/problem/15552
        /// </summary>
        static void Main(string[] args)
        {
            //n줄 받습니다.
            int n = int.Parse(Console.ReadLine());

            int a;
            int b;

            int[] sum = new int[n];
            //a b 받아요
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int.TryParse(input[0], out a);
                int.TryParse(input[1], out b);
                sum[i] = a + b;
            }


            // 출력을 한꺼번에 하는 시스템
            // stringbuilder도 있지만, 일단 백준에서 제공하는 양식인
            // output stream 을 console에 연결해서 사용한다.
            /*
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            // 이 밑에 console.write를 사용한다.
            for (int i = 0; i < n; i++) {
                Console.WriteLine(sum[i]); }
            Console.Out.Flush();*/

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                //문제에서 요하는 답을 만들기 위해 스트링처럼 써주고
                //\n을 추가한다
                output.Append($"{sum[i]}\n");
            }

            Console.WriteLine(output.ToString());

        }
    }
}
