namespace A_B_5
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 11일
        /// 문제 : (10952) 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
        /// url : https://www.acmicpc.net/problem/10952
        /// </summary>
        static void Main(string[] args)
        {
            int n = 1000;
            int[] sum = new int[n]; 
            //a,b 숫자 받습니다
            for (int i = 0; i < n; i++) 
            {
                string[] inputs = Console.ReadLine().Split();
                int.TryParse(inputs[0], out int a);
                int.TryParse(inputs[1], out int b);

                //마지막 0 0 받으면 종료
                if (a == 0 && b == 0) break;

                sum[i] = a+b;

            }

            //평소처럼 a+b 출력
            for (int i = 0; i < n; i++)
            {
                if (sum[i]  == 0) break;
                Console.WriteLine(sum[i]);
            }
        }
    }
}
