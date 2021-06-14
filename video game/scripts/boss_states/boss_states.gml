// Script assets have changed for v2.3.0 see
// https://help.yoyogames.com/hc/en-us/articles/360005277377 for more information
function st_shootyou() {
	count++;
	if count % 60 = 0 {
		with instance_create_layer(x, y-sprite_height/2, 0, o_bullet) {
			speed = 11;
			direction = point_direction(x, y-sprite_height/2, global.me.x, global.me.y-global.me.sprite_height/2);
		}
	}
	image_index = floor(((count+30)%60)/8);
}
function st_laseryou() {
	count++;
	if count % 300 = 0 {
		instance_create_layer(x, y-sprite_height/2, 0, o_laser)
	}
	image_index = floor(((count+150)%300)/8);
}