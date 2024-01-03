<?php 
//I Ahmed Nakhuda, 000878456, certify that this material is my original work. No other person's work has been used without suitable acknowledgment and I have not made my work available to anyone else.
/**
 * @author Ahmed Nakhuda
 * @version 2023.11.04
 * @package COMP 102600 Assignment 2, Question 1
 */

 if($_SERVER['REQUEST_METHOD'] === 'GET') {
    
    // Get the choice and sort method the user selected 
    if (isset($_GET['choice'])) {
        $choice = $_GET['choice'];
    }

    if (isset($_GET['sort'])) {
        $sort = $_GET['sort'];
    }

/**
 * Function to read and parse the pokemon.txt file into an associative array
 * @return array data from the pokemon.txt file 
 */
function ReadPokemonFile() {
    // Read the content of the file and store each line in the array 
    $lines = file("pokemon.txt");
    if ($lines !== false) {
    // Iterate over the file by 2 lines
    for ($i = 0; $i < count($lines); $i += 2) {
        // Retrieve the name from the first line and the image from the next line  
        $name = htmlspecialchars($lines[$i]); 
        $image = htmlspecialchars($lines[$i + 1]);
        // Associative array that stores the values 
        $pokemonData[] = [
            "name" => $name,
            "image" => $image,
        ];
    }
}
    // Return the array containing the data 
    return $pokemonData;  
}


/**
 * Function to read and parse the movies.json file into an associative array
 * @return array data from the movies.json file 
 */
function ReadMoviesFile() {
    // Decode the json file and parse the data into an associative array 
    $moviesData = json_decode(file_get_contents("movies.json"), true);
    return $moviesData;
}


// Call the function based on the user's choice
if ($choice === "pokemon") {
    $data = ReadPokemonFile();
} elseif ($choice === "movies") {
    $data = ReadMoviesFile();
}


/**
 * Function to sort elements in the array by ascending order using selection sort algorithim 
 * @param $array the array that is being sorting 
 */
function SortAscending(&$array) { // Use &array so you make change to the original array not a copy of it
    $count = count($array);
    for ($i = 0; $i < $count - 1; $i++) {
        $minIndex = $i;
         // If the name at index j is alphabetically smaller than update minIndex to j 
        for ($j = $i + 1; $j < $count; $j++) {
            if ($array[$j]['name'] < $array[$minIndex]['name']) {
                $minIndex = $j;
            }
        }
            // Swap the elements to complete an iteration until finished 
            $temp = $array[$i];
            $array[$i] = $array[$minIndex];
            $array[$minIndex] = $temp;        
    }
}

/**
 * Function to sort elements in the array by descending order using selection sort algorithim 
 * @param $array the array that is being sorted
 */ 
function SortDescending(&$array) { // Use &array so you make change to the original array not a copy of it
    $count = count($array);
    for ($i = 0; $i < $count - 1; $i++) {
        $minIndex = $i;
         // If the name at index j is alphabetically greater than update minIndex to j 
        for ($j = $i + 1; $j < $count; $j++) {
            if ($array[$j]['name'] > $array[$minIndex]['name']) {
                $minIndex = $j;
            }
        }
            // Swap the elements to complete an iteration until finished 
            $temp = $array[$i];
            $array[$i] = $array[$minIndex];
            $array[$minIndex] = $temp;       
    }
}

// Sort the data based on the user's choice
if ($sort === "a") {
    SortAscending($data);
} elseif ($sort === "d") {
    SortDescending($data);
}

// Echo the data as a JSON encoded array 
echo json_encode($data);

} 
?>
