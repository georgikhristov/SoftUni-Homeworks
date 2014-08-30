<form method="post" class="form-horizontal" action="createTopic.php?sid=<?php echo tep_session_id();?>">
    <fieldset>
        <legend>Create Topic</legend>
        <div class="form-group">
            <label for="topicName" class="col-lg-2 control-label">Topic Name<sup class="required"/></label>
            <div class="col-lg-10">
                <input type="text" required="" name="topicName" class="form-control" id="topicName" placeholder="Topic Name">
            </div>
        </div>
		<?php
$category = mysql_query("SELECT cat_name,cat_id FROM categories  ORDER  BY cat_name DESC");
if (mysql_num_rows($category)){
?>
		<div class="form-group">
            <label for="select" class="col-lg-2 control-label">Topic category</label>
            <div class="col-lg-10">
               <select id="select" class="form-control" name="catTopic">
				<?php while($categories = mysql_fetch_array($category, MYSQL_ASSOC)){?>
					<option value="<?php echo $categories['cat_id'];?>"><?php echo htmlentities($categories['cat_name']);?></option>
				<?php } ?>
			   </select>
            </div>
        </div>
<?php } ?>

        <div class="form-group">
            <label for="description" class="col-lg-2 control-label">Description</label>
            <div class="col-lg-10">
                <textarea class="form-control" name="topicDescription" rows="3" id="description"></textarea>
                <span class="help-block">Write your topic </span>
            </div>
        </div>
        <div class="form-group">
            <label for="topicTag" class="col-lg-2 control-label">Enter topic tags<sup class="required"/></label>
            <div class="col-lg-10">
                <input type="text" required="" name="topicTag" class="form-control" id="topicTag" placeholder="Topic Tags">
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
