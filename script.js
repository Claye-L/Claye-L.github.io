/* jshint browser: true */
var gamecanvas = document.getElementById("gamecanvas");
var canvasinfo = {height: gamecanvas.height, width: gamecanvas.width};

basicDraw(gamecanvas.getContext("2d"));


function basicDraw(ctx) {
    ctx.strokeRect(0, 0, canvasinfo.width, canvasinfo.height);
}
