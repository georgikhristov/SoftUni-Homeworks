<?php require ("includes/connect.php"); ?>

<?php if (tep_session_is_registered('signed_in') == true){
    //unset all variables
	tep_session_unregister('username_s');
	tep_session_unregister('signed_in');
	tep_session_unregister('users_id');
    tep_session_destroy();
	}
    ?>
<?php require ("includes/headerForm.php"); ?>
<?php require ("includes/logoutForm.php"); ?>

<?php require "includes/footerForm.php"; ?>