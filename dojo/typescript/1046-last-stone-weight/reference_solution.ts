// O(n log n) time. Always smashes the two heaviest stones.
export function lastStoneWeight(stones: number[]): number {
  const heap = [...stones].sort((a, b) => a - b);
  while (heap.length > 1) {
    const first = heap.pop() as number;
    const second = heap.pop() as number;
    if (first !== second) {
      const rest = first - second;
      let index = heap.length;
      while (index > 0 && heap[index - 1] > rest) index--;
      heap.splice(index, 0, rest);
    }
  }
  return heap.length === 0 ? 0 : heap[0];
}
