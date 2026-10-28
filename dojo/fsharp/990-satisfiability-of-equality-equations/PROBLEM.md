# Drill 990: Satisfiability of Equality Equations

LeetCode Medium: https://leetcode.com/problems/satisfiability-of-equality-equations/

Each equation is four characters, such as `"a==b"` or `"a!=b"`, using lowercase variable names. Return whether integer values can be assigned to satisfy all equations simultaneously.

Constraints: 1 to 500 equations.

Example: `["a==b","b!=a"]` returns false. Implement `EquationsPossible(string[] equations)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/990-satisfiability-of-equality-equations/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
