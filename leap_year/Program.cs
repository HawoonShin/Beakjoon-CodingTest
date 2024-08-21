namespace leap_year
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 6일
        /// 문제 :연도가 주어졌을 때, 윤년이면 1, 아니면 0을 출력하는 프로그램을 작성하시오.
        /// url : https://www.acmicpc.net/problem/2753
        /// </summary>
        static void Main(string[] args)
        {
            //윤년은 연도가 4의 배수이면서, 100의 배수가 아닐 때 또는 400의 배수일 때이다.
            //예를 들어, 2012년은 4의 배수이면서 100의 배수가 아니라서 윤년이다.
            //1900년은 100의 배수이고 400의 배수는 아니기 때문에 윤년이 아니다.
            //하지만, 2000년은 400의 배수이기 때문에 윤년이다.

            //년도 입력 받기
            string[] inputs = Console.ReadLine().Split();
            int.TryParse(inputs[0], out int year);

            //윤년 = 1
            //4의 배수이면서 100의 배수가 아닐때
            // year%4 ==0 && year%100 != 0
            if (year % 4 == 0 && year % 100 != 0)
            {
                //Console.WriteLine("1");
                Console.WriteLine("1"); 
            }
            //400의 배수일때
            // year%400 == 0
            else if (year % 400 == 0)
            {
                Console.WriteLine("1");
            }

            //나머지 윤년아님 =0
            else {Console.WriteLine("0"); }
            

        }
    }
}
