import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(9, s.evalRPN(new String[] {"2", "1", "+", "3", "*"})));
        TestSupport.test("operand order", () -> TestSupport.equal(-1, s.evalRPN(new String[] {"2", "3", "-"})));
        TestSupport.test("negative division", () -> TestSupport.equal(-2, s.evalRPN(new String[] {"-7", "3", "/"})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
