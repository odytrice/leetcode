module ReferenceSolution

// O(n) time. Tracks the furthest reachable index.
let canJump (nums: int array) : bool =
    let mutable reach = 0
    let mutable possible = true
    let mutable doneSearch = false

    for index in 0 .. nums.Length - 1 do
        if not doneSearch then
            if index > reach then
                possible <- false
                doneSearch <- true
            else
                reach <- max reach (index + nums[index])
                if reach >= nums.Length - 1 then doneSearch <- true

    possible
