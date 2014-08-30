<?php 
$cat=$_GET['cat'];
$tp=$_GET['tp'];
// tep_session_id()
$topics = mysql_query("SELECT t.topic_name,t.topic_id,t.topic_description,t.topic_date,t.topic_cat_id,u.user_username,c.cat_name,count(p.post_topic_id) as br_com FROM topics as t LEFT JOIN users as u ON(t.topic_user_id = u.users_id) LEFT JOIN categories as c ON(t.topic_cat_id = c.cat_id) lEFT JOIN posts as p ON (p.post_topic_id=t.topic_id) WHERE t.topic_id='".$tp."'");
$topicsArr= mysql_fetch_array($topics, MYSQL_ASSOC);
?>
<div class="col-md-8 col-xs-12 list-style-none">
 <div class="row">
        <div class="categories col-md-12"><?php echo $topicsArr['cat_name'];?></div>
    </div>

            <div class="topic-wrapper clearfix">
                <li class="discovery-post">
                    
                        <header class="discovery-post-header">
                            <h3>
                                <span class="title line-truncate"><a href="#" class="publisher-anchor-color"><?php echo htmlentities($topicsArr['topic_name']);?></a></span>
                            </h3>
                            <ul class="meta meta-info">
                                <li><strong><?php echo $topicsArr['cat_name'];?></strong></li>
                                <li class="comments"><?php echo "Number of comments: ";
									if ($topicsArr['br_com']=='') echo '0'; else echo 	$topicsArr['br_com'];?></li>
                            </ul>
                        </header>
                    <a href="#" class="top-comment" id="top-comment">
                        <img alt="Avatar" data-role="discovery-avatar" src="//a.disquscdn.com/uploads/users/7757/9394/avatar92.jpg?1405907751">
                    </a>
                    <p><span class="line-truncate"><?php echo htmlentities($topicsArr['topic_description']);?></span></p>
                    <hr/>
                    <span>
                        <span class="glyphicon glyphicon-time"></span>
                         <?php echo $topicsArr['topic_date'].' Created by: '. $topicsArr['user_username'];?>
                    </span>
                </li>
            </div>

<form method="post" class="form-horizontal" action="simpleTopicTemplate.php?sid=<?php echo tep_session_id().'&tp='.$tp;?>">
	<fieldset>
<?php 
	if(!tep_session_is_registered('signed_in')){ ?>
		<legend>Add Comment</legend>

        <div class="form-group">
            <label for="name" class="col-lg-2 control-label">Name<sup class="required">*</sup></label>
            <div class="col-lg-10">
                <input type="text" required="" name="name" class="form-control" id="name" placeholder="Your Name">
            </div>
        </div>
        <div class="form-group">
            <label for="email" class="col-lg-2 control-label">Email    </label>
            <div class="col-lg-10">
                <input type="email" name="email" class="form-control" id="email" placeholder="Email">
            </div>
        </div>
<?php } ?>
		<div class="form-group">
            <label for="comment" class="col-lg-2 control-label">Comment<sup class="required">*</sup></label>
            <div class="col-lg-10">
                <textarea name="comment" required="" id="comment" class="form-control" rows="3"></textarea>
            </div>
        </div>
        <div class="form-group">
            <div class="col-lg-10 col-lg-offset-2">
                <button type="submit" class="btn btn-primary">Comment</button>
            </div>
        </div>
    </fieldset>
</form>
<?php $posts = mysql_query("SELECT p.post_id,p.post_content,p.post_date,p.post_topic_id,p.post_user_id,p.post_email_u,p.post_name_u FROM posts  as p  WHERE p.post_topic_id='".$tp."'");
while ($postArr= mysql_fetch_array($posts, MYSQL_ASSOC)){?>	
	
            <div class="topic-wrapper clearfix" id="answer-wrapper">
                <li class="discovery-post">
                    <a href="#" class="publisher-anchor-color">
                        <header class="discovery-post-header">
                            <h3>
                                <span class="title line-truncate"><?php echo 'Created by: '. $postArr['post_name_u'];?></span>
                            </h3>
                        </header>
                    </a>
                    <a href="#" class="top-comment" id="top-comment">
                        <img alt="Avatar" data-role="discovery-avatar" src="//a.disquscdn.com/uploads/users/7757/9394/avatar92.jpg?1405907751">
                    </a>
                    <p><span class="line-truncate"><?php echo htmlentities($postArr['post_content']);?></span></p>
                    <hr/>
                    <span>
                        <span class="glyphicon glyphicon-time"></span>
                        <small><?php echo $postArr['post_date'];?></small>
                    </span>
                </li>
            </div>

<?php } ?>	
</div>