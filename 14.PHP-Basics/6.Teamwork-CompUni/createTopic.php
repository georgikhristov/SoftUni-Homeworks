<?php
require ("includes/connect.php");
require("includes/headerForm.php");

$tryTopic=true;
$topicName = $_POST['topicName'];
if($topicName=='') $tryTopic=false;
$topicDescription = $_POST['topicDescription'];
if($topicDescription=='') $tryTopic=false;
$topicTag = $_POST['topicTag'];
if($topicTag=='') $tryTopic=false;
$catTopic=$_POST['catTopic'];
if($tryTopic){
$resultTopic = mysql_query("INSERT INTO topics (topic_name, topic_description, topic_tag,topic_cat_id,topic_user_id,topic_date) VALUES ('".$topicName. "','".$topicDescription. "','".$topicTag."','".$catTopic."','".tep_session_value('users_id')."',now())");
}

require("includes/createTopicsForm.php");
require("includes/footerForm.php");