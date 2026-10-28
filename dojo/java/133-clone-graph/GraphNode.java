import java.util.ArrayList;
import java.util.List;

class GraphNode {
    int val;
    List<GraphNode> neighbors = new ArrayList<>();

    GraphNode(int val) {
        this.val = val;
    }
}
