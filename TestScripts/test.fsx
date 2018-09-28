type X = { x : int -> int }

let y = { x = (+) 5 }

/// BREAK
y
|> _.x(5)
|> printfn "%d"
