window_frame_update();
if (window_frame_is_ready && !was_ready) {
    was_ready = true;
    window_command_hook(window_command_close);
    window_frame_set_min_size(224, 192); // how small the window can be allowed to get
}
if (window_command_check(window_command_close)) {
    leaving = 1;
}
if (window_frame_get_visible()) {
    var w = window_frame_get_width();
    var h = window_frame_get_height();
    if (w > 0 && h > 0 && surface_exists(application_surface)
    && (window_get_width() != w || window_get_height() != h)
    ) {
        room_width = w; room_height = h;
        window_frame_set_region(0, 0, w, h);
        surface_resize(application_surface, w, h);
    }
}
if count > 5 {
window_set_position(0,0);	
}count++;