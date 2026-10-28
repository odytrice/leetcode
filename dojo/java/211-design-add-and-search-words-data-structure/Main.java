import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        java.util.function.Supplier<WordDictionary> make =
                () -> reference ? new ReferenceSolution() : new WordDictionary();

        TestSupport.test("wildcards", () -> {
            WordDictionary dictionary = make.get();
            for (String word : new String[] {"bad", "dad", "mad"}) {
                dictionary.addWord(word);
            }
            TestSupport.equal(true, dictionary.search(".ad"));
            TestSupport.equal(true, dictionary.search("b.."));
            TestSupport.equal(false, dictionary.search("pad"));
        });
        TestSupport.test("exact length", () -> {
            WordDictionary dictionary = make.get();
            dictionary.addWord("abc");
            TestSupport.equal(false, dictionary.search(".."));
            TestSupport.equal(false, dictionary.search("abc."));
            TestSupport.equal(false, dictionary.search("ab"));
        });
        TestSupport.test("branch exploration", () -> {
            WordDictionary dictionary = make.get();
            dictionary.addWord("cat");
            dictionary.addWord("dog");
            TestSupport.equal(true, dictionary.search(".og"));
            TestSupport.equal(false, dictionary.search(".ox"));
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
