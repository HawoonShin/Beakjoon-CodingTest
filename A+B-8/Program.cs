namespace A_B_8
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 9일
        /// 문제 : (11022) 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
        /// url : https://www.acmicpc.net/problem/11022
        /// </summary>
        static void Main(string[] args)
        {
            // 반복횟수 받아요
            int n = int.Parse(Console.ReadLine());

            int[] sum = new int[n];
            int[] a = new int[n];
            int[] b = new int[n];


            for (int i = 0; i < n; i++)
            {
                //a. b 받아요
                string[] input = Console.ReadLine().Split();
                int.TryParse(input[0], out a[i]);
                int.TryParse(input[1], out b[i]);

                sum[i] = a[i] + b[i];
            }

            //Case #x: A + B =C의 형식으로 출력
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Case #{i+1}: {a[i]} + {b[i]} = {sum[i]}");
            }
        }
    }
}
