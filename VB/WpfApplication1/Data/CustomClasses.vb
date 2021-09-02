Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace WpfApplication1
	Public Class Country
		Public Property Id() As Integer
		Public Property Name() As String
		Public Property Stats() As PopulationStats
	End Class

	Public Class Person
		Public Property Id() As Integer
		Public Property Firstname() As String
		Public Property Lastname() As String
	End Class


	Public Class Address
		Public Property Number() As Integer
		Public Property Name() As String
		Public Property Country() As Country
		Public Property Persons() As List(Of Person)

	End Class

	Public Class PopulationStats
		Public Property Id() As Integer
		Public Property CitizensCount() As Integer
	End Class
End Namespace
