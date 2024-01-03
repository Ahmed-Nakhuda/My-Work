/* SA001: I Ahmed Nakhuda, 000878456 certify that this material is 
 my original work. No other person's work has been used without due 
 acknowledgement. I have not made my work available to anyone else. 
 
  Author: Ahmed Nakhuda, 000878456
  Date: Wednesday April 5, 2023 
  Assignment 5, AJAX and fetch request, JavaScript  
*/

window.addEventListener("load", () => {
  // Get the elements from the HTML 
  let nameContainer = document.getElementById("nameContainer");
  let imageCopyright = document.getElementById("imageCopyright"); 
  let imageContainer = document.getElementById("imageContainer");
  let tableContainer = document.getElementById("tableContainer"); 
  let tableCopyright = document.getElementById("tableCopyright"); 
  let button1 = document.getElementById("button1");
  let button2 = document.getElementById("button2");
  let button3 = document.getElementById("button3");
  let form = document.getElementById("form");


  // add a click event listener to button1
  button1.addEventListener("click", () => {
    let url = "https://csunix.mohawkcollege.ca/~adams/10259/a6_responder.php?"
    // create a new AJAX request
    fetch(url, { credentials: 'include' })
      .then(response => response.text())
      .then(text => {
        // create a new h1 element with the response text as name and number
        let h1 = document.createElement("h1");
        let name = " " + "Ahmed Nakhuda, 000878456";
        h1.textContent = text + name; 

        // append the h1 element to the container
        nameContainer.appendChild(h1);
      });
  });
  
  // add a click event listener to button2
  button2.addEventListener("click", () => {
    let choice = form.choice.value; // get the selected value from the radio buttons
    let url = "https://csunix.mohawkcollege.ca/~adams/10259/a6_responder.php?choice=" + choice;

    // create a new AJAX request
    fetch(url) // fetch the url 
      .then(response => response.json())
      .then(json => {
        let numDivs = json.length; // create the amount of divs as the length of the array
        let space = 100 / numDivs; // space out the images 
   
        
        for (let i = 0; i < numDivs; i++) { // iterate through the array 
          let div = document.createElement("div"); // create a div element which holds the images 
          div.style.width = space + "%"; // space the divs 
          div.style.float = "left"; // float images to the left 
          
          // create a h2 element and set the text content to what it retrieves
          let h2 = document.createElement("h2"); 
          h2.textContent = json[i].series;  
          div.appendChild(h2); // appened it to the div 
          
          // create a img element and set the img src to what it retrieves 
          let img = document.createElement("img");  
          img.src = json[i].url; 
          img.width = "250"; 
          img.height = "250"; 
          div.appendChild(img); // append it to the div 
          
          // create a p element for the name and set the text content to what it retrieves
          let name = document.createElement("p");  
          name.textContent = json[i].name; 
          div.appendChild(name); // append it to the div 
          
          imageContainer.appendChild(div); // append the div to the container 
          
          // set the copyright based on the choice 
          if (choice === "mario") {
            imageCopyright.textContent = "Game trademarks and copyrights are properties of their respective owners. Nintendo properties are trademarks of Nintendo. © 2019 Nintendo.";
          } else if (choice === "starwars") {
            imageCopyright.textContent = "Star Wars © & TM 2022 Lucasfilm Ltd. All rights reserved. Visual material © 2022 Electronic Arts Inc";
          }
        }
      })
  });
  
  // add a click event listener to button3
  button3.addEventListener("click", () => {
    let choice = form.choice.value; // set the choice to the form input value 
    let params = "choice=" + choice; // choice 
    // create a new AJAX request
    fetch("https://csunix.mohawkcollege.ca/~adams/10259/a6_responder.php", { // fetch the URL 
      method: 'POST', // Post method 
      credentials: 'include',
      headers: { "Content-Type": "application/x-www-form-urlencoded" },
      body: params
    })
      // json response 
      .then(response => response.json())
      .then(json => {
        console.log(json);
        console.log(choice);

        
        // create a table 
        let table = document.createElement("table");

        // create a row 
        let row = document.createElement("tr");

        // create th elements for the series, name, and link  
        let th = document.createElement("th");
        let th2 = document.createElement("th");
        let th3 = document.createElement("th");
        // set the text content 
        th.textContent = "Series";
        th2.textContent = "Name"
        th3.textContent = "Link"

        // append the th elements to the first row 
        row.appendChild(th);
        row.appendChild(th2);
        row.appendChild(th3);
        table.appendChild(row); // append the row to the table 

        // set the table length to the length of the json array 
        let tableLength = json.length;


        // iterate through the array 
        for (let i = 0; i < tableLength; i++) {

          let row2 = document.createElement("tr"); // create a new row 

          // create td elements for the series, name, and url 
          let td = document.createElement("td");
          let td2 = document.createElement("td");
          let td3 = document.createElement("td");

          // reterive the series, name, and url and set the text content 
          td.textContent = json[i].series;
          td2.textContent = json[i].name;
          td3.textContent = json[i].url;
          // append the td elements to row2  
          row2.appendChild(td);
          row2.appendChild(td2);
          row2.appendChild(td3);
         
          table.appendChild(row2); // append the second row to the table 
          tableContainer.appendChild(table); // append the table to the container 
          
           // set the copyright based on the choice
          if (choice === "mario") {
            tableCopyright.textContent = "Game trademarks and copyrights are properties of their respective owners. Nintendo properties are trademarks of Nintendo. © 2019 Nintendo.";
          } else if (choice === "starwars") {
            tableCopyright.textContent = "Star Wars © & TM 2022 Lucasfilm Ltd. All rights reserved. Visual material © 2022 Electronic Arts Inc";
          }
        }
      })
   });
});

