
<?php
$server	    = 'localhost';
$user_name	= 'okiana1';
$password	= 'Sq3*%Qfi#';
$database	= 'okiana1_wp469';
if(!mysql_connect($server, $user_name, $password))
{
 	exit('Error: could not establish database connection');
}
if(!mysql_select_db($database))
{
 	exit('Error: could not select the database');
}
mysql_pconnect($server, $user_name, $password);
define('FORUM_SESSIONS', 'mysql');
require ("includes/sessions.php");
 tep_session_name('sid');
if (isset($_POST[tep_session_name()]))  tep_session_id($_POST[tep_session_name()]);
// start the session
if (!tep_session_id()){
   tep_session_start();
   $session_started = true;
   tep_session_register('session_started');
  }

?>
