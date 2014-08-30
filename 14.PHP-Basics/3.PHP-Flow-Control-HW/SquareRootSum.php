<!DOCTYPE html>
<html>
<head>
    <title>Square Root Sum</title>
</head>
<body>
    <table border="1">
        <thead>
        <tr>
            <th><b>Number</b></th>
            <th><b>Square</b></th>
        </tr>
        </thead>
        <tbody>
        <?php
        $sum = 0;
        for($i = 0; $i <= 100; $i+=2):
            $sum += round(sqrt($i), 2);
        ?>
            <tr>
                <td><?php echo $i ?></td>
                <td><?php echo round(sqrt($i), 2);?></td>
            </tr>
        <?php endfor; ?>
        </tbody>
        <tfoot>
            <tr>
                <td><b>Total:</b></td>
                <td><?php echo $sum ?></td>
            </tr>
        </tfoot>

    </table>
</body>
</html>
