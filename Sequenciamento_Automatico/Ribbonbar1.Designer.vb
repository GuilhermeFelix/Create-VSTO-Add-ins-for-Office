﻿Partial Class Ribbonbar1
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Exigido para suporte ao Designer de Composição da Classe Windows.Forms
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'Esta chamada é exigida pelo Designer de Componentes.
        InitializeComponent()

    End Sub

    'O componente substitui o descarte para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Designer de Componentes
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Designer de Componentes
    'Pode ser modificado usando o Designer de Componentes.
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tab1 = Me.Factory.CreateRibbonTab
        Me.Settings = Me.Factory.CreateRibbonGroup
        Me.btn_directoryimport = Me.Factory.CreateRibbonButton
        Me.btn_SequencingInterval = Me.Factory.CreateRibbonButton
        Me.btn_PStandardDay = Me.Factory.CreateRibbonButton
        Me.btn_NPException = Me.Factory.CreateRibbonButton
        Me.Implementing_Rules = Me.Factory.CreateRibbonGroup
        Me.btn_ProductPreferenceDay = Me.Factory.CreateRibbonButton
        Me.Tab1.SuspendLayout()
        Me.Settings.SuspendLayout()
        Me.Implementing_Rules.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.Groups.Add(Me.Settings)
        Me.Tab1.Groups.Add(Me.Implementing_Rules)
        Me.Tab1.Label = "Automatic Sequencing"
        Me.Tab1.Name = "Tab1"
        '
        'Settings
        '
        Me.Settings.Items.Add(Me.btn_directoryimport)
        Me.Settings.Items.Add(Me.btn_PStandardDay)
        Me.Settings.Items.Add(Me.btn_NPException)
        Me.Settings.Label = "Basic Settings"
        Me.Settings.Name = "Settings"
        '
        'btn_directoryimport
        '
        Me.btn_directoryimport.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btn_directoryimport.Image = Global.Sequenciamento_Automatico.My.Resources.Resources.imagedirectory
        Me.btn_directoryimport.Label = "Directory Import"
        Me.btn_directoryimport.Name = "btn_directoryimport"
        Me.btn_directoryimport.ShowImage = True
        '
        'btn_SequencingInterval
        '
        Me.btn_SequencingInterval.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btn_SequencingInterval.Image = Global.Sequenciamento_Automatico.My.Resources.Resources.imagetimer
        Me.btn_SequencingInterval.Label = "Sequencing Interval"
        Me.btn_SequencingInterval.Name = "btn_SequencingInterval"
        Me.btn_SequencingInterval.ShowImage = True
        '
        'btn_PStandardDay
        '
        Me.btn_PStandardDay.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btn_PStandardDay.Image = Global.Sequenciamento_Automatico.My.Resources.Resources.imagepdays1
        Me.btn_PStandardDay.Label = "P Standard Day"
        Me.btn_PStandardDay.Name = "btn_PStandardDay"
        Me.btn_PStandardDay.ShowImage = True
        '
        'btn_NPException
        '
        Me.btn_NPException.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btn_NPException.Image = Global.Sequenciamento_Automatico.My.Resources.Resources.imagenpexception
        Me.btn_NPException.Label = "NP Exception Day"
        Me.btn_NPException.Name = "btn_NPException"
        Me.btn_NPException.ShowImage = True
        '
        'Implementing_Rules
        '
        Me.Implementing_Rules.Items.Add(Me.btn_SequencingInterval)
        Me.Implementing_Rules.Items.Add(Me.btn_ProductPreferenceDay)
        Me.Implementing_Rules.Label = "Implementing Rules"
        Me.Implementing_Rules.Name = "Implementing_Rules"
        '
        'btn_ProductPreferenceDay
        '
        Me.btn_ProductPreferenceDay.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btn_ProductPreferenceDay.Image = Global.Sequenciamento_Automatico.My.Resources.Resources.imagepreferenceproductday
        Me.btn_ProductPreferenceDay.Label = "Product Preference Day"
        Me.btn_ProductPreferenceDay.Name = "btn_ProductPreferenceDay"
        Me.btn_ProductPreferenceDay.ShowImage = True
        '
        'Ribbonbar1
        '
        Me.Name = "Ribbonbar1"
        Me.RibbonType = "Microsoft.Excel.Workbook"
        Me.Tabs.Add(Me.Tab1)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.Settings.ResumeLayout(False)
        Me.Settings.PerformLayout()
        Me.Implementing_Rules.ResumeLayout(False)
        Me.Implementing_Rules.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Settings As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btn_directoryimport As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btn_SequencingInterval As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btn_NPException As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btn_PStandardDay As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Implementing_Rules As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btn_ProductPreferenceDay As Microsoft.Office.Tools.Ribbon.RibbonButton
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbonbar1() As Ribbonbar1
        Get
            Return Me.GetRibbon(Of Ribbonbar1)()
        End Get
    End Property
End Class
