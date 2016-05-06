function framesToTime(fs as integer) as string
	'Frames per seconds, depending on system setup (PAL = 50, NTSC = 60):
	dim fps as integer = 50

	'Set up local variables
	dim hh as integer
	dim mm as integer
	dim ss as integer
	dim ff as integer
	'Convert frames to time:
	hh = (fs / 60 / 60 / fps)
	mm = ((fs - hh * 60 * 60 * fps) / 60 / fps)
	ss = ((fs - hh * 60 * 60 * fps - mm * 60 * fps) / fps)
	ff = (fs - hh * 60 * 60 * fps - mm * 60 * fps - ss * fps)
	'Setup local variables for output
	dim hours as string
	dim minutes as string
	dim seconds as string
	dim frames as string
	
	'Add prefix 0 if hours are less than 0:
	if hh < 10 then
		hours = "0" & cstr(hh)
	else
		hours = cstr(hh)
	end if
	'Add prefix 0 if minutes are less than 0:
	if mm < 10 then
		minutes = "0" & cstr(mm)
	else
		hours = cstr(mm)
	end if
	'Add prefix 0 if seconds are less than 0:
	if ss < 10 then
		seconds = "0" & cstr(ss)
	else
		seconds = cstr(ss)
	end if
	'Add prefix 0 if frames are less than 0:
	if ff < 10 then
		frames = "0" & cstr(ff)
	else
		frames = cstr(ff)
	end if
	'Build and return time string:
	framesToTime = hours & ":" & minutes & ":" & seconds & ":" & frames
end function
