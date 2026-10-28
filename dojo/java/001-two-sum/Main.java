public class Main {
    public static void main(String[] args) {
        boolean reference = java.util.Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example",
                () -> TestSupport.set(TestSupport.ints(0, 1), TestSupport.ints(s.twoSum(new int[] {2, 7, 11, 15}, 9))));
        TestSupport.test("duplicate values",
                () -> TestSupport.set(TestSupport.ints(0, 1), TestSupport.ints(s.twoSum(new int[] {3, 3}, 6))));
        TestSupport.test("negative values",
                () -> TestSupport.set(TestSupport.ints(1, 2), TestSupport.ints(s.twoSum(new int[] {4, -2, -3}, -5))));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
