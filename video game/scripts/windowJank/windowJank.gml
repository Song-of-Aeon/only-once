// Script assets have changed for v2.3.0 see
// https://help.yoyogames.com/hc/en-us/articles/360005277377 for more information
function MakeSecondWindow(){
	/// @description New window

var _defw, _defh;

// change this to your liking?
_defw = 800;
_defh = 600;

var n;

global.window = libmulti_create_window(
    -1, -1, // we don't care about x,y
    _defw, _defh, // width height
    0x80000000, -1, -1, // style|extended style|sw_show we don't care
    320, 240, // min width min height, something regular
    -1, -1 // max width max height, we don't care
);
libmulti_set_x(global.window,200);

ds_list_add(windows, global.window);
ds_list_add(buffers, buffer_create(_defw * _defh * 4, buffer_fixed, 1));
ds_list_add(inputs, "");

n = 10 + irandom(10);
//libmulti_set_caption(_w, "libmulti window, you're just as cool as " + string(n) + " cats.");
libmulti_set_window_style()
}