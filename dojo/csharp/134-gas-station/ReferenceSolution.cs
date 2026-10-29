public class ReferenceSolution : Solution
{
    // O(n) time. If the tank runs dry, no station up to here can be the start.
    public override int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int total = 0;
        int tank = 0;
        int start = 0;
        for (int i = 0; i < gas.Length; i += 1)
        {
            int delta = gas[i] - cost[i];
            total += delta;
            tank += delta;
            if (tank < 0)
            {
                start = i + 1;
                tank = 0;
            }
        }
        return total < 0 ? -1 : start;
    }
}
