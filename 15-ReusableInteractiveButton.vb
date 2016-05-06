dim onoff = false

sub OnInitParameters()
	RegisterParameterString("DirectorOn", "Director On", "", 30, 100, "")
	RegisterParameterString("DirectorOff", "Director Off", "", 30, 100, "")
	RegisterParameterBool("InitialState", "Initial State", false)
end sub

sub OnInit()
	onoff = GetParameterBool("InitialState")
end sub

sub OnLButtonDown()
	if onoff then
		Stage.FindDirector( GetParameterString("DirectorOn") ).StartAnimation()
	else
		Stage.FindDirector( GetParameterString("DirectorOff") ).StartAnimationReverse()
	end if
	
	onoff = Not onoff
end sub
