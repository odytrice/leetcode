import { MinStack } from "./solution.ts";

// O(1) per operation. Each entry remembers the minimum at or below it.
export class ReferenceSolution extends MinStack {
  private readonly stack: [number, number][] = [];

  override push(val: number): void {
    const currentMin = this.stack.length === 0 ? val : Math.min(val, this.stack[this.stack.length - 1][1]);
    this.stack.push([val, currentMin]);
  }

  override pop(): void {
    this.stack.pop();
  }

  override top(): number {
    return this.stack[this.stack.length - 1][0];
  }

  override getMin(): number {
    return this.stack[this.stack.length - 1][1];
  }
}
