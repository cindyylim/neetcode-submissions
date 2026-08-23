class Solution {
    public int carFleet(int target, int[] position, int[] speed) {
        int[][] cars = new int[position.length][2];
        for(int i = 0; i < position.length; i++) {
            cars[i][0] = position[i];
            cars[i][1] = speed[i];
        }
        Arrays.sort(cars, (a,b) -> b[0] - a[0]);
        double slowestTime = 0;
        int fleets = 0;
        for(int[] car: cars) {
            double time = (double)(target - car[0])/ car[1];
            if (time > slowestTime) {
                slowestTime = time;
                fleets++;
            }
        }
        return fleets;
    }
}
