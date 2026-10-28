import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("nested", () -> TestSupport.equal(true, s.isValid("([]){}")));
        TestSupport.test("crossed", () -> TestSupport.equal(false, s.isValid("([)]")));
        TestSupport.test("unclosed", () -> TestSupport.equal(false, s.isValid("(")));
        TestSupport.test("unopened", () -> TestSupport.equal(false, s.isValid(")")));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
