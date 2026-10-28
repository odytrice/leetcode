import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("lexicographic top three", () -> TestSupport.stringRows(
                List.of(List.of("baggage", "bags", "banner"), List.of("baggage", "bags", "banner")),
                s.suggestedProducts(new String[] {"bags", "baggage", "banner", "box", "cloth"}, "ba"), false));
        TestSupport.test("missing suffix", () -> TestSupport.stringRows(
                List.of(List.of("a"), List.of(), List.of()), s.suggestedProducts(new String[] {"a"}, "abc"), false));
        TestSupport.test("fewer than three", () -> TestSupport.stringRows(
                List.of(List.of("car", "cat"), List.of("car", "cat"), List.of("cat")),
                s.suggestedProducts(new String[] {"cat", "car"}, "cat"), false));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
