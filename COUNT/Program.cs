namespace COUNT
{
    /// <summary>
    /// 2024년 8월 17일
    /// 문제 : (10807) 개수 세기 
    /// 총 N개의 정수가 주어졌을 때, 정수 v가 몇 개인지 구하는 프로그램을 작성하시오.
    /// url : https://www.acmicpc.net/problem/10807
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //n개 정수가 주어졌을때 정수 v가 몇개인지 구하는 프로그램

            //n개를 받는다
            int n = int.Parse(Console.ReadLine());

            //n칸의 배열 만든다
            int[] array = new int[n];

            //n칸의 배열 숫자를 입력 받는다
            string[] inputs = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                // 굳이 이렇게 할 필요 있나..?
                int.TryParse(inputs[i], out array[i]);
            }


            //v가 몇개 들어있는지 확인
            int v = int.Parse(Console.ReadLine());

                    int count = 0;
            //v의 갯수를 출력
            for (int i = 0; i < n; i++) 
            {
                if (array[i] == v)
                {
                     count += 1;
                }
            }

            Console.WriteLine($"{count}");
        }
    }
}
