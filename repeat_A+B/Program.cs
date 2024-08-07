namespace repeat_A_B
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 7일
        /// 문제 : (10950) 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
        /// url : https://www.acmicpc.net/problem/10950
        /// </summary>
        /// 
        static void Main(string[] args)
        {
            
            int t = int.Parse(Console.ReadLine());

                int[] a = new int[t];
                int[] b = new int[t];
            
            for (int i = 0; i < t; i++) 
            {
                string[] inputs = Console.ReadLine().Split();   
                int.TryParse(inputs[0], out a[i]);
                int.TryParse(inputs[1], out b[i]);

            }

            
            for(int i = 0;i < t; i++)
            {
                int sum = a[i] + b[i];
                Console.WriteLine($"{sum}");
                
            }

            
        }
    }
}
