namespace MaxAndMin
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 22일
        /// 문제 : (10818) N개의 정수가 주어진다. 
        /// 이때, 최솟값과 최댓값을 구하는 프로그램을 작성하시오.
        /// url : https://www.acmicpc.net/problem/10818
        /// </summary>
        static void Main(string[] args)
        {
            //n개의 정수가 주어진다
            //최대값 최소값을 구한다

            //n개를 받는다.
            int.TryParse(Console.ReadLine(), out int n);

            //수열을 만든다
            int[] array = new int[n];

            //최대값 변수와 최소값 변수 생성

            //수열을 받는다
            string[] inputs = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                int.TryParse(inputs[i], out array[i]);
            }

            int max = array[0];
                int min = array[0];
            for (int i =0; i < n; i++)
            {

                if (array[i] > max)
                {
                    max = array[i];
                }
                else if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine($"{min} {max}");

        }
    }
}
