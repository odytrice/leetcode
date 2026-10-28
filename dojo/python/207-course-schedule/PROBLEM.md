# Drill 207: Course Schedule

LeetCode Medium: https://leetcode.com/problems/course-schedule/

Courses are 0 through numCourses-1. Each pair `[a,b]` requires b before a. Return whether it is possible to finish every course.

Constraints: 1 to 2000 courses, at most 5000 distinct prerequisite pairs.

Example: `2, [[1,0],[0,1]]` returns `false`. Implement `CanFinish(int numCourses, int[][] prerequisites)`.

## Your task

Implement the stubs in `solution.py` using Python without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
python test_solution.py
```

Or from the `dojo` root:

```powershell
python python/207-course-schedule/test_solution.py
```

To test the completed reference instead of your solution, add `--reference`.
