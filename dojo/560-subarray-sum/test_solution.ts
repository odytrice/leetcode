import assert from "node:assert/strict";
import { test } from "node:test";
import { subarraySum } from "./solution.ts";

test("example one", () => {
  assert.equal(subarraySum([1, 1, 1], 2), 2);
});

test("example two", () => {
  assert.equal(subarraySum([1, 2, 3], 3), 2);
});

test("example three", () => {
  assert.equal(subarraySum([1, -1, 0], 0), 3);
});

test("single match", () => {
  assert.equal(subarraySum([3], 3), 1);
});

test("no match", () => {
  assert.equal(subarraySum([2, 4, 6], 5), 0);
});

// Add your own cases here.
