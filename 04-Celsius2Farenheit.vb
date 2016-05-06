dim inputGemo as geometry 
dim outputGemo as geometry

sub OnInitParameters()
    RegisterParameterContainer("input", "Input")
    RegisterParameterContainer("output",  "Output")
end sub

sub OnInit()
    inputGemo = GetParameterContainer("input").geometry
    outputGemo = GetParameterContainer("output").geometry

    inputGemo .RegisterTextChangedCallback()
end sub

function celsius2Farenheit(calsiue as string) as string
    dim result as double
    result = cdbl(calsiue) * 9 / 5 + 32

    celsius2Farenheit = cstr(Round(result))
end function

sub OnGeometryChanged(geom as geometry)
    outputGemo .text = celsius2Farenheit(inputGemo .text)
end sub


