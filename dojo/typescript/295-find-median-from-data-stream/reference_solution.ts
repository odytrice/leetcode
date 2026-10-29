import { MedianFinder } from "./solution.ts";

// O(log n) insertion, O(1) median. Keeps a sorted list and reads the middle.
export class ReferenceSolution extends MedianFinder {
  private readonly values: number[] = [];

  override addNum(num: number): void {
    let low = 0;
    let high = this.values.length;
    while (low < high) {
      const middle = (low + high) >> 1;
      if (this.values[middle] < num) {
        low = middle + 1;
      } else {
        high = middle;
      }
    }
    this.values.splice(low, 0, num);
  }

  override findMedian(): number {
    const middle = this.values.length >> 1;
    if (this.values.length % 2 === 1) {
      return this.values[middle];
    }
    return (this.values[middle - 1] + this.values[middle]) / 2;
  }
}
