x = window_frame_get_rect()[0]
y = window_frame_get_rect()[1]
x = clamp(x, 0, 1600);
y = clamp(y, 0, 840);
camera_set_view_pos(view_camera[0],x,y);
//camera_set_begin_script(view_camera[0],function() {x = o_view.x; y = o_view.y});