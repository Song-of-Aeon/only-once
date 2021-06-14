if image_index = 6 {
	image_speed = 0;
	bye = true;
}
if bye {
	image_alpha -= .1;
	if image_alpha <= 1 {
		instance_destroy();
	}
}