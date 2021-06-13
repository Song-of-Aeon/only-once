// Script assets have changed for v2.3.0 see
// https://help.yoyogames.com/hc/en-us/articles/360005277377 for more information
function c_input() {
	jump = keyboard_check(vk_up) + keyboard_check(ord("I"));
	attack = keyboard_check(vk_down) + keyboard_check(ord("K"));
	left = keyboard_check(vk_left) + keyboard_check(ord("J"));
	right = keyboard_check(vk_right) + keyboard_check(ord("L"));
}