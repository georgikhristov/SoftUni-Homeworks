<!DOCTYPE html>
<html>
<head>
    <title>URL Replacer</title>
</head>
<body>
<form method="post">
    <textarea name="text"></textarea>
    <input type="submit" value="Replace URLs" />
</form>
<?php
if(!empty($_POST['text'])){
    $new = preg_replace("/<\\s*a\\s+href\\s*=\\s*[\"\'](.+?)[\"\']\\s*>(.+?)<\/a>/","[URL=\\1]\\2[/URL]" ,$_POST['text']);
    echo htmlentities($new);
}
?>
</body>
</html>