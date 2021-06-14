if image_index = 6 {
	image_speed = 0;
	bye = true;
	image_index = 3;
}
if bye {
	image_alpha -= .1;
	if image_alpha <= 1 {
		instance_destroy();
	}
}