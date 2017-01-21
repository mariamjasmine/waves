//global variables 
//waveHeight range is 0,100;

var parseChat = “null”;
var parseCount = 0;
var upCount = 0;
var downCount = 0;
var chatCommand = “null”;

var waveHeight = 30;
var underwaterObject = “NO”;

//parse Twitch chat for commands

function parse() {
   parseCount += 1;
   parseChat = *chat input*
   if (parseChat === “UP”) {
      upCount += 1;
   }
   else if (parseChat === “DOWN”) {
      downCount += 1;
   }
}

function setCommand() {
   if (upCount > downCount) {
      chatCommand = “UP”;
   }
   else if (downCount > upCount) {
      chatCommand = “DOWN”;
   }
}

if (parseCount < 15) {
   parse();
}

if (parseCount === 15) {
   parseCount = 0;
setCommand();
}

//waveHeight changes based on aggregate chat command

if (chatCommand === “UP”) {
   waveHeight += Math.floor(Math.random() * 10) + 1);  
}
else if (chatCommand === “DOWN”) {
   waveHeight -= Math.floor(Math.random() * 10) + 1);  
}

//waveHeight increases when underwaterObject appears 

if (underwaterObject === “YES”) {
   waveHeight -= Math.floor(Math.random() * 5) + 1);  
} 

//fail conditions

function fail(){
//game over stuff
}

if (waveHeight < 10 || waveHeight > 90) {
   fail();
}
