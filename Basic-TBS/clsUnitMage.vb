Public Class clsUnitMage
    Inherits clsUnit
    Public unitID_Old As Integer
    Public unitType As Char

    Public Sub unitAttack()

    End Sub

    Public Sub unitDefend()

    End Sub

    Public Sub unitInitialize(ByVal unitNumber As Integer, ByVal cUnitTeam As String, ByVal assignedArea As String, ByVal LocationX As Integer, ByVal LocationY As Integer)
        unitSetTeam(cUnitTeam)
        unitAssignedPicBox = assignedArea
        unitID = unitNumber
        unitHealth = 5
        unitStrength = 3
        unitRange = 3
        unitLocX = LocationX
        unitLocY = LocationY
        unitID_Old = unitID
    End Sub

    Public Sub unitTileLocation()

    End Sub

    Public Sub unitSetTeam(ByVal sUnitTeam As String)
        unitTeam = sUnitTeam
    End Sub

End Class
