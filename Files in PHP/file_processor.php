<?php
//I Ahmed Nakhuda, 000878456, certify that this material is my original work. No other person's work has been used without suitable acknowledgment and I have not made my work available to anyone else.
/**
 * @author Ahmed Nakhuda 
 * @version 2023.11.04
 * @package COMP 102600 Assignment 2, Question 2
 */

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
   
    // Get the uploaded file and the column the user wants to sorts
    if (isset($_FILES['csvFile'])) {
        $file = $_FILES['csvFile']['tmp_name'];

        if (isset($_POST['sortColumn'])) {
            $sortColumn = $_POST['sortColumn'];
        }

        // Read the CSV file
        $file = fopen($file, 'r');

        if ($file !== false) {
            // Read the first line of the file to get the column names 
            $columnName = fgets($file);
            $columnName = explode(',', $columnName);

            // Read the CSV file and store the data in $fileData 
            while (!feof($file)) {
                $line = fgets($file);
                $row = explode(',', $line);
                $fileData[] = $row;
            }

            fclose($file);


            /**
             * Function to compare two elements based on the column specified.
             * @param $a The first element to compare.
             * @param $b The second element to compare.
             * @param $sortColumn The column used for sorting.
             * @return int A positive value if $a should come after $b, a negative value if $a should come before $b, or 0 if they are equal.
             */
            function SortColumns($a, $b, $sortColumn)
            {
                return strnatcasecmp($a[$sortColumn - 1], $b[$sortColumn - 1]); // -1 for 0 based index 
            }

            // Sort the columns using usort
            usort($fileData, function ($a, $b) {
                global $sortColumn; // get the column being sorted 
                return SortColumns($a, $b, $sortColumn);
            });

            // Combine the $columnName array with the $fileData array as key and value pairs and store them in $data 
            foreach ($fileData as $row) {
                $data[] = array_combine($columnName, $row);
            }

            // Echo the data as a JSON encoded array  
            echo json_encode($data);
        }
    }
}
