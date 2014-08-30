<?php
$text = $_GET['text'];
$sampleKey = $_GET['key'];
$key = preg_quote($sampleKey[0]);
for($i = 1; $i < strlen($sampleKey) - 1; $i++){
    $charValue = ord($sampleKey[$i]);
    if($charValue >= 48 && $charValue <= 57){
        $key .= "\\d*";
    } elseif($charValue >= 65 && $charValue <= 90){
        $key .= "[A-Z]*";
    } elseif($charValue >= 97 && $charValue <= 122 ){
        $key .= "[a-z]*";
    } else {
        $key .= preg_quote($sampleKey[$i]);
    }
//    if(ctype_digit($sampleKey[$i])){
//        $key .= '\d*';
//    } elseif( ctype_lower($sampleKey[$i])){
//        $key .= '[a-z]*';
//    } elseif (ctype_upper($sampleKey[$i])){
//        $key .= '[A-Z]*';
//    } else {
//        $key .= preg_quote($sampleKey[$i]);
//    }
}
$key .= preg_quote($sampleKey[strlen($sampleKey) - 1]);

$pattern = "/".$key . '(.{2,6})' . $key."/";
preg_match_all($pattern, $text, $matches, PREG_PATTERN_ORDER);

echo join("", $matches[1]);
?>