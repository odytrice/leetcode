import { NumMatrix } from "./solution.ts";

// O(rows * cols) build, O(1) queries from a 2D prefix sum.
export class ReferenceSolution extends NumMatrix {
  private readonly prefix: number[][];

  constructor(matrix: number[][]) {
    super(matrix);
    const rows = matrix.length;
    const cols = matrix[0].length;
    this.prefix = Array.from({ length: rows + 1 }, () => new Array<number>(cols + 1).fill(0));
    for (let row = 0; row < rows; row += 1) {
      for (let column = 0; column < cols; column += 1) {
        this.prefix[row + 1][column + 1] =
          matrix[row][column] +
          this.prefix[row][column + 1] +
          this.prefix[row + 1][column] -
          this.prefix[row][column];
      }
    }
  }

  override sumRegion(row1: number, col1: number, row2: number, col2: number): number {
    const prefix = this.prefix;
    return (
      prefix[row2 + 1][col2 + 1] -
      prefix[row1][col2 + 1] -
      prefix[row2 + 1][col1] +
      prefix[row1][col1]
    );
  }
}
