public class Main {
    public static void main(String[] args) {
        boolean reference = java.util.Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(4, s.longestConsecutive(new int[] {100, 4, 200, 1, 3, 2})));
        TestSupport.test("duplicates and negatives", () -> TestSupport.equal(4, s.longestConsecutive(new int[] {0, -1, 1, 2, 2})));
        TestSupport.test("empty", () -> TestSupport.equal(0, s.longestConsecutive(new int[] {})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
