//not sure how obstacleSprite(s) gets introduced (stuff with objects?); 
<<<<<<< Updated upstream
<<<<<<< HEAD
//var obstacleSprites = [];
//var obstacleSprite = "";
//var obstacleName = "";
=======
//var sprite1,sprite2,sprite3,sprite4,thisSprite;
=======
/*var sprite1,sprite2,sprite3,sprite4,thisSprite;
>>>>>>> Stashed changes
var maxX = 10;
var maxY = 10;
var minX = 5;
var minY = 5;
var obstacleSprites = [sprite1, sprite2, sprite3, sprite4];
var obstacleSprite = "";
var obstacleName = "";
var endPosition;
>>>>>>> origin/master



<<<<<<< HEAD
//function makeObstacles() {
//
//	for (var i=0;i<obstacleSprites.length;i++)
//		obstacleSprite = obstacleSprites[i];
//		obstacleName = obstacleSprite.name;
//		obstacleSprites[i] = Instantiate(obstacleSprites[i], new Vector3(Math.floor(Math.random() * (maxY - minY + 1)) + minY), Math.floor(Math.random() * (maxX - minX + 1)) + minX),0,transform.rotation);
//}
//
//setInterval(function(){
//	makeObstacles();
//},10000);
=======
function makeObstacle() {	
	thisSprite = obstacleSprites[Math.floor(Math.random() * 4)];
 	obstacleName = thisSprite.name;
	obstacleSprite = Instantiate(thisSprite, new Vector3(Math.floor(Math.random() * (maxY - minY + 1)) + minY), Math.floor(Math.random() * (maxX - minX + 1)) + minX,0,transform.rotation);
}

setInterval(function(){
	makeObstacle();
	//clearInterval on fail state
},Math.floor(Math.random() * 15000);

/*
function moveObstacle(){
//animate obstacle so it moves from its x position to < 0 while
randomly animating y position slightly higher or lower
}
*/
>>>>>>> origin/master
