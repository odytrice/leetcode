import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.set(
                List.of("ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"), s.letterCombinations("23")));
        TestSupport.test("empty", () -> TestSupport.equal(0, s.letterCombinations("").size()));
        TestSupport.test("four letter digit", () -> TestSupport.set(List.of("p", "q", "r", "s"), s.letterCombinations("7")));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
