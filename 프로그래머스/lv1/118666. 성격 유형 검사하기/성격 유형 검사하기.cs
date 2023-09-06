using System;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        int[] scores = new int[4];
        for (int i = 0; i < survey.Length; ++i)
            switch (survey[i][0]) {
                case 'R':
                    scores[0] += choices[i] - 4;
                    break;
                case 'T':
                    scores[0] += 4 - choices[i];
                    break;
                case 'C':
                    scores[1] += choices[i] - 4;
                    break;
                case 'F':
                    scores[1] += 4 - choices[i];
                    break;
                case 'J':
                    scores[2] += choices[i] - 4;
                    break;
                case 'M':
                    scores[2] += 4 - choices[i];
                    break;
                case 'A':
                    scores[3] += choices[i] - 4;
                    break;
                case 'N':
                    scores[3] += 4 - choices[i];
                    break;
            }

        char[] answer = new char[4];
        if (scores[0] <= 0) answer[0] = 'R'; else answer[0] = 'T';
        if (scores[1] <= 0) answer[1] = 'C'; else answer[1] = 'F';
        if (scores[2] <= 0) answer[2] = 'J'; else answer[2] = 'M';
        if (scores[3] <= 0) answer[3] = 'A'; else answer[3] = 'N';
        return new String(answer);
    }
}