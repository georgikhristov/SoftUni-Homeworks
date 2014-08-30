<!DOCTYPE html>
<html>
<head>
    <title>Text Filter</title>
</head>
<body>
<form method="post">
    <textarea name="text"></textarea><br>
    <label for="banList">Ban List</label>
    <input type="text" name="banList"/><br>
    <input type="submit" value="Submit"/>
</form>
<?php
if (!empty($_POST['text']) && !empty($_POST['banList'])) {
    $text = $_POST['text'];
    $bans = preg_split("/\\W+/", $_POST['banList'], -1, PREG_SPLIT_NO_EMPTY);
    $banRegex = "/(" . join("|", $bans) . ")/";
    $new = preg_replace_callback($banRegex, "addStars", $text);
    echo htmlentities($new);
}

function addStars($matches) {
    $stars = '';
    for ($i = 0; $i < strlen($matches[0]); $i++) {
        $stars .= '*';
    }
    return $stars;
}

?>
</body>
</html>