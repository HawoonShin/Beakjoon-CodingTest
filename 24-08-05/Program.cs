namespace _24_08_05
{
    /// <summary>
    /// 2024년 8월 5일
    /// 문제 : 정수 n이 주어질 때, n이하의 짝수를 모두 더한 값을 return 하도록 solution 함수를 작성해주세요.
    /// url : https://school.programmers.co.kr/learn/courses/30/lessons/120831
    /// </summary>
    /// 
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int n)
            {
                //for문으로 i가 n이 될때까지 반복한다
                // 이때 if문으로 짝수일 경우 sum에 더해둔다.
                // 홀수 일 경우 생략한다.

                    //int sum = 0;
                    int answer = 0;

                // 처음 ==으로 지정하여 조건문이 성립하지 않아서 실행되지 않음
                // <=로 고친 후 정상적으로 실행
                for (int i = 0; i <= n; i++)
                {
                    if(i %2 ==0)
                    {
                        //sum = sum + i;
                        answer = answer + i;
                    }
                    else 
                    {
                        // 여기는 비워두면 아무것도 실행하지 않고 넘어간다.
                    }
                        

                }

                    return answer;
            }
        }
    }
}
