using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int lux = 50;
        int luy = 50;
        int rdx = 0;
        int rdy = 0;
        for (int i = 0; i < wallpaper.Length; ++i) {
            bool hasFile = false;
            for (int j = 0; j < wallpaper[i].Length; ++j)
                if (wallpaper[i][j] == '#') {
                    if (j < luy) luy = j;
                    if (j + 1 > rdy) rdy = j + 1;
                    hasFile = true;
                }
                    
            if (hasFile == true) {
                if (i < lux) lux = i;
                if (i + 1 > rdx) rdx = i + 1;
            } 
            
        }
            
        
        return new int[] {lux, luy, rdx, rdy};
    }
}