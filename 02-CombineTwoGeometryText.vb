dim srcGeomA as geometry
dim srcGeomB as geometry
dim targetGeom as geometry

sub OnInitParameters()
    RegisterParameterContainer("sourceA", "Source A")
    RegisterParameterContainer("sourceB", "Source B")
    RegisterParameterContainer("target",  "Target")
end sub

sub OnInit()
    srcGeomA   = GetParameterContainer("sourceA").geometry
    srcGeomB   = GetParameterContainer("sourceB").geometry
    targetGeom = GetParameterContainer("target").geometry

    srcGeomA.RegisterTextChangedCallback()
    srcGeomB.RegisterTextChangedCallback()
end sub


sub OnGeometryChanged(geom as geometry)
    dim strA, strB as string
    strA = srcGeomA.text
    strB = srcGeomB.text

    targetGeom.text = strA & strB
end sub


