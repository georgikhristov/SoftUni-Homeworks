<?php
date_default_timezone_set('Europe/Sofia');
$startDateText = $_GET['dateOne'];
$endDateText = $_GET['dateTwo'];
$holidaysTextArr = preg_split("/\\s+/", $_GET['holidays'], -1, PREG_SPLIT_NO_EMPTY);

function parseDate($dateText){
    $date = DateTime::createFromFormat("d-m-Y h:i:s",$dateText . " 00:00:00");
    return $date;
}
$startDate = parseDate($startDateText);
$endDate = parseDate($endDateText);
$holidays = [];
foreach($holidaysTextArr as $holidayText){
    $holidays[] = parseDate($holidayText);
}
$date = $startDate;
$workingDays = [];
while($date <= $endDate) {
    $dateCopy = clone $date;
    if(isWorkingDay($date)){
        array_push($workingDays, $dateCopy);
    }
    $date = $startDate->add(DateInterval::createFromDateString('1 day'));
}

if(count($workingDays) == 0){
    echo '<h2>No workdays</h2>';
} else{
    echo '<ol>';
    foreach($workingDays as $workingDay){
        echo '<li>' . $workingDay->format("d-m-Y") . '</li>';
    }
    echo '</ol>';
}

function isWorkingDay(DateTime $date){
    $dateText = $date->format("d-m-Y");
    $dayOfWeek = date('w',strtotime($dateText));
    if($dayOfWeek == 0 || $dayOfWeek == 6){
        return false;
    } else{
        global $holidays;
        foreach($holidays as $holiday){
            if($date == $holiday){
                return false;
            }
        }

    }
    return true;
}