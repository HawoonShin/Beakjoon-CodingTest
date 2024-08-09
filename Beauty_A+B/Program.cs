namespace Beauty_A_B
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 9일
        /// 문제 : (11021) 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
        /// url : https://www.acmicpc.net/problem/11021
        /// </summary>
        static void Main(string[] args)
        {
            //첫줄 테스트 케이스 받음
            int n = int.Parse(Console.ReadLine());

            int[] sum = new int[n];
            for (int i = 0; i < n; i++) 
            { 
            //a.b 받아용
            string[] input = Console.ReadLine().Split();
            int.TryParse(input[0], out int a);
            int.TryParse(input[1], out int b);

                //밑에 덧샘을 받음
                sum[i] = a+b;

            }

            //출력은 Case #x: 로 출력한다
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine($"Case #{i+1}: {sum[i]}");
            } 
        }
    }
}
