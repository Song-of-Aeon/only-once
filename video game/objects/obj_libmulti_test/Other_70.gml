/// @description An example of handling libmulti events.

var _ev_type;

// just in case it's undefined, it will turn into a string "<undefined>"
// which will be an unknown event.
_ev_type = string(ds_map_find_value(async_load, "event_type"));
libmulti_set_caption(0, "can't grab me!");
