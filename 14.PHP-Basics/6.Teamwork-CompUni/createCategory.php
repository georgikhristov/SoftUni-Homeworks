<?php
require ("includes/connect.php");
require("includes/headerForm.php");


$tryCategory=true;
$categoryName = $_POST['categoryName'];
if($categoryName=='') $tryCategory=false;
$categoryDescription = $_POST['categoryDescription'];
if($categoryDescription=='') $tryCategory=false;
if($tryCategory){
	$resultCategory = mysql_query("INSERT INTO categories (cat_name, cat_description,cat_date_create,cat_user_id) VALUES ('".$categoryName. "','".$categoryDescription. "',now(),'".tep_session_value('users_id'). "')" );
}

require("includes/createCategoriesForm.php");
require("includes/footerForm.php");