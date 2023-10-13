using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights) {
        Queue<(int, int)> onBridge = new Queue<(int, int)>();
        int next_truck = 0;
        int currentTime = 0;
        while (next_truck < truck_weights.Length || onBridge.Count > 0) {
            ++currentTime;
            
            if (onBridge.Count > 0) {
                (int tWeight, int entranceTime) truck = onBridge.Peek();
                if (currentTime - truck.entranceTime >= bridge_length) {
                    onBridge.Dequeue();
                    weight += truck.tWeight;
                }
            }
            
            if (next_truck < truck_weights.Length) {
                int current_truck_weight = truck_weights[next_truck];
                if (current_truck_weight <= weight) {
                    onBridge.Enqueue((current_truck_weight, currentTime));
                    weight -= current_truck_weight;
                    ++next_truck;
                }
            }
        }
        
        return currentTime;
    }
}