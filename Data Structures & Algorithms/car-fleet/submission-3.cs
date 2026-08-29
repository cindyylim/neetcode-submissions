public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        (int Position, int Speed)[] cars = new (int Position, int Speed)[position.Length];
        for(int i = 0; i < position.Length; i++) {
            cars[i] = (position[i], speed[i]);
        }
        double slowestTime = 0;
        int fleets = 0;
        Array.Sort(cars, (a, b) => b.Position.CompareTo(a.Position));
        foreach ((int Position, int Speed) car in cars) {
            double time = (double)(target - car.Position)/car.Speed;
            if (time > slowestTime) {
                slowestTime = time;
                fleets++;
            }
        }
        return fleets;
    }
}
