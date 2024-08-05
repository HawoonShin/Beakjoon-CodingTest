

namespace lamb_skewers
{
    /// <summary>
    /// 2024년 8월 5일
    /// 문제 : 머쓱이네 양꼬치 가게는 10인분을 먹으면 음료수 하나를 서비스로 줍니다. 
    /// 양꼬치는 1인분에 12,000원, 음료수는 2,000원입니다. 
    /// 정수 n과 k가 매개변수로 주어졌을 때, 
    /// 양꼬치 n인분과 음료수 k개를 먹었다면 총얼마를 지불해야 하는지 return 하도록 solution 함수를 완성해보세요. 
    /// url : https://school.programmers.co.kr/learn/courses/30/lessons/120830
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // 전체 총 값 = n *12,000 + k*2,000
            // 만약 10분 이상이면 k-(n/10)

            int n = 10;  // 양꼬치 수
            int k = 3;  // 음료의 수

            int answer = 0;

            if (n >= 10)
            {
                //int answer;
                answer = n * 12000 + (k - (n / 10)) * 2000;
                Console.WriteLine($"총액 : {answer}");
            }
            else
            {
                answer = n * 12000 + k * 2000;
                Console.WriteLine($"총액 : {answer}");
            }
            //return answer;

        }

        /*
         * #include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>
int solution(int n, int k) {
    int answer = 0;
	
    answer = (n * 12000) + ((k - (n / 10)) * 2000);
	return answer;
}
         */

        /*
        public class Solution 
        {
            public int solution(int n, int k)
            {
            }
        }*/

    }
}
