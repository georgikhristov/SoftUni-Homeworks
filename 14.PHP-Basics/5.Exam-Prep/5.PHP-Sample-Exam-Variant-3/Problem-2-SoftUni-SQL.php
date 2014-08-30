<?php
//$commands = [
//    "UPDAtE users SET (age = 30) WHERE (user_id = 1)",
//    "INSERT INTO users (login, age, gender) VALUES (yana, 20, female)",
//    "UPDATE users SET (age = 30) WHERE (user_id = 1)",
//    "INSERT INTO users (login, age) VALUES (yana, 20, female)",
//    "INSERT INTO users (login, age, gender) VALUES (yana, 20, female)",
//    "INSERT INTO users (user_id, login, gender) VALUES (12, yana, female)",
//    "INSERT INTO users (login, age, gender) VALUES (yana, 20, female)",
//    "INSrRT INTO users (login, age, gender) VALUES (yana, 20, female)",
//    "UPDATE users SET (age = 30) WHERE (user_id = 1)",
//    "UPDATE users SET (age = 30) WHERE (age = undefined)",
//    "DELETE FROM users WHERE (age = 30)"];
$commands = $_GET['commands'];

$errorCount = 0;
$users = [];

foreach ($commands as $command) {
    switch (substr($command, 0, 6)) {
        case "INSERT":
            insertEntry($command);
            break;
        case "UPDATE":
            updateEntry($command);
            break;
        case "DELETE":
            deleteEntry($command);
            break;
        default:
            $errorCount++;
            break;

    }
}

if(empty($users)){
    echo 'You have '.$errorCount.' error/s';
} else{
    echo '<table>';
    echo '<thead><tr><th>user_id</th><th>login</th><th>gender</th><th>age</th></tr></thead>';
    echo '<tbody>';
    foreach($users as $id => $user){
        echo '<tr>';
        echo '<td>'. $id .'</td>';
        foreach($user as $key=>$value){
            echo '<td>'. $value .'</td>';
        }
        echo '</tr>';
    }
    echo '</tbody>';
    echo '<tfoot><tr><td colspan="4">Errors='.$errorCount.'</td></tr></tfoot>';
    echo '</table>';
}

function insertEntry($command)
{
    global $errorCount;
    global $users;
    preg_match_all('/\((.*?)\)/', $command, $matches);
    $groups = $matches[1];
    $fields = explode(", ", $groups[0]);
    $values = explode(", ", $groups[1]);

    if (count($fields) != count($values)) {
        $errorCount++;
    } elseif (!in_array('login', $fields)) {
        $errorCount++;
    } else {
        $insertInfo = array_combine($fields, $values);
        if(!in_array('age', $fields)){
            $insertInfo['age'] = 'undefined';
        }
        if(!in_array('gender', $fields)){
            $insertInfo['gender'] = 'undefined';
        }
        krsort($insertInfo);
        if (!in_array('user_id', $fields)){
            $users[] = $insertInfo;
        } else {
            $tempId = $insertInfo['user_id'];
            unset($insertInfo['user_id']);
            $users[$tempId] = $insertInfo;
        }

    }
}

function updateEntry($command)
{
    global $errorCount;
    global $users;

    $existingKeys = ['login', 'gender', 'age'];
    preg_match_all('/\((.*?)\)/', $command, $matches);
    $groups = $matches[1];

    $fields = preg_split('/\s*=\s*/', $groups[0], -1, PREG_SPLIT_NO_EMPTY);
    $fieldKey = $fields[0];
    $fieldValue = $fields[1];
    $fieldKeyExists = in_array($fieldKey, $existingKeys);

    $conditions = preg_split('/\s*=\s*/', $groups[1], -1, PREG_SPLIT_NO_EMPTY);
    $conditionKey = $conditions[0];
    $conditionValue = $conditions[1];
    $conditionKeyExists = in_array($conditionKey, $existingKeys);

    if ($conditionKey == 'user_id') {
        if (array_key_exists($conditionValue, $users) && $fieldKeyExists) {
            $users[$conditionValue][$fieldKey] = $fieldValue;
        } else{
            if($fieldKey == 'user_id'){
                $users[$fieldValue] = $users[$conditionValue];
                unset($users[$fieldValue]);
            } else{
                $errorCount++;
            }
        }
    } elseif($conditionKeyExists && $fieldKeyExists){
        $hasError = true;
        foreach($users as $key => $user){
            //if (in_array($conditionValue, $user)){
            if($user[$conditionKey] == $conditionValue){
                $users[$key][$fieldKey] = $fieldValue;
                $hasError = false;
            }
        }
        if($hasError){
            $errorCount++;
        }
    } else {
        $hasError = true;
        if($fieldKey == 'user_id'){
            foreach($users as $id => $user){
                if($user[$conditionKey] == $conditionValue){
                    $users[$fieldValue] = $user;
                    unset($users[$id]);
                    $hasError = false;
                }
            }
            if($hasError){
                $errorCount++;
            }
        } else{
            $errorCount++;
        }
    }
}

function deleteEntry($command)
{
    global $errorCount;
    global $users;
    preg_match_all('/\((.*?)\)/', $command, $matches);
    $groups = $matches[1];

    $conditions = preg_split('/\s*=\s*/', $groups[0], -1, PREG_SPLIT_NO_EMPTY);
    $conditionKey = $conditions[0];
    $conditionValue = $conditions[1];

    if($conditionKey == 'login'){
        $errorCount++;
    } elseif($conditionKey == 'user_id'){
        unset($users[$conditionValue]);
    } elseif($conditionKey == 'gender' || $conditionKey == 'age'){
        foreach($users as $id => $user){
            if($conditionValue == $user[$conditionKey]){
                unset($users[$id]);
            }
        }
    } else{
        $errorCount++;
    }
}
