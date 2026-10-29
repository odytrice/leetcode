/** O(n) time. Restarts after every deficit; a total surplus guarantees one circuit. */
class ReferenceSolution extends Solution {
    @Override
    public int canCompleteCircuit(int[] gas, int[] cost) {
        // total covers the whole loop; tank covers only the trip since the current start.
        int total = 0;
        int tank = 0;
        int start = 0;
        for (int index = 0; index < gas.length; index += 1) {
            int difference = gas[index] - cost[index];
            total += difference;
            tank += difference;
            // No station from start to here can work, so try the next one with an empty tank.
            if (tank < 0) {
                start = index + 1;
                tank = 0;
            }
        }
        // Not enough gas overall means no start works; -1 signals that.
        return total < 0 ? -1 : start;
    }
}
