<?php
$mainWordInput = $_GET['mainWord'];
$wordsInput = $_GET['words'];

$mainWordObj = json_decode($mainWordInput);
$key = key($mainWordObj);
preg_match('/\d+/', $key, $matchRow);
$mainWordRow = $matchRow[0] - 1;
$mainWord = $mainWordObj->$key;

$words = json_decode($wordsInput);
//var_dump($mainWord);

for ($i = 0; $i < strlen($mainWord); $i++) {
    if ($i == $mainWordRow) {
        $board[$i] = str_split($mainWord, 1);
//        for($j = 0; $j < strlen($mainWord); $j++){
//            $board[$i][] = $mainWord[$j];
//        }
    } else {
        $tempRow = array_fill(0, strlen($mainWord), "");
        $board[] = $tempRow;
    }
}

usort($words, function ($a, $b) {
    return strlen($b) - strlen($a);
});
$mainLen = strlen($mainWord);
$above = $mainWordRow;
$below = $mainLen - $mainWordRow - 1;
$wordFound = false;
$targetWord = '';
$targetCol = 0;
$targetRow = 0;
foreach ($words as $word) {
    $wordLen = strlen($word);
    if ($wordLen > $mainLen) {
        continue;
    }
    for ($col = 0; $col < $mainLen; $col++) {
        for ($wordIndex = 0; $wordIndex < $wordLen; $wordIndex++) {
            if ($mainWord[$col] == $word[$wordIndex]) {
                $aboveWord = $wordIndex;
                $belowWord = $wordLen - $wordIndex - 1;
                if (($aboveWord <= $above) && ($belowWord <= $below)) {
                    $wordFound = true;
                    $targetWord = $word;
                    $targetCol = $col;
                    $targetRow = $above - $aboveWord;
                    break;
                }
            }
        }
        if ($wordFound) {
            break;
        }
    }
    if ($wordFound) {
        break;
    }
}
if ($wordFound) {
    for($i = $targetRow; $i < strlen($targetWord) + $targetRow; $i++){
        $board[$i][$targetCol] = $targetWord[$i - $targetRow];
    }
    unset($words[array_search($targetWord, $words)]);
    $words = array_values($words);
}
echo "<table>";
for($row = 0; $row < $mainLen; $row++){
    echo '<tr>';
    for($col = 0; $col < $mainLen; $col++){
        echo '<td>' . $board[$row][$col] . '</td>';
    }
    echo '</tr>';
}
echo "</table>";



$wordsCount = array_count_values($words);
ksort($wordsCount);
//var_dump($wordsCount);
$jsonOutput = [];
foreach($wordsCount as $word => $count){
    $charSum = 0;
    for($i = 0; $i < strlen($word); $i++){
        $charSum += ord($word[$i]);
    }
    $jsonOutput[htmlentities($word)] = $charSum * $count;
    //var_dump($jsonOutput);
}
echo json_encode($jsonOutput);