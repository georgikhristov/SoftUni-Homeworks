<?php
$n = 1203;

if($n < 100){
    echo 'no';
} else {
    if($n > 999){
        $n = 999;
    }
    $numbers = array();
    for($i = 100; $i <= $n; $i++){
        $digit1 = floor($i/100);
        $digit2 = floor($i/10)%10;
        $digit3 = $i%10;
        $isValid = ($digit1 != $digit2) && ($digit1 != $digit3) && ($digit2 != $digit3);
        if($isValid == true){
            array_push($numbers,$i);
        }
    }
    echo join(', ', $numbers);
}
?>