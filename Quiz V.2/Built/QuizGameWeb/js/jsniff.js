var wide = screen.width;
var beta = function () {
    wide >= 900 ? window.location.href = "quiz-game.html" : window.location.href = "quiz-game.html";
};
var lambda = function () {
    wide <= 480 ? document.write = "This game is designed for Desktop play only." : beta();
};