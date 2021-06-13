// Script assets have changed for v2.3.0 see
// https://help.yoyogames.com/hc/en-us/articles/360005277377 for more information
function st_standard(){
	hput = left - right;
	
	hspd = -hput*5;
	
	if !place_meeting(x, y+1, o_solid) {
	    vspd += .2;
	    aerial = true;
	} else { //.gravity
	    aerial = false;
	    y = floor(y);
	    vspd = 0;
	}
	if jump && !aerial {
		vspd = -7;
	}
	c_basiccollision() //same script file scroll down
	x += hspd;
	y += vspd;
	if attack {
		instance_create_layer(x, y, 1, o_bullet);
	}
	
}

function c_basiccollision() {

	if place_meeting(x + hspd, y, o_solid) {
	    var i = 0;
	    while !place_meeting(x + sign(hspd), y, o_solid) {
	        x += sign(hspd);
	        i++;
	        if i > sprite_width {
	            break;
	        }
	    }
	    hspd = 0;
	}

	if place_meeting(x, y + vspd, o_solid) {
	    while !place_meeting(x, y + sign(vspd), o_solid) {
	        y += sign(vspd);
	    }
	    vspd = 0;
		aerial = false
	} //aerial = true
}