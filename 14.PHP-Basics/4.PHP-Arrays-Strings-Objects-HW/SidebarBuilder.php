<!DOCTYPE html>
<html>
<head>
    <title>Sidebar Builder</title>
    <style>
        h3 {
            margin: 0;
            padding-left: 20px;
            text-transform: capitalize;
        }

        ul {
            margin: 0;
        }

        aside {
            padding: 10px;
            width: 150px;
            background-color: lightblue;
            border: 1px solid black;
            border-radius: 30px;
            margin: 10px;
        }
    </style>
</head>
<body>
<form method="post">
    <label for="categories">Categories</label>
    <input type="text" name="categories"/><br>
    <label for="tags">Tags</label>
    <input type="text" name="tags"/><br>
    <label for="months">Months</label>
    <input type="text" name="months"/><br>
    <input type="submit" value="Generate"/>
</form>
<?php
sidebar("categories");
sidebar("tags");
sidebar("months");

function sidebar($name) {
    if (!empty($_POST[$name])):
        $items = preg_split("/\\W+/", $_POST[$name], -1, PREG_SPLIT_NO_EMPTY);
        ?>
        <aside>
            <h3><?php echo $name; ?></h3>
            <hr>
            <ul>
                <?php foreach ($items as $item): ?>
                    <li><?php echo $item; ?> </li>
                <?php endforeach; ?>
            </ul>
        </aside>
    <?php endif;
}

?>
</body>
</html>



