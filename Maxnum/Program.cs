namespace Maxnum
{
    /// <summary>
    /// 2024년 8월 27일
    /// 문제 : (2562) 최대값을 찾고 그 수가 몇 번째 수인지 구하는 프로그램
    /// url : https://www.acmicpc.net/problem/2562
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9개의 서로 다른 자연수
            // 최대값 찾고 몇번째인지 구할것

            // 수열을 만든다
            int[] array = new int[9];
            // 큰 수를 넣을 변수를 만든다
            int maxNum = 0;
            // 몇번째인지 넣을 변수
            int count = 0;
            // 숫자를 받는다
            for (int i = 0; i < array.Length; i++)
            {
               array[i]= int.Parse(Console.ReadLine());
                if(array[i] > maxNum)
                {
                    maxNum = array[i];
                    count = i;
                }
            }

            //count는 0부터 시작함으로 +1로 1부터 시작하도록 해준다.
            Console.WriteLine($"{maxNum}\n{count+1}");
            
        }
    }
}
