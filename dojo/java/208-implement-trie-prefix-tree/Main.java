import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        java.util.function.Supplier<Trie> make = () -> reference ? new ReferenceSolution() : new Trie();

        TestSupport.test("word versus prefix", () -> {
            Trie trie = make.get();
            trie.insert("apple");
            TestSupport.equal(true, trie.search("apple"));
            TestSupport.equal(false, trie.search("app"));
            TestSupport.equal(true, trie.startsWith("app"));
            trie.insert("app");
            TestSupport.equal(true, trie.search("app"));
        });
        TestSupport.test("missing branch", () -> {
            Trie trie = make.get();
            trie.insert("cat");
            TestSupport.equal(false, trie.search("car"));
            TestSupport.equal(false, trie.startsWith("z"));
        });
        TestSupport.test("duplicate insert", () -> {
            Trie trie = make.get();
            trie.insert("a");
            trie.insert("a");
            TestSupport.equal(true, trie.search("a"));
            TestSupport.equal(false, trie.search("aa"));
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
