import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(4, s.characterReplacement("AABABBA", 1)));
        TestSupport.test("whole string", () -> TestSupport.equal(4, s.characterReplacement("ABAB", 2)));
        TestSupport.test("no replacements", () -> TestSupport.equal(2, s.characterReplacement("ABBA", 0)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
