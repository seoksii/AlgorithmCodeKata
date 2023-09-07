using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string, int> presentRanks = new Dictionary<string, int>();
        int n = 0;
        foreach(string p in players)
            presentRanks.Add(p, n++);
        foreach(string c in callings) {
            int rankC = presentRanks[c];
            string prevPlayer = players[rankC - 1];
            players[rankC - 1] = c;
            --presentRanks[c];
            players[rankC] = prevPlayer;
            ++presentRanks[prevPlayer];
        }
        
        return players;
    }
}