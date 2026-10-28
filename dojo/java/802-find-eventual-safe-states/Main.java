import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.sequence(TestSupport.ints(2, 4, 5, 6),
                s.eventualSafeNodes(new int[][] {{1, 2}, {2, 3}, {5}, {0}, {5}, {}, {}})));
        TestSupport.test("self loop",
                () -> TestSupport.sequence(TestSupport.ints(1), s.eventualSafeNodes(new int[][] {{0}, {}})));
        TestSupport.test("all terminal",
                () -> TestSupport.sequence(TestSupport.ints(0, 1), s.eventualSafeNodes(new int[][] {{}, {}})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
