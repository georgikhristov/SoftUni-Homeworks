<!DOCTYPE html>
<html>
<head>
    <title>Sentence Extractor</title>
</head>
<body>
<form method="post">
    <textarea name="text"></textarea><br>
    <label for="word">Word</label>
    <input type="text" name="word"/><br>
    <input type="submit" value="Submit"/>
</form>
<?php
if (!empty($_POST['text']) && !empty($_POST['word'])) {
    $text = $_POST['text'];
    $word = $_POST['word'];
    preg_match_all("/.+?[.!?]/", $text, $matches, PREG_PATTERN_ORDER);
    foreach ($matches[0] as $sentence) {
        $words = preg_split("/\\W+/", $sentence);
        if (array_search($word, $words)) {
            echo htmlentities($sentence) . '<br>';
        }
    }
}
?>
</body>
</html>