<?php if(!tep_session_is_registered('signed_in')) {

?>
<form method="post" class="form-horizontal" action="login.php">
    <fieldset>
        <legend>Login</legend>

        <div class="form-group">
            <label for="inputEmail" class="col-lg-2 control-label">User Name</label>
            <div class="col-lg-10">
                <input type="text" required="" name="userName" class="form-control" id="inputEmail" placeholder="User Name">
            </div>
        </div>
        <div class="form-group">
            <label for="inputPass" class="col-lg-2 control-label">Password</label>
            <div class="col-lg-10">
                <input type="password" required="" name="password" class="form-control" id="inputPass" placeholder="Password">
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
}
else{
require("includes/categoriesForm.php");
require("includes/topicsForm.php");
}
?>