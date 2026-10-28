# Drill 1011: Capacity To Ship Packages Within D Days

LeetCode Medium: https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/

Ship packages in their input order. Each day the total weight cannot exceed capacity. Return the smallest capacity that finishes within days days; packages cannot be split.

Constraints: 1 to 50,000 weights in [1,500]; 1 <= days <= weights.Length.

Example: `[1,2,3,4,5,6,7,8,9,10], 5` returns `15`. Implement `ShipWithinDays(int[] weights, int days)`.

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
java\run-all.ps1 -Drill 1011-capacity-to-ship-packages-within-d-days
```

To test the completed reference instead of your solution, add `--reference`.
