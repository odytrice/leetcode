import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");

        TestSupport.test("whole rectangle", () -> {
            int[][] matrix = {{1, 2}, {3, 4}};
            NumMatrix values = reference ? new ReferenceSolution(matrix) : new NumMatrix(matrix);
            TestSupport.equal(10, values.sumRegion(0, 0, 1, 1));
        });
        TestSupport.test("interior", () -> {
            int[][] matrix = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            NumMatrix values = reference ? new ReferenceSolution(matrix) : new NumMatrix(matrix);
            TestSupport.equal(8, values.sumRegion(2, 1, 2, 1));
        });
        TestSupport.test("negatives", () -> {
            int[][] matrix = {{-1, 2}, {3, -4}};
            NumMatrix values = reference ? new ReferenceSolution(matrix) : new NumMatrix(matrix);
            TestSupport.equal(-1, values.sumRegion(1, 0, 1, 1));
            TestSupport.equal(0, values.sumRegion(0, 0, 1, 1));
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
