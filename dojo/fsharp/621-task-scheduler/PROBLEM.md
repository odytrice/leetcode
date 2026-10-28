# Drill 621: Task Scheduler

LeetCode Medium: https://leetcode.com/problems/task-scheduler/

Each uppercase task takes one time interval. Identical tasks must be separated by at least n intervals. Tasks can be reordered and idle intervals inserted. Return the minimum total intervals.

Constraints: 1 to 10,000 tasks; 0 <= n <= 100.

Example: `['A','A','A','B','B','B'], 2` returns `8`. Implement `LeastInterval(char[] tasks, int n)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/621-task-scheduler/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
