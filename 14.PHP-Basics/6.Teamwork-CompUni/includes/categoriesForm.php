<!--Categories-->
<?php
$category = mysql_query(" SELECT c.cat_name,c.cat_description,c.cat_date_create,u.user_username,c.cat_id FROM categories as c LEFT JOIN users as u ON(c.cat_user_id = u.users_id) ORDER  BY cat_date_create DESC");
if (mysql_num_rows($category)){

?>
<div class="col-md-3 col-xs-12 pull-right">
    <div class="row">
        <div class="categories">Categories<a href="index.php?sid=<?php echo tep_session_id();?>" style="float:right">All</a></div>
    </div>
    <div class="row">
        <ul>
		<?php while($categories = mysql_fetch_array($category, MYSQL_ASSOC)){?>
            <li>
                <a href="index.php?sid=<?php echo tep_session_id().'&cat='.$categories['cat_id'];?>"><?php echo htmlentities($categories['cat_name']);  
				// $categories['cat_id']?></a>
                <div class="category-description"><?php echo htmlentities($categories['cat_description']).'<br>  Created on: '.$categories['cat_date_create'].'<br> Created by: '.$categories['user_username'];?></div>
            </li>
           <?php } ?>
        </ul>
    </div>
</div>

<?php }else {?>
<div class="col-md-3 col-xs-12 pull-right">
    <div class="row">
        <div class="categories">Categories</div>
    </div>
    <div class="row">
        <ul>
            <li>
                <a href="#"><?php echo "We don't have categories yet!";  
				// $categories['cat_id']?></a>
                <div class="category-description"> </div>
            </li>
        </ul>
    </div>
</div>
<?php } ?>
