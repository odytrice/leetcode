# Drill 133: Clone Graph

LeetCode Medium: https://leetcode.com/problems/clone-graph/

Deep-copy a connected undirected graph given one node, preserving values and adjacency. Return the corresponding copied node, or null for an empty graph. No copied neighbor may refer to an original node.

Constraints: 0 to 100 nodes, unique values 1 to 100, no repeated edges or self-loops. `Node` is supplied locally.

Example: two nodes connected both ways must produce two new nodes with the same connection. Implement `CloneGraph(Node? node)`.

## Your task

Implement the stubs in `GraphNode.java` using Java without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
javac -d build -sourcepath "..;." Main.java
java -cp build Main
```

Or from the `dojo` root:

```powershell
java\run-all.ps1 -Drill 133-clone-graph
```

To test the completed reference instead of your solution, add `--reference`.
