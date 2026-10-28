public class ReferenceSolution : Solution
{
    public override int LastStoneWeight(int[] stones)
    {
        var heap = new PriorityQueue<int, int>(); foreach (int w in stones) heap.Enqueue(w, -w);
        while (heap.Count > 1) { int a = heap.Dequeue(), b = heap.Dequeue(); if (a != b) heap.Enqueue(a - b, b - a); }
        return heap.Count == 0 ? 0 : heap.Dequeue();
    }
}
