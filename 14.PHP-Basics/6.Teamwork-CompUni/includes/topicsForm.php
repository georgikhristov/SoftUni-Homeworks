<!--Topics-->
<?php
$cat=$_GET['cat'];
if($cat != ''){
$search = "WHERE t.topic_cat_id = '".$cat."' ";
} else $search = '';
$top=$_GET['top'];
$topicsFull =  mysql_query("SELECT count(t.topic_id) as calc,c.cat_name FROM topics as t LEFT JOIN categories as c ON(t.topic_cat_id = c.cat_id)".$search);
$tFullArr = mysql_fetch_array($topicsFull, MYSQL_ASSOC);

$pg=$_GET['pg'];
if($pg == ''){
$pg = 1;
}
$brtSTR=4;
$limit= "LIMIT  ".($pg-1)*$brtSTR.",".( ( ($pg-1)*$brtSTR) + $brtSTR);
$sort = "ORDER BY t.topic_date DESC ";

$topics = mysql_query("SELECT t.topic_name,t.topic_id,t.topic_description,t.topic_date,t.topic_cat_id,u.user_username,c.cat_name FROM topics as t LEFT JOIN 
users as u ON(t.topic_user_id = u.users_id) LEFT JOIN categories as c ON(t.topic_cat_id = c.cat_id)".$search.$sort.$limit);

if (mysql_num_rows($topics)){
$count = $tFullArr['calc']% $brtSTR;

if($count!=0) $count= floor($tFullArr['calc']/ $brtSTR )+ 1;
else $count= floor($tFullArr['calc']/ $brtSTR );

?>
<div class="col-md-8 col-xs-12 list-style-none">
    <div class="row">
        <div class="categories col-md-12"><?php if($cat == '')echo "TOPICS"; else echo $tFullArr['cat_name'] ?>
		<span style="float:right"> Page:  
				<?php for($i=1;$i<=$count;$i++){
					echo '<a href="index.php?sid='.tep_session_id().'&cat='.$cat.'&pg='.$i.'">'.$i.' </a>';
				}
				?>
		</span>			
		</div>
    </div>
    <section class="col-organic discovery-col-0">
        <ul class="discovery-posts col-md-12">
		<?php while($topicsArr= mysql_fetch_array($topics, MYSQL_ASSOC)){?>

            <div class="topic-wrapper clearfix">
                <li class="discovery-post">
                   
                        <header class="discovery-post-header">
                            <h3>
                                <span class="title line-truncate"> 
								<a href="simpleTopicTemplate.php?sid=<?php echo tep_session_id().'&cat='.$topicsArr['topic_cat_id'].'&tp='.$topicsArr['topic_id'];?>" ><?php echo htmlentities($topicsArr['topic_name']);?></a></span>
                            </h3>
                            <ul class="meta meta-info">
                                <li class="comments"><?php echo htmlentities($topicsArr['cat_name']);?></li>
                            </ul>
                        </header>
                    
                    <a href="#" class="top-comment" id="top-comment">
                        <img alt="Avatar" data-role="discovery-avatar" src="//a.disquscdn.com/uploads/users/7757/9394/avatar92.jpg?1405907751">
                    </a>
                        <p><span class="line-truncate"><?php echo htmlentities($topicsArr['topic_description']);?></span></p>
                    <hr/>
                    <span>
                        <span class="glyphicon glyphicon-time"></span>
                         <?php echo $topicsArr['topic_date']." Created by: ".$topicsArr['user_username'];?>
                    </span>
                </li>
            </div>
		<?php } ?>
        </ul>

</div>
<?php }else { ?>
 <p>
        <h4>
           There are no topics in this category!
        </h4>
</p>

<?php } ?>