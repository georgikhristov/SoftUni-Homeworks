<?php

require ("includes/connect.php");
if (!tep_session_is_registered('signed_in')) {
$userName=$_POST['userName'];
$password=$_POST['password'];
$result = mysql_query("SELECT distinct * FROM users where user_username ='".$userName."' and users_password='".md5($password)."'");
if (mysql_num_rows($result)){
$account= mysql_fetch_array($result, MYSQL_ASSOC);

    if (!tep_session_is_registered('users_id')) {
      $users_id =$account['users_id'];
      tep_session_register('users_id');
    }
    if (!tep_session_is_registered('username_s')) {
      $username_s =$account['user_username'];
      tep_session_register('username_s');
    }
	    if (!tep_session_is_registered('signed_in')) {
      $signed_in =true;
      tep_session_register('signed_in');
    }
}
require("includes/headerForm.php");
require("includes/loginForm.php");

}
if(($userName != $account['user_username'] )&&($password != $account['users_password'])){
?>
 <p>
        <h4>
            <?= 'Wrong username or password!';?>
        </h4>
    </p>
<?php
}
require("includes/footerForm.php");