if aerial && !animating {
	sprite_index = s_jumping;
	image_index = 0;
} else if !animating {
	sprite_index = s_me;
	if hspd = 0 {
		image_index = 0;
	}
}
if hput != 0 {
	image_xscale = -hput;
}
if !animating {
	image_speed = hspd/15;
}
draw_self();