// 1 hour countdown for reading.
var count = 3600;
var counter = setInterval(countdown, 1000);

function countdown() {
    count -= 1;
    if (count == -1) {
        clearInterval(counter);
        return;
    }

    var seconds = count % 60;
    var minutes = Math.floor(count / 60);
    var hours = Math.floor(minutes / 60);
    minutes %= 60;
    hours %= 60;

    document.getElementById("time-container").innerHTML = minutes + " minutes " + seconds + " seconds ";
}
// 1 hour countdown for reading.

