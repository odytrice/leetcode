import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(3, s.lengthOfLongestSubstring("abcabcbb")));
        TestSupport.test("repeated character", () -> TestSupport.equal(1, s.lengthOfLongestSubstring("bbbbb")));
        TestSupport.test("window end", () -> TestSupport.equal(3, s.lengthOfLongestSubstring("pwwkew")));
        TestSupport.test("empty", () -> TestSupport.equal(0, s.lengthOfLongestSubstring("")));
        TestSupport.test("previous occurrence outside window",
                () -> TestSupport.equal(2, s.lengthOfLongestSubstring("abba")));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
