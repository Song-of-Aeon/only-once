if aerial {
	sprite_index = s_jumping;
	image_index = 0;
} else {
	sprite_index = s_me;
	if hspd = 0 {
		image_index = 0;
	}
}
if hput != 0 {
	image_xscale = -hput;
}
image_speed = hspd/15;
draw_self();