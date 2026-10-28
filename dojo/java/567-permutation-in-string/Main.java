import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("present", () -> TestSupport.equal(true, s.checkInclusion("ab", "eidbaooo")));
        TestSupport.test("absent", () -> TestSupport.equal(false, s.checkInclusion("ab", "eidboaoo")));
        TestSupport.test("multiplicities", () -> TestSupport.equal(false, s.checkInclusion("aab", "abb")));
        TestSupport.test("pattern longer", () -> TestSupport.equal(false, s.checkInclusion("abc", "ab")));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
