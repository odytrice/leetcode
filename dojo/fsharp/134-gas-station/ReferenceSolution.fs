module ReferenceSolution

// O(n) time. Restarts after every deficit; a total surplus guarantees one circuit.
let canCompleteCircuit (gas: int array) (cost: int array) : int =
    let mutable total = 0
    let mutable tank = 0
    let mutable start = 0
    for index in 0 .. gas.Length - 1 do
        let difference = gas[index] - cost[index]
        total <- total + difference
        tank <- tank + difference
        if tank < 0 then
            start <- index + 1
            tank <- 0
    if total < 0 then -1 else start
