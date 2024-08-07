namespace OvenClock
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 7일
        /// 문제 : (2525)훈제오리구이를 시작하는 시각과 오븐구이를 하는 데 필요한 시간이 분단위로 주어졌을 때, 
        /// 오븐구이가 끝나는 시각을 계산하는 프로그램을 작성하시오.
        /// url : https://www.acmicpc.net/problem/2525
        /// </summary>
        static void Main(string[] args)
        {
            //오븐시계
        
            //시간은 스트링으로 받을것.
            string[] strings = Console.ReadLine().Split();
            int.TryParse(strings[0], out int hour);    //시간
            int.TryParse(strings[1], out int minute);    //분


            //요리시간은 트라이파스로 받을 것
            int timer = int.Parse(Console.ReadLine());  //타이머

            //요리 시간을 시 분으로 분리하고
            //100분을 예시로 할 경우
            int plusHour = timer / 60;
            int plusMinute= timer % 60;
            

            //그걸 각각 시간, 분에 더할것
            hour = hour + plusHour;
            minute = minute + plusMinute;

            // 60분 넘으면 시간으로 넘겨요
            if(minute>=60)
            {
                minute -= 60;
                hour += 1;
            }
            // 23시간 넘으면 0시로 넘겨요
            if(hour>=24)
            {
                hour -= 24;
            }

            //출력 시간은 (시간) (분)으로 출력
            Console.WriteLine($"{hour} {minute}");
        }
    }
}
