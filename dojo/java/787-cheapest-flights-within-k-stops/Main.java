import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();
        int[][] flights = {{0, 1, 100}, {1, 2, 100}, {0, 2, 500}};

        TestSupport.test("one stop", () -> TestSupport.equal(200, s.findCheapestPrice(3, flights, 0, 2, 1)));
        TestSupport.test("no stops", () -> TestSupport.equal(500, s.findCheapestPrice(3, flights, 0, 2, 0)));
        TestSupport.test("unreachable",
                () -> TestSupport.equal(-1, s.findCheapestPrice(3, new int[][] {{0, 1, 100}}, 0, 2, 2)));
        TestSupport.test("cheaper route exceeds stop limit", () -> TestSupport.equal(6,
                s.findCheapestPrice(4, new int[][] {{0, 1, 1}, {1, 2, 1}, {2, 3, 1}, {0, 2, 5}}, 0, 3, 1)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
