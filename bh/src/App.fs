module App

(**
 The famous Increment/Decrement ported from Elm.
 You can find more info about Elmish architecture and samples at https://elmish.github.io/
*)

open Elmish
open Elmish.React
open Fable.React
open Fable.React.Props
open BhGame
// MODEL

type Model = int

type Msg =
| Increment
| Decrement

let init() : Model = 0

// UPDATE

let update (msg:Msg) (model:Model) =
    match msg with
    | Increment -> model + 1
    | Decrement -> model - 1

// VIEW (rendered with React)

let gameBoard (model:Model) dispatch =
    div [Style [Display DisplayOptions.Grid]] 
      [
        yield! [0..21] 
        |> Seq.map (fun i -> 
          div [Style 
              [
                GridColumn (i %  6 + 1); 
                GridRow (i / 6 + 1); 
                Border "2px"; 
                Margin "2px"; 
                BackgroundColor "red"
              ]
            ] 
            [p [] [str "+"]])
      ]

let view (model:Model) dispatch =

  div [Style [Display DisplayOptions.Grid]] [
    // //increment button owo
    // div []
    //   [ button [ OnClick (fun _ -> dispatch Increment) ] [ str "+" ]
    //     div [] [ str (string model) ]
    //     button [ OnClick (fun _ -> dispatch Decrement) ] [ str "-" ] ] ;
      gameBoard model dispatch
  ]
 



// App
Program.mkSimple init update view
|> Program.withReactSynchronous "elmish-app"
|> Program.withConsoleTrace
|> Program.run
