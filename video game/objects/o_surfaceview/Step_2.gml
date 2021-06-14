x = libmulti_get_x(0);
y = libmulti_get_y(0);
x = clamp(x, 0, 1600);
y = clamp(y, 0, 840);
camera_set_view_pos(view_camera[1],x,y);
camera_set_view_pos(view_camera[1],x,y);