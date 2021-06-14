function st_shootyou() {
	image_index = (count/20%2);
	count++;
	if count % 20 = 0 && count >= 80 {
		with instance_create_layer(x, y-sprite_height/2, 0, o_bullet) {
			speed = 11;
			direction = point_direction(x, y, global.me.x, global.me.y-global.me.sprite_height/2) + random(20*(other.count/80))-10*(other.count/80);
		}
		
		if count >= 120 {
			count = 0;
			iteration++;
		}
	}
	if count > 80 || image_index > 2 {
		image_index = floor(((count+10)%20)/3.3);
	}
	if iteration > 5 {
		next();
	}
}
function st_shootbig() {
	image_index = (count/20%2);
	count++;
	if count%115 = 10 {
		for (var i=0; i<7; i++) {
			with instance_create_layer(x, y-sprite_height/2, 0, o_bullet) {
				speed = 11;
				direction = i*20-225+other.count%230/10;
			}
			
		}
		iteration++;
		
	}
	if count%115 > 85 {
		image_index = floor(((count)%20)/3.3);
	}
	if iteration > 8 {
		next();
	}
	
}
function st_laseryou() {
	//visibly charge up
	//shoot
	count++;
	if count % 300 = 0 {
		instance_create_layer(x, y-sprite_height/2, 0, o_laser);
		iteration++;
	}
	image_index = floor(((count+150)%300)/8);
	if iteration > 3 {
		next();
	}
}
function st_loading() {
	count++;
	if count >= 200 {
		state = attacks[irandom(array_length(attacks)-1)];
	}
}

function next() {
	iteration = 0;
	count = 0;
	state = st_loading;
}