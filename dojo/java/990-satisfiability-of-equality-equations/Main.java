import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("contradiction",
                () -> TestSupport.equal(false, s.equationsPossible(new String[] {"a==b", "b!=a"})));
        TestSupport.test("transitive and reordered",
                () -> TestSupport.equal(false, s.equationsPossible(new String[] {"a!=c", "a==b", "b==c"})));
        TestSupport.test("consistent",
                () -> TestSupport.equal(true, s.equationsPossible(new String[] {"a==b", "b!=c"})));
        TestSupport.test("self inequality",
                () -> TestSupport.equal(false, s.equationsPossible(new String[] {"a!=a"})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
