namespace multiplication_table
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 7일
        /// 문제 : (2739)N을 입력받은 뒤, 구구단 N단을 출력하는 프로그램을 작성하시오. 출력 형식에 맞춰서 출력하면 된다.
        /// url : https://www.acmicpc.net/status?user_id=sinhaoon&problem_id=2739&from_mine=1
        /// </summary>
        static void Main(string[] args)
        {
            //단 입력 받고
            int dan = int.Parse(Console.ReadLine());
            
            //구구단 출력
            //for문
            for(int i = 1; i<10;i++)
            {
                int mul = i * dan;
                Console.WriteLine($"{dan} * {i} = {mul}");
            }
        }
    }
}
