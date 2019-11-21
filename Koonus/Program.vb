Imports System

Module Program
	Sub Main(args As String())
		Console.OutputEncoding = Text.Encoding.UTF8
		Dim Calc As Calculations = New Calculations(args)

		Console.WriteLine("+--------------------+")
		Console.WriteLine("| Koonuse arvutamine |")
		Console.WriteLine("+--------------------+")
		Console.WriteLine(" Kõrgus - " & Calc.getArg("-h"))
		Console.WriteLine(" Raadius - " & Calc.getArg("-r"))
		Console.WriteLine("+--------------------+")
		Calc.getVolume()
		Calc.getHypotenuse()
		Calc.getBottomArea()
		Calc.getLateralArea()
		Calc.getArea()
		Calc.getBottomCircum()
		Console.ReadKey()
	End Sub
End Module
