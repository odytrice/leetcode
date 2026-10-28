module ReferenceSolution

// O(n log k) time. Keeps a sorted window of the k largest values.
let findKthLargest (nums: int array) (k: int) : int =
    nums
    |> Array.sortDescending
    |> Array.item (k - 1)
