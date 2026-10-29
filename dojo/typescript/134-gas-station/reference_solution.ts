// O(n) time. Restarts after every deficit; a total surplus guarantees one circuit.
export function canCompleteCircuit(gas: number[], cost: number[]): number {
  let total = 0;
  let tank = 0;
  let start = 0;
  for (let index = 0; index < gas.length; index += 1) {
    const difference = gas[index] - cost[index];
    total += difference;
    tank += difference;
    if (tank < 0) {
      start = index + 1;
      tank = 0;
    }
  }
  return total < 0 ? -1 : start;
}
