namespace Athletic
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 8일
        /// 문제 : (25314)  N바이트 정수까지 저장할 수 있다고 생각해서 칠판에 쓴 정수 자료형의 이름은 무엇일까?
        /// url : https://www.acmicpc.net/status?user_id=sinhaoon&problem_id=25314&from_mine=1
        /// </summary>
        static void Main(string[] args)
        {
            //4배수 n을 받아온다
            int n = int.Parse(Console.ReadLine());
            //아닐경우 어쩌지

            //n/4를 계산
            int num = n / 4;

            //나온 값 만큼  for문 반복해서
            for (int i = 0; i < num; i++)
            {
                // long을 붙여준다
                Console.Write("long ");
            }

            //마지막에 int 를 붙여준다.
            Console.Write("int");
        }
    }
}
