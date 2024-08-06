namespace Quadrant
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 7일
        /// 문제 : (14681)사분면 고르기
        /// 점의 좌표를 입력받아 그 점이 어느 사분면에 속하는지 알아내는 프로그램을 작성하시오.
        /// 단, x좌표와 y좌표는 모두 양수나 음수라고 가정한다.
        /// url : https://www.acmicpc.net/problem/14681
        /// </summary>
        static void Main(string[] args)
        {
            // 정수 x
            //int x;
            // 정수 y
            //int y;

            //계속 런타임 오류가 발생했었는데
            //문제에서 원하는 입력 방식이 다름
           

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            // 숫자 받고
            //기존의 입력 방식은 숫자 숫자의 형식이었지만
            //이번 문제의 원하는 방식은 숫자(엔터)숫자 의 형태임으로 밑의 방식을 사용하면
            //런타임 오류가 발생한다.

            // string[] inputs = Console.ReadLine().Split();
            // int.Parse(inputs[0], out int x);
            // int.TParse(inputs[1], out int y);

            // 그 숫자가 양수인지 음수인지 판단하고
            // 양수 음수인지에 따라서

            //양수 양수 1분면
            if (x > 0 && y > 0 && 1000 >= x && 1000 >= y)
            {
                Console.WriteLine("1");
            }

            //음수 양수 2분면
            else if (x < 0 && y > 0 && -1000 <= x && 1000 >= y)
            {
                Console.WriteLine("2");
            }

            //음수 음수 3분면
            else if (x < 0 && y < 0 && -1000 <= x && -1000 <= y)
            {
                Console.WriteLine("3");
            }

            //양수 음수 4분면
            else if (x > 0 && y < 0 && 1000 >= x && -1000 <= y)
            {
                Console.WriteLine("4");
            }

            else
            {

            }

        }
    }
}
