import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("nested", () -> TestSupport.equal("accaccacc", s.decodeString("3[a2[c]]")));
        TestSupport.test("adjacent", () -> TestSupport.equal("abcabccdcdcdef", s.decodeString("2[abc]3[cd]ef")));
        TestSupport.test("multiple digits", () -> TestSupport.equal("a".repeat(12), s.decodeString("12[a]")));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
