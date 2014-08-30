<?php
$today = getdate();
$month = $today['mon'];
$year = $today['year'];
$firstDate = strtotime("01-".$month."-".$year);
$startDate = strtotime("Sunday", $firstDate);
switch ($month){
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12: $maxDay = 31; break;
    case 2: $maxDay = $year % 4 == 0 ? 29 : 28; break;
    case 4:
    case 6:
    case 9:
    case 11:$maxDay = 30;
}
$endDate = strtotime($maxDay."-".$month."-".$year);
while ($startDate <=  $endDate) :
?>
<p><?=date("jS F, Y", $startDate)?></p>
<?php
    $startDate = strtotime("+1 week", $startDate);
endwhile;
?>
