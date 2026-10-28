import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Deque;
import java.util.List;

/** O(courses + prerequisites) time. Kahn's algorithm emits one valid order. */
class ReferenceSolution extends Solution {
    @Override
    public int[] findOrder(int numCourses, int[][] prerequisites) {
        List<List<Integer>> edges = new ArrayList<>();
        for (int course = 0; course < numCourses; course++) {
            edges.add(new ArrayList<>());
        }
        int[] degree = new int[numCourses];
        for (int[] pair : prerequisites) {
            edges.get(pair[1]).add(pair[0]);
            degree[pair[0]]++;
        }
        Deque<Integer> queue = new ArrayDeque<>();
        for (int course = 0; course < numCourses; course++) {
            if (degree[course] == 0) {
                queue.add(course);
            }
        }
        int[] order = new int[numCourses];
        int count = 0;
        while (!queue.isEmpty()) {
            int course = queue.poll();
            order[count++] = course;
            for (int following : edges.get(course)) {
                if (--degree[following] == 0) {
                    queue.add(following);
                }
            }
        }
        return count == numCourses ? order : new int[] {};
    }
}
