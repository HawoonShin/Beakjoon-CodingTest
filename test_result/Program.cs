namespace test_result
{
    /// <summary>
    /// 2024년 8월 6일
    /// 문제 : (9498)시험 점수를 입력받아 90 ~ 100점은 A,
    /// 80 ~ 89점은 B, 70 ~ 79점은 C, 60 ~ 69점은 D,
    /// 나머지 점수는 F를 출력하는 프로그램을 작성하시오.
    /// url : https://www.acmicpc.net/problem/9498
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // 입력받기
            string[] input = Console.ReadLine().Split();
            int.TryParse(input[0], out int result);

            //점수별로 나누기
            //if문

            //90~100
            if (result > 89)
            {
                Console.WriteLine("A");
            }
            //80~89
            else if (result > 79)
            {
                Console.WriteLine("B");
            }
            //70~79
            else if (result > 69)
            {
                Console.WriteLine("C");
            }
            //60~69
            else if (result > 59)
            {
                Console.WriteLine("D");
            }
            //넌 f야
            else
            {
                Console.WriteLine("F");
            }


        }
    }
}
