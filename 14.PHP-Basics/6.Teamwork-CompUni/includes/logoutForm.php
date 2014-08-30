<h2>Logout</h2>

<?php if (!tep_session_is_registered('signed_in') == true){
    ?>
    <p>
        <h4>
            <?= 'Succesfully signed out, thank you for visiting.  <br> Would you like to <a href="login.php"> sign in</a>?';?>
        </h4>
    </p>
    <?php } ?>

	
	