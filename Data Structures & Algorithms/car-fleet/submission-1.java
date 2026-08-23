class Solution {
    public int carFleet(int target, int[] position, int[] speed) {
        int[][] cars = new int[position.length][2];
        for (int i = 0; i < position.length; i++) {
            cars[i][0] = position[i];
            cars[i][1] = speed[i];
        }
        int fleets =0;
        double slowestTime =0;
        Arrays.sort(cars, (a, b) -> b[0] - a[0]);
        for(int[] car : cars) {
            int pos = car[0];
            int spd = car[1];
            double time = (double)(target - pos) / spd;
            if (time > slowestTime) {
                fleets++;
                slowestTime = time;
            }
        }
        return fleets;
    }
}
