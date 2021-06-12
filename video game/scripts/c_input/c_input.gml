// Script assets have changed for v2.3.0 see
// https://help.yoyogames.com/hc/en-us/articles/360005277377 for more information
function c_input() {
	jump = keyboard_check_pressed(ord("S")) + keyboard_check_pressed(ord("Z"));
	attack = keyboard_check_pressed(ord("A")) + keyboard_check_pressed(ord("X"));
	up = keyboard_check_pressed(vk_up) + keyboard_check_pressed(ord("I"));
	down = keyboard_check_pressed(vk_down) + keyboard_check_pressed(ord("K"));
	left = keyboard_check_pressed(vk_left) + keyboard_check_pressed(ord("J"));
	right = keyboard_check_pressed(vk_right) + keyboard_check_pressed(ord("L"));
}