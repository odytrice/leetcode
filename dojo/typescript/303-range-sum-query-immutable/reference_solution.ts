import { NumArray } from "./solution.ts";

// O(n) build, O(1) queries. Stores prefix sums so a range is one subtraction.
export class ReferenceSolution extends NumArray {
  private readonly prefix: number[];

  constructor(nums: number[]) {
    super(nums);
    this.prefix = [0];
    for (const value of nums) {
      this.prefix.push(this.prefix[this.prefix.length - 1] + value);
    }
  }

  override sumRange(left: number, right: number): number {
    return this.prefix[right + 1] - this.prefix[left];
  }
}
