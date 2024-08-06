namespace A_B
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 6일
        /// 문제 :
        /// url :https://www.acmicpc.net/problem/1000
        /// </summary>
        static void Main(string[] args)
        {
            //문자 받기
            string[] inputs = Console.ReadLine().Split();
            int.TryParse(inputs[0], out int a );
            int.TryParse(inputs[1], out int b );
           
            //a+b
            int sum = a+ b;

            //출력하기
            Console.WriteLine(sum);
        }
    }
}
