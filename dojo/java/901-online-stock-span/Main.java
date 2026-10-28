import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        java.util.function.Supplier<StockSpanner> make =
                () -> reference ? new ReferenceSolution() : new StockSpanner();

        TestSupport.test("example", () -> {
            StockSpanner spanner = make.get();
            int[] spans = new int[7];
            int[] prices = {100, 80, 60, 70, 60, 75, 85};
            for (int index = 0; index < prices.length; index++) {
                spans[index] = spanner.next(prices[index]);
            }
            TestSupport.sequence(new int[] {1, 1, 1, 2, 1, 4, 6}, spans);
        });
        TestSupport.test("equal prices", () -> {
            StockSpanner spanner = make.get();
            TestSupport.equal(1, spanner.next(5));
            TestSupport.equal(2, spanner.next(5));
            TestSupport.equal(3, spanner.next(5));
        });
        TestSupport.test("independent instances", () -> {
            StockSpanner first = make.get();
            first.next(1);
            TestSupport.equal(1, make.get().next(2));
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
