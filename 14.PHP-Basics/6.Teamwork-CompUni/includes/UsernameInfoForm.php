<?php $information = mysql_query("SELECT * FROM users where user_username ='".$_SESSION['username_s']."'");
$info= mysql_fetch_array($information, MYSQL_ASSOC);
?>


<div class="modal-content user-profile-panel col-md-6">
    <div class="modal-header">
        <h4 class="modal-title">
            <?= 'More About: '.htmlentities($info['user_username']);?>
        </h4>
    </div>
    <div class="modal-body">
        <center>
            <img src="images/defaultAvatar.png" width="140"  class="img-circle" border="0" height="140" alt="avatar"/>

            <h3 class="media-heading">
                <?= htmlentities($info['users_firstname']).' ' . htmlentities($info['users_lastname']);?>
            </h3>

            <span>
                <strong>Gender:</strong>
            </span>
            <span class="label label-warning">
                <?= htmlentities($info['users_gender']);?>
            </span>
            <br/>
            <span>
                <strong>
                    Town:
                </strong>
            </span>
            <span class="label label-info">
                <?= htmlentities($info['user_town']);?>
            </span>
            <br/>
            <span>
                <strong>Email:</strong>
            </span>

            <span class="label label-success">
                <?= htmlentities($info['users_email_address']);?>
            </span>

            <hr/>

            <center>
                <p class="text-left">
                    <strong>Description:</strong>
                    <br/>
                    <?= htmlentities($info['user_description']);?>
                </p>
            </center>

        </center>
    </div>
</div>
