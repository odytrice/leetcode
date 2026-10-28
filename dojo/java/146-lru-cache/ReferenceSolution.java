import java.util.LinkedHashMap;
import java.util.Map;

/** O(1) average per operation: an access-ordered map evicts the oldest entry. */
class ReferenceSolution extends LRUCache {
    private final Map<Integer, Integer> values;

    ReferenceSolution(int capacity) {
        super(capacity);
        values = new LinkedHashMap<>(16, 0.75f, true) {
            @Override
            protected boolean removeEldestEntry(Map.Entry<Integer, Integer> eldest) {
                return size() > capacity;
            }
        };
    }

    @Override
    public int get(int key) {
        return values.getOrDefault(key, -1);
    }

    @Override
    public void put(int key, int value) {
        values.put(key, value);
    }
}
