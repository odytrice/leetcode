// LeetCode supplies these types. Linked here so each drill builds independently.
public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;

    public static ListNode? From(params int[] values)
    {
        ListNode? head = null;
        for (int i = values.Length - 1; i >= 0; i--) head = new(values[i], head);
        return head;
    }

    public static int[] Values(ListNode? head)
    {
        var seen = new HashSet<ListNode>();
        var result = new List<int>();
        for (; head != null; head = head.next)
        {
            if (!seen.Add(head)) throw new Exception("Unexpected cycle in result");
            result.Add(head.val);
        }
        return result.ToArray();
    }
}

public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;

    public static TreeNode? From(params int?[] values)
    {
        if (values.Length == 0 || values[0] == null) return null;
        var root = new TreeNode(values[0]!.Value);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int i = 1;
        while (queue.Count > 0 && i < values.Length)
        {
            var node = queue.Dequeue();
            if (values[i++] is int l) { node.left = new(l); queue.Enqueue(node.left); }
            if (i < values.Length && values[i++] is int r) { node.right = new(r); queue.Enqueue(node.right); }
        }
        return root;
    }
}
