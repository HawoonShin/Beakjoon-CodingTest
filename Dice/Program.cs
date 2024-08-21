namespace Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //주사위 숫자 입력받음
            //1~6
            //3개를 입력 받음
            string[] inputs = Console.ReadLine().Split();
            int.TryParse(inputs[0], out int a);
            int.TryParse(inputs[1], out int b);
            int.TryParse(inputs[2], out int c);

            int price = 0;

            //3개가 같으면
            if (a == b && b == c)
            {
                //10000 + (같은눈)*1000
                price = 10000 + a * 1000;
            }

            //전부 다 다르다
            else if (a != b && b != c && a != c)
            {
                int big = 0;
                //a와 b를 비교 큰 수를 big에 넣어둔다
                if (a > b)
                {
                    big = a;
                }
                else
                {
                    big = b;
                }


                //big과 c를 비교하고 큰 수를 big에 넣어둔다.
                if (c > big)
                {
                    big = c;
                }
                else { }

                //big을 가지고 상금 계산
                //가장 큰 눈 *100
                price = big * 100;
            }

            //2개가 같다
            else
            {
                //a=b
                if (a == b) { price = 1000 + a * 100; }
                //a=c
                else if (a == c) { price = 1000 + a * 100; }
                //b=c
                else { price = 1000 + b * 100; }
            //1000+ (같은눈) *100

            }

            Console.WriteLine(price);
        }
    }
}
