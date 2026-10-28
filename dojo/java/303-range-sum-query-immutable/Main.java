import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");

        TestSupport.test("queries", () -> {
            int[] nums = {-2, 0, 3, -5, 2, -1};
            NumArray values = reference ? new ReferenceSolution(nums) : new NumArray(nums);
            TestSupport.equal(1, values.sumRange(0, 2));
            TestSupport.equal(-1, values.sumRange(2, 5));
            TestSupport.equal(-3, values.sumRange(0, 5));
        });
        TestSupport.test("single", () -> {
            int[] nums = {-5};
            NumArray values = reference ? new ReferenceSolution(nums) : new NumArray(nums);
            TestSupport.equal(-5, values.sumRange(0, 0));
        });
        TestSupport.test("repeated query", () -> {
            int[] nums = {1, 2};
            NumArray values = reference ? new ReferenceSolution(nums) : new NumArray(nums);
            TestSupport.equal(3, values.sumRange(0, 1));
            TestSupport.equal(3, values.sumRange(0, 1));
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
