Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ComponentModel
Namespace ModelDevelopment.Converters
    Public Class LengthListTypeConverter : Inherits TypeConverter
        Private Shared MY_list As New Collection
        Public Overloads Overrides Function GetStandardValuesSupported(ByVal context As ITypeDescriptorContext) As Boolean
            Return True
        End Function
        Public Overloads Overrides Function GetStandardValuesExclusive(ByVal context As ITypeDescriptorContext) As Boolean
            Return True
        End Function
        Private Shared Function GetValues() As StandardValuesCollection
            Return New StandardValuesCollection(MY_list)
        End Function
        Public Shared Sub SetList(ByVal list As Collection)
            MY_list = list
        End Sub
        Public Overloads Overrides Function GetStandardValues(ByVal context As ITypeDescriptorContext) As StandardValuesCollection
            Return GetValues()
        End Function
    End Class
End Namespace