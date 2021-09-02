Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace WpfApplication1.Data
	Public Module DataHelper
		Public Function GetDummyData() As List(Of Address)
			Dim countries = New List(Of Country) From {
				New Country With {
					.Id = 1,
					.Name = "USA",
					.Stats = New PopulationStats With {.CitizensCount = 100}
				},
				New Country With {
					.Id = 2,
					.Name = "Germany",
					.Stats = New PopulationStats With {.CitizensCount = 200}
				},
				New Country With {
					.Id = 3,
					.Name = "Sweden",
					.Stats = New PopulationStats With {.CitizensCount = 300}
				},
				New Country With {
					.Id = 4,
					.Name = "Poland",
					.Stats = New PopulationStats With {.CitizensCount = 400}
				}
			}

			Dim persons = New List(Of Person) From {
				New Person With {
					.Id = 1,
					.Firstname = "FirstnamePerson1",
					.Lastname = "LastnamePerson1"
				},
				New Person With {
					.Id = 2,
					.Firstname = "FirstnamePerson2",
					.Lastname = "LastnamePerson2"
				},
				New Person With {
					.Id = 3,
					.Firstname = "FirstnamePerson3",
					.Lastname = "LastnamePerson3"
				},
				New Person With {
					.Id = 4,
					.Firstname = "FirstnamePerson4",
					.Lastname = "LastnamePerson4"
				},
				New Person With {
					.Id = 5,
					.Firstname = "FirstnamePerson5",
					.Lastname = "LastnamePerson5"
				},
				New Person With {
					.Id = 6,
					.Firstname = "FirstnamePerson6",
					.Lastname = "LastnamePerson6"
				},
				New Person With {
					.Id = 7,
					.Firstname = "FirstnamePerson7",
					.Lastname = "LastnamePerson7"
				},
				New Person With {
					.Id = 8,
					.Firstname = "FirstnamePerson8",
					.Lastname = "LastnamePerson8"
				}
			}

			Return New List(Of Address) _
				From {
					New Address With {
						.Number = 1,
						.Name = "Address1",
						.Country = countries(0),
						.Persons = New List(Of Person) From {persons(0), persons(1)}
					},
					New Address With {
						.Number = 2,
						.Name = "Address2",
						.Country = countries(1),
						.Persons = New List(Of Person) From {persons(2), persons(3)}
					},
					New Address With {
						.Number = 3,
						.Name = "Address3",
						.Country = countries(2),
						.Persons = New List(Of Person) From {persons(4), persons(5)}
					},
					New Address With {
						.Number = 4,
						.Name = "Address4",
						.Country = countries(3),
						.Persons = New List(Of Person) From {persons(6), persons(7)}
					}
				}
		End Function
	End Module
End Namespace
