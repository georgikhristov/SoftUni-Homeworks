<!DOCTYPE html>
<html>
<head>
    <title>Sum Digits</title>
</head>
<body>
<form method="post">
    <label for="nums">Enter numbers</label>
    <input type="text" name="nums"/>
    <input type="submit" value="Submit">
</form>
<table>
    <thead>
    <tr>
        <th>Number</th>
        <th>Sum of digits</th>
    </tr>
    </thead>
    <tbody>
    <?php
    if(isset($_POST['nums'])):
        $nums = explode(", ",$_POST['nums']);
        foreach ($nums as $num) :
            $sum = 0;
            if(!is_numeric($num)){
                $sum = 'I cannot sum that';
            } else{
                $int = intval($num);
                while($int > 0){
                    $sum += $int % 10;
                    $int = floor($int / 10);
                }
            }
            ?>
            <tr>
                <td><?php echo $num;?></td>
                <td><?php echo $sum;?></td>
            </tr>
    <?php
        endforeach;
    endif;
    ?>
    </tbody>
</table>

</body>
</html>