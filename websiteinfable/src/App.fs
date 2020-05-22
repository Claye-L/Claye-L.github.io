module App

open Browser.Dom
open Fable.Core.JsInterop

let window = Browser.Dom.window
let mutable myCanvas : Browser.Types.HTMLCanvasElement = unbox window.document.getElementById "myCanvas"
let ctx = myCanvas.getContext_2d()

let w = myCanvas.width
let h = myCanvas.height
let steps = 10
let squareSize = 20

let gridWidth = float (steps * squareSize) 
myCanvas.width <- gridWidth
myCanvas.height <- gridWidth

let drawGrid()=
    [0..steps] // this is a list
      |> Seq.iter( fun x -> // we iter through the list using an anonymous function
          let v = float ((x) * squareSize) 
          ctx.moveTo(v, 0.)
          ctx.lineTo(v, gridWidth)
          ctx.moveTo(0., v)
          ctx.lineTo(gridWidth, v)
        )
    ctx.strokeStyle <- !^"#ddd"
    ctx.stroke() 


// Get a reference to our button and cast the Element to an HTMLButtonElement
let clearBtn = document.getElementById("clearBtn") :?> Browser.Types.HTMLButtonElement
let drawGridBtn = document.getElementById("drawGridBtn") :?> Browser.Types.HTMLButtonElement
// Register our listener
clearBtn.onclick <- fun _ ->
    ctx.clearRect(0.0,0.0,gridWidth,gridWidth)
drawGridBtn.onclick <- fun _ -> 
    drawGrid()