﻿Public Class OreMineral
    'Key .OreID = result.GetInt32(0), Key .MineralID = result.GetInt32(1), Key .MineralQuantity = result.GetInt32(2), Key .OreMultiplier = 1
    Public OreID As Integer
    Public MineralID As Integer
    Public MineralQuantity As Double
    Public OreMultiplier As Integer
    Public OreName As String
    Public OreSelectedFor As Integer
    Public Locked As Boolean
End Class
