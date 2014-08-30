<form method="post">
    <textarea name="text"></textarea>
    <input type="submit" value="Color text"/>
</form>
<?php
if (isset($_POST['text'])):
    $text = $_POST['text'];
    for ($i = 0; $i < strlen($text); $i++):
        if (ord($text[$i]) % 2 == 0) {
            $color = "red";
        } else {
            $color = "blue";
        }
        ?>
        <span style="color:<?php echo $color ?>"><?php echo $text[$i] ?></span>
    <?php
    endfor;
endif;
?>