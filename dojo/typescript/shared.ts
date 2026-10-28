// LeetCode helper types and assertions shared by the TypeScript drills.

export class ListNode {
  val: number;
  next: ListNode | null;

  constructor(val = 0, next: ListNode | null = null) {
    this.val = val;
    this.next = next;
  }

  static from(values: number[]): ListNode | null {
    let head: ListNode | null = null;
    for (let i = values.length - 1; i >= 0; i--) head = new ListNode(values[i], head);
    return head;
  }

  static values(head: ListNode | null): number[] {
    const result: number[] = [];
    const seen = new Set<ListNode>();
    for (let node = head; node !== null; node = node.next) {
      if (seen.has(node)) throw new Error("Unexpected cycle in result");
      seen.add(node);
      result.push(node.val);
    }
    return result;
  }
}

export class TreeNode {
  val: number;
  left: TreeNode | null;
  right: TreeNode | null;

  constructor(val = 0, left: TreeNode | null = null, right: TreeNode | null = null) {
    this.val = val;
    this.left = left;
    this.right = right;
  }

  static from(values: (number | null)[]): TreeNode | null {
    if (values.length === 0 || values[0] === null) return null;
    const root = new TreeNode(values[0]);
    const queue: TreeNode[] = [root];
    let index = 1;
    for (let head = 0; head < queue.length && index < values.length; head++) {
      const node = queue[head];
      const left = values[index++];
      if (left !== null && left !== undefined) queue.push((node.left = new TreeNode(left)));
      const right = values[index++];
      if (right !== null && right !== undefined) queue.push((node.right = new TreeNode(right)));
    }
    return root;
  }
}

let total = 0;
let failed = 0;

function describe(error: unknown): string {
  return error instanceof Error ? error.message : String(error);
}

export function test(name: string, run: () => void): void {
  total++;
  try {
    run();
    console.log(`PASS: ${name}`);
  } catch (error) {
    failed++;
    console.log(`FAIL: ${name}: ${describe(error)}`);
  }
}

export function check(condition: boolean, message = "Assertion failed"): void {
  if (!condition) throw new Error(message);
}

export function equal<T>(expected: T, actual: T): void {
  if (!Object.is(expected, actual)) throw new Error(`Expected ${expected}, got ${actual}`);
}

export function sequence<T>(expected: readonly T[], actual: readonly T[]): void {
  const left = JSON.stringify(expected);
  const right = JSON.stringify(actual);
  if (left !== right) throw new Error(`Expected ${left}, got ${right}`);
}

/** Compare outer order independently, while still detecting duplicated results. */
export function set<T>(expected: readonly T[], actual: readonly T[]): void {
  sequence(sorted(expected), sorted(actual));
}

export function rows(
  expected: readonly (readonly number[] | readonly string[])[],
  actual: readonly (readonly number[] | readonly string[])[],
  sortInside = false,
): void {
  const key = (row: readonly (number | string)[]) => JSON.stringify(sortInside ? [...row].sort() : row);
  set(expected.map(key), actual.map(key));
}

function sorted<T>(values: readonly T[]): string[] {
  return values.map((value) => JSON.stringify(value)).sort();
}

export function finish(): void {
  console.log(`\n${total - failed}/${total} passed.`);
  if (failed > 0) process.exitCode = 1;
}
