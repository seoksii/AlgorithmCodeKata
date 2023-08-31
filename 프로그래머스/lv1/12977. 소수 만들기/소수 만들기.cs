using System;

class Solution
{
    int[] Prime = new int[3000];
    
    bool isPrime(int num) {
        if (Prime[num] == 1 ) return true;
        else if (Prime[num] == -1) return false;
        
        for (int i = 2; i * i <= num; ++i)
            if (num % i == 0) {
                Prime[num] = -1;
                return false;
            }
        Prime[num] = 1;
        return true;
    }
    
    public int solution(int[] nums)
    {
        int answer = 0;
        for (int i = 0; i < nums.Length - 2; ++i)
            for (int j = i + 1; j < nums.Length - 1; ++j)
                for (int k = j + 1; k < nums.Length; ++k)
                    if (isPrime(nums[i] + nums[j] + nums[k])) ++answer;

        return answer;
    }
}