# Drill 138: Copy List with Random Pointer

LeetCode Medium: https://leetcode.com/problems/copy-list-with-random-pointer/

Deep-copy a linked list whose nodes each have next and random pointers. Random points to any node in the list or null. Every pointer in the copy must refer to copied nodes, never originals. Preserve the original list.

Constraints: 0 to 1000 nodes; next pointers form an acyclic list. `Node` is supplied locally.

Example: a one-node list pointing randomly to itself produces a new self-referencing node. Implement `CopyRandomList(Node? head)`.

## Your task

Implement the stubs in `solution.ts` using TypeScript without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
node test_solution.ts
```

Or from the `dojo` root:

```powershell
node typescript/138-copy-list-with-random-pointer/test_solution.ts
```

To test the completed reference instead of your solution, add `--reference`.
