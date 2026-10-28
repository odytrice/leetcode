import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(3, s.numDecodings("226")));
        TestSupport.test("leading zero", () -> TestSupport.equal(0, s.numDecodings("06")));
        TestSupport.test("valid zeros", () -> TestSupport.equal(1, s.numDecodings("1010")));
        TestSupport.test("invalid zero", () -> TestSupport.equal(0, s.numDecodings("100")));
        TestSupport.test("pair too large", () -> TestSupport.equal(1, s.numDecodings("27")));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
