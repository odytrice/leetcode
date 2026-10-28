import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Deque;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("cycle and shared neighbors", () -> {
            List<GraphNode> originals = new ArrayList<>();
            for (int value = 1; value <= 3; value++) {
                originals.add(new GraphNode(value));
            }
            for (GraphNode node : originals) {
                for (GraphNode other : originals) {
                    if (other != node) {
                        node.neighbors.add(other);
                    }
                }
            }

            GraphNode copy = s.cloneGraph(originals.get(0));
            List<GraphNode> seen = new ArrayList<>();
            Deque<GraphNode> queue = new ArrayDeque<>();
            queue.add(copy);
            while (!queue.isEmpty()) {
                GraphNode node = queue.poll();
                TestSupport.check(!originals.contains(node), "copies must be new nodes");
                if (seen.contains(node)) {
                    continue;
                }
                seen.add(node);
                TestSupport.equal(originals.get(node.val - 1).neighbors.size(), node.neighbors.size());
                queue.addAll(node.neighbors);
            }
            TestSupport.equal(3, seen.size());
        });
        TestSupport.test("isolated", () -> {
            GraphNode node = new GraphNode(1);
            GraphNode copy = s.cloneGraph(node);
            TestSupport.check(copy != node, "copy must be a new node");
            TestSupport.equal(1, copy.val);
            TestSupport.equal(0, copy.neighbors.size());
        });
        TestSupport.test("empty", () -> TestSupport.check(s.cloneGraph(null) == null, "empty graph"));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
