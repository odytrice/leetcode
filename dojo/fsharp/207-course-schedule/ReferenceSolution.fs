module ReferenceSolution

// O(courses + prerequisites) time. Kahn's algorithm: peel off courses with no unmet prerequisite.
let canFinish (numCourses: int) (prerequisites: int array array) : bool =
    let edges = Array.init numCourses (fun _ -> ResizeArray<int>())
    let degree = Array.zeroCreate<int> numCourses
    for pair in prerequisites do
        edges[pair[1]].Add pair[0]
        degree[pair[0]] <- degree[pair[0]] + 1

    let queue = System.Collections.Generic.Queue<int>()
    for course in 0 .. numCourses - 1 do
        if degree[course] = 0 then queue.Enqueue course

    let mutable doneCount = 0
    while queue.Count > 0 do
        let course = queue.Dequeue()
        doneCount <- doneCount + 1
        for following in edges[course] do
            degree[following] <- degree[following] - 1
            if degree[following] = 0 then queue.Enqueue following

    doneCount = numCourses
