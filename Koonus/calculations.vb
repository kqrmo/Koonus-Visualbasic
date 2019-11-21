Public Class Calculations

	Private cmdPars As String()
	Private argsTotal As Integer
	Private argsOK As Boolean = False
	Private volume As Double
	Private hypotenuse As Double
	Private bottomarea As Double
	Private lateralarea As Double
	Private area As Double
	Private bottomcircum As Double

	Public Sub New(args As String())
		argsTotal = args.Count
		If argsTotal >= 2 Then ' Kaks või rohkem
			If argsTotal Mod 2 = 0 Then ' Paaris arv
				cmdPars = args
				argsOK = True
			End If
		End If
	End Sub
	Public Function getArg(mySwitch As String)
		If argsOK Then
			For i As Integer = 0 To argsTotal - 1 Step 2
				If mySwitch.Equals(cmdPars(i).ToLower) Then
					Return cmdPars(i + 1)
				End If
			Next
		End If
	End Function

	' RUUMALA
	Public Function getVolume()
		If argsOK Then
			volume = 1 / 3 * (Math.PI * getArg("-r") * getArg("-r") * getArg("-h"))
			Console.WriteLine(" Ruumala (V) - " & volume)
		End If
	End Function

	' HÜPOTENUUS
	Public Function getHypotenuse()
		If argsOK Then
			hypotenuse = Math.Sqrt(getArg("-r") ^ 2 + getArg("-h") ^ 2)
			Console.WriteLine(" Hüpotenuus(m) - " & hypotenuse)
		End If
	End Function

	' PÕHJA PINDALA
	Public Function getBottomArea()
		If argsOK Then
			bottomarea = Math.PI * getArg("-r") ^ 2
			Console.WriteLine(" Põhja pindala (Sp) - " & bottomarea)
		End If
	End Function

	' KÜLJE PINDALA
	Public Function getLateralArea()
		If argsOK Then
			lateralarea = Math.PI * getArg("-r") * bottomarea
			Console.WriteLine(" Külgpindala (Sk) - " & lateralarea)
		End If
	End Function

	Public Function getArea()
		If argsOK Then
			area = Math.PI * getArg("-r") * (getArg("-r") + bottomarea)
			Console.WriteLine(" Täispindala (S) - " & area)
		End If
	End Function

	Public Function getBottomCircum()
		If argsOK Then
			bottomcircum = 2 * Math.PI * getArg("-r")
			Console.WriteLine(" Koonuse põhja ümbermõõt (C) - " & bottomcircum)
		End If
	End Function
End Class
