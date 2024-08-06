namespace Compare
{
    /// <summary>
    /// 2024년 8월 6일
    /// 문제 : 두 정수 A와 B가 주어졌을 때, A와 B를 비교하는 프로그램을 작성하시오.
    /// url : https://www.acmicpc.net/problem/1330
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //입력받기
            string[] inputs = Console.ReadLine().Split();
            int.TryParse(inputs[0], out int a);
            int.TryParse(inputs[1], out int b);

            //비교하기
            if (a > b)
            {
                Console.WriteLine(">");
            }
            else if (a < b)
            {
                Console.WriteLine("<");
            }
            else
            {
                //출력하기
                Console.WriteLine("==");
            }

        }
    }
}
