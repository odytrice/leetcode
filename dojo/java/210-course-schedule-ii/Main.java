import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("diamond", () -> verifyOrder(s.findOrder(4, new int[][] {{1, 0}, {2, 0}, {3, 1}, {3, 2}}), 4,
                new int[][] {{1, 0}, {2, 0}, {3, 1}, {3, 2}}));
        TestSupport.test("cycle", () -> TestSupport.equal(0, s.findOrder(2, new int[][] {{1, 0}, {0, 1}}).length));
        TestSupport.test("isolated courses", () -> verifyOrder(s.findOrder(3, new int[][] {}), 3, new int[][] {}));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }

    private static void verifyOrder(int[] order, int courses, int[][] edges) {
        int[] sorted = order.clone();
        Arrays.sort(sorted);
        TestSupport.sequence(java.util.stream.IntStream.range(0, courses).toArray(), sorted);
        int[] positions = new int[courses];
        for (int index = 0; index < order.length; index++) {
            positions[order[index]] = index;
        }
        for (int[] pair : edges) {
            TestSupport.check(positions[pair[1]] < positions[pair[0]], "Prerequisite order violated");
        }
    }
}
