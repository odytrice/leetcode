# Drill 210: Course Schedule II

LeetCode Medium: https://leetcode.com/problems/course-schedule-ii/

Courses are 0 through numCourses-1. Each pair `[a,b]` means b must be completed before a. Return any ordering containing every course once and respecting prerequisites, or an empty array for a cycle.

Constraints: 1 to 2000 courses, distinct prerequisite pairs, no self-edges.

Example: `2, [[1,0]]` returns `[0,1]`. Implement `FindOrder(int numCourses, int[][] prerequisites)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/210-course-schedule-ii/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
