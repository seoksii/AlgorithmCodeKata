using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] fees, string[] records) {
        Dictionary<int, (int totalTime, int enterTime)> carDict = new Dictionary<int, (int, int)>();
        foreach(string record in records) {
            string[] r = record.Split(' ');
            string[] timeString = r[0].Split(':');
            int time = Convert.ToInt32(timeString[0]) * 60 + Convert.ToInt32(timeString[1]);
            if (r[2] == "OUT") {
                (int totalTime, int enterTime) carData = carDict[Convert.ToInt32(r[1])];
                carData.totalTime += time - carData.enterTime;
                carData.enterTime = -1;
                carDict[Convert.ToInt32(r[1])] = carData;
            }
            else if (r[2] == "IN" && carDict.ContainsKey(Convert.ToInt32(r[1])))
                carDict[Convert.ToInt32(r[1])] = (carDict[Convert.ToInt32(r[1])].totalTime, time);
            else
                carDict.Add(Convert.ToInt32(r[1]), (0, time));
        }
        
        List<int> answer = new List<int>();
        List<int> keyList = carDict.Keys.ToList();
        keyList.Sort();
        
        foreach(int key in keyList) {
            int time = carDict[key].totalTime;
            if (carDict[key].enterTime != -1)
                time += (1439 - carDict[key].enterTime);
            
            if (time <= fees[0]) answer.Add(fees[1]);
            else answer.Add(fees[1] + ((time - fees[0] - 1) / fees[2] + 1) * fees[3]);
        }
            
        return answer.ToArray();
    }
}