<form method="post" action="">
    <label for="tag">Enter html tags</label><br>
    <input type="text" name="tag"/>
    <input type="submit"/>
</form>
<?php
$validTags = array('a', 'abbr', 'acronym', 'address', 'applet', 'area', 'b', 'base', 'basefont',
    'bdo', 'bgsound', 'big', 'blockquote', 'blink', 'body', 'br', 'button', 'caption', 'center', 'cite', 'code',
    'col', 'colgroup', 'dd', 'dfn', 'del', 'dir', 'dl', 'div', 'dt', 'embed', 'em', 'fieldset', 'font', 'form',
    'frame', 'frameset', 'h1', 'h2', 'h3', 'h4', 'h5', 'h6', 'head', 'hr', 'html', 'iframe', 'img', 'input',
    'ins', 'isindex', 'i', 'kbd', 'label', 'legend', 'li', 'link', 'marquee', 'menu', 'meta', 'noframe',
    'noscript', 'optgroup', 'option', 'ol', 'p', 'pre', 'q', 's', 'samp', 'script', 'select', 'small', 'span', 'strike',
    'strong', 'style', 'sub', 'sup', 'table', 'td', 'th', 'tr', 'tbody', 'textarea', 'tfoot', 'thead', 'title',
    'tt', 'u', 'ul', 'var');

session_start();
if (!isset($_SESSION['count']) || !isset($_SESSION['guessedTags'])) {
    $_SESSION['count'] = 0;
    $_SESSION['guessedTags'] = [];
}
if (isset($_POST['tag'])):
    $isValid = false;
    $isGuessed = false;
    foreach ($validTags as $valid) {
        if ($_POST['tag'] == $valid) {
            $isValid = true;
            $isGuessed = false;
            foreach ($_SESSION['guessedTags'] as $guessed) {
                if ($_POST['tag'] == $guessed) {
                    $isGuessed = true;
                    break;
                }
            }
            if ($isGuessed == false) {
                $_SESSION['guessedTags'][] = $valid;
            }
            break;
        }
    }
    if ($isValid == true):
        if ($isGuessed == false):
            $_SESSION['count']++; ?>
            <h1>Valid tag!</h1>
            <h1>Score: <?= $_SESSION['count'] ?></h1>
        <?php else: ?>
            <h1>You already entered this tag!</h1>
            <h1>Score: <?= $_SESSION['count'] ?></h1>
        <?php endif; ?>
    <?php else: ?>
        <h1>Invalid tag</h1>
        <h1>Score: <?= $_SESSION['count'] ?></h1>
    <?php
    endif;
endif;
?>

