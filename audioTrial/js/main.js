var x = document.getElementById("myAudio");
var btnPlay = document.querySelector(".btnPlay");
isPlayed = false;

btnPlay.addEventListener("click", function (e) {
    if (isPlayed == false) {
        x.play();
        isPlayed = true;
    }
});