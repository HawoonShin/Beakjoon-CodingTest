namespace A_B_4
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 11일
        /// 문제 : (10951) 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
        /// url : https://www.acmicpc.net/problem/10951
        /// </summary>
        static void Main(string[] args)
        {
            while (true)
            {
              
                string inputs = Console.ReadLine();
                if (string.IsNullOrEmpty(inputs)) break;
                else
                {
                    string[] num = inputs.Split();
                    int.TryParse(num[0], out int a);
                    int.TryParse(num[1], out int b);

                int sum = a + b;
                Console.WriteLine(sum);
                }
            }
        }
    }
}
