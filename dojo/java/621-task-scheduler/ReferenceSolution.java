/** O(n) time. The most frequent task sets the frame; ties add one slot each. */
class ReferenceSolution extends Solution {
    @Override
    public int leastInterval(char[] tasks, int n) {
        int[] counts = new int[26];
        for (char task : tasks) {
            counts[task - 'A'] += 1;
        }
        int most = 0;
        for (int count : counts) {
            most = Math.max(most, count);
        }
        // Every task with the top count also fills a slot in the final row.
        int tied = 0;
        for (int count : counts) {
            if (count == most) {
                tied += 1;
            }
        }
        // Frame: most - 1 rows of width n + 1, then a last row of the tied tasks.
        // If other tasks overflow the gaps, no idling is needed and the answer is just the task count.
        return Math.max(tasks.length, (most - 1) * (n + 1) + tied);
    }
}
