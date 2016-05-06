sub OnInitParameters()
    RegisterPushButton("play", "Play", 1)
    RegisterPushButton("rewind", "Rewind", 2)
end sub


sub onExecAction(btnId as Integer)
    if btnId = 1 then
        playAnimation("Director", "A", true)
    elseif btnId = 2 then
        playAnimation("Director", "B", false)
    end if
end sub


sub playAnimation(dir as string, kframe as string, reverse as boolean)
    dim targetDirector as director

    targetDirector = stage.FindDirector(dir)
    targetDirector.reverse = reverse

    dim startTime as double
    startTime = targetDirector.FindKeyframe(kframe).time

    targetDirector.Show(startTime)

    targetDirector.StartAnimation()

end sub

