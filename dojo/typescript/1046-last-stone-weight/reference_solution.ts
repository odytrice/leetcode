// O(n log n) time. Always smashes the two heaviest stones.
export function lastStoneWeight(stones: number[]): number {
  // A sorted array stands in for a max-heap: the heaviest stones are at the end.
  const heap = [...stones].sort((a, b) => a - b);
  while (heap.length > 1) {
    const first = heap.pop() as number;
    const second = heap.pop() as number;
    // Equal stones destroy each other; otherwise the difference goes back in.
    if (first !== second) {
      const rest = first - second;
      let index = heap.length;
      // Walk left to find where the leftover stone keeps the array sorted.
      while (index > 0 && heap[index - 1] > rest) {
        index -= 1;
      }
      heap.splice(index, 0, rest);
    }
  }
  // 0 means every stone was destroyed.
  return heap.length === 0 ? 0 : heap[0];
}
