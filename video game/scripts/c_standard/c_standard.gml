// Script assets have changed for v2.3.0 see
// https://help.yoyogames.com/hc/en-us/articles/360005277377 for more information
function c_standard(){
	var hput = left - right;
	var vput = up - down;
	
	hspd = hput*5;
	if jump {
		vspd = -7;
	}
	c_basiccollision() //im just takin this bitch from firegame
	x += hspd;
	y += vspd;
	
	
}