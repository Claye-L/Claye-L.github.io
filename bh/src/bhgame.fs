module BhGame
    type Player = | One | Two
    type Token = |Empty |Value of (Player * int)
    type Board = Token list

    let newBoard : Board = [0..21] |> List.map (fun _ -> Empty)