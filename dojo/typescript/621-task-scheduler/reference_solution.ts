// O(n) time. The most frequent task sets the frame; ties add one slot each.
export function leastInterval(tasks: string[], n: number): number {
  const counts = new Map<string, number>();
  for (const task of tasks) counts.set(task, (counts.get(task) ?? 0) + 1);
  const most = Math.max(...counts.values());
  let tied = 0;
  for (const count of counts.values()) if (count === most) tied++;
  return Math.max(tasks.length, (most - 1) * (n + 1) + tied);
}
