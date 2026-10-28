public class Main {
    public static void main(String[] args) {
        boolean reference = java.util.Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example one", () -> TestSupport.equal(2, s.subarraySum(new int[] {1, 1, 1}, 2)));
        TestSupport.test("example two", () -> TestSupport.equal(2, s.subarraySum(new int[] {1, 2, 3}, 3)));
        TestSupport.test("example three", () -> TestSupport.equal(3, s.subarraySum(new int[] {1, -1, 0}, 0)));
        TestSupport.test("single match", () -> TestSupport.equal(1, s.subarraySum(new int[] {3}, 3)));
        TestSupport.test("no match", () -> TestSupport.equal(0, s.subarraySum(new int[] {2, 4, 6}, 5)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
