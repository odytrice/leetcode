// O(n) time. A monotonic stack holds days still waiting for a warmer day.
export function dailyTemperatures(temperatures: number[]): number[] {
  const answer = new Array<number>(temperatures.length).fill(0);
  // Indices of days still waiting; their temperatures decrease from bottom to top.
  const waiting: number[] = [];
  for (let today = 0; today < temperatures.length; today += 1) {
    // Today is warmer than each popped day, and it is the first such day for them.
    while (waiting.length > 0 && temperatures[waiting[waiting.length - 1]] < temperatures[today]) {
      const earlier = waiting.pop() as number;
      answer[earlier] = today - earlier;
    }
    waiting.push(today);
  }
  // Days never popped keep 0: no warmer day follows.
  return answer;
}
