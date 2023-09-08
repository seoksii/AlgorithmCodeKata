using System;

public class Solution {
    (int X, int Y) calDelta(string direction) {
        int[] dX = new int[] {0, 0, 1, -1};
        int[] dY = new int[] {1, -1, 0, 0};
        
        switch (direction) {
            case "E":
                return (dX[0], dY[0]);
            case "W":
                return (dX[1], dY[1]);
            case "S":
                return (dX[2], dY[2]);
            case "N":
                return (dX[3], dY[3]);
            default:
                return (0, 0);
        }
    }
    
    public int[] solution(string[] park, string[] routes) {
        (int X, int Y) presentPos = (0, 0);
        for (int i = 0; i < park.Length; ++i)
            for (int j = 0; j < park[i].Length; ++j)
                if (park[i][j] == 'S') {
                    presentPos = (i, j);
                }
        
        foreach (string s in routes) {
            string[] splitted = s.Split(' ');
            (int X, int Y) delta = calDelta(splitted[0]);
            int dist = Convert.ToInt32(splitted[1]);
            
            bool isValid = true;
            (int X, int Y) nextPos = presentPos;
            for(int i = 1; i <= dist; ++i) {
                nextPos = (presentPos.X + i * delta.X, presentPos.Y + i * delta.Y);
                if (nextPos.X < 0 || nextPos.Y < 0 || nextPos.X >= park.Length || nextPos.Y >= park[0].Length
                    || park[nextPos.X][nextPos.Y] == 'X') {
                    isValid = false;
                    break;
                }
            }
            if (isValid) presentPos = nextPos;
        }
        
        return new int[] {presentPos.X, presentPos.Y};
    }
}