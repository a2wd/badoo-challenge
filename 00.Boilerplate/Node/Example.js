var readline = require("readline");
var start = true;

//Calculate the gcd
var gcd = function(i, j) {
    if(j === 0)
        return i;

    var k = i % j;
    return gcd(j, k);
}

//Read from stdIn
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
    terminal: false
});

//Main program loop
rl.on("line", function(line){
    if(start) {
        start = false;
        return;
    }

    //Split input and calculate GCD
    var numbers = line.split(" ");
    if(numbers.length === 3) {
        var i = parseInt(numbers[0]);
        var j = parseInt(numbers[1]);
        var inputGcd = parseInt(numbers[2]);
        var actualGcd = gcd(i, j);

        if(inputGcd === actualGcd)
            console.log("OK");
        else
            console.log(actualGcd);
    }
});
