<!DOCTYPE html>
<html>
<head>
    <title>Car Randomizer</title>
</head>
<body>
    <form method="post">
        <label for="cars">Enter cars</label>
        <input type="text" name="cars"/>
        <input type="submit" value="Show Results">
    </form>
    <?php if(isset($_POST['cars'])): ?>
    <table border="1">
        <thead>
        <tr>
            <th>Car</th>
            <th>Color</th>
            <th>Count</th>
        </tr>
        </thead>
        <tbody>
        <?php
        $cars = explode(", ", $_POST['cars']);
        $colors = array("red", "orange", "yellow", "green", "blue",
                        "purple", "pink", "black", "grey", "white"
        );
        foreach ($cars as $car) : ?>
        <tr>
            <td><?php echo $car?></td>
            <td><?php echo $colors[rand(0,count($colors) - 1)]; ?> </td>
            <td><?php echo rand(1,5); ?></td>
        </tr>
        <?php endforeach; ?>
        </tbody>
    </table>
<?php endif;?>
</body>
</html>