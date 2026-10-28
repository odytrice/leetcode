import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(8, s.leastInterval("AAABBB".toCharArray(), 2)));
        TestSupport.test("no cooldown", () -> TestSupport.equal(6, s.leastInterval("AAABBB".toCharArray(), 0)));
        TestSupport.test("single type", () -> TestSupport.equal(7, s.leastInterval("AAA".toCharArray(), 2)));
        TestSupport.test("enough filler", () -> TestSupport.equal(6, s.leastInterval("ABCABC".toCharArray(), 1)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
