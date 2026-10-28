module ReferenceSolution

// O(n) time, O(1) space. Moves the shorter wall inward; it can only improve.
let maxArea (height: int array) : int =
    let mutable left = 0
    let mutable right = height.Length - 1
    let mutable best = 0
    while left < right do
        best <- max best ((right - left) * min height[left] height[right])
        if height[left] <= height[right] then
            left <- left + 1
        else
            right <- right - 1
    best
