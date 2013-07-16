﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18051
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection

Namespace MPD
	
	<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="AgapeConnect")>  _
	Partial Public Class MPDDataContext
		Inherits System.Data.Linq.DataContext
		
		Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub InsertAP_mpdCalc_Definition(instance As AP_mpdCalc_Definition)
    End Sub
    Partial Private Sub UpdateAP_mpdCalc_Definition(instance As AP_mpdCalc_Definition)
    End Sub
    Partial Private Sub DeleteAP_mpdCalc_Definition(instance As AP_mpdCalc_Definition)
    End Sub
    Partial Private Sub InsertAP_mpdCalc_Section(instance As AP_mpdCalc_Section)
    End Sub
    Partial Private Sub UpdateAP_mpdCalc_Section(instance As AP_mpdCalc_Section)
    End Sub
    Partial Private Sub DeleteAP_mpdCalc_Section(instance As AP_mpdCalc_Section)
    End Sub
    Partial Private Sub InsertAP_mpdCalc_Question(instance As AP_mpdCalc_Question)
    End Sub
    Partial Private Sub UpdateAP_mpdCalc_Question(instance As AP_mpdCalc_Question)
    End Sub
    Partial Private Sub DeleteAP_mpdCalc_Question(instance As AP_mpdCalc_Question)
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("SiteSqlServer").ConnectionString, mappingSource)
			OnCreated
		End Sub
		
		Public Sub New(ByVal connection As String)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public Sub New(ByVal connection As System.Data.IDbConnection)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public ReadOnly Property AP_mpdCalc_Definitions() As System.Data.Linq.Table(Of AP_mpdCalc_Definition)
			Get
				Return Me.GetTable(Of AP_mpdCalc_Definition)
			End Get
		End Property
		
		Public ReadOnly Property AP_mpdCalc_Sections() As System.Data.Linq.Table(Of AP_mpdCalc_Section)
			Get
				Return Me.GetTable(Of AP_mpdCalc_Section)
			End Get
		End Property
		
		Public ReadOnly Property AP_mpdCalc_Questions() As System.Data.Linq.Table(Of AP_mpdCalc_Question)
			Get
				Return Me.GetTable(Of AP_mpdCalc_Question)
			End Get
		End Property
	End Class
	
	<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.AP_mpdCalc_Definition")>  _
	Partial Public Class AP_mpdCalc_Definition
		Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
		
		Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
		
		Private _mpdDefId As Integer
		
		Private _TabModuleId As Integer
		
		Private _PortalId As Integer
		
		Private _ActiveFromYear As Short
		
		Private _AssessmentRate As Double
		
		Private _ShowComplience As Boolean
		
		Private _Complience As String
		
		Private _AP_mpdCalc_Sections As EntitySet(Of AP_mpdCalc_Section)
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnmpdDefIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnmpdDefIdChanged()
    End Sub
    Partial Private Sub OnTabModuleIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnTabModuleIdChanged()
    End Sub
    Partial Private Sub OnPortalIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnPortalIdChanged()
    End Sub
    Partial Private Sub OnActiveFromYearChanging(value As Short)
    End Sub
    Partial Private Sub OnActiveFromYearChanged()
    End Sub
    Partial Private Sub OnAssessmentRateChanging(value As Double)
    End Sub
    Partial Private Sub OnAssessmentRateChanged()
    End Sub
    Partial Private Sub OnShowComplienceChanging(value As Boolean)
    End Sub
    Partial Private Sub OnShowComplienceChanged()
    End Sub
    Partial Private Sub OnComplienceChanging(value As String)
    End Sub
    Partial Private Sub OnComplienceChanged()
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New
			Me._AP_mpdCalc_Sections = New EntitySet(Of AP_mpdCalc_Section)(AddressOf Me.attach_AP_mpdCalc_Sections, AddressOf Me.detach_AP_mpdCalc_Sections)
			OnCreated
		End Sub
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_mpdDefId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
		Public Property mpdDefId() As Integer
			Get
				Return Me._mpdDefId
			End Get
			Set
				If ((Me._mpdDefId = value)  _
							= false) Then
					Me.OnmpdDefIdChanging(value)
					Me.SendPropertyChanging
					Me._mpdDefId = value
					Me.SendPropertyChanged("mpdDefId")
					Me.OnmpdDefIdChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TabModuleId", DbType:="Int NOT NULL")>  _
		Public Property TabModuleId() As Integer
			Get
				Return Me._TabModuleId
			End Get
			Set
				If ((Me._TabModuleId = value)  _
							= false) Then
					Me.OnTabModuleIdChanging(value)
					Me.SendPropertyChanging
					Me._TabModuleId = value
					Me.SendPropertyChanged("TabModuleId")
					Me.OnTabModuleIdChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PortalId", DbType:="Int NOT NULL")>  _
		Public Property PortalId() As Integer
			Get
				Return Me._PortalId
			End Get
			Set
				If ((Me._PortalId = value)  _
							= false) Then
					Me.OnPortalIdChanging(value)
					Me.SendPropertyChanging
					Me._PortalId = value
					Me.SendPropertyChanged("PortalId")
					Me.OnPortalIdChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ActiveFromYear", DbType:="SmallInt NOT NULL")>  _
		Public Property ActiveFromYear() As Short
			Get
				Return Me._ActiveFromYear
			End Get
			Set
				If ((Me._ActiveFromYear = value)  _
							= false) Then
					Me.OnActiveFromYearChanging(value)
					Me.SendPropertyChanging
					Me._ActiveFromYear = value
					Me.SendPropertyChanged("ActiveFromYear")
					Me.OnActiveFromYearChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AssessmentRate", DbType:="Float NOT NULL")>  _
		Public Property AssessmentRate() As Double
			Get
				Return Me._AssessmentRate
			End Get
			Set
				If ((Me._AssessmentRate = value)  _
							= false) Then
					Me.OnAssessmentRateChanging(value)
					Me.SendPropertyChanging
					Me._AssessmentRate = value
					Me.SendPropertyChanged("AssessmentRate")
					Me.OnAssessmentRateChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShowComplience", DbType:="Bit NOT NULL")>  _
		Public Property ShowComplience() As Boolean
			Get
				Return Me._ShowComplience
			End Get
			Set
				If ((Me._ShowComplience = value)  _
							= false) Then
					Me.OnShowComplienceChanging(value)
					Me.SendPropertyChanging
					Me._ShowComplience = value
					Me.SendPropertyChanged("ShowComplience")
					Me.OnShowComplienceChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Complience", DbType:="NVarChar(MAX)")>  _
		Public Property Complience() As String
			Get
				Return Me._Complience
			End Get
			Set
				If (String.Equals(Me._Complience, value) = false) Then
					Me.OnComplienceChanging(value)
					Me.SendPropertyChanging
					Me._Complience = value
					Me.SendPropertyChanged("Complience")
					Me.OnComplienceChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="AP_mpdCalc_Definition_AP_mpdCalc_Section", Storage:="_AP_mpdCalc_Sections", ThisKey:="mpdDefId", OtherKey:="mpdDefId")>  _
		Public Property AP_mpdCalc_Sections() As EntitySet(Of AP_mpdCalc_Section)
			Get
				Return Me._AP_mpdCalc_Sections
			End Get
			Set
				Me._AP_mpdCalc_Sections.Assign(value)
			End Set
		End Property
		
		Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
		
		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		
		Protected Overridable Sub SendPropertyChanging()
			If ((Me.PropertyChangingEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub
		
		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
			If ((Me.PropertyChangedEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
		
		Private Sub attach_AP_mpdCalc_Sections(ByVal entity As AP_mpdCalc_Section)
			Me.SendPropertyChanging
			entity.AP_mpdCalc_Definition = Me
		End Sub
		
		Private Sub detach_AP_mpdCalc_Sections(ByVal entity As AP_mpdCalc_Section)
			Me.SendPropertyChanging
			entity.AP_mpdCalc_Definition = Nothing
		End Sub
	End Class
	
	<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.AP_mpdCalc_Section")>  _
	Partial Public Class AP_mpdCalc_Section
		Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
		
		Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
		
		Private _SectionId As Integer
		
		Private _Number As Short
		
		Private _Name As String
		
		Private _TotalMode As String
		
		Private _mpdDefId As Integer
		
		Private _AP_mpdCalc_Questions As EntitySet(Of AP_mpdCalc_Question)
		
		Private _AP_mpdCalc_Definition As EntityRef(Of AP_mpdCalc_Definition)
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnSectionIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnSectionIdChanged()
    End Sub
    Partial Private Sub OnNumberChanging(value As Short)
    End Sub
    Partial Private Sub OnNumberChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnTotalModeChanging(value As String)
    End Sub
    Partial Private Sub OnTotalModeChanged()
    End Sub
    Partial Private Sub OnmpdDefIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnmpdDefIdChanged()
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New
			Me._AP_mpdCalc_Questions = New EntitySet(Of AP_mpdCalc_Question)(AddressOf Me.attach_AP_mpdCalc_Questions, AddressOf Me.detach_AP_mpdCalc_Questions)
			Me._AP_mpdCalc_Definition = CType(Nothing, EntityRef(Of AP_mpdCalc_Definition))
			OnCreated
		End Sub
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SectionId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
		Public Property SectionId() As Integer
			Get
				Return Me._SectionId
			End Get
			Set
				If ((Me._SectionId = value)  _
							= false) Then
					Me.OnSectionIdChanging(value)
					Me.SendPropertyChanging
					Me._SectionId = value
					Me.SendPropertyChanged("SectionId")
					Me.OnSectionIdChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Number", DbType:="SmallInt NOT NULL")>  _
		Public Property Number() As Short
			Get
				Return Me._Number
			End Get
			Set
				If ((Me._Number = value)  _
							= false) Then
					Me.OnNumberChanging(value)
					Me.SendPropertyChanging
					Me._Number = value
					Me.SendPropertyChanged("Number")
					Me.OnNumberChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="NVarChar(120) NOT NULL", CanBeNull:=false)>  _
		Public Property Name() As String
			Get
				Return Me._Name
			End Get
			Set
				If (String.Equals(Me._Name, value) = false) Then
					Me.OnNameChanging(value)
					Me.SendPropertyChanging
					Me._Name = value
					Me.SendPropertyChanged("Name")
					Me.OnNameChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TotalMode", DbType:="NVarChar(10) NOT NULL", CanBeNull:=false)>  _
		Public Property TotalMode() As String
			Get
				Return Me._TotalMode
			End Get
			Set
				If (String.Equals(Me._TotalMode, value) = false) Then
					Me.OnTotalModeChanging(value)
					Me.SendPropertyChanging
					Me._TotalMode = value
					Me.SendPropertyChanged("TotalMode")
					Me.OnTotalModeChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_mpdDefId", DbType:="Int NOT NULL")>  _
		Public Property mpdDefId() As Integer
			Get
				Return Me._mpdDefId
			End Get
			Set
				If ((Me._mpdDefId = value)  _
							= false) Then
					If Me._AP_mpdCalc_Definition.HasLoadedOrAssignedValue Then
						Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
					End If
					Me.OnmpdDefIdChanging(value)
					Me.SendPropertyChanging
					Me._mpdDefId = value
					Me.SendPropertyChanged("mpdDefId")
					Me.OnmpdDefIdChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="AP_mpdCalc_Section_AP_mpdCalc_Question", Storage:="_AP_mpdCalc_Questions", ThisKey:="SectionId", OtherKey:="SectionId")>  _
		Public Property AP_mpdCalc_Questions() As EntitySet(Of AP_mpdCalc_Question)
			Get
				Return Me._AP_mpdCalc_Questions
			End Get
			Set
				Me._AP_mpdCalc_Questions.Assign(value)
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="AP_mpdCalc_Definition_AP_mpdCalc_Section", Storage:="_AP_mpdCalc_Definition", ThisKey:="mpdDefId", OtherKey:="mpdDefId", IsForeignKey:=true)>  _
		Public Property AP_mpdCalc_Definition() As AP_mpdCalc_Definition
			Get
				Return Me._AP_mpdCalc_Definition.Entity
			End Get
			Set
				Dim previousValue As AP_mpdCalc_Definition = Me._AP_mpdCalc_Definition.Entity
				If ((Object.Equals(previousValue, value) = false)  _
							OrElse (Me._AP_mpdCalc_Definition.HasLoadedOrAssignedValue = false)) Then
					Me.SendPropertyChanging
					If ((previousValue Is Nothing)  _
								= false) Then
						Me._AP_mpdCalc_Definition.Entity = Nothing
						previousValue.AP_mpdCalc_Sections.Remove(Me)
					End If
					Me._AP_mpdCalc_Definition.Entity = value
					If ((value Is Nothing)  _
								= false) Then
						value.AP_mpdCalc_Sections.Add(Me)
						Me._mpdDefId = value.mpdDefId
					Else
						Me._mpdDefId = CType(Nothing, Integer)
					End If
					Me.SendPropertyChanged("AP_mpdCalc_Definition")
				End If
			End Set
		End Property
		
		Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
		
		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		
		Protected Overridable Sub SendPropertyChanging()
			If ((Me.PropertyChangingEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub
		
		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
			If ((Me.PropertyChangedEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
		
		Private Sub attach_AP_mpdCalc_Questions(ByVal entity As AP_mpdCalc_Question)
			Me.SendPropertyChanging
			entity.AP_mpdCalc_Section = Me
		End Sub
		
		Private Sub detach_AP_mpdCalc_Questions(ByVal entity As AP_mpdCalc_Question)
			Me.SendPropertyChanging
			entity.AP_mpdCalc_Section = Nothing
		End Sub
	End Class
	
	<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.AP_mpdCalc_Question")>  _
	Partial Public Class AP_mpdCalc_Question
		Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
		
		Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
		
		Private _QuestionId As Long
		
		Private _SectionId As Integer
		
		Private _QuestionNumber As Short
		
		Private _Name As String
		
		Private _Type As String
		
		Private _Min As String
		
		Private _Max As String
		
		Private _Formula As String
		
		Private _Help As String
		
		Private _AccountCode As String
		
		Private _Rate1 As System.Nullable(Of Double)
		
		Private _Threshold1 As System.Nullable(Of Decimal)
		
		Private _Rate2 As System.Nullable(Of Double)
		
		Private _Threshold2 As System.Nullable(Of Decimal)
		
		Private _Rate3 As System.Nullable(Of Double)
		
		Private _Threshold3 As System.Nullable(Of Decimal)
		
		Private _Rate4 As System.Nullable(Of Double)
		
		Private _Fixed As System.Nullable(Of Decimal)
		
		Private _TaxSystem As String
		
		Private _AP_mpdCalc_Section As EntityRef(Of AP_mpdCalc_Section)
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnQuestionIdChanging(value As Long)
    End Sub
    Partial Private Sub OnQuestionIdChanged()
    End Sub
    Partial Private Sub OnSectionIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnSectionIdChanged()
    End Sub
    Partial Private Sub OnQuestionNumberChanging(value As Short)
    End Sub
    Partial Private Sub OnQuestionNumberChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnTypeChanging(value As String)
    End Sub
    Partial Private Sub OnTypeChanged()
    End Sub
    Partial Private Sub OnMinChanging(value As String)
    End Sub
    Partial Private Sub OnMinChanged()
    End Sub
    Partial Private Sub OnMaxChanging(value As String)
    End Sub
    Partial Private Sub OnMaxChanged()
    End Sub
    Partial Private Sub OnFormulaChanging(value As String)
    End Sub
    Partial Private Sub OnFormulaChanged()
    End Sub
    Partial Private Sub OnHelpChanging(value As String)
    End Sub
    Partial Private Sub OnHelpChanged()
    End Sub
    Partial Private Sub OnAccountCodeChanging(value As String)
    End Sub
    Partial Private Sub OnAccountCodeChanged()
    End Sub
    Partial Private Sub OnRate1Changing(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnRate1Changed()
    End Sub
    Partial Private Sub OnThreshold1Changing(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnThreshold1Changed()
    End Sub
    Partial Private Sub OnRate2Changing(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnRate2Changed()
    End Sub
    Partial Private Sub OnThreshold2Changing(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnThreshold2Changed()
    End Sub
    Partial Private Sub OnRate3Changing(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnRate3Changed()
    End Sub
    Partial Private Sub OnThreshold3Changing(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnThreshold3Changed()
    End Sub
    Partial Private Sub OnRate4Changing(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnRate4Changed()
    End Sub
    Partial Private Sub OnFixedChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnFixedChanged()
    End Sub
    Partial Private Sub OnTaxSystemChanging(value As String)
    End Sub
    Partial Private Sub OnTaxSystemChanged()
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New
			Me._AP_mpdCalc_Section = CType(Nothing, EntityRef(Of AP_mpdCalc_Section))
			OnCreated
		End Sub
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_QuestionId", AutoSync:=AutoSync.OnInsert, DbType:="BigInt NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
		Public Property QuestionId() As Long
			Get
				Return Me._QuestionId
			End Get
			Set
				If ((Me._QuestionId = value)  _
							= false) Then
					Me.OnQuestionIdChanging(value)
					Me.SendPropertyChanging
					Me._QuestionId = value
					Me.SendPropertyChanged("QuestionId")
					Me.OnQuestionIdChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SectionId", DbType:="Int NOT NULL")>  _
		Public Property SectionId() As Integer
			Get
				Return Me._SectionId
			End Get
			Set
				If ((Me._SectionId = value)  _
							= false) Then
					If Me._AP_mpdCalc_Section.HasLoadedOrAssignedValue Then
						Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
					End If
					Me.OnSectionIdChanging(value)
					Me.SendPropertyChanging
					Me._SectionId = value
					Me.SendPropertyChanged("SectionId")
					Me.OnSectionIdChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_QuestionNumber", DbType:="SmallInt NOT NULL")>  _
		Public Property QuestionNumber() As Short
			Get
				Return Me._QuestionNumber
			End Get
			Set
				If ((Me._QuestionNumber = value)  _
							= false) Then
					Me.OnQuestionNumberChanging(value)
					Me.SendPropertyChanging
					Me._QuestionNumber = value
					Me.SendPropertyChanged("QuestionNumber")
					Me.OnQuestionNumberChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="NVarChar(120) NOT NULL", CanBeNull:=false)>  _
		Public Property Name() As String
			Get
				Return Me._Name
			End Get
			Set
				If (String.Equals(Me._Name, value) = false) Then
					Me.OnNameChanging(value)
					Me.SendPropertyChanging
					Me._Name = value
					Me.SendPropertyChanged("Name")
					Me.OnNameChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Type", DbType:="NVarChar(20) NOT NULL", CanBeNull:=false)>  _
		Public Property Type() As String
			Get
				Return Me._Type
			End Get
			Set
				If (String.Equals(Me._Type, value) = false) Then
					Me.OnTypeChanging(value)
					Me.SendPropertyChanging
					Me._Type = value
					Me.SendPropertyChanged("Type")
					Me.OnTypeChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Min", DbType:="NVarChar(400) NOT NULL", CanBeNull:=false)>  _
		Public Property Min() As String
			Get
				Return Me._Min
			End Get
			Set
				If (String.Equals(Me._Min, value) = false) Then
					Me.OnMinChanging(value)
					Me.SendPropertyChanging
					Me._Min = value
					Me.SendPropertyChanged("Min")
					Me.OnMinChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Max", DbType:="NVarChar(400)")>  _
		Public Property Max() As String
			Get
				Return Me._Max
			End Get
			Set
				If (String.Equals(Me._Max, value) = false) Then
					Me.OnMaxChanging(value)
					Me.SendPropertyChanging
					Me._Max = value
					Me.SendPropertyChanged("Max")
					Me.OnMaxChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Formula", DbType:="NVarChar(MAX)")>  _
		Public Property Formula() As String
			Get
				Return Me._Formula
			End Get
			Set
				If (String.Equals(Me._Formula, value) = false) Then
					Me.OnFormulaChanging(value)
					Me.SendPropertyChanging
					Me._Formula = value
					Me.SendPropertyChanged("Formula")
					Me.OnFormulaChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Help", DbType:="NVarChar(MAX)")>  _
		Public Property Help() As String
			Get
				Return Me._Help
			End Get
			Set
				If (String.Equals(Me._Help, value) = false) Then
					Me.OnHelpChanging(value)
					Me.SendPropertyChanging
					Me._Help = value
					Me.SendPropertyChanged("Help")
					Me.OnHelpChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AccountCode", DbType:="NVarChar(20)")>  _
		Public Property AccountCode() As String
			Get
				Return Me._AccountCode
			End Get
			Set
				If (String.Equals(Me._AccountCode, value) = false) Then
					Me.OnAccountCodeChanging(value)
					Me.SendPropertyChanging
					Me._AccountCode = value
					Me.SendPropertyChanged("AccountCode")
					Me.OnAccountCodeChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Rate1", DbType:="Float")>  _
		Public Property Rate1() As System.Nullable(Of Double)
			Get
				Return Me._Rate1
			End Get
			Set
				If (Me._Rate1.Equals(value) = false) Then
					Me.OnRate1Changing(value)
					Me.SendPropertyChanging
					Me._Rate1 = value
					Me.SendPropertyChanged("Rate1")
					Me.OnRate1Changed
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Threshold1", DbType:="Money")>  _
		Public Property Threshold1() As System.Nullable(Of Decimal)
			Get
				Return Me._Threshold1
			End Get
			Set
				If (Me._Threshold1.Equals(value) = false) Then
					Me.OnThreshold1Changing(value)
					Me.SendPropertyChanging
					Me._Threshold1 = value
					Me.SendPropertyChanged("Threshold1")
					Me.OnThreshold1Changed
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Rate2", DbType:="Float")>  _
		Public Property Rate2() As System.Nullable(Of Double)
			Get
				Return Me._Rate2
			End Get
			Set
				If (Me._Rate2.Equals(value) = false) Then
					Me.OnRate2Changing(value)
					Me.SendPropertyChanging
					Me._Rate2 = value
					Me.SendPropertyChanged("Rate2")
					Me.OnRate2Changed
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Threshold2", DbType:="Money")>  _
		Public Property Threshold2() As System.Nullable(Of Decimal)
			Get
				Return Me._Threshold2
			End Get
			Set
				If (Me._Threshold2.Equals(value) = false) Then
					Me.OnThreshold2Changing(value)
					Me.SendPropertyChanging
					Me._Threshold2 = value
					Me.SendPropertyChanged("Threshold2")
					Me.OnThreshold2Changed
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Rate3", DbType:="Float")>  _
		Public Property Rate3() As System.Nullable(Of Double)
			Get
				Return Me._Rate3
			End Get
			Set
				If (Me._Rate3.Equals(value) = false) Then
					Me.OnRate3Changing(value)
					Me.SendPropertyChanging
					Me._Rate3 = value
					Me.SendPropertyChanged("Rate3")
					Me.OnRate3Changed
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Threshold3", DbType:="Money")>  _
		Public Property Threshold3() As System.Nullable(Of Decimal)
			Get
				Return Me._Threshold3
			End Get
			Set
				If (Me._Threshold3.Equals(value) = false) Then
					Me.OnThreshold3Changing(value)
					Me.SendPropertyChanging
					Me._Threshold3 = value
					Me.SendPropertyChanged("Threshold3")
					Me.OnThreshold3Changed
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Rate4", DbType:="Float")>  _
		Public Property Rate4() As System.Nullable(Of Double)
			Get
				Return Me._Rate4
			End Get
			Set
				If (Me._Rate4.Equals(value) = false) Then
					Me.OnRate4Changing(value)
					Me.SendPropertyChanging
					Me._Rate4 = value
					Me.SendPropertyChanged("Rate4")
					Me.OnRate4Changed
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Fixed", DbType:="Money")>  _
		Public Property Fixed() As System.Nullable(Of Decimal)
			Get
				Return Me._Fixed
			End Get
			Set
				If (Me._Fixed.Equals(value) = false) Then
					Me.OnFixedChanging(value)
					Me.SendPropertyChanging
					Me._Fixed = value
					Me.SendPropertyChanged("Fixed")
					Me.OnFixedChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TaxSystem", DbType:="NVarChar(20)")>  _
		Public Property TaxSystem() As String
			Get
				Return Me._TaxSystem
			End Get
			Set
				If (String.Equals(Me._TaxSystem, value) = false) Then
					Me.OnTaxSystemChanging(value)
					Me.SendPropertyChanging
					Me._TaxSystem = value
					Me.SendPropertyChanged("TaxSystem")
					Me.OnTaxSystemChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="AP_mpdCalc_Section_AP_mpdCalc_Question", Storage:="_AP_mpdCalc_Section", ThisKey:="SectionId", OtherKey:="SectionId", IsForeignKey:=true)>  _
		Public Property AP_mpdCalc_Section() As AP_mpdCalc_Section
			Get
				Return Me._AP_mpdCalc_Section.Entity
			End Get
			Set
				Dim previousValue As AP_mpdCalc_Section = Me._AP_mpdCalc_Section.Entity
				If ((Object.Equals(previousValue, value) = false)  _
							OrElse (Me._AP_mpdCalc_Section.HasLoadedOrAssignedValue = false)) Then
					Me.SendPropertyChanging
					If ((previousValue Is Nothing)  _
								= false) Then
						Me._AP_mpdCalc_Section.Entity = Nothing
						previousValue.AP_mpdCalc_Questions.Remove(Me)
					End If
					Me._AP_mpdCalc_Section.Entity = value
					If ((value Is Nothing)  _
								= false) Then
						value.AP_mpdCalc_Questions.Add(Me)
						Me._SectionId = value.SectionId
					Else
						Me._SectionId = CType(Nothing, Integer)
					End If
					Me.SendPropertyChanged("AP_mpdCalc_Section")
				End If
			End Set
		End Property
		
		Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
		
		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		
		Protected Overridable Sub SendPropertyChanging()
			If ((Me.PropertyChangingEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub
		
		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
			If ((Me.PropertyChangedEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
	End Class
End Namespace
