<?php
$nameStr = $_GET['name'];
$genderStr = $_GET['gender'];
$pinStr = $_GET['pin'];

function incorrect()
{
    die("<h2>Incorrect data</h2>");
}

$namePattern = '/[A-Z][a-z]*\s[A-Z][a-z]*/';
preg_match($namePattern, $nameStr, $matchName);

$pinPattern = '/[0-9]{10}/';
preg_match($pinPattern, $pinStr, $matchPin);

if (empty($matchName) || empty($matchPin)) {
    incorrect();
} else {
    $name = $matchName[0];
    $pin = $matchPin[0];
    if(!pinValidate($pin,$genderStr)){
        incorrect();
    } else{
        $person = [
            "name" => $name,
            "gender" => $genderStr,
            "pin" => $pin
        ];
        echo json_encode($person);
    }
}

function pinValidate($pin, $gender)
{
    $year = substr($pin, 0, 2);
    $month = substr($pin, 2, 2);
    $day = substr($pin, 4, 2);
    if($month > 40){
        $month -=40;
        $year = "20" . $year;
    } elseif($month > 20){
        $month -= 20;
        $year = "18" . $year;
    } else{
        $year = "19" . $year;
    }
    $dateStr = $day . "-" . $month . "-" .$year;
    $date = date_create($dateStr, timezone_open("Europe/Sofia"));

    if (!$date){
        return false;
//    } else{
//        $dateCheck = date_format($date, "d-m-Y");
//        if($dateCheck != $dateStr){
//            return false;
//        }
    }

    $genderCheck = ($gender == 'male') ? 0 : 1;
    $genderDigit = $pin[8];
    if($genderDigit % 2 != $genderCheck){
        return false;
    }

    $sum = 0;
    $pinWeights = [2,4,8,5,10,9,7,3,6];
    for($i = 0; $i < 9; $i++){
        $sum += $pin[$i] * $pinWeights[$i];
    }
    $checkSum = $pin[9];
    $sumRemainder = ($sum % 11) % 10;
    if ($checkSum != $sumRemainder){
        return false;
    }

    return true;

}