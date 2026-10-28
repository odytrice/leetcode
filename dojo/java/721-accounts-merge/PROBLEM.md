# Drill 721: Accounts Merge

LeetCode Medium: https://leetcode.com/problems/accounts-merge/

Each account contains a name followed by one or more emails. Accounts sharing an email belong to the same person, transitively. Names alone do not imply identity. Return merged accounts with the name first and unique emails sorted lexicographically. Outer order does not matter. Accounts for one person have the same name.

Constraints: 1 to 1000 accounts, 2 to 10 fields per account; field lengths 1 to 30.

Example: `[["John","a@x"],["John","a@x","b@x"]]` returns `[["John","a@x","b@x"]]`. Implement `AccountsMerge(IList<IList<string>> accounts)` returning `IList<IList<string>>`.

## Your task

Implement the stubs in `Solution.java` using Java without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
javac -d build -sourcepath "..;." Main.java
java -cp build Main
```

Or from the `dojo` root:

```powershell
java\run-all.ps1 -Drill 721-accounts-merge
```

To test the completed reference instead of your solution, add `--reference`.
