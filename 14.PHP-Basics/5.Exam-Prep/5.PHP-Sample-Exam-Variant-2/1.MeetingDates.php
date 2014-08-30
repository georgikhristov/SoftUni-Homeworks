<?php
$dateOne = $_GET['dateOne'];
$dateTwo = $_GET['dateTwo'];

$dateOneObj = date_create($dateOne, timezone_open("Europe/Sofia"));
$dateTwoObj = date_create($dateTwo, timezone_open("Europe/Sofia"));

$dateStart = ($dateOneObj > $dateTwoObj) ? $dateTwoObj : $dateOneObj;
$dateEnd = ($dateOneObj == $dateStart) ? $dateTwoObj : $dateOneObj;

$currentDate = $dateStart;
$interval = date_interval_create_from_date_string("1 day");
$thursdays = [];
while($currentDate <= $dateEnd){
    $weekDay = date_format($currentDate, "w");
    if($weekDay == 4){
        $thursdays[] = date_format($currentDate, "d-m-Y");
        $interval = date_interval_create_from_date_string("1 week");
    }
    date_add($currentDate, $interval);
}

if(empty($thursdays)){
    echo '<h2>No Thursdays</h2>';
} else{
    echo '<ol>';
    foreach($thursdays as $thursday){
        echo '<li>' . $thursday . '</li>';
    }
    echo '</ol>';
}