// O(n) time. The most frequent task sets the frame; ties add one slot each.
export function leastInterval(tasks: string[], n: number): number {
  const counts = new Map<string, number>();
  for (const task of tasks) {
    counts.set(task, (counts.get(task) ?? 0) + 1);
  }
  // The most frequent task needs most - 1 full cycles of n + 1 slots, then one final slot.
  const most = Math.max(...counts.values());
  // Every task tied for the top count also needs a slot in that final cycle.
  let tied = 0;
  for (const count of counts.values()) {
    if (count === most) {
      tied += 1;
    }
  }
  // If there are enough other tasks to fill every gap, no idle time is needed at all.
  return Math.max(tasks.length, (most - 1) * (n + 1) + tied);
}
