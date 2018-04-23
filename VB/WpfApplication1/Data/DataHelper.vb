Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace WpfApplication1.Data
    Public NotInheritable Class DataHelper

        Private Sub New()
        End Sub

        Public Shared Function GetDummyData() As List(Of Address)
            Dim countries = New List(Of Country) From { _
                New Country With { _
                    .Id = 1, _
                    .Name = "USA", _
                    .Stats = New PopulationStats With {.CitizensCount = 100} _
                }, _
                New Country With { _
                    .Id = 2, _
                    .Name = "Germany", _
                    .Stats = New PopulationStats With {.CitizensCount = 200} _
                }, _
                New Country With { _
                    .Id = 3, _
                    .Name = "Sweden", _
                    .Stats = New PopulationStats With {.CitizensCount = 300} _
                }, _
                New Country With { _
                    .Id = 4, _
                    .Name = "Poland", _
                    .Stats = New PopulationStats With {.CitizensCount = 400} _
                } _
            }

            Dim persons = New List(Of Person) From { _
                New Person With { _
                    .Id = 1, _
                    .Firstname = "FirstnamePerson1", _
                    .Lastname = "LastnamePerson1" _
                }, _
                New Person With { _
                    .Id = 2, _
                    .Firstname = "FirstnamePerson2", _
                    .Lastname = "LastnamePerson2" _
                }, _
                New Person With { _
                    .Id = 3, _
                    .Firstname = "FirstnamePerson3", _
                    .Lastname = "LastnamePerson3" _
                }, _
                New Person With { _
                    .Id = 4, _
                    .Firstname = "FirstnamePerson4", _
                    .Lastname = "LastnamePerson4" _
                }, _
                New Person With { _
                    .Id = 5, _
                    .Firstname = "FirstnamePerson5", _
                    .Lastname = "LastnamePerson5" _
                }, _
                New Person With { _
                    .Id = 6, _
                    .Firstname = "FirstnamePerson6", _
                    .Lastname = "LastnamePerson6" _
                }, _
                New Person With { _
                    .Id = 7, _
                    .Firstname = "FirstnamePerson7", _
                    .Lastname = "LastnamePerson7" _
                }, _
                New Person With { _
                    .Id = 8, _
                    .Firstname = "FirstnamePerson8", _
                    .Lastname = "LastnamePerson8" _
                } _
            }

            Return New List(Of Address) _
                From { _
                    New Address With { _
                        .Number = 1, _
                        .Name = "Address1", _
                        .Country = countries(0), _
                        .Persons = New List(Of Person) From {persons(0), persons(1)} _
                    }, _
                    New Address With { _
                        .Number = 2, _
                        .Name = "Address2", _
                        .Country = countries(1), _
                        .Persons = New List(Of Person) From {persons(2), persons(3)} _
                    }, _
                    New Address With { _
                        .Number = 3, _
                        .Name = "Address3", _
                        .Country = countries(2), _
                        .Persons = New List(Of Person) From {persons(4), persons(5)} _
                    }, _
                    New Address With { _
                        .Number = 4, _
                        .Name = "Address4", _
                        .Country = countries(3), _
                        .Persons = New List(Of Person) From {persons(6), persons(7)} _
                    } _
                }
        End Function
    End Class
End Namespace
