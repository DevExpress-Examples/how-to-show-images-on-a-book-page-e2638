Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Windows.Media.Imaging



Namespace SilverlightApplication3
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			Dim im1 As New MyImage()
			Dim myImage1 As New Image()
			Dim bi3 As New BitmapImage()
			bi3.UriSource = New Uri("Images/Chrysanthemum.jpg", UriKind.Relative)
			myImage1.Stretch = Stretch.Fill

			im1.MyCollImage = bi3
			im1.ImageName = "Desert"


			Dim im2 As New MyImage()
			Dim myImage2 As New Image()
			Dim bi2 As New BitmapImage()
			bi2.UriSource = New Uri("Images/Desert.jpg", UriKind.Relative)
			myImage2.Stretch = Stretch.Fill

			im2.MyCollImage = bi2
			im2.ImageName = "Chrysanthemum"

			list.Add(im1)
			list.Add(im2)

			imageBook.DataSource = list
			Me.DataContext = im2

		End Sub
		Private list As New List(Of MyImage)()


	End Class

	Public Class MyImage
		Private privateImageName As String
		Public Property ImageName() As String
			Get
				Return privateImageName
			End Get
			Set(ByVal value As String)
				privateImageName = value
			End Set
		End Property
		Private privateMyCollImage As ImageSource
		Public Property MyCollImage() As ImageSource
			Get
				Return privateMyCollImage
			End Get
			Set(ByVal value As ImageSource)
				privateMyCollImage = value
			End Set
		End Property
	End Class
End Namespace
