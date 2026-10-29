import { RandomizedSet } from "./solution.ts";

// O(1) average for every operation: swap the removal target with the last value.
export class ReferenceSolution extends RandomizedSet {
  private readonly values: number[] = [];
  private readonly positions = new Map<number, number>();

  override insert(val: number): boolean {
    if (this.positions.has(val)) {
      return false;
    }
    this.positions.set(val, this.values.length);
    this.values.push(val);
    return true;
  }

  override remove(val: number): boolean {
    const position = this.positions.get(val);
    if (position === undefined) {
      return false;
    }
    const last = this.values[this.values.length - 1];
    this.values[position] = last;
    this.positions.set(last, position);
    this.values.pop();
    this.positions.delete(val);
    return true;
  }

  override getRandom(): number {
    return this.values[Math.floor(Math.random() * this.values.length)];
  }
}
