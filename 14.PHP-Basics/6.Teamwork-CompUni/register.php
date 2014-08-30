<?php
require ("includes/connect.php");
require("includes/headerForm.php");
$check = true;
$fName=$_POST['fName'];
if($fName =='') $check=false;
$lName=$_POST['lName'];
if($lName=='') $check=false;
$gender=$_POST['gender'];
if($gender=='') $check=false;
$town=$_POST['town'];
if($town=='') $check=false;
$userName=$_POST['userName'];
if($userName=='') $check=false; 
$email=$_POST['email'];
if($email=='') $check=false;
$password=$_POST['password'];
if($password=='') $check=false;
$confirmPassword=$_POST['confirmPassword'];
$description=$_POST['description'];
if ($password != $confirmPassword) $check=false; 
if($check){
$result = mysql_query("INSERT INTO users (users_gender, users_firstname, users_lastname, user_username, user_town, user_description, users_email_address, user_image, users_password) VALUES ('".$gender. "','".$fName. "','".$lName. "','".$userName. "','".$town. "','".$description. "','".$email. "','".$_FILES["picture"]["name"]. "','".md5($password). "')");
if (!$result) {
    die('Invalid query: ' . mysql_error());
}

  if (!tep_session_is_registered('register_s')) {
     $register_s=true;
      tep_session_register('register_s');
    }
}
require("includes/registerForm.php");
require("includes/footerForm.php");


