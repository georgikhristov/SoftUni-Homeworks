<form method="post" class="form-horizontal" action="createCategory.php?sid=<?php echo tep_session_id();?>">
        <fieldset>
            <legend>Create Category</legend>
            <div class="form-group">
                <label for="categoryName" class="col-lg-2 control-label">Category Name<sup class="required"/></label>
                <div class="col-lg-10">
                    <input type="text" required="" name="categoryName" class="form-control" id="categoryName" placeholder="Category Name">
                </div>
            </div>
            <div class="form-group">
                <label for="textArea" class="col-lg-2 control-label">Description</label>
                <div class="col-lg-10">
                    <textarea class="form-control" name="categoryDescription" rows="3" id="textArea">

                    </textarea>
                    <span class="help-block">Describe your category </span>
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