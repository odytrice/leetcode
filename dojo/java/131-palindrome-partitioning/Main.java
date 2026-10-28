import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.stringRows(
                List.of(List.of("a", "a", "b"), List.of("aa", "b")), s.partition("aab"), false));
        TestSupport.test("single", () -> TestSupport.stringRows(
                List.of(List.of("a")), s.partition("a"), false));
        TestSupport.test("whole palindrome", () -> TestSupport.stringRows(
                List.of(List.of("a", "b", "a"), List.of("aba")), s.partition("aba"), false));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
