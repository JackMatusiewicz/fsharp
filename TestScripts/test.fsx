type X = { x : int -> int -> int }

let y = { x = (+) }

/// BREAK
y
|> fun n -> n.x 20 99
|> printfn "%d"
