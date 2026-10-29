import { LRUCache } from "./solution.ts";

// O(1) average per operation: a map keeps insertion order, so the first key is oldest.
export class ReferenceSolution extends LRUCache {
  private readonly capacity: number;
  // A Map iterates in insertion order, so re-inserting a key makes it the newest.
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
    // Re-insert the key to mark it as most recently used.
    this.values.delete(key);
    this.values.set(key, value);
    return value;
  }

  override put(key: number, value: number): void {
    // Delete first so the set below moves an existing key to the newest position.
    if (this.values.has(key)) {
      this.values.delete(key);
    // Full: evict the least recently used key, which is the first one in the map.
    } else if (this.values.size === this.capacity) {
      this.values.delete(this.values.keys().next().value as number);
    }
    this.values.set(key, value);
  }
}
