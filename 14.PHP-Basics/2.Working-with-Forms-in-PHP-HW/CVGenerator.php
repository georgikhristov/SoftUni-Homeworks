<!DOCTYPE html>
<html>
<head>
    <title>CV Generator</title>
    <style>
        td,th,table{
            border:1px solid black;
        }
    </style>
</head>
<body>
<?php
$errors = [];
if (!isset($_POST['first_name']) || !isset($_POST['last_name']) || !isset($_POST['email']) ||
    !isset($_POST['phone']) || !isset($_POST['gender']) || !isset($_POST['birth_date']) ||
    !isset($_POST['nationality']) || !isset($_POST['company']) || !isset($_POST['work_from']) ||
    !isset($_POST['work_to']) || !isset($_POST['progLang']) || !isset($_POST['level']) ||
    !isset($_POST['lang']) || !isset($_POST['comprehension'])|| !isset($_POST['reading'])||
    !isset($_POST['writing']) || !isset($_POST['license'])){
    $errors[] = 'Please fill out all fields';
}
//.....
if (count($errors) == 0):
?>

<h1>CV</h1>
<table>
    <thead>
    <tr>
        <th colspan="2">Personal Information</th>
    </tr>
    </thead>
    <tbody>
    <tr>
        <td>First Name</td>
        <td><?=$_POST['first_name']?></td>
    </tr>
    <tr>
        <td>Last Name</td>
        <td><?=$_POST['last_name']?></td>
    </tr>
    <tr>
        <td>Email</td>
        <td><?=$_POST['email']?></td>
    </tr>
    <tr>
        <td>Phone Number</td>
        <td><?=$_POST['phone']?></td>
    </tr>
    <tr>
        <td>Gender</td>
        <td><?=$_POST['gender']?></td>
    </tr>
    <tr>
        <td>Birth Date</td>
        <td><?=$_POST['birth_date']?></td>
    </tr>
    <tr>
        <td>Nationality</td>
        <td><?=$_POST['nationality']?></td>
    </tr>
    </tbody>
</table>
<table>
    <thead>
    <tr>
        <th colspan="2">Last Work Position</th>
    </tr>
    </thead>
    <tbody>
    <tr>
        <td>Company Name</td>
        <td><?=$_POST['company']?></td>
    </tr>
    <tr>
        <td>From</td>
        <td><?=$_POST['work_from']?></td>
    </tr>
    <tr>
        <td>To</td>
        <td><?=$_POST['work_to']?></td>
    </tr>
    </tbody>
</table>
<table>
    <thead>
    <tr>
        <th colspan="2">Computer Skills</th>
    </tr>
    </thead>
    <tbody>
    <tr>
        <td>Programming Languages</td>
        <td>
            <table>
                <thead>
                <tr>
                    <th>Language</th>
                    <th>Skill Level</th>
                </tr>
                </thead>
                <tbody>
<?php
$progLang = $_POST['progLang'];
$level = $_POST['level'];
for($i = 0; $i < count($progLang); $i++): ?>
    <tr>
        <td><?=$progLang[$i]?></td>
        <td><?=$level[$i]?></td>
    </tr>
<?php endfor;?>
                </tbody>
            </table>
        </td>
    </tr>
    </tbody>
</table>
<table>
    <thead>
    <tr>
        <th colspan="2">Other Skills</th>
    </tr>
    </thead>
    <tbody>
    <tr>
        <td>Languages</td>
        <td>
            <table>
                <thead>
                <tr>
                    <th>Language</th>
                    <th>Comprehension</th>
                    <th>Reading</th>
                    <th>Writing</th>
                </tr>
                </thead>
                <tbody>
<?php
$lang = $_POST['lang'];
$comprehension = $_POST['comprehension'];
$reading = $_POST['reading'];
$writing = $_POST['writing'];
for($i = 0; $i < count($lang); $i++): ?>
    <tr>
        <td><?=$lang[$i]?></td>
        <td><?=$comprehension[$i]?></td>
        <td><?=$reading[$i]?></td>
        <td><?=$writing[$i]?></td>
    </tr>
<?php endfor;?>
                </tbody>
            </table>
        </td>
    </tr>
    <tr>
        <td>Driver's license</td>
        <td><?=join(', ',$_POST['license']) ?></td>
    </tr>
    </tbody>
</table>

<?php

else:
    echo '<ul>';
    foreach($errors as $error){
        echo '<li>' . $error . '</li>';
    }
    echo '</ul>';

endif;
?>
</body>
</html>