import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(3, s.longestCommonSubsequence("abcde", "ace")));
        TestSupport.test("disjoint", () -> TestSupport.equal(0, s.longestCommonSubsequence("abc", "def")));
        TestSupport.test("repeated letters", () -> TestSupport.equal(2, s.longestCommonSubsequence("aaaa", "aa")));
        TestSupport.test("order matters", () -> TestSupport.equal(1, s.longestCommonSubsequence("abc", "cba")));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
