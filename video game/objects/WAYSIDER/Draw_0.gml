if aerial {
	sprite_index = s_hooting2;
} else {
	sprite_index = s_greyman;
}
if hspd != 0 {
	image_speed = hspd/10;
	sprite_index = s_hooting;
}