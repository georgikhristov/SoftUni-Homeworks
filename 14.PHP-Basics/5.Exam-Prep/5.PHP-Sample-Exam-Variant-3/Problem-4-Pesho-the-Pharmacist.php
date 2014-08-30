<?php
date_default_timezone_set('Europe/Sofia');
//$todayInput = '27/08/2014';
//$invoices =[
//    '27/08/2014 | Actavis | Aulin | 231.12',
//    '17/08/2014 | Actavis | Aulin | 231.12',
//    '12/08/2014 | Actavis | Aulin | 231.12',
//    '22/08/2014 | Actavis | Aulin | 231.1',
//    '27/08/2014 | Peshopharm | Aulin | 231.12'];
//
//

$todayInput = $_GET['today'];
$invoices = $_GET['invoices'];
$todayPieces = explode('/', $todayInput);
$today = strtotime($todayPieces[1].'/'.$todayPieces[0].'/'.$todayPieces[2]);

$deliveries = [];
foreach($invoices as $invoice){
    $matches = preg_split('/\s*\|s*/', $invoice, -1, PREG_SPLIT_NO_EMPTY);
    $invPieces = [];
    foreach($matches as $inv){
        $invPieces[] = trim($inv);
    }
    $dateStr = $invPieces[0];
    $company = $invPieces[1];
    $medicine = $invPieces[2];
    $price = (double) $invPieces[3];
    $price = (string) $price;
    $datePieces = explode('/', $dateStr);
    $date = strtotime($datePieces[1].'/'.$datePieces[0].'/'.$datePieces[2]);
    if($date < strtotime('-5 years', $today)){
        continue;
    }
    if(!array_key_exists($date, $deliveries) || !array_key_exists($company, $deliveries[$date]) ){
        $deliveries[$date][$company][$price][] = $medicine;
    } else {
        $oldPrice = key($deliveries[$date][$company]);
        $newPrice = (string)($oldPrice + $price);
        $deliveries[$date][$company][$newPrice] = $deliveries[$date][$company][$oldPrice];
        $deliveries[$date][$company][$newPrice][] = $medicine;
        unset($deliveries[$date][$company][$oldPrice]);
    }
}
ksort($deliveries);
echo "<ul>";
foreach($deliveries as $date => &$companies){
    ksort($companies);
    echo "<li><p>". date("d/m/Y",$date) ."</p>";

    foreach ($companies as $company => &$prices ) {
        echo "<ul>";
        //ksort($prices);
        echo "<li><p>". $company ."</p>";

        foreach ($prices as &$medicines) {
            echo "<ul>";
            asort($medicines);
            echo "<li><p>". join(",", $medicines). "-". array_keys($prices)[0] ."lv</p></li>";
            echo "</ul>";
        }
        echo "</li></ul>";
    }
    echo "</li>";
}
echo "</ul>";

//http://localhost:63342/5.%20Exam-Prep/Var3/Problem-4-Pesho-the-Pharmacist.php?invoices%5B%5D=11%2F05%2F2013+%7C+Sopharma+%7C+Paracetamol+%7C+20.54+lv&invoices%5B%5D=11%2F05%2F2013+%7C+Sopharma+%7C+Analgin+%7C+57.45+lv&invoices%5B%5D=02%2F12%2F2011+%7C+Actavis+%7C+Aulin+%7C+120.54+lv&invoices%5B%5D=13%2F05%2F2009+%7C+Sopharma+%7C+Tamiflu+%7C+221.54+lv&invoices%5B%5D=23%2F01%2F2014+%7C+Actavis+%7C+Paracetamol+%7C+7.54+lv&invoices%5B%5D=11%2F05%2F2013+%7C+Actavis+%7C+Paracetamol+%7C+17.54+lv&today=07%2F08%2F2014