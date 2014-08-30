<meta charset="UTF-8">

<form method="POST" action="CalculateInterest.php">
    Enter Amount <input type="text" name="money"><br>
    <input type="radio" name="currency" value="USD">
    <label for="USD">USD</label>
    <input type="radio" name="currency" value="EUR">
    <label for="EUR">EUR</label>
    <input type="radio" name="currency" value="BGN">
    <label for="BGN">BGN</label><br>
    Compound Interest Amount <input type="text" name="interest"><br>
    <select name="time">
        <option value="6">6 months</option>
        <option value="12">1 year</option>
        <option value="24">2 years</option>
        <option value="60">5 years</option>
    </select>
    <input type="submit" value="Calculate"/>
</form>

<?php
if (isset($_POST['money'])) {
    $money = $_POST['money'];
    $currency = $_POST['currency'];
    $interest = $_POST['interest'] / 12;
    $time = $_POST['time'];
    for ($i = 0; $i < $time; $i++) {
        $money *= (100 + $interest) / 100;
    }
    switch($currency){
        case 'EUR': $currency = '€'; break;
        case 'USD': $currency = '$'; break;
        case 'BGN': $currency = 'лв'; break;
    }

    echo $currency . ' ' . $money;
}
?>