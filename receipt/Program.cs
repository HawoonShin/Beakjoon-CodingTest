namespace receipt
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 7일
        /// 문제 : (25304) 영수증에 적힌, 구매한 각 물건의 가격과 개수
        ///구매한 물건들의 총 금액을 보고, 구매한 물건의 가격과 개수로 계산한 총 금액이 영수증에 적힌 총 금액과 일치하는지 검사해보자.
        /// url : https://www.acmicpc.net/problem/25304
        /// </summary>
        static void Main(string[] args)
        {
            // 구매한 각 물건의 가격과 개수
            // 구매한 물건들의 총 금액

            // 범위의 제한이 존재
            //일단 범위 제한은 제외하고 코드 짜고 생각하자

            //첫줄에 영수증에 적힌 총 금액 x가 주어진다
            //총액 x
            int totalPrice = int.Parse(Console.ReadLine());

            //둘째 줄에는 영수증에 적힌 구매한 물건의 종류의 수 n이 주어진다
            //가지수 n = n 번 반복하세요
            int thingType = int.Parse(Console.ReadLine());

            int[] a = new int[totalPrice];
            int[] b = new int[totalPrice];
            //물건의 가격 a 개수 b
            //공백을 사이에 두고 주어진다 = 배열로 받아라
            for (int i = 0; i < thingType; i++)
            {

                string[] input = Console.ReadLine().Split();
                int.TryParse(input[0], out a[i]);
                int.TryParse(input[1], out b[i]);
            }

            int allPrice = 0;
            for (int i = 0; i < thingType; i++)
            {
                int onePrice = a[i] * b[i];
                allPrice += onePrice;
            }

            //총 금액과 계산한 가격의 영수증이 금액과 일치한다면 yes 틀리면 no 를 출력
            //이프문 써라

            //백준에서 y, n 대분자로 안써서 틀렸었다 ^^

            if (totalPrice == allPrice)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }
    }
}
