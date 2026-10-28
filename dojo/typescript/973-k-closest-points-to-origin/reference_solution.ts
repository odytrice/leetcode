// O(n log n) time. Sorting by squared distance keeps the arithmetic exact.
export function kClosest(points: number[][], k: number): number[][] {
  const distance = (point: number[]) => point[0] * point[0] + point[1] * point[1];
  return [...points].sort((a, b) => distance(a) - distance(b)).slice(0, k);
}
