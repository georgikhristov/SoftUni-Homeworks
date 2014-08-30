<form method="post" action="MostFrequentTag.php">
    <p>Enter tags:</p>
    <input type="text" name="input"/>
    <input type="submit"/>
</form>
<?php
if (isset($_POST['input'])) {
    $input = explode(", ", $_POST['input']);
    $uniqueTags;

    for ($i = 0; $i < count($input); $i++) {
        $unique = true;
        for ($j = 0; $j < $i; $j++){
            if ($input[$i] == $input[$j]){
                $unique = false;
            }
        }
        if($unique){
            $count = 1;
            for ($j = $i + 1; $j < count($input); $j++) {
                if ($input[$i] == $input[$j]){
                    $count++;
                }
            }
            $uniqueTags[$input[$i]] = $count;
        }
    }
    foreach ($uniqueTags as $tag){
        //?????????
    }
}
?>