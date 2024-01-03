/* SA001: I Ahmed Nakhuda, 000878456 certify that this material is 
   my original work. No other person's work has been used without due 
   acknowledgement. I have not made my work available to anyone else. 
 
   Author: Ahmed Nakhuda, 000878456
   Date: March 10, 2023 
   Assignment 4, SVG Game, JavaScript 
*/

window.addEventListener("load", function () {
  let coinCanvas = document.getElementById("coinCanvas");
  let headCount = document.getElementById("headCount");
  let tailCount = document.getElementById("tailCount");
  let guessesRemaining = document.getElementById("guesses");
  let score = document.getElementById("score");
  let guess = document.getElementById("guess");
  let flipBtn = document.getElementById("flipBtn");
  let resetBtn = document.getElementById("resetBtn");
  
  // Set counters 
  let heads = 0; // heads counter 
  let tails = 0;  // tails counter 
  let remainingGuesses = 10;
  let currentScore = 0;

  // Function to flip the coin
  function flipCoin() {
    // Generate a random number between 0 and 1 to represent heads or tails
    let randomNum = Math.floor(Math.random() * 2);

    // Create a SVG circle to represent the coin
	const svgNS = "http://www.w3.org/2000/svg";
    let coin = document.createElementNS(svgNS, "circle");
    coin.setAttribute("cx", "200");
    coin.setAttribute("cy", "180");
    coin.setAttribute("r", "150");
	
	// Add the coin to the SVG
	coinCanvas.style.display = "block";
    coinCanvas.appendChild(coin);
	
    // Change the color of the coin based on the random number
    if (randomNum === 0) {
      coin.setAttribute("fill", "yellow"); 
      heads++;
	  headCount.textContent = heads;
    } else {
      coin.setAttribute("fill", "orange"); 
      tails++;
	  tailCount.textContent = tails;
    }
	
    // Check if the user's guess matches the result and update score 
    let userGuess = guess.value.toLowerCase();
    if (userGuess === "heads" && randomNum === 0) {
      currentScore++;
    } else if (userGuess === "tails" && randomNum === 1) {
      currentScore++;
    }
    score.textContent = currentScore;  

    // Decrease the remaining guesses
    remainingGuesses--;
    guessesRemaining.textContent = remainingGuesses;

    // Reset the game when user has no more guesses 
    if (remainingGuesses === -1) { // -1 so you can see final score before reset 
      resetGame();
    }
  }
  
  // Add animation to the SVG when button is clicked 
  flipBtn.addEventListener("click", () => {
    coinCanvas.classList.add("flip"); // CSS animation 
  setTimeout(() => {
    coinCanvas.classList.remove("flip");
  }, 350); // Animation duration
 }); 
  
  // Function to reset the game
  function resetGame() {
	// Reset counters 
    heads = 0;
	headCount.textContent = heads;
    tails = 0;
	tailCount.textContent = tails;
    remainingGuesses = 10;
	guessesRemaining.textContent = remainingGuesses;
    currentScore = 0;
    score.textContent = currentScore;
	// Clear guess input 
    guess.value = "";
	// Hide SVG 
    coinCanvas.style.display = "none";
  }

  // Add event listeners to the buttons
  flipBtn.addEventListener("click", flipCoin);
  resetBtn.addEventListener("click", resetGame);
});
