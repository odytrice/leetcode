import { StockSpanner } from "./solution.ts";

// Amortized O(1) per call. Drops prices no higher than today's, summing their spans.
export class ReferenceSolution extends StockSpanner {
  private readonly stack: [number, number][] = [];

  override next(price: number): number {
    let span = 1;
    while (this.stack.length > 0 && this.stack[this.stack.length - 1][0] <= price) {
      span += (this.stack.pop() as [number, number])[1];
    }
    this.stack.push([price, span]);
    return span;
  }
}
