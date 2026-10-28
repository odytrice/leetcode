import { equal, finish, test } from "../shared.ts";
import { isValidSudoku } from "./solution.ts";
import { isValidSudoku as referenceIsValidSudoku } from "./reference_solution.ts";

const isValidSudokuImpl = process.argv.includes("--reference") ? referenceIsValidSudoku : isValidSudoku;
const emptyBoard = (): string[][] => Array.from({ length: 9 }, () => new Array<string>(9).fill("."));

test("empty", () => equal(true, isValidSudokuImpl(emptyBoard())));

test("row duplicate", () => {
  const board = emptyBoard();
  board[0][0] = board[0][8] = "5";
  equal(false, isValidSudokuImpl(board));
});

test("column duplicate", () => {
  const board = emptyBoard();
  board[0][0] = board[8][0] = "5";
  equal(false, isValidSudokuImpl(board));
});

test("box duplicate", () => {
  const board = emptyBoard();
  board[0][0] = board[1][1] = "5";
  equal(false, isValidSudokuImpl(board));
});

test("separate units", () => {
  const board = emptyBoard();
  board[0][0] = board[4][4] = "5";
  equal(true, isValidSudokuImpl(board));
});

// Add your own cases here.

finish();
