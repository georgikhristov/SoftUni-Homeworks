<!DOCTYPE html>
<html>
<head>
    <title>Sum Digits</title>
</head>
<body>
    <form method="post">
        <label for="string">Enter a string</label>
        <input type="text" name="string">
        <input type="radio" name="function" value="palindrome">
        <label for="palindrome">Check if palindrome</label>
        <input type="radio" name="function" value="reverse">
        <label for="reverse">Reverse string</label>
        <input type="radio" name="function" value="split">
        <label for="split">Split</label>
        <input type="radio" name="function" value="hash">
        <label for="hash">Hash string</label>
        <input type="radio" name="function" value="shuffle">
        <label for="shuffle">Shuffle string</label>
        <input type="submit" value="submit">
    </form>
    <?php
    if(isset($_POST['string']) && isset($_POST['function'])){
        $str = $_POST['string'];
        switch($_POST['function']){
            case "palindrome": $result = palindrome($str); break;
            case "reverse": $result = strrev($str); break;
            case "split": $result = mySplit($str); break;
            case "hash": $result = crypt($str); break;
            case "shuffle": $result = str_shuffle($str); break;
        }
        echo $result;
    }
    function palindrome($s){
        $count = strlen($s);
        for($i = 0; $i < $count/2; $i++){
            if($s[$i] != $s[$count - 1 - $i]){
                return $s . " is not a palindrome";
            }
        }
        return $s . " is a palindrome";
    }
    function mySplit($str){
        preg_match_all("/[a-zA-Z]/", $str, $arr);
        return implode(' ', $arr[0]);
    }
    ?>
</body>
</html>