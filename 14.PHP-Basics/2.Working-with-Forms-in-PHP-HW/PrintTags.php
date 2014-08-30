<form method="post" action="PrintTags.php">
    <p>Enter tags:</p>
    <input type="text" name="input"/>
    <input type="submit"/>
</form>
<?php
if (isset($_POST['input'])) {
    $input = explode(", ", $_POST['input']);
    for ($i = 0; $i < count($input); $i++) {
        echo '<p>' . $i . ' : ' . $input[$i] . '</p>';
    }
}
?>
