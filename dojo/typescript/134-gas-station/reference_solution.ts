// O(n) time. Restarts after every deficit; a total surplus guarantees one circuit.
export function canCompleteCircuit(gas: number[], cost: number[]): number {
  let total = 0;
  let tank = 0;
  let start = 0;
  for (let index = 0; index < gas.length; index += 1) {
    const difference = gas[index] - cost[index];
    total += difference;
    tank += difference;
    // We cannot reach index + 1 from start, nor from any station in between; restart after it.
    if (tank < 0) {
      start = index + 1;
      tank = 0;
    }
  }
  // If total gas covers total cost, the last restart point is a valid start.
  return total < 0 ? -1 : start;
}
