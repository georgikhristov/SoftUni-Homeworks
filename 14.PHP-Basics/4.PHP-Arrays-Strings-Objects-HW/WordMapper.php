<form method="post">
    <textarea name="text"></textarea>
    <input type="submit" value="Count words"/>
</form>
<?php
if (isset($_POST['text'])):
    $words = preg_split("/\\W+/", strtolower($_POST['text']), -1, PREG_SPLIT_NO_EMPTY);
    $uniqueWords = array_count_values($words);
    ?>
    <table border="1">
        <thead>
        <tr>
            <th>Word</th>
            <th>Count</th>
        </tr>
        </thead>
        <tbody>
        <?php foreach ($uniqueWords as $word => $count): ?>
            <tr>
                <td><?php echo $word ?></td>
                <td><?php echo $count ?></td>
            </tr>
        <?php endforeach; ?>
        </tbody>
    </table>
<?php endif; ?>