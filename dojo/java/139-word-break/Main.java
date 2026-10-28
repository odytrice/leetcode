import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(true, s.wordBreak("leetcode", List.of("leet", "code"))));
        TestSupport.test("reuse", () -> TestSupport.equal(true, s.wordBreak("applepenapple", List.of("apple", "pen"))));
        TestSupport.test("impossible suffix", () -> TestSupport.equal(false,
                s.wordBreak("catsandog", List.of("cats", "dog", "sand", "and", "cat"))));
        TestSupport.test("non greedy split",
                () -> TestSupport.equal(true, s.wordBreak("aaaaaaa", List.of("aaaa", "aaa"))));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
