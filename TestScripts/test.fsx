type X = { x : int }

let y = { x = 5 }

/// BREAK

y
|> _.x.ToString().ToString()
|> printfn "%s"