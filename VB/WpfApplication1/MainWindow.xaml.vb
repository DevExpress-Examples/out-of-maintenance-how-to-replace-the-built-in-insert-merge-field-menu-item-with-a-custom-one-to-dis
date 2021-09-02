Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.RichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Reflection
Imports System.Windows

Namespace WpfApplication1
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()

			richEdit.MailMergeOptions.DataSource = Data.DataHelper.GetDummyData()
			richEdit.MailMergeOptions.ViewMergedData = True
			Dim firstDataSourceItem As Object = (TryCast(richEdit.MailMergeOptions.DataSource, System.Collections.IList))(0)
			InitializeInsertMergeBarItem(firstDataSourceItem)

		End Sub

		Private Sub InitializeInsertMergeBarItem(ByVal firstDataSourceItem As Object)
			Dim result As New List(Of MergeFieldName)()
			CalculateAllowedFieldsNames(result, "", btCustomInsertMergeField, firstDataSourceItem.GetType())
		End Sub

		Private Sub CalculateAllowedFieldsNames(ByVal mmFields As List(Of MergeFieldName), ByVal parentPropertyName As String, ByVal parentItem As BarSubItem, ByVal currenType As Type)
			Dim properties() As PropertyInfo = currenType.GetProperties()
			For Each propInfo As PropertyInfo In properties
				Dim propertyType As Type = propInfo.PropertyType
				Dim df As String = If(parentPropertyName = "", propInfo.Name, parentPropertyName & "." & propInfo.Name)
				If propertyType.Equals(GetType(System.Collections.IList)) Then
					Continue For
				End If
				If propertyType.IsGenericType AndAlso propertyType.GetGenericTypeDefinition().Equals(GetType(System.Collections.Generic.List(Of ))) Then
					Continue For
				End If

				If propertyType.Equals(GetType(String)) OrElse propertyType.Equals(GetType(DateTime)) OrElse propertyType.Equals(GetType(Boolean)) OrElse propertyType.Equals(GetType(Decimal)) OrElse propertyType.Equals(GetType(Integer)) Then
					CreateBarButtonItem(parentItem, df, propInfo.Name)
				Else
					Dim subItem As New BarSubItem()
					subItem.Content = propInfo.Name
					parentItem.Items.Add(subItem)
					CalculateAllowedFieldsNames(mmFields, df, subItem, propertyType)
				End If
			Next propInfo
		End Sub

		Private Sub CreateBarButtonItem(ByVal parentItem As BarSubItem, ByVal name As String, ByVal displayName As String)
			Dim item As New BarButtonItem()
			AddHandler item.ItemClick, AddressOf Item_ItemClick

			item.Content = displayName
			item.Tag = name
			parentItem.Items.Add(item)
		End Sub

		Private Sub Item_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim item As BarButtonItem = TryCast(sender, BarButtonItem)
			If item.Tag Is Nothing Then
				Return
			End If
			Dim fieldName As String = CStr(item.Tag)
			Dim mergeField As Field = richEdit.Document.Fields.Create(richEdit.Document.CaretPosition, String.Format("MERGEFIELD ""{0}""", fieldName))
			mergeField.Update()
		End Sub


	End Class
End Namespace
