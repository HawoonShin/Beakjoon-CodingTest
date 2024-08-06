namespace Alarm
{
    internal class Program
    {
        /// <summary>
        /// 2024년 n월 n일
        /// 문제 : (2884) 알람시계
        /// url : https://www.acmicpc.net/problem/2884
        /// </summary>
        static void Main(string[] args)
        {
            //45분 일찍 알람 맞추기
            //시간 H (0 ≤ H ≤ 23)
            //분 M (0 ≤ M ≤ 59)

            //입력 받기
            string[] inputs = Console.ReadLine().Split();
            int.TryParse(inputs[0], out int H);  //시간 받아요
            int.TryParse(inputs[1], out int M);  //분 받아요

            //현재분 >45
            if (M >= 45)
            {
                // 분에서만 빼기
                M = M - 45;
            }

            //현재분<45
         
                //주의 0시일 경우
                else if (H == 0)
                {
                    //23시로 계산할 것
                    H = 23;
                    M = (60 + M) - 45;
                }
                else
                {
                    //만약 분을 빼야할 경우
                    // 시간 하나 빼고 분 빼기
                    H = H - 1;
                    M = (60 + M) - 45;

                }
            

            //현재 시간 표기
            Console.WriteLine($"{H} {M}");
        }
    }
}
