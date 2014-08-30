<?php
require('includes/connect.php');
require('includes/headerForm.php');
$tryPost=true;
if(tep_session_is_registered('signed_in')) {
$name = tep_session_value('username_s'); 
$user_id = tep_session_value('users_id');

} else {
$name=$_POST['name'];
if($name=='') $tryPost=false;
$email=$_POST['email'];
$user_id='';
}
$tp=$_GET['tp'];
$comment=$_POST['comment'];
if($comment=='') $tryPost=false;

if($tryPost){
$insertPost = mysql_query("INSERT INTO posts (post_content, post_topic_id, post_user_id,post_email_u,post_name_u,post_date) VALUES ('".$comment. "','".$tp. "','".$user_id."','".$email."','".$name."',now())");
}




require("includes/categoriesForm.php");
require('includes/simpleTopicForm.php');
require('includes/footerForm.php');