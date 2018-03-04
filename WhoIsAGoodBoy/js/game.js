function handleReady() {
   alert("Welcome to the game!");
}

$(document).ready(ShellGame);

$("#shell1").attr("src","second.jpg");

function ShowPups(){
	var validPups = false;
   
	var pup1 = (Math.ceil(Math.random() * 6));
	var pup2 = (Math.ceil(Math.random() * 6));
	var pup3 = (Math.ceil(Math.random() * 6));
	
	while(!validPups){

       if(pup1 == pup2){
           pup1 = (Math.ceil(Math.random() * 6));
       }
       else if(pup1 == pup3){
           pup1 = (Math.ceil(Math.random() * 6));
       }
       else if (pup2 == pup3){
           pup2 = (Math.ceil(Math.random() * 6));
       }

       if(pup1 != pup2  && pup1 != pup3 && pup2 != pup3){
			validPups = true;
	   }
   }
   switch (pup1){
   	   case 1:
	   $("#shell1").attr("src","images/Pups/pup1.jpg");
	   break;
	   case 2:
	   $("#shell1").attr("src","images/Pups/pup2.jpg");
	   break;
	   case 3:
	   $("#shell1").attr("src","images/Pups/pup3.jpg");
	   break;
	   case 4:
	   $("#shell1").attr("src","images/Pups/pup4.jpg");
	   break;
	   case 5:
	   $("#shell1").attr("src","images/Pups/pup5.jpg");
	   break;
	   case 6:
	   $("#shell1").attr("src","images/Pups/pup6.jpg");
	   break;
   }
   switch (pup2){
   	   case 1:
	   $("#shell2").attr("src","images/Pups/pup1.jpg");
	   break;
	   case 2:
	   $("#shell2").attr("src","images/Pups/pup2.jpg");
	   break;
	   case 3:
	   $("#shell2").attr("src","images/Pups/pup3.jpg");
	   break;
	   case 4:
	   $("#shell2").attr("src","images/Pups/pup4.jpg");
	   break;
	   case 5:
	   $("#shell2").attr("src","images/Pups/pup5.jpg");
	   break;
	   case 6:
	   $("#shell2").attr("src","images/Pups/pup6.jpg");
	   break;
   }
   switch (pup3){
   	   case 1:
	   $("#shell3").attr("src","images/Pups/pup1.jpg");
	   break;
	   case 2:
	   $("#shell3").attr("src","images/Pups/pup2.jpg");
	   break;
	   case 3:
	   $("#shell3").attr("src","images/Pups/pup3.jpg");
	   break;
	   case 4:
	   $("#shell3").attr("src","images/Pups/pup4.jpg");
	   break;
	   case 5:
	   $("#shell3").attr("src","images/Pups/pup5.jpg");
	   break;
	   case 6:
	   $("#shell3").attr("src","images/Pups/pup6.jpg");
	   break;
   }
}


function ShellGame(){
   ShowPups();
   var gameOver = false;

   var winningNumber = (Math.ceil(Math.random() * 3));

   $("#shell1").on("click", function () {
       PlayAgainButton();
       if(!gameOver){
           if(winningNumber == 1){
               document.getElementById("winner").style.display = "block";
           }
           else{
               document.getElementById("loser").style.display = "block";
           }
       }
       gameOver = true;        
   })
   
   $("#shell2").on("click", function () {
       PlayAgainButton();
       if(!gameOver){
           if(winningNumber == 2 && !gameOver){
               document.getElementById("winner").style.display = "block";
           }
           else{
               document.getElementById("loser").style.display = "block";
           }
       }
       gameOver = true;        
   })
   
   $("#shell3").on("click", function () {
       PlayAgainButton();
       if(!gameOver){
           if(winningNumber == 3 && !gameOver){
               document.getElementById("winner").style.display = "block";
           }
           else{
               document.getElementById("loser").style.display = "block";
           }
       }
       gameOver = true;        
   })

   $('#playAgain').click(function(){
       location.reload();
   });
}

function PlayAgainButton(){
   document.getElementById("playAgain").style.display = "block";
}


