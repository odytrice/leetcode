import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example",
                () -> TestSupport.equal(3, s.canCompleteCircuit(new int[] {1, 2, 3, 4, 5}, new int[] {3, 4, 5, 1, 2})));
        TestSupport.test("impossible",
                () -> TestSupport.equal(-1, s.canCompleteCircuit(new int[] {2, 3, 4}, new int[] {3, 4, 3})));
        TestSupport.test("single", () -> TestSupport.equal(0, s.canCompleteCircuit(new int[] {5}, new int[] {5})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
