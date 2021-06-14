draw_set_font(fnt_window_frame_test);
draw_set_color(c_white);
var s;
if (leaving > 0) {
    s = "sayounara asswipe";
    if (--leaving <= 0) game_end();
} else s = "youre in tha upper left asswipe"
draw_text(5, 5, s);
draw_circle(mouse_x, mouse_y, 10, true);