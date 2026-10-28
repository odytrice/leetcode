# Drill 138: Copy List with Random Pointer

LeetCode Medium: https://leetcode.com/problems/copy-list-with-random-pointer/

Deep-copy a linked list whose nodes each have next and random pointers. Random points to any node in the list or null. Every pointer in the copy must refer to copied nodes, never originals. Preserve the original list.

Constraints: 0 to 1000 nodes; next pointers form an acyclic list. `Node` is supplied locally.

Example: a one-node list pointing randomly to itself produces a new self-referencing node. Implement `CopyRandomList(Node? head)`.
