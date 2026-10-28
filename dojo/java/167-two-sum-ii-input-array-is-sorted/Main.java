import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.sequence(new int[] {1, 2}, s.twoSum(new int[] {2, 7, 11, 15}, 9)));
        TestSupport.test("negative", () -> TestSupport.sequence(new int[] {1, 3}, s.twoSum(new int[] {-3, 0, 4}, 1)));
        TestSupport.test("duplicates", () -> TestSupport.sequence(new int[] {1, 2}, s.twoSum(new int[] {2, 2}, 4)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
