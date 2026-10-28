import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("small slope", () -> TestSupport.rows(
                List.of(List.of(0, 1), List.of(1, 0), List.of(1, 1)),
                s.pacificAtlantic(new int[][] {{1, 2}, {4, 3}})));
        TestSupport.test("single cell",
                () -> TestSupport.rows(List.of(List.of(0, 0)), s.pacificAtlantic(new int[][] {{7}})));
        TestSupport.test("plateau", () -> TestSupport.rows(
                List.of(List.of(0, 0), List.of(0, 1), List.of(1, 0), List.of(1, 1)),
                s.pacificAtlantic(new int[][] {{1, 1}, {1, 1}})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
