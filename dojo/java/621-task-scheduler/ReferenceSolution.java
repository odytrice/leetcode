/** O(n) time. The most frequent task sets the frame; ties add one slot each. */
class ReferenceSolution extends Solution {
    @Override
    public int leastInterval(char[] tasks, int n) {
        int[] counts = new int[26];
        for (char task : tasks) {
            counts[task - 'A']++;
        }
        int most = 0;
        for (int count : counts) {
            most = Math.max(most, count);
        }
        int tied = 0;
        for (int count : counts) {
            if (count == most) {
                tied++;
            }
        }
        return Math.max(tasks.length, (most - 1) * (n + 1) + tied);
    }
}
