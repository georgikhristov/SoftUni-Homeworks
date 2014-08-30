<?php if (!tep_session_is_registered('register_s')) { ?>
<form method="post" class="form-horizontal" action="register.php?sid=<?php echo tep_session_id();?>">
    <fieldset>
        <legend>Register</legend>
        <div class="form-group">
            <label for="firstFName" class="col-lg-2 control-label">First Name<sup class="required">*</sup></label>
            <div class="col-lg-10">
                <input type="text" required="" name="fName" class="form-control" id="firstFName" placeholder="First Name">
            </div>
        </div>
        <div class="form-group">
            <label for="inputLName" class="col-lg-2 control-label">Last Name<sup class="required">*</sup></label>
            <div class="col-lg-10">
                <input type="text" required="" name="lName" class="form-control" id="inputLName" placeholder="Last Name">
            </div>
        </div>
        <div class="form-group">
            <label class="col-lg-2 control-label">Gender<sup class="required">*</sup></label>
            <div class="col-lg-10">
                <div class="radio">
                    <label>
                        <input type="radio" name="gender" id="optionsRadios1" value="Male" checked="">
                        Male
                    </label>
                </div>
                <div class="radio">
                    <label>
                        <input type="radio" name="gender" id="optionsRadios2" value="Female">
                        Female
                    </label>
                </div>
            </div>
        </div>
        <div class="form-group">
            <label for="inputTown" class="col-lg-2 control-label">Town<sup class="required">*</sup></label>
            <div class="col-lg-10">
                <input type="text" name="town" required="" class="form-control" id="inputTown" placeholder="Town">
            </div>
        </div>
        <div class="form-group">
            <label for="inputUserName" class="col-lg-2 control-label">User Name<sup class="required">*</sup></label>
            <div class="col-lg-10">
                <input type="text" name="userName" required="" class="form-control" id="inputUserName" placeholder="User Name">
            </div>
        </div>

        <div class="form-group">
            <label for="inputEmail" class="col-lg-2 control-label">Email<sup class="required">*</sup></label>
            <div class="col-lg-10">
                <input type="email" name="email" required="" class="form-control" id="inputEmail" placeholder="Email">
            </div>
        </div>
        <div class="form-group">
            <label for="inputPass" class="col-lg-2 control-label">Password<sup class="required">*</sup></label>
            <div class="col-lg-10">
                <input type="password" name="password" required="" class="form-control" id="inputPass" placeholder="Password">
            </div>
        </div>
        <div class="form-group">
            <label for="inputConfPass" class="col-lg-2 control-label">Confirm Password<sup class="required">*</sup></label>
            <div class="col-lg-10">
                <input type="password" name="confirmPassword" required="" class="form-control" id="inputConfPass" placeholder="Confirm Password">
            </div>
        </div>
		 <div class="form-group">
            <label for="textArea" class="col-lg-2 control-label">User Picture</label>
            <div class="col-lg-10">
                Select a file:<input type="file" name="picture">
            </div>
        </div>
		<div class="form-group">
            <label for="textArea" class="col-lg-2 control-label">Description</label>
            <div class="col-lg-10">
                <textarea class="form-control" name="description" rows="3" id="textArea"></textarea>
                <span class="help-block">Describe yourself - personal skills, hobbies, things you like to do. </span>
            </div>
        </div>

        <div class="form-group">
            <div class="col-lg-10 col-lg-offset-2">
                <button type="reset" class="btn btn-default">Reset</button>
                <button type="submit" class="btn btn-primary">Submit</button>
            </div>
        </div>
    </fieldset>
</form>
<?php 
} else { ?>

            <h4>Congratulations! Your registration is sucsessfull. Please <a href="http://okiana.softuni-friends.org/php_teamwork/trunk/login.php?sid="<?php tep_session_id()?> > sign in!</a></h4>

<?php
 }
?>
