// O(n log max(piles)) time. Binary search the smallest speed that finishes in time.
export function minEatingSpeed(piles: number[], h: number): number {
  // Speed 1 is the slowest possible; the largest pile's size finishes any pile in an hour.
  let left = 1;
  let right = Math.max(...piles);
  while (left < right) {
    const speed = (left + right) >> 1;
    let hours = 0;
    for (const pile of piles) {
      // A pile takes whole hours, so round up.
      hours += Math.ceil(pile / speed);
    }
    // Fast enough, so the answer is at most this speed; otherwise it must be faster.
    if (hours <= h) {
      right = speed;
    } else {
      left = speed + 1;
    }
  }
  return left;
}
