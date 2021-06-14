x = o_solid2.x;
y = o_solid2.y;
script_execute(state);
if place_meeting(x, y, o_mybullet) {
	hp--;
}