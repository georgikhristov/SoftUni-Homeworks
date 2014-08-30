<!DOCTYPE html>
<html>
<head>
    <title>Car Randomizer</title>
</head>
<body>
<form method="post">
    <label for="start">Start index</label>
    <input type="text" name="start"/>
    <label for="end">End index</label>
    <input type="text" name="end"/>
    <input type="submit" value="Submit">
</form>
<?php if (isset($_POST['start']) && isset($_POST['end'])) {
    $nums = [];
    for ($i = $_POST['start']; $i <= $_POST['end']; $i++) {
        if (is_prime($i)) {
            $nums[] =  "<b>{$i}</b>";
        } else {
            $nums[] = $i;
        }
    }
    echo join(", ", $nums);
}

function is_prime($n)
{
    $end = sqrt($n);
    for ($i = 2; $i <= $end; $i++) {
        if ($n % $i == 0) {
            return false;
        }
    }
    return true;
}

?>
</body>
</html>