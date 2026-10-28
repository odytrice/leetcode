# Drill 295: Find Median from Data Stream

LeetCode Hard: https://leetcode.com/problems/find-median-from-data-stream/

Implement `MedianFinder()`, `AddNum(int num)`, and `FindMedian()`. Return the middle value of all inserted values, or the mean of the two middle values for an even count. Queries occur only after an insertion. Aim for O(log n) insertion and O(1) queries.

Constraints: values in [-100,000,100,000]; at most 50,000 operations.

Example: insert 1,2 -> median 1.5; insert 3 -> median 2.
