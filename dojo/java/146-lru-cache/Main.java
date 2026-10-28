import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        java.util.function.IntFunction<LRUCache> make =
                capacity -> reference ? new ReferenceSolution(capacity) : new LRUCache(capacity);

        TestSupport.test("eviction and access", () -> {
            LRUCache cache = make.apply(2);
            cache.put(1, 1);
            cache.put(2, 2);
            TestSupport.equal(1, cache.get(1));
            cache.put(3, 3);
            TestSupport.equal(-1, cache.get(2));
            cache.put(4, 4);
            TestSupport.equal(-1, cache.get(1));
            TestSupport.equal(3, cache.get(3));
            TestSupport.equal(4, cache.get(4));
        });
        TestSupport.test("update refreshes recency", () -> {
            LRUCache cache = make.apply(2);
            cache.put(1, 1);
            cache.put(2, 2);
            cache.put(1, 9);
            cache.put(3, 3);
            TestSupport.equal(9, cache.get(1));
            TestSupport.equal(-1, cache.get(2));
        });
        TestSupport.test("capacity one", () -> {
            LRUCache cache = make.apply(1);
            cache.put(1, 2);
            cache.put(2, 3);
            TestSupport.equal(-1, cache.get(1));
            TestSupport.equal(3, cache.get(2));
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
