window_frame_update();
if (window_frame_is_ready && !was_ready) {
    was_ready = true;
    window_command_hook(window_command_close);
    window_frame_set_min_size(640, 480);
	window_frame_set_max_size(640, 480);
	window_command_set_active(window_command_maximize, false);
	window_command_set_active(window_command_resize, false);
}
if (window_command_check(window_command_close)) {
    leaving = 1;
}
if count > 5 {
	window_set_position(0,0);	
}
count++;