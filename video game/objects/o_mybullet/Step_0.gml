x += hspd;
y += vspd;
if x < 0 || x > 1920 || y < 0 || y > 1080 {
	instance_destroy();
}