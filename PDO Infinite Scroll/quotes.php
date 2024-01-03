<?php

//I Ahmed Nakhuda, 000878456, certify that this material is my original work. No other person's work has been used without suitable acknowledgment and I have not made my work available to anyone else.
/**
 * @author Ahmed Nakhuda
 * @version 2023.12.08
 * @package COMP 10260 Assignment 4
 */

 
/**
 * Function to generate an HTML card
 * @param $authorName the name of the author retrived from the database 
 * @param $quoteText the quote retrived from the database 
 */
function MakeCard($authorName, $quoteText)
{
    return '<div class="card mb-3 a4card w-100">
                <div class="card-header">' . htmlspecialchars($authorName) . '</div>
                <div class="card-body d-flex align-items-center">
                    <p class="card-text w-100">' . htmlspecialchars($quoteText) . '</p>
                </div>
            </div>';
}

// Validate and sanitize the incoming page parameter
$page = filter_input(INPUT_GET, 'page', FILTER_VALIDATE_INT);

// Set the limit and calculate the offset
$limit = 20;
$offset = ($page - 1) * $limit;

include "db.php";
try {
    $db = new PDO(DSN, USER, PASS);
    $db->setAttribute( PDO::ATTR_EMULATE_PREPARES, false );  //useful
 } catch (Exception $e) {
    die("ERROR: Couldn't connect. {$e->getMessage()}"); 
 }


// Query to retrieve quotes and authors from the database
$query = "SELECT quotes.quote_text, authors.author_name
              FROM quotes
              JOIN authors ON quotes.author_id = authors.author_id
              LIMIT :per_page
              OFFSET :offset";

$stmt = $db->prepare($query);
$stmt->bindParam(':per_page', $limit, PDO::PARAM_INT);
$stmt->bindParam(':offset', $offset, PDO::PARAM_INT);
$stmt->execute();

// Fetch quotes and build an array of HTML cards
$rows = $stmt->fetchAll(PDO::FETCH_ASSOC);
foreach ($rows as $row) {
    $cards[] = MakeCard($row['author_name'], $row['quote_text']);
}

// Output JSON-encoded array of card
echo json_encode($cards);
?>
