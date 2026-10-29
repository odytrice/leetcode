import { LRUCache } from "./solution.ts";

// O(1) average per operation: a map keeps insertion order, so the first key is oldest.
export class ReferenceSolution extends LRUCache {
  private readonly capacity: number;
  private readonly values = new Map<number, number>();

  constructor(capacity: number) {
    super(capacity);
    this.capacity = capacity;
  }

  override get(key: number): number {
    const value = this.values.get(key);
    if (value === undefined) {
      return -1;
    }
    this.values.delete(key);
    this.values.set(key, value);
    return value;
  }

  override put(key: number, value: number): void {
    if (this.values.has(key)) {
      this.values.delete(key);
    } else if (this.values.size === this.capacity) {
      this.values.delete(this.values.keys().next().value as number);
    }
    this.values.set(key, value);
  }
}
