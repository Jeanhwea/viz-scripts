dim _time as Integer
dim _duration as Integer
dim _runTimer as boolean = false
dim _fps as Integer = 1 / System.CurrentRefreshRate


sub OnInitParameters()
    RegisterParameterInt("dur", "Duration (seconds)", 0, 0, 100000)
    RegisterPushButton("start", "Start Timer", 1)
end sub


sub OnExecAction(buttonId as Integer)
    dim d as Integer = GetParameterInt("dur") * _fps
    startTime(d)
end sub

sub startTimer(duration as Integer)
    _time = 0
    _duration = duration
    _runTimer = true
end sub

sub OnTimerEnd()
    _runTimer = false
    println "Timer finished after " & _time & " frames"
end sub

sub OnExecPerField()
    if _runTimer then
        _time++
        println _time
        if _time = _duration then
            OnTimerEnd
        end if
    end if
end sub

