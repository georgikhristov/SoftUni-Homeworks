<!DOCTYPE html>
<html>
<head>
    <title>Annual Expenses</title>
</head>
<body>
<form method="post">
    <label for="years">Enter number of years</label>
    <input type="text" name="years"/>
    <input type="submit" value="Show Costs">
</form>
<?php
if (isset($_POST['years'])):
    $yearNum = intval($_POST['years']);
    ?>
    <table border="1">
        <thead>
        <tr>
            <th>Year</th>
        <?php
        $today = getdate();
        $year = $today['year'];
        for($i = 1; $i <=12; $i++):
            $month = strtotime("01-".$i."-".$year);?>
            <th><?php echo date("F", $month); ?></th>
        <?php endfor;?>
            <th>Total:</th>
        </tr>
        </thead>
        <tbody>
        <?php
        for($i = 0; $i < $yearNum; $i++ ): ?>
            <tr>
                <td><?php echo ($year - $i)?></td>
                <?php
                $sum = 0;
                for($j = 1; $j <=12; $j++):
                    $rand = rand(0,999);
                    $sum += $rand; ?>
                    <td><?php echo $rand; ?></td>
                <?php endfor;?>
                <td><?php echo $sum?></td>
            </tr>
        <?php endfor; ?>
        </tbody>
    </table>
<?php endif; ?>
</body>
</html>