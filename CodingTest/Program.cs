using System;

public class Solution
{
    public int solution(float num1, float num2)
    {
        float result = (num1 / num2) * 1000;
        int answer = (int)result;
        return answer;
    }
}