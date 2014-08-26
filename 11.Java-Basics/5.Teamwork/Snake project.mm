<map version="1.0.1">
<!-- To view this file, download free mind mapping software FreeMind from http://freemind.sourceforge.net -->
<node COLOR="#000000" CREATED="1400328370806" ID="ID_459445807" MODIFIED="1400330864985" STYLE="bubble" TEXT="Snake project">
<edge COLOR="#808080" STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="20"/>
<hook NAME="accessories/plugins/AutomaticLayout.properties"/>
<node COLOR="#0033ff" CREATED="1400328407672" ID="ID_1113850247" MODIFIED="1400330864921" POSITION="right" TEXT="Interface">
<edge STYLE="sharp_bezier" WIDTH="8"/>
<font NAME="SansSerif" SIZE="18"/>
<node COLOR="#00b439" CREATED="1400328608958" ID="ID_587070558" MODIFIED="1400330864926" TEXT="Render grid in console">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
</node>
<node COLOR="#00b439" CREATED="1400328620222" ID="ID_1605797900" MODIFIED="1400330864927" STYLE="bubble" TEXT="Controller input">
<edge COLOR="#808080" STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
<node COLOR="#990000" CREATED="1400328949171" ID="ID_374255124" MODIFIED="1400330864929" TEXT="Wait for input up until snake movement">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1400329185916" ID="ID_1353475548" MODIFIED="1400330864936" TEXT="Pass last input (possibly to global var to be available to all methods/classes at the time of movement)">
<font NAME="SansSerif" SIZE="14"/>
</node>
</node>
</node>
<node COLOR="#0033ff" CREATED="1400328418530" ID="ID_76588197" MODIFIED="1400330864943" POSITION="right" TEXT="Engine">
<edge STYLE="sharp_bezier" WIDTH="8"/>
<font NAME="SansSerif" SIZE="18"/>
<node COLOR="#00b439" CREATED="1400328503934" ID="ID_1782891389" MODIFIED="1400330864948" TEXT="Game grid creation (2d array to hold all objects numerically)">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
<node COLOR="#990000" CREATED="1400330725474" ID="ID_287480316" MODIFIED="1400330864949" TEXT="Grid is constantly in memory until end of game or level">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1400330750338" ID="ID_1818291436" MODIFIED="1400331059646" TEXT="Each x, y element holds the value of object that is there, e.g.:&#xa;0 - empty space&#xa;1 - solid object&#xa;2 - element of the snake&#xa;etc.">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1400331095072" ID="ID_615887243" MODIFIED="1400331134260" TEXT="Grid initializes with all values = 0 (empty space) and is populated by other methods at game/level start">
<font NAME="SansSerif" SIZE="14"/>
</node>
</node>
<node COLOR="#00b439" CREATED="1400328551455" ID="ID_443452861" MODIFIED="1400330864954" TEXT="Eatable objects">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
<node COLOR="#990000" CREATED="1400328886996" ID="ID_451313148" MODIFIED="1400330864955" TEXT="Snake-growing objects">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1400328894814" ID="ID_783095587" MODIFIED="1400331718884" TEXT="Bonus objects (points only) - these can be available together with &quot;snake-growers&quot; for a limited time (e.g. 5, 10, etc. seconds)">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1400329300042" ID="ID_71161611" MODIFIED="1400330864957" TEXT="Remove objects once Snake passes through them and generate next one">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1400329273529" ID="ID_1035951534" MODIFIED="1400330864958" TEXT="Random-generate position only after last object is &quot;eaten&quot;">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1400329332666" ID="ID_138417786" MODIFIED="1400330864959" TEXT="Generate only on empty space (no snake or solid objects on that grid space)">
<font NAME="SansSerif" SIZE="14"/>
</node>
</node>
<node COLOR="#00b439" CREATED="1400328562353" ID="ID_1233714476" MODIFIED="1400330864960" TEXT="Crashing mechanism">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
<node COLOR="#990000" CREATED="1400328569118" ID="ID_663037926" MODIFIED="1400330864960" TEXT="Walls (end of screen)">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1400328575632" ID="ID_1181599176" MODIFIED="1400330864961" TEXT="In-level solid objects (in level-play mode)">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1400328585686" ID="ID_417561210" MODIFIED="1400330864962" TEXT="Snake itself">
<font NAME="SansSerif" SIZE="14"/>
</node>
</node>
<node COLOR="#00b439" CREATED="1400328633963" ID="ID_640530995" MODIFIED="1400330864964" TEXT="Snake movement">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
<node COLOR="#990000" CREATED="1400329418530" ID="ID_413702712" MODIFIED="1400330864964" TEXT="Initial movement (pre-defined snake length and direction of travel)">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1400328687274" ID="ID_1800422095" MODIFIED="1400330864965" TEXT="Read last controller input">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1400328696507" ID="ID_286910457" MODIFIED="1400330864966" TEXT="If no input remember snake travel direction for next frame">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1400328762856" ID="ID_647761247" MODIFIED="1400330864966" TEXT="Remember snake position in 2d grid (all snake elements)">
<font NAME="SansSerif" SIZE="14"/>
</node>
</node>
</node>
<node COLOR="#0033ff" CREATED="1400329533883" ID="ID_432133694" MODIFIED="1400330864970" POSITION="right" TEXT="Levels design">
<edge STYLE="sharp_bezier" WIDTH="8"/>
<font NAME="SansSerif" SIZE="18"/>
<node COLOR="#00b439" CREATED="1400329564777" ID="ID_603618951" MODIFIED="1400330864972" TEXT="Could offer either continuous play (no obstacles) or level-play (with obstacles)">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
</node>
<node COLOR="#00b439" CREATED="1400329609120" ID="ID_1685317034" MODIFIED="1400330864978" TEXT="Levels can be stored either in text file (easy modification) or hardcoded in a class/method">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
</node>
</node>
<node COLOR="#0033ff" CREATED="1400329545756" ID="ID_1662853415" MODIFIED="1400330864985" POSITION="right" TEXT="Possible multiplayer (if enough time)">
<edge STYLE="sharp_bezier" WIDTH="8"/>
<font NAME="SansSerif" SIZE="18"/>
</node>
</node>
</map>
