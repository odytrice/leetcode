// O(n log n) time. Sorting by squared distance keeps the arithmetic exact.
export function kClosest(points: number[][], k: number): number[][] {
  // Squared distance has the same order as real distance without needing a square root.
  const distance = (point: number[]) => point[0] * point[0] + point[1] * point[1];
  return [...points].sort((a, b) => distance(a) - distance(b)).slice(0, k);
}
